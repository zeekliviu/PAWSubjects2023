using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sub10PAW
{
    public partial class Form1 : Form
    {
        List<ExtrasCont> extrase;
        public Form1()
        {
            InitializeComponent();
            extrase = new List<ExtrasCont>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=1; i<=5; i++)
            {
                new Form2(extrase, $"tranzactii{i}.txt").ShowDialog();
            }
        }
    }
}
