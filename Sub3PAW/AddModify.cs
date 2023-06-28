using Sub3PAW.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sub3PAW
{
    public partial class AddModify : Form
    {
        private Salariat salariat;
        public AddModify()
        {
            InitializeComponent();
        }
        public AddModify(Salariat salariat): this()
        {
            this.salariat = salariat;
            marcaTb.Text = salariat.Marca.ToString();
            salariuTb.Text = salariat.Salariu.ToString();
            nrOreTb.Text = salariat.NrOre.ToString();
            numeTb.Text = salariat.Nume;
        }

        private void addmodBtn_Click(object sender, EventArgs e)
        {
            var salariu = 0m;
            var nrOre = 0f;
            var marca = 0;
            try
            {
                salariu = decimal.Parse(salariuTb.Text);
                if(salariu<=0m)
                {
                    MessageBox.Show("Salariul nu poate fi negativ/zero!");
                    salariuTb.Text = string.Empty;
                }
            }
            catch
            {
                MessageBox.Show("Salariu in format gresit!");
                salariuTb.Text = string.Empty;
                return;
            }
            try
            {
                nrOre = float.Parse(nrOreTb.Text);
                if(nrOre<=0f)
                {
                    MessageBox.Show("Nr. ore nu poate fi negativ/zero!");
                    nrOreTb.Text = string.Empty;
                    
                }
            }
            catch
            {
                MessageBox.Show("Numar ore in format gresit!");
                nrOreTb.Text = string.Empty;
                return;
            }
            try
            {
                marca = int.Parse(marcaTb.Text);
                if(marca<=0)
                {
                    MessageBox.Show("Marca nu poate fi negativa/zero!");
                    marcaTb.Text = string.Empty;
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Marca in format gresit!");
                marcaTb.Text = string.Empty;
                return;
            }
            salariat.Marca = marca;
            salariat.Nume = numeTb.Text;
            salariat.NrOre = nrOre;
            salariat.Salariu = salariu;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
