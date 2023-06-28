using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubRazvanPAW
{
    public partial class Form2 : Form
    {
        List<Apartament> apartamente;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(List<Apartament> ap): this()
        {
            apartamente = ap;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.CreateGraphics().Clear(Color.White);
            var g = panel1.CreateGraphics();
            var font = new Font("Arial", 10);
            var fontBrush = new SolidBrush(Color.Black);
            var rectBrush = new SolidBrush(Color.Blue);
            var pen = new Pen(Color.Black, 2);
            var x = 0;
            var y = 0;
            var h = 0;
            var w = 0;
            var maxApartamente = apartamente.Max(apartament => apartament.calculSuprafata());
            var nrAp = apartamente.Count;
            var wUnit = panel1.Width / nrAp;
            var hUnit = panel1.Height / (maxApartamente + 5f);
            apartamente.Sort((a1, a2)=>a2.calculSuprafata().CompareTo(a1.calculSuprafata()));
            foreach(var apartament in apartamente)
            {
                x = apartamente.IndexOf(apartament) * wUnit;
                y = panel1.Height - (int)(apartament.calculSuprafata() * hUnit);
                w = wUnit;
                h = (int)(apartament.calculSuprafata() * hUnit);
                g.DrawRectangle(pen, x, y, w, h);
                g.FillRectangle(rectBrush, x, y, w, h);
                g.DrawString(apartament.calculSuprafata().ToString(), font, fontBrush, x, y-20);
            }
        }
    }
}
