using SubCristina.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubCristina
{
    public partial class Form2 : Form
    {
        private CardTransport ct;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(CardTransport cardTransport): this()
        {
            ct = cardTransport;
            numeTb.Text = ct.Nume;
            soldTb.Text = ct.Sold.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var sold = float.Parse(soldTb.Text);
                if(sold<0f)
                {
                    MessageBox.Show("Soldul nu poate fi negativ!");
                    return;
                }
                ct.Sold = sold;
                ct.Nume = numeTb.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch
            {
                MessageBox.Show("Format invalid pentru sold!");
                return;
            }
        }
    }
}
