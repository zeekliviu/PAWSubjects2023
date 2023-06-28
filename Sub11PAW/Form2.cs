using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sub11PAW
{
    public partial class Form2 : Form
    {
        List<Camion> camioane;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(List<Camion> camioane):this()
        {
            this.camioane = camioane;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.CreateGraphics().Clear(Color.White);
            var g = panel1.CreateGraphics();
            var pen = new Pen(Color.Black, 2);
            var font = new Font("Arial", 8);
            var fontBrush = new SolidBrush(Color.Black);
            var rectBrush = new SolidBrush(Color.Blue);
            var x = 0;
            var y = 0;
            var h = 0;
            var w = 0;
            camioane.Sort((c1, c2)=>c2.Marfuri.Length.CompareTo(c1.Marfuri.Length));
            var maxNr = camioane.Max(camion=>camion.Marfuri.Length);
            var nrC = camioane.Count;
            var wUnit = panel1.Width / nrC;
            var hUnit = panel1.Height / (maxNr + 1);
            foreach(var c in camioane)
            {
                x = camioane.IndexOf(c) * wUnit;
                y = panel1.Height - (c.Marfuri.Length * hUnit);
                w = wUnit;
                h = (c.Marfuri.Length * hUnit);
                g.DrawRectangle(pen, x, y, w, h);
                g.FillRectangle(rectBrush, x, y, w, h);
                g.DrawString(c.Marca.ToString() + " " + c.An.ToString(), font, fontBrush, x, y-20);
            }
        }
    }
}
