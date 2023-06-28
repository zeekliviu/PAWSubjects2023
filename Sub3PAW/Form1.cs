using Sub3PAW.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sub3PAW
{
    public partial class Form1 : Form
    {
        private Firma firma;
        public Form1()
        {
            InitializeComponent();
            firma = new Firma();
        }

        public Form1(List<Salariat> salariati): this()
        {
            firma = new Firma(salariati);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var fondSalarial = 0m;
            foreach(var salariat in firma.Salariati)
            {
                var lvi = new ListViewItem(salariat.Marca.ToString());
                lvi.Tag = salariat;
                lvi.SubItems.Add(salariat.Nume);
                lvi.SubItems.Add(salariat.NrOre.ToString());
                lvi.SubItems.Add(salariat.Salariu.ToString());
                lvi.SubItems.Add(salariat.CalculSalariu().ToString());
                listView1.Items.Add(lvi);
                fondSalarial += salariat.CalculSalariu();
            }
            toolStripStatusLabel1.Text = "Fondul salarial: " + fondSalarial.ToString();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            panel1.CreateGraphics().Clear(Color.White);
            var g = panel1.CreateGraphics();
            var pen = new Pen(Color.Black, 2);
            var font = new Font("Arial", 10);
            var fontBrush = new SolidBrush(Color.Blue);
            var x = 0;
            var y = 0;
            var w = 0;
            var h = 0;
            var maxSalariu = firma.Salariati.Max(salariat => salariat.Salariu);
            var wUnit = panel1.Width / firma.Salariati.Count;
            var hUnit = panel1.Height / (maxSalariu + 1000);
            firma.Salariati.Sort((sal1, sal2) => sal1.Salariu.CompareTo(sal2.Salariu));
            foreach (var salariat in firma.Salariati)
            {
                x = firma.Salariati.IndexOf(salariat) * wUnit;
                y = panel1.Height - (int)(salariat.Salariu * hUnit);
                w = wUnit;
                h = (int)(salariat.Salariu * hUnit);
                g.DrawRectangle(pen, x, y, w, h);
                g.FillRectangle(fontBrush, x, y, w, h);
                g.DrawString(salariat.Salariu.ToString() + " "+salariat.Nume, font, new SolidBrush(Color.Black), x, y - 20);
            }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count == 0)
            {
                MessageBox.Show("Nu mai ai ce sa stergi!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            else if(listView1.SelectedItems.Count != 1)
            {
                MessageBox.Show("Selecteaza doar un salariat!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                firma.Salariati.Remove((Salariat)listView1.SelectedItems[0].Tag);
                listView1.Items.Clear();
                var fondSalarial = 0m;
                foreach (var salariat in firma.Salariati)
                {
                    var lvi = new ListViewItem(salariat.Marca.ToString());
                    lvi.Tag = salariat;
                    lvi.SubItems.Add(salariat.Nume);
                    lvi.SubItems.Add(salariat.NrOre.ToString());
                    lvi.SubItems.Add(salariat.Salariu.ToString());
                    lvi.SubItems.Add(salariat.CalculSalariu().ToString());
                    listView1.Items.Add(lvi);
                    fondSalarial += salariat.CalculSalariu();
                }
                toolStripStatusLabel1.Text = "Fondul salarial: " + fondSalarial.ToString();
                panel1.Invalidate();
            }
        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Nu mai ai ce sa modifici!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (listView1.SelectedItems.Count != 1)
            {
                MessageBox.Show("Selecteaza doar un salariat!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var modifyForm = new AddModify((Salariat)listView1.SelectedItems[0].Tag);
                if(modifyForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Salariat modificat cu succes!");
                    listView1.Items.Clear();
                    var fondSalarial = 0m;
                    foreach (var salariat in firma.Salariati)
                    {
                        var lvi = new ListViewItem(salariat.Marca.ToString());
                        lvi.Tag = salariat;
                        lvi.SubItems.Add(salariat.Nume);
                        lvi.SubItems.Add(salariat.NrOre.ToString());
                        lvi.SubItems.Add(salariat.Salariu.ToString());
                        lvi.SubItems.Add(salariat.CalculSalariu().ToString());
                        listView1.Items.Add(lvi);
                        fondSalarial += salariat.CalculSalariu();
                    }
                    toolStripStatusLabel1.Text = "Fondul salarial: " + fondSalarial.ToString();
                }
                panel1.Invalidate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var salariatNou = new Salariat();
            var newForm = new AddModify(salariatNou);
            if(newForm.ShowDialog() == DialogResult.OK)
            {
                firma.addSalariat(salariatNou);
                MessageBox.Show("Salariat adaugat cu succes!");
                listView1.Items.Clear();
                var fondSalarial = 0m;
                foreach (var salariat in firma.Salariati)
                {
                    var lvi = new ListViewItem(salariat.Marca.ToString());
                    lvi.Tag = salariat;
                    lvi.SubItems.Add(salariat.Nume);
                    lvi.SubItems.Add(salariat.NrOre.ToString());
                    lvi.SubItems.Add(salariat.Salariu.ToString());
                    lvi.SubItems.Add(salariat.CalculSalariu().ToString());
                    listView1.Items.Add(lvi);
                    fondSalarial += salariat.CalculSalariu();
                }
                toolStripStatusLabel1.Text = "Fondul salarial: " + fondSalarial.ToString();
                panel1.Invalidate();
            }
        }



        private void Form1_Resize(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.CreateGraphics().Clear(Color.White);
            var g = panel1.CreateGraphics();
            var pen = new Pen(Color.Black, 2);
            var font = new Font("Arial", 10);
            var fontBrush = new SolidBrush(Color.Blue);
            var x = 0;
            var y = 0;
            var w = 0;
            var h = 0;
            var maxSalariu = firma.Salariati.Max(salariat => salariat.Salariu);
            var wUnit = panel1.Width / firma.Salariati.Count;
            var hUnit = panel1.Height / (maxSalariu + 1000);
            firma.Salariati.Sort((sal1, sal2) => sal1.Salariu.CompareTo(sal2.Salariu));
            foreach (var salariat in firma.Salariati)
            {
                x = firma.Salariati.IndexOf(salariat) * wUnit;
                y = panel1.Height - (int)(salariat.Salariu * hUnit);
                w = wUnit;
                h = (int)(salariat.Salariu * hUnit);
                g.DrawRectangle(pen, x, y, w, h);
                g.FillRectangle(fontBrush, x, y, w, h);
                g.DrawString(salariat.Salariu.ToString() + " " + salariat.Nume, font, new SolidBrush(Color.Black), x, y - 20);
            }
        }
    }
}
