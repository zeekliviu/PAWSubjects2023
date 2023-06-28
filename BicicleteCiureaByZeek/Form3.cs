using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicicleteCiureaByZeek
{
    public partial class Form3 : Form
    {
        private List<Bicicleta> biciclete;
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(List<Bicicleta> biciclete): this()
        {
            this.biciclete = biciclete;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.CreateGraphics().Clear(Color.White);
            var g = panel1.CreateGraphics();
            var pen = new Pen(Color.Black, 2);
            var font = new Font("Arial", 7);
            var fontBrush = new SolidBrush(Color.Black);
            var rectBrush = new SolidBrush(Color.Blue);
            int maxParcurs = biciclete.Max(bicicleta => bicicleta.KM);
            var hUnit = panel1.Height / (maxParcurs + 25f);
            var wUnit = panel1.Width / biciclete.Count;
            var x = 0;
            var y = 0;
            var h = 0;
            var w = 0;
            biciclete.Sort((b1,b2)=>b1.KM.CompareTo(b2.KM));
            foreach(var bicla in biciclete)
            {
                x = biciclete.IndexOf(bicla) * wUnit;
                y = panel1.Height - (int)(bicla.KM * hUnit);
                w = wUnit;
                h = (int)(bicla.KM * hUnit);
                g.DrawRectangle(pen, x, y, w, h);
                g.FillRectangle(rectBrush, x, y, w, h);
                g.DrawString("Cod: "+bicla.CodB.ToString() + " Km: "+ bicla.KM.ToString(), font, fontBrush, x, y - 20);
            }
        }
    }
}
