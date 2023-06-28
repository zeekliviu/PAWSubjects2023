using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sub5PAW
{
    public partial class Form2 : Form
    {
        public List<Carte> carti;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(List<Carte> carti):this()
        {
            this.carti = carti;
        }

        private bool ValidateISBN(string isbn)
        {
            if (isbn.Length != 13)
            {
                return false;
            }

            int sum = 0;

            for (int i = 0; i < 12; i++)
            {
                if (i % 2 == 0)
                {
                    sum += int.Parse(isbn[i].ToString());
                }
                else
                {
                    sum += int.Parse(isbn[i].ToString()) * 3;
                }
            }

            int checkDigit = 10 - (sum % 10);
            if (checkDigit == 10)
            {
                checkDigit = 0;
            }

            return checkDigit == int.Parse(isbn[12].ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float pret;
            float.TryParse(textBox2.Text, out pret);
            if(pret==0)
            {
                MessageBox.Show("Pret incorect scris!");
                return;
            }
            else if(pret<0)
            {
                MessageBox.Show("Pret negativ!");
                return;
            }
            if(!ValidateISBN(textBox3.Text)) {
                MessageBox.Show("ISBN incorect!");
                return;
            }
            var deAdaugat = new Carte(textBox3.Text, comboBox1.Text);
            deAdaugat.Titlu = textBox1.Text;
            deAdaugat.Pret = pret;
            carti.Add(deAdaugat);
            DialogResult = DialogResult.OK;
        }
    }
}
