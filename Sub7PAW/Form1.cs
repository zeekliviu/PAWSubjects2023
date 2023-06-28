using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Sub7PAW
{
    public partial class Form1 : Form
    {
        private List<ComandaPizza> comenzi;

        public Form1()
        {
            InitializeComponent();
            comenzi = new List<ComandaPizza>();
        }

        private void adaugaPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (new Form2(comenzi).ShowDialog() == DialogResult.OK)
            {
                var blatPeComenzi = comenzi.GroupBy(comanda => comanda.Blat).ToDictionary(group => group.Key, group => group.ToList());
                treeView1.Nodes.Clear();
                int i = 0;
                foreach (var entry in blatPeComenzi)
                {
                    treeView1.Nodes.Add(entry.Key);
                    foreach (var item in entry.Value)
                    {
                        treeView1.Nodes[i].Nodes.Add(item.ToString());
                    }
                    i++;
                }
            }
        }

        private void citireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(var sr = new StreamReader("../../../date.txt"))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    var values = line.Split(',');
                    comenzi.Add(new ComandaPizza(values[0], values[1], int.Parse(values[2])));
                }
            }
            var blatPeComenzi = comenzi.GroupBy(comanda => comanda.Blat).ToDictionary(group => group.Key, group => group.ToList());
            treeView1.Nodes.Clear();
            int i = 0;
            foreach (var entry in blatPeComenzi)
            {
                treeView1.Nodes.Add(entry.Key);
                int k = 0;
                foreach (var item in entry.Value)
                {
                    treeView1.Nodes[i].Nodes.Add(item.ToString());
                    treeView1.Nodes[i].Nodes[k++].Tag = item;
                }
                i++;
            }
        }

        private void citireToppinguriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (treeView1.SelectedNode.Nodes.Count > 0)
            {
                MessageBox.Show("Selecteaza o pizza!");
                return;
            }
            var numeBd = Interaction.InputBox("Dati numele BD", "Nume BD");
            var caleBd = Interaction.InputBox("Dati calea BD", "Cale BD");
            var connString = $"Provider=Microsoft.ACE.OLEDB.12.0; Data Source={caleBd}\\{numeBd}.accdb";
            var lstToppings = new List<Topping>();
            using(var conn = new OleDbConnection(connString))
            {
                conn.Open();
                using(var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from toppings";
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var topping = new Topping(reader["Denumire"].ToString(), float.Parse(reader["Pret"].ToString()), int.Parse(reader["Cod"].ToString()));
                        lstToppings.Add(topping);
                    }
                }
            }
            if(new Form4(lstToppings).ShowDialog() == DialogResult.OK)
            {
                var cp = (ComandaPizza)treeView1.SelectedNode.Tag;
                foreach (var topping in lstToppings)
                {
                    cp += topping;
                }
                treeView1.SelectedNode.Text = cp.ToString();
            }
        }

        private void graficUtilizareToppinguriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Topping> topinguri = new List<Topping>();
            foreach(TreeNode nodParinte in  treeView1.Nodes)
            {
                foreach(TreeNode nodCopil in nodParinte.Nodes)
                {
                    var cp = (ComandaPizza)nodCopil.Tag;
                    if(cp.Toppings.Count != 0)
                        foreach(var topping in cp.Toppings)
                        { topinguri.Add(topping);}
                }
            }
            var toppingPeNumar = topinguri.GroupBy(topping => topping.Denumire).ToDictionary(group => group.Key, group=>group.Count());
            new Form5(toppingPeNumar).ShowDialog();
        }
    }
}
