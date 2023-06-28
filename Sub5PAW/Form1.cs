using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sub5PAW
{
    public partial class Form1 : Form
    {
        private List<Carte> publicatii;
        private List<Autor> autori;
        private List<Autor> autoriBD;
        private Random rnd;
        private ListViewItem dragItm;

        public Form1()
        {
            InitializeComponent();
            publicatii = new List<Carte>();
            autoriBD = new List<Autor>();
            autori = new List<Autor>
            {
                new Autor("Cristian Ciurea", "Prof. univ. dr.", 1),
                new Autor("Bogdan Iancu", "Conf. univ. dr.", 2),
                new Autor("Marius Popa", "Prof. univ. dr.", 3),
                new Autor("Iuliana Botha", "Conf. univ. dr.", 4),
                new Autor("Alexandru Agapie", "Prof. univ. dr.", 5),
                new Autor("Solomon Ovidiu", "Conf. univ. dr.", 6)
            };
            rnd = new Random();
        }

        private void adaugaManualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(new Form2(publicatii).ShowDialog() == DialogResult.OK)
            {
                var nrAutori = rnd.Next(1, 4);
                for(int i=0; i<nrAutori; i++)
                {
                    var indexAutor = rnd.Next(0, 6);
                    while (publicatii.Last().Autori.Contains(autori[indexAutor]))
                    {
                        indexAutor = rnd.Next(0, 6);
                    }
                    publicatii.Last().Autori.Add(autori[indexAutor]);
                }
            }
            listView1.Items.Clear();
            publicatii.Sort((c1, c2) => c1.Titlu.CompareTo(c2.Titlu));
            foreach(var pub in publicatii)
            {
                var lvi = new ListViewItem(pub.isbn);
                lvi.Tag = pub;
                lvi.SubItems.Add(pub.Categorie);
                lvi.SubItems.Add(pub.Titlu);
                lvi.SubItems.Add(pub.Pret.ToString());
                listView1.Items.Add(lvi);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(var autor in autori)
            {
                var lvi = new ListViewItem(autor.Marca.ToString());
                lvi.Tag = autor;
                lvi.SubItems.Add(autor.Grad_Didactic);
                lvi.SubItems.Add(autor.Nume);
                listView2.Items.Add(lvi);
            }
        }

        private void citireDinBDAAutorilorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(new Form3(autoriBD).ShowDialog() == DialogResult.OK)
            {
                listView2.Items.Clear();
                foreach (var autor in autoriBD)
                {
                    var lvi = new ListViewItem(autor.Marca.ToString());
                    lvi.Tag = autor;
                    lvi.SubItems.Add(autor.Grad_Didactic);
                    lvi.SubItems.Add(autor.Nume);
                    listView2.Items.Add(lvi);
                }
                autoriBD = new List<Autor>();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox1.Text = string.Empty;
            Carte c;
            try
            {
                c = (Carte)listView1.SelectedItems[0].Tag;
                textBox1.Text = c.genereazaReferinta();
            } 
            catch
            {

            }
        }

        private void listView2_MouseUp(object sender, MouseEventArgs e)
        {
            dragItm = null;
        }

        private void listView2_MouseDown(object sender, MouseEventArgs e)
        {
            var lv = (ListView)sender;
            dragItm = lv.GetItemAt(e.X, e.Y);
        }

        private void listView2_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left && dragItm != null)
            {
                Autor a = (Autor)dragItm.Tag;
                var autorString = $"{a.Marca},{a.Grad_Didactic},{a.Nume}";
                var effects = listView1.DoDragDrop(autorString, DragDropEffects.Copy);
            }
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.Text) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.Text))
            {
                var dragText = (string)e.Data.GetData(DataFormats.Text);
                var values = dragText.Split(',');

                Carte c = (Carte)listView1.SelectedItems[0].Tag;
                c += new Autor(values[2], values[1], int.Parse(values[0]));
                textBox1.Text = c.genereazaReferinta();
            }
        }
    }
}
