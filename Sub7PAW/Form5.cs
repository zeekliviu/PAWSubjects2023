using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sub7PAW
{
    public partial class Form5 : Form
    {
        Dictionary<string, int> topinguri;
        public Form5()
        {
            InitializeComponent();
        }
        public Form5(Dictionary<string, int> topinguriPeNr): this()
        {
            topinguri = topinguriPeNr;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.CreateGraphics().Clear(Color.White);
            var g = panel1.CreateGraphics();
            var pen = new Pen(Color.Black, 2);
            var font = new Font("Arial", 10);
            var fontBrush = new SolidBrush(Color.Black);
            var rectBrush = new SolidBrush(Color.Blue);
            var x = 0;
            var y = 0;
            var h = 0;
            var w = 0;
            var maxUsage = topinguri.Values.Max();
            var nrTopings = topinguri.Keys.Count;
            var wUnit = panel1.Width / nrTopings;
            var hUnit = panel1.Height / (maxUsage + 2);
            var topinguriList = topinguri.ToList();
            topinguriList.Sort((e1, e2) => e2.Value.CompareTo(e1.Value));
            int i = 0;
            foreach(var entry in topinguriList)
            {
                x = i++ * wUnit;
                y = panel1.Height - (int)(entry.Value * hUnit);
                w = wUnit;
                h = (int)(entry.Value * hUnit);
                g.DrawRectangle(pen, x, y, w, h);
                g.FillRectangle(rectBrush, x, y, w, h);
                g.DrawString(entry.Key + " " +entry.Value, font, fontBrush, x, y - 20);
            }
        }

        private void Form5_Resize(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }
    }
}
