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

namespace Pregatire_examen_PAW
{
    public partial class Form2 : Form
    {
        List<Poligon> poligoane;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(List<Poligon> poligoane):this()
        {
            this.poligoane = poligoane;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.CreateGraphics().Clear(Color.White);
            var g = panel1.CreateGraphics();
            foreach(var poligon in poligoane)
            {
                PointF[] puncte = new PointF[poligon.NrPuncte];
                for(int i=0; i<poligon.NrPuncte; i++)
                {
                    puncte[i].X = poligon.Puncte[i].x;
                    puncte[i].Y = poligon.Puncte[i].y;
                }
                g.DrawPolygon(new Pen(poligon.Color), puncte);
                g.FillPolygon(new SolidBrush(poligon.Color), puncte);
            }
        }
    }
}
