using SubCristina.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubCristina
{
    public partial class Form3 : Form
    {
        private CardTransport[] carduri;
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(CardTransport[] carduri): this()
        {
            this.carduri = carduri;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.CreateGraphics().Clear(Color.White);
            var g = panel1.CreateGraphics();
            var pen = new Pen(Color.Black, 2);
            var font = new Font("Arial", 6);
            var fontBrush = new SolidBrush(Color.Black);
            var rectBrush = new SolidBrush(Color.Blue);
            var x = 0;
            var y = 0;
            var h = 0;
            var w = 0;
            var carduriNenule = carduri.Where(card => card != null).ToArray();
            var maxSold = carduriNenule.Max(card => card.Sold);
            var hUnit = panel1.Height / (maxSold + 1.5f);
            var wUnit = panel1.Width / carduriNenule.Length;
            Array.Sort(carduriNenule);
            for (int i = 0; i < carduriNenule.Length; i++)
            {
                x = i * wUnit;
                y = panel1.Height - (int)(carduriNenule[i].Sold * hUnit);
                w = wUnit;
                h = (int)(carduriNenule[i].Sold * hUnit);
                g.DrawRectangle(pen, x, y, w, h);
                g.FillRectangle(rectBrush, x, y, w, h);
                g.DrawString(carduri[i].ToString(), font, fontBrush, x+w/5, y - 20);

            }
        }
    }
}
