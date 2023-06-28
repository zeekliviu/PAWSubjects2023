using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sub11PAW
{
    public partial class Form1 : Form
    {
        List<Camion> camioane;
        const string connString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=E:\\Sub11PAW\\vehicule.accdb";


        public Form1()
        {
            InitializeComponent();
            camioane = new List<Camion>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {  
            using (var conn = new OleDbConnection(connString))
            {
                conn.Open();
                using(var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from vehicule";
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var marca = reader.GetInt32(0);
                        var an = reader.GetInt32(1);
                        var nrUsi = reader.GetInt32(2);
                        var cantitati = reader.GetString(3);
                        var values = cantitati.Split(',');
                        var vect = new int[values.Length];
                        for(int i=0; i< values.Length; i++)
                        {
                            vect[i] = int.Parse(values[i]);
                        }
                        camioane.Add(new Camion(marca, an, nrUsi, vect));
                    }
                }
            }
            foreach(var cam in camioane)
            {
                var lvi = new ListViewItem(cam.Marca.ToString());
                lvi.Tag = cam;
                lvi.SubItems.Add(cam.An.ToString());
                lvi.SubItems.Add(cam.NrUsi.ToString());
                lvi.SubItems.Add(string.Join(" ", cam.Marfuri.Select(m => m.ToString())));
                listView1.Items.Add(lvi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listView1.CheckedItems.Count < 1) {
                MessageBox.Show("Selecteaza macar un item!");
                return;
            }
            foreach(ListViewItem lvi in  listView1.CheckedItems)
            {
                var camion = (Camion)lvi.Tag;
                using (var conn = new OleDbConnection(connString))
                {
                    conn.Open();
                    using(var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = $"delete from vehicule where ID={camion.Marca}";
                        cmd.ExecuteNonQuery();
                    }
                }
                camioane.Remove(camion);   
            }
            listView1.Items.Clear();
            foreach (var cam in camioane)
            {
                var lvi = new ListViewItem(cam.Marca.ToString());
                lvi.Tag = cam;
                lvi.SubItems.Add(cam.An.ToString());
                lvi.SubItems.Add(cam.NrUsi.ToString());
                lvi.SubItems.Add(string.Join(" ", cam.Marfuri.Select(m => m.ToString())));
                listView1.Items.Add(lvi);
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                new Form2(camioane).Show();
            }
        }
    }
}
