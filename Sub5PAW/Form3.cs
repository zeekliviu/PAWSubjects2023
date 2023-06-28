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

namespace Sub5PAW
{
    public partial class Form3 : Form
    {
        private List<Autor> autori;
        private string connString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=E:\Sub5PAW\autori.accdb";
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(List<Autor> autori) : this()
        {
            this.autori = autori;
            using(var conn = new OleDbConnection(connString))
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from autori";
                    var result = cmd.ExecuteReader();
                    while(result.Read())
                    {
                        var marca = (int)result["ID"];
                        var grad = (string)result["Grad"];
                        var nume = (string)result["Nume"];
                        var autor = new Autor(nume, grad, marca);
                        autori.Add(autor);
                    }
                }
            }
            foreach(var autor in autori)
            {
                var lvi = new ListViewItem(autor.Marca.ToString());
                lvi.Tag = autor;
                lvi.SubItems.Add(autor.Grad_Didactic);
                lvi.SubItems.Add(autor.Nume);
                listView1.Items.Add(lvi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listView1.CheckedItems.Count == 0)
            { 
                MessageBox.Show("Selecteaza un autor");
                return;
            }
            foreach(ListViewItem lvi in listView1.Items)
            {
                if (!lvi.Checked)
                    autori.Remove((Autor)lvi.Tag);
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
