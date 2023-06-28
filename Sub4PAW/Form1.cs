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

namespace Sub4PAW
{
    public partial class Form1 : Form
    {
        private List<Tren> trenuri;
        private List<Vagon> vagoane;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(List<Tren> trenuri):this()
        {
            this.trenuri = trenuri;
            vagoane = new List<Vagon>();
            foreach(var t in trenuri)
                foreach(var v in t.Vagoane)
                {
                    vagoane.Add(v);
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(var v in vagoane)
            {
                var lvi = new ListViewItem(v.CodV.ToString());
                lvi.Tag = v;
                lvi.SubItems.Add(v.DescriereTIP);
                lvi.SubItems.Add(v.Capacitate.ToString());
                listView1.Items.Add(lvi);
            }
        }

        private void filtrareBtn_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach(var v in vagoane.Where(v => v.DescriereTIP.Equals("Cereale")))
            {
                var lvi = new ListViewItem(v.CodV.ToString());
                lvi.Tag = v;
                lvi.SubItems.Add(v.DescriereTIP);
                lvi.SubItems.Add(v.Capacitate.ToString());
                listView1.Items.Add(lvi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Vagon> aux = new List<Vagon>();
            foreach (ListViewItem v in listView1.Items)
                aux.Add((Vagon)v.Tag);
            listView1.Items.Clear();
            foreach(var v in aux.OrderBy(x=>x.Capacitate))
            {
                var lvi = new ListViewItem(v.CodV.ToString());
                lvi.Tag = v;
                lvi.SubItems.Add(v.DescriereTIP);
                lvi.SubItems.Add(v.Capacitate.ToString());
                listView1.Items.Add(lvi);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)
            { 
                MessageBox.Show("Selecteaza un singur item");
                return;
            }
            if(new Form2((Vagon)listView1.SelectedItems[0].Tag).ShowDialog() == DialogResult.OK)
            {
                List<Vagon> vagoaneaux = new List<Vagon>();
                foreach(ListViewItem lvi in listView1.Items)
                {
                    vagoaneaux.Add((Vagon)lvi.Tag);
                }
                listView1.Items.Clear();
                foreach (var v in vagoaneaux)
                {
                    var lvi = new ListViewItem(v.CodV.ToString());
                    lvi.Tag = v;
                    lvi.SubItems.Add(v.DescriereTIP);
                    lvi.SubItems.Add(v.Capacitate.ToString());
                    listView1.Items.Add(lvi);
                }
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)
            {
                MessageBox.Show("Selecteaza un singur item");
                return;
            }
            var cldlg = new ColorDialog();
            if(cldlg.ShowDialog() == DialogResult.OK)
            {
                listView1.SelectedItems[0].BackColor = cldlg.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Vagon> aux = new List<Vagon>();
            foreach(ListViewItem lvi in listView1.Items)
            {
                aux.Add((Vagon)lvi.Tag);
            }
            new Form3(aux).ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using(var sw = new StreamWriter("../../export.xml"))
            {
                var xml = new XmlSerializer(typeof(List<Tren>));
                xml.Serialize(sw, trenuri);
            }
        }
    }
}
