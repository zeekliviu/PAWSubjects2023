using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubRazvanPAW
{
    public partial class Form1 : Form
    {
        List<Apartament> apartamente;

        string connString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source = E:\\SubRazvanPAW\\camere.accdb";

        Random rnd;

        DataView dw;

        int nrRanduri;

        public Form1()
        {
            InitializeComponent();
            apartamente = new List<Apartament>();
            rnd = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var conn = new OleDbConnection(connString))
            {
                conn.Open();
                var adapter = new OleDbDataAdapter("select * from tblCamere", conn);
                var dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dw = new DataView(dt, "Orientare = 'S'", string.Empty, DataViewRowState.CurrentRows);
                nrRanduri = dt.Rows.Count;
                toolStripStatusLabel1.Text = $"Sunt {nrRanduri} camere în tabela tblCamere.";
                int nrCam = rnd.Next(1, 6);
                int nrTotal = dataGridView1.Rows.Count;
                int nrIndexInferior = 0;
                int nrIndexSuperior = nrCam - 1;
                while(nrIndexInferior!=nrTotal-1)
                {
                    var camere = new Camera[nrCam];
                    int k = 0;
                    for (int i = nrIndexInferior; i <= nrIndexSuperior; i++)
                    {
                        DataGridViewRow dgvr = dataGridView1.Rows[i];
                        float latime = float.Parse(dgvr.Cells[1].Value.ToString());
                        float lungime = float.Parse(dgvr.Cells[2].Value.ToString());
                        Orientare orientare = (Orientare)Enum.Parse(typeof(Orientare), dgvr.Cells[3].Value.ToString());
                        var c = new Camera(latime, lungime, orientare);
                        c.Suprafata = latime * lungime;
                        camere[k++] = c;
                    }
                    apartamente.Add(new Apartament(camere));
                    nrIndexInferior += nrCam;
                    nrCam = rnd.Next(1, 6);
                    while (nrIndexInferior + nrCam > nrTotal - 1)
                        if (nrIndexInferior == nrTotal - 1)
                        { nrIndexSuperior = nrIndexInferior; break; }
                        else nrCam = rnd.Next(1, 6);
                    nrIndexSuperior += nrCam;
                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            using (var conn = new OleDbConnection(connString))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "update tblCamere set " +
                    $"Latime = @Latime, Lungime = @Lungime, Orientare = @Orientare where ID = {e.RowIndex + 1}";
                    cmd.Parameters.AddWithValue("@Latime", dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@Lungime", dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    cmd.Parameters.AddWithValue("@Orientare", dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2(apartamente).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dw;
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            using(var conn =  new OleDbConnection(connString))
            {
                conn.Open();
                using(var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "delete from tblCamere where ID = @ID";
                    cmd.Parameters.AddWithValue("@ID", e.Row.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    nrRanduri--;
                }
            }
            toolStripStatusLabel1.Text = $"Sunt {nrRanduri} camere în tabela tblCamere.";
        }

        private void schimbaFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fd = new FontDialog();
            if(fd.ShowDialog()==DialogResult.OK)
            {
                button2.Font = fd.Font;
            }
        }
    }
}
