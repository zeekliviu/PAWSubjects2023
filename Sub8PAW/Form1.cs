using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Sub8PAW
{
    public partial class Form1 : Form
    {
        List<Prod> prod;
        public Form1()
        {
            InitializeComponent();
            prod = new List<Prod>();
            toolStripStatusLabel1.Text = string.Empty;
            panel1.Visible = false;
        }
        public Form1(List<Prod> prod):this()
        {
            this.prod = prod;
            foreach(var prodItem in prod)
            {
                var lvi = new ListViewItem(prodItem.cod.ToString());
                lvi.Tag = prodItem;
                lvi.SubItems.Add(prodItem.denumire);
                lvi.SubItems.Add(prodItem.Pret.ToString("C"));
                listView1.Items.Add(lvi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(new Form2(prod, false).ShowDialog() == DialogResult.OK)
            {
                listView1.Items.Clear();
                foreach (var prodItem in prod)
                {
                    var lvi = new ListViewItem(prodItem.cod.ToString());
                    lvi.Tag = prodItem;
                    lvi.SubItems.Add(prodItem.denumire);
                    lvi.SubItems.Add(prodItem.Pret.ToString("C"));
                    listView1.Items.Add(lvi);
                }
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(listView1.SelectedItems.Count != 1)
            {
                MessageBox.Show("Selecteaza doar un element!");
                return;
            }
            else
            {
                var produs = (Prod)listView1.SelectedItems[0].Tag;
                if(new Form2(produs, true).ShowDialog() == DialogResult.OK)
                {
                    listView1.Items.Clear();
                    foreach (var prodItem in prod)
                    {
                        var lvi = new ListViewItem(prodItem.cod.ToString());
                        lvi.Tag = prodItem;
                        lvi.SubItems.Add(prodItem.denumire);
                        lvi.SubItems.Add(prodItem.Pret.ToString("C"));
                        listView1.Items.Add(lvi);
                    }
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using(var sw = new StreamWriter("../../date.xml"))
            {
                var xml = new XmlSerializer(typeof(List<Prod>));
                xml.Serialize(sw, prod);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            using(var sr = new StreamReader("../../date.xml"))
            {
                var xml = new XmlSerializer(typeof(List<Prod>));
                var prodDeserializate = (List<Prod>)xml.Deserialize(sr);
                listView1.Items.Clear();
                foreach(var prodItem in prodDeserializate)
                {
                    var lvi = new ListViewItem(prodItem.cod.ToString());
                    lvi.Tag = prodItem;
                    lvi.SubItems.Add(prodItem.denumire);
                    lvi.SubItems.Add(prodItem.Pret.ToString("C"));
                    listView1.Items.Add(lvi);
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Prod produs=null;
            for(int i=0; i<prod.Count-1; i++)
                for(int j=i+1; j<prod.Count; j++)
                    if (prod[i] < prod[j])
                    {
                        produs = prod[i];
                        prod[i] = prod[j];
                        prod[j] = produs;
                    }
            toolStripStatusLabel1.Text = prod.Last().ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.CreateGraphics().Clear(Color.White);
            var g = panel1.CreateGraphics();
            var pretMin = prod.Min(produs => produs.Pret);
            var produsMin = prod.Find(produs => produs.Pret == pretMin);
            var produsSelectat = (Prod)listView1.SelectedItems[0].Tag;
            var pretProdus = produsSelectat.Pret;
            if(pretProdus==pretMin)
            {
                MessageBox.Show("Alege un produs diferit de cel minim!");
                return;
            }
            int centerX = panel1.Width / 2;
            int centerY = panel1.Height / 2;
            float radiusMin = (pretMin + panel1.Width/4)/ 2;
            float radiusProdus = (pretProdus+panel1.Width/4) / 2;
            float xMin = centerX - radiusMin;
            float yMin = centerY - radiusMin;
            float xProd = centerX - radiusProdus;
            float yProd = centerY - radiusProdus;
            float diametruMin = 2 * radiusMin;
            float diametruProdus = 2 * radiusProdus;
            g.DrawEllipse(Pens.Red, xProd, yProd, diametruProdus, diametruProdus);
            g.FillEllipse(Brushes.Red, xProd, yProd, diametruProdus, diametruProdus);
            g.DrawEllipse(Pens.Blue, xMin, yMin, diametruMin, diametruMin);
            g.FillEllipse(Brushes.Blue, xMin, yMin, diametruMin, diametruMin);
            g.DrawString(produsMin.ToString(), SystemFonts.SmallCaptionFont, Brushes.Blue, 5, 5);
            g.DrawString(produsSelectat.ToString(), SystemFonts.SmallCaptionFont, Brushes.Red, 5, 20);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            if(listView1.SelectedItems.Count != 1) {
                MessageBox.Show("Selecteaza un singur item!");
                return;
            }
            panel1.Invalidate();
        }
    }
}
