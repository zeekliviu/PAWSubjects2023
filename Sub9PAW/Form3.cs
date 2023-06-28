using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sub9PAW
{
    public partial class Form3 : Form
    {
        Dictionary<int, int> dict;
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Dictionary<int, int> dict):this()
        {
            this.dict = dict;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.CreateGraphics().Clear(Color.White);
            var g = panel1.CreateGraphics();
            var pen = new Pen(Color.Black, 2);
            var font = new Font("Arial", 7);
            var fontBrush = new SolidBrush(Color.Black);
            var rectBrush = new SolidBrush(Color.Blue);
            var x = 0;
            var y = 0;
            var h = 0;
            var w = 0;
            var dictList = dict.ToList();
            dictList.Sort((v1,v2)=>v2.Value.CompareTo(v1.Value));
            var maxInscrisi = dict.Values.Max();
            var nrInscrisi = dict.Keys.Count;
            var wUnit = panel1.Width / nrInscrisi;
            var hUnit = panel1.Height / (maxInscrisi + 2);
            foreach(var kvp in dictList )
            {
                x = dictList.IndexOf(kvp) * wUnit;
                y = panel1.Height - (kvp.Value * hUnit);
                w = wUnit;
                h = (kvp.Value * hUnit);
                g.DrawRectangle(pen, x, y, w, h);
                g.FillRectangle(rectBrush, x, y, w, h);
                g.DrawString($"Optiunea {kvp.Key} - {kvp.Value}", font, fontBrush, x, y-20);
            }
        }
    }
}
