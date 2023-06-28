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
    public partial class Form3 : Form
    {
        private List<Topping> toppings;
        private Random rnd;
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(List<Topping> toppings):this()
        {
            this.toppings = toppings;
            rnd = new Random();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float pret; 
            float.TryParse(textBox2.Text, out pret);
            float cantitate;
            float.TryParse(textBox3.Text, out cantitate);
            if(pret<=0)
            {
                MessageBox.Show("Pret incorect!");
                return;
            }
            if(cantitate<=0)
            {
                MessageBox.Show("Cantitate incorecta!");
                return;
            }
            toppings.Add(new Topping(textBox1.Text, pret, cantitate, rnd.Next(0, 101)));
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
