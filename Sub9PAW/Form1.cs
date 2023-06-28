using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sub9PAW
{
    public partial class Form1 : Form
    {
        List<Candidat> candidati;
        List<ProgramStudiu> programe;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(List<Candidat> candidati, List<ProgramStudiu> programe): this()
        {
            this.candidati = candidati;
            this.programe = programe;
            foreach(var candidat in this.candidati)
            {
                var lvi = new ListViewItem(candidat.CodCandidat.ToString());
                lvi.Tag = candidat;
                lvi.SubItems.Add(candidat.NumeCandidat);
                lvi.SubItems.Add(candidat.MedieConcurs.ToString());
                lvi.SubItems.Add(Helpers.ArrayToString(candidat.VectorOptiuni));
                listView1.Items.Add(lvi);   
            }
            foreach(var program in this.programe)
            {
                listBox1.Items.Add(program);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count != 1)
            {
                MessageBox.Show("Doar un candidat!");
                return;
            }
            else
            {
                var candidatSelectat = (Candidat)listView1.SelectedItems[0].Tag;
                var program = (ProgramStudiu)listBox1.SelectedItems[0];
                var optiuniNoi = new int[candidatSelectat.VectorOptiuni.Length + 1];
                Array.Copy(candidatSelectat.VectorOptiuni, optiuniNoi, candidatSelectat.VectorOptiuni.Length);
                optiuniNoi[candidatSelectat.VectorOptiuni.Length] = program.CodProgram;
                candidatSelectat.VectorOptiuni = optiuniNoi;
                listView1.Items.Clear();
                foreach (var candidat in candidati)
                {
                    var lvi = new ListViewItem(candidat.CodCandidat.ToString());
                    lvi.Tag = candidat;
                    lvi.SubItems.Add(candidat.NumeCandidat);
                    lvi.SubItems.Add(candidat.MedieConcurs.ToString());
                    lvi.SubItems.Add(Helpers.ArrayToString(candidat.VectorOptiuni));
                    listView1.Items.Add(lvi);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(new Form2(candidati, programe).ShowDialog() == DialogResult.OK)
            {
                listView1.Items.Clear();
                foreach (var candidat in candidati)
                {
                    var lvi = new ListViewItem(candidat.CodCandidat.ToString());
                    lvi.Tag = candidat;
                    lvi.SubItems.Add(candidat.NumeCandidat);
                    lvi.SubItems.Add(candidat.MedieConcurs.ToString());
                    lvi.SubItems.Add(Helpers.ArrayToString(candidat.VectorOptiuni));
                    listView1.Items.Add(lvi);
                }
            }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count != 1) {
                MessageBox.Show("Selecteaza un candidat!");
                return;
            }
            var candidatSelectat = (Candidat)listView1.SelectedItems[0].Tag;
            candidati.Remove(candidatSelectat);
            listView1.Items.Clear();
            foreach (var candidat in candidati)
            {
                var lvi = new ListViewItem(candidat.CodCandidat.ToString());
                lvi.Tag = candidat;
                lvi.SubItems.Add(candidat.NumeCandidat);
                lvi.SubItems.Add(candidat.MedieConcurs.ToString());
                lvi.SubItems.Add(Helpers.ArrayToString(candidat.VectorOptiuni));
                listView1.Items.Add(lvi);
            }
        }

        private void editeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)
            {
                MessageBox.Show("Selecteaza un candidat!");
                return;
            }
            var candidatSelectat = (Candidat)listView1.SelectedItems[0].Tag;
            if (new Form2(candidatSelectat, programe).ShowDialog() == DialogResult.OK)
            {
                listView1.Items.Clear();
                foreach (var candidat in candidati)
                {
                    var lvi = new ListViewItem(candidat.CodCandidat.ToString());
                    lvi.Tag = candidat;
                    lvi.SubItems.Add(candidat.NumeCandidat);
                    lvi.SubItems.Add(candidat.MedieConcurs.ToString());
                    lvi.SubItems.Add(Helpers.ArrayToString(candidat.VectorOptiuni));
                    listView1.Items.Add(lvi);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            candidati.Select(candidat => candidat.VectorOptiuni).ToList().ForEach(element => { for (int i = 0; i < element.Length; i++) list.Add(element[i]); });
            var dict = list.GroupBy(num=>num).ToDictionary(group=>group.Key, group=>group.Count());
            new Form3(dict).ShowDialog();
        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var draw = e.Graphics;
            var x = 30;
            var y = 30;
            foreach(var prog in programe)
            {
                var sb = new StringBuilder();
                sb.Append(prog.CodProgram.ToString());
                sb.Append(": ");
                foreach(var candidat in candidati)
                    if(candidat.VectorOptiuni.Contains(prog.CodProgram))
                        sb.Append(candidat.NumeCandidat.ToString()).Append(", ");
                sb.Remove(sb.Length - 2, 2);
                draw.DrawString(sb.ToString(), SystemFonts.MessageBoxFont, Brushes.Black, x, y);
                y += 20;
            }    
        }
    }
}
