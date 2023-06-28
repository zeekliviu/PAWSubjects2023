using Pregatire_examen_PAW.Entities;
using Pregatire_examen_PAW.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Pregatire_examen_PAW
{
    public partial class Form1 : Form
    {
        private List<Poligon> poligoane;

        public Form1()
        {
            InitializeComponent();
            poligoane = new List<Poligon>();
        }

        private void insereazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new coordonateTxtBox(poligoane).ShowDialog();
            listViewPoligoane.Items.Clear();
            foreach(var poligon in poligoane)
            {
                var lvi = new ListViewItem(poligon.getCod().ToString());
                lvi.Tag = poligon;
                lvi.SubItems.Add(poligon.eticheta);
                lvi.SubItems.Add(poligon.grosime_linie.ToString());
                listViewPoligoane.Items.Add(lvi);
            }
        }

        private void salvareSerializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(poligoane.Count==0)
            {
                MessageBox.Show("Nu ai figuri! ;)");
                return;
            }
            string numeFisier = Interaction.InputBox("Scrie aici fișierul unde vrei să se salveze:", "Salvează la...");
            using (var fs = new FileStream($"../../{numeFisier}.dat", FileMode.Create))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(fs, poligoane);
            }
        }

        private void restaurareDeserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string numeFisier = Interaction.InputBox("Scrie aici fișierul de unde vrei să se restaureze:", "Restaurează de la...");
            if(!File.Exists($"../../{numeFisier}.dat"))
            {
                MessageBox.Show("Fisier inexistent!");
                return;
            }
            using(var fs = new FileStream($"../../{numeFisier}.dat", FileMode.Open))
            {
                var formatter = new BinaryFormatter();
                poligoane = (List<Poligon>)formatter.Deserialize(fs);
                foreach (var poligon in poligoane)
                {
                    var lvi = new ListViewItem(poligon.getCod().ToString());
                    lvi.Tag = poligon;
                    lvi.SubItems.Add(poligon.eticheta);
                    lvi.SubItems.Add(poligon.grosime_linie.ToString());
                    listViewPoligoane.Items.Add(lvi);
                }
            }
        }

        private void desenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2(poligoane).Show();
        }
    }
}
