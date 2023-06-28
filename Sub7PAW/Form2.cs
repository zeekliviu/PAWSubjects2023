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
    public partial class Form2 : Form
    {
        private List<Topping> toppings;
        private List<ComandaPizza> comenzi;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(List<ComandaPizza> comenzi):this()
        {
            this.comenzi = comenzi;
            toppings = new List<Topping>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(new Form3(toppings).ShowDialog() == DialogResult.OK)
            {
                textBox3.Text = string.Empty;
                toppings.ForEach(topping => textBox3.Text += topping.ToString()+Environment.NewLine);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int durata;
            int.TryParse(textBox2.Text, out durata);
            if(durata <= 0)
            {
                MessageBox.Show("Nu e buna durata!");
                return;
            }
            if (!comboBox1.Items.Contains(comboBox1.Text))
            {
                MessageBox.Show("Selecteaza un blat existent!");
                return;
            }
            comenzi.Add(new ComandaPizza(textBox1.Text, comboBox1.Text, durata, toppings));
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
