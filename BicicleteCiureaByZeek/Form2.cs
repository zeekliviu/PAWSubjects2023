using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicicleteCiureaByZeek
{
    public partial class Form2 : Form
    {
        private Utilizator user;
        private Dictionary<Bicicleta, List<Utilizator>> inchirieri;
        private Bicicleta b;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Dictionary<Bicicleta, List<Utilizator>> inchirieri, Bicicleta b, Utilizator u):this()
        {
            this.inchirieri = inchirieri;
            this.b = b;
            user = u;
            codUTb.Text = u.CodU.ToString();
            codBTb.Text = u.CodB.ToString();
            numeTb.Text = u.Nume;
            durataTb.Text = u.Durata.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int durata;
            int codB;
            int.TryParse(durataTb.Text, out durata);
            errorProvider1.Clear();
            if (durata == 0)
            {
                errorProvider1.SetError(durataTb, "Numarul nu a putut fi interpretat!");
                return;
            }
            else if (durata < 0)
            {
                errorProvider1.SetError(durataTb, "Durata nu poate fi negativa!");
                return;
            }
            int.TryParse(codBTb.Text, out codB);
            if(codB==0)
            {
                errorProvider1.SetError(codBTb, "Numarul nu a putut fi interpretat!");
                return;
            }
            else
            {
                bool gasit = false;
                Bicicleta bicGasita=null;
                foreach(var bic in inchirieri.Keys)
                {
                    if(bic.CodB == codB)
                    {
                        gasit = true;
                        bicGasita = bic;
                        break;
                    }
                }
                if(!gasit)
                {
                    errorProvider1.SetError(codBTb, "Numarul bicicletei nu e in lista de biciclete disponibile!");
                    return;
                }
                else if(!bicGasita.Equals(b))
                {
                    inchirieri[b].Remove(user);
                    user.Durata = durata;
                    user.Nume = numeTb.Text;
                    user.CodB = codB;
                    inchirieri[bicGasita].Add(user);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    user.Durata = durata;
                    user.Nume = numeTb.Text;
                    user.CodB = codB;
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }
    }
}
