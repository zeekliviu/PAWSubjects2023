using SubCristina.entities;
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

namespace SubCristina
{
    public partial class Form1 : Form
    {
        private CardTransport[] carduri;
        private Calatorie[] calatorii;

        delegate void SimpleDelegate(string message);

        private void DisplayMsg(string message)
        {
            MessageBox.Show(message);
        }

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(CardTransport[] carduri, Calatorie[] calatorii) : this()
        {
            this.carduri = carduri;
            this.calatorii = calatorii;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var smpDelegate = new SimpleDelegate(DisplayMsg);
            smpDelegate("hello, world!");
            var totalSold = 0f;
            for(int i=0; i<carduri.Length; i++)
            {
                if (carduri[i]!=null)
                {
                    int k = 0;
                    treeView1.Nodes.Add(carduri[i].ToString());
                    treeView1.Nodes[i].Tag = carduri[i];
                    for(int j=0; j<calatorii.Length; j++)
                    {
                        if (calatorii[j] != null && calatorii[j].CodC == carduri[i].CodC)
                        {
                            treeView1.Nodes[i].Nodes.Add(calatorii[j].ToString());
                            treeView1.Nodes[i].Nodes[k++].Tag = calatorii[j];
                        }
                    }
                    totalSold += carduri[i];
                }
            }
            totalSoldTb.Text = totalSold.ToString("F2")+" lei";
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!treeView1.Nodes.Contains(treeView1.SelectedNode))
            {
                MessageBox.Show("Selecteaza un calator!");
                return;
            }
            if(new Form2((CardTransport)treeView1.SelectedNode.Tag).ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Card modificat cu succes!");
                treeView1.Nodes.Clear();
                for (int i = 0; i < carduri.Length; i++)
                {
                    if (carduri[i] != null)
                    {
                        int k = 0;
                        treeView1.Nodes.Add(carduri[i].ToString());
                        treeView1.Nodes[i].Tag = carduri[i];
                        for (int j = 0; j < calatorii.Length; j++)
                        {
                            if (calatorii[j] != null && calatorii[j].CodC == carduri[i].CodC)
                            {
                                treeView1.Nodes[i].Nodes.Add(calatorii[j].ToString());
                                treeView1.Nodes[i].Nodes[k++].Tag = calatorii[j];
                            }
                        }
                    }
                }
                return;
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.Nodes.Contains(treeView1.SelectedNode))
            {
                var totalValoareCalatorii = 0f;
                var totalDistantaCalatorii = 0;
                for (int i = 0; i < calatorii.Length; i++)
                    if (calatorii[i] == null)
                        break;
                    else
                    {
                        var card = (CardTransport)treeView1.SelectedNode.Tag;
                        if (card.CodC == calatorii[i].CodC)
                        {
                            totalValoareCalatorii += calatorii[i].Valoare;
                            totalDistantaCalatorii += calatorii[i].Distanta;
                        }
                    }
                sumaTotalaTb.Text = totalValoareCalatorii.ToString();
                totalDistantaTb.Text = totalDistantaCalatorii.ToString();
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                new Form3(carduri).Show();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using(var writer = new StreamWriter("../../carduri.xml"))
            {
                var xml = new XmlSerializer(typeof(CardTransport[]));
                xml.Serialize(writer, carduri.Where(card => card!=null).ToArray());
            }
            using(var writer = new StreamWriter("../../calatorii.xml"))
            {
                var xml = new XmlSerializer(typeof(Calatorie[]));
                xml.Serialize(writer, calatorii.Where(calatorie => calatorie != null).ToArray());
            }
        }
    }
}
