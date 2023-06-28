using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sub4PAW
{
    public partial class Form3 : Form
    {
        List<Vagon> vagoane;
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(List<Vagon> vag):this()
        {
            vagoane = vag;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.CreateGraphics().Clear(Color.White);
            var g = panel1.CreateGraphics();
            var pen = new Pen(Color.Black, 2);
            var font = new Font("Arial", 10);
            var rectBrush = new SolidBrush(Color.Blue);
            var x = 0;
            var y = 0;
            var w = 0;
            var h = 0;
            var maxCapacitate = vagoane.Max(vagon => vagon.Capacitate);
            var wUnit = panel1.Width / vagoane.Count;
            var hUnit = panel1.Height / (maxCapacitate + 5f);
            vagoane.Sort((v1,v2)=>v1.Capacitate.CompareTo(v2.Capacitate));
            foreach(var  v in vagoane)
            {
                x = vagoane.IndexOf(v) * wUnit;
                y = panel1.Height - (int)(v.Capacitate * hUnit);
                w = wUnit;
                h = (int)(v.Capacitate * hUnit);
                g.DrawRectangle(pen, x, y, w, h);
                g.FillRectangle(rectBrush, x, y, w, h);
                g.DrawString(v.Capacitate.ToString() + " Cod: "+v.CodV.ToString(), font, new SolidBrush(Color.Black), x, y - 20);
            }
        }
    }
}
