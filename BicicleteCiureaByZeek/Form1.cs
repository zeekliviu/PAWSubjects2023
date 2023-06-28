using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicicleteCiureaByZeek
{
    public partial class Form1 : Form
    {
        private Dictionary<Bicicleta, List<Utilizator>> inchirieri;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Dictionary<Bicicleta, List<Utilizator>> dict): this()
        {
            inchirieri = dict;
            foreach(var bicla in inchirieri.Keys)
            {
                var lvi = new ListViewItem(bicla.CodB.ToString());
                lvi.Tag = bicla;
                lvi.SubItems.Add(bicla.Denumire);
                lvi.SubItems.Add(bicla.KM.ToString());
                listView1.Items.Add(lvi);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var bicla = (Bicicleta)listView1.SelectedItems[0].Tag;
                var users = inchirieri[bicla];
                int total = 0;
                label1.Visible = true;
                textBox1.Visible = true;
                label1.Text = $"Venitul generat de bicicleta cu codul {bicla.CodB}: ";
                listBox1.Items.Clear();
                foreach (var u in users)
                {
                    int timpPlatibil = u.Durata-30;
                    int totalUser = 0;
                    listBox1.Items.Add(u);
                    if(timpPlatibil > 0)
                    {
                        totalUser = timpPlatibil / 10 * 2;
                    }
                    total += totalUser;
                }
                textBox1.Text = total.ToString("D") + " euro";
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(listBox1.SelectedItems.Count > 0)
            {
                var user = (Utilizator)listBox1.SelectedItems[0];
                var bicla = (Bicicleta)listView1.SelectedItems[0].Tag;
                if (new Form2(inchirieri, bicla, user).ShowDialog() == DialogResult.OK)
                {  
                    if (listView1.SelectedItems.Count > 0)
                    {
                        var users = inchirieri[bicla];
                        listBox1.Items.Clear();
                        foreach (var u in users)
                        {
                            listBox1.Items.Add(u);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form3(inchirieri.Keys.ToList()).ShowDialog();
        }

        private void printPreviwToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var x = 20f;
            var y = 0f;
            foreach(var entry in inchirieri)
            {
                var sb = new StringBuilder();
                sb.Append(entry.Key.CodB);
                sb.Append(": ");
                foreach(var u in entry.Value)
                { sb.Append(u.Nume + ", "); }
                sb.Remove(sb.Length - 2, 2);
                y += 20;
                e.Graphics.DrawString(sb.ToString(), new Font("Arial", 12), new SolidBrush(Color.Black), x, y);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var bf = new BinaryFormatter();
            using (var sw = new FileStream("../../biciclete.dat", FileMode.Create))
            {
                bf.Serialize(sw, inchirieri.Keys.ToList());
            }
            using(var sw = new FileStream("../../utilizatori.dat", FileMode.Create))
            {
                bf.Serialize(sw, inchirieri.Values.ToList());
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Modifiers == Keys.Alt && e.KeyCode == Keys.X)
            {
                Close();
            }
        }
    }
}
