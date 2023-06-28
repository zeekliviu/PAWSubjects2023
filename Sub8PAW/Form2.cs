using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sub8PAW
{
    public partial class Form2 : Form
    {
        bool deModificat;
        List<Prod> produse;
        Prod prod;


        public Form2()
        {
            InitializeComponent();
        }


        public Form2(List<Prod> produse,bool deModificat):this()
        {
            this.deModificat = deModificat;
            button1.Text = "Adauga";
            this.produse = produse;
        }

        public Form2(Prod prod, bool deModificat):this()
        {
            this.prod = prod;
            this.deModificat = deModificat;
            button1.Text = "Modifica";
            textBox1.Text = prod.cod.ToString();
            textBox2.Text = prod.denumire;
            textBox3.Text = prod.Pret.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!deModificat)
            {
                int cod;
                float pret;
                try
                {
                    int.TryParse(textBox1.Text, out cod);
                    if(cod<=0)
                    {
                        MessageBox.Show("Codul nu e valid!");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Codul nu e numeric intreg!");
                    return;
                }
                try
                {
                    float.TryParse(textBox3.Text, out pret);
                    if(pret<=0)
                    {
                        MessageBox.Show("Pretul nu e valid!");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Pretul nu e numeric real!");
                    return;
                }
                produse.Add(new Prod(cod, textBox2.Text, pret));
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                int cod;
                float pret;
                try
                {
                    int.TryParse(textBox1.Text, out cod);
                    if (cod <= 0)
                    {
                        MessageBox.Show("Codul nu e valid!");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Codul nu e numeric intreg!");
                    return;
                }
                try
                {
                    float.TryParse(textBox3.Text, out pret);
                    if (pret <= 0)
                    {
                        MessageBox.Show("Pretul nu e valid!");
                        return;
                    }
                    else if (pret < prod.Pret)
                    {
                        MessageBox.Show("Pretul nu poate fi mai mic!");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Pretul nu e numeric real!");
                    return;
                }
                DialogResult = DialogResult.OK;
                prod.cod = cod;
                prod.Pret = pret;
                prod.denumire = textBox2.Text;
                Close();
            }
        }
    }
}
