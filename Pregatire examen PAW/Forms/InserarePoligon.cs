using Pregatire_examen_PAW.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Pregatire_examen_PAW.Forms
{
    public partial class coordonateTxtBox : Form
    {
        private List<Poligon> poligoane;
        public int nrPuncte;
        public coordonateTxtBox()
        {
            InitializeComponent();
            nrpLabel.Text = string.Empty;
            foreach(var color in Enum.GetValues(typeof(KnownColor)))
            {
                var culoare = Color.FromKnownColor((KnownColor)color);
                if(!culoare.IsSystemColor && culoare.A == 255)
                    colorCb.Items.Add(culoare.ToKnownColor().ToString());
            }
        }

        public coordonateTxtBox(List<Poligon> poligoane): this()
        {
            this.poligoane = poligoane;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                nrPuncte = int.Parse(nrPuncteTxtBox.Text);
                if (nrPuncte < 0)
                {
                    MessageBox.Show("Nu poti adauga un nr. negativ de puncte!");
                    nrPuncteTxtBox.Text = string.Empty;
                }
                else if (nrPuncte < 3)
                {
                    MessageBox.Show("Adauga macar 3 puncte!");
                    nrPuncteTxtBox.Text = string.Empty;
                }
                else nrpLabel.Text = string.Format("Introdu {0} coordonate, cate doua pe linie, separate prin spatiu.", nrPuncte * 2);
            }
            catch {
                nrpLabel.Text = string.Empty;
                nrPuncteTxtBox.Text = string.Empty;
                MessageBox.Show("Introdu un numar!");
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (nrPuncteTxtBox.Text != string.Empty && puncteTxtBox.Lines.Length == nrPuncte)
            {
                if (thicknessNDD.Value < 1)
                {
                    MessageBox.Show("Introdu o grosime mai mare!");
                    return;
                }
                if (!colorCb.Items.Contains(colorCb.Text))
                {
                    colorCb.Text = string.Empty;
                    MessageBox.Show("Introdu o culoare din lista!");
                    return;
                }
                var i = 0;
                var puncte = new List<Punct>();
                foreach (var line in puncteTxtBox.Lines)
                {
                    var values = line.Split(' ');
                    if (values.Length > 2)
                    {        
                        MessageBox.Show(string.Format("Valorile punctului de pe linia {0} nu sunt in regula! Prea multe valori!", i + 1));
                        return;
                    }
                    float x, y;
                    try
                    {
                        x = float.Parse(values[0]);
                        y = float.Parse(values[1]);
                        if(x < 0 || y < 0)
                        {
                            MessageBox.Show(string.Format("Valorile punctului de pe linia {0} nu sunt pozitive!", i + 1));
                            return;
                        }
                        puncte.Add(new Punct(x, y));
                    }
                    catch
                    {
                        MessageBox.Show(string.Format("Valorile punctului de pe linia {0} nu sunt numere reale!", i + 1));
                        return;
                    }
                    i++;
                }
                poligoane.Add(new Poligon(puncte.ToArray(), Color.FromName(colorCb.Text), (float)thicknessNDD.Value, new Random().Next(0, 100), nrPuncte == 3 ? "triunghi" : nrPuncte == 4 ? "dreptunghi" : "poligon"));
                Close();
            }
            else MessageBox.Show("Completeaza corect numarul de puncte si lista acestora!");
        }
    }
}
