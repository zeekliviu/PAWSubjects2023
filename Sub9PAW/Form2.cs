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
    public partial class Form2 : Form
    {
        List<Candidat> candidati;
        List<ProgramStudiu> programe;
        Candidat c;

        public Form2()
        {
            InitializeComponent();
        }
        public Form2(List<Candidat> candidati, List<ProgramStudiu> programe):this()
        {
            this.candidati = candidati;
            this.programe = programe;
        }
        public Form2(Candidat c, List<ProgramStudiu> programe):this()
        {
            this.c = c;
            this.programe = programe;
            textBox1.Text = c.CodCandidat.ToString();
            textBox2.Text = c.NumeCandidat;
            textBox3.Text = c.MedieConcurs.ToString();
            textBox4.Text = Helpers.ArrayToString(c.VectorOptiuni).Replace(" ", string.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cod;
            float medie;
            int.TryParse(textBox1.Text, out cod);
            float.TryParse(textBox3.Text, out medie);
            if(cod<=0)
            {
                MessageBox.Show("Cod invalid!");
                return;
            }
            if(medie<=0||medie>10)
            {
                MessageBox.Show("Medie invalida!");
                return;
            }
            var optiuni = textBox4.Text.Split(',');
            if(optiuni.Length==0)
            {
                MessageBox.Show("Optiuni invalide!");
                return;
            }
            int optiune;
            var coduri = programe.Select(program=>program.CodProgram).ToArray();
            int[] optiuniCandidat = new int[optiuni.Length];
            foreach(var opt in optiuni.ToList())
            {
                
                int.TryParse(opt, out optiune);
                if(optiune <= 0)
                {
                    MessageBox.Show("Optiune invalida!");
                    return;
                }
                if(!coduri.Contains(optiune))
                {
                    MessageBox.Show($"Optiunea {optiune} nu se afla in lista de programe.");
                    return;
                }
                optiuniCandidat[optiuni.ToList().IndexOf(opt)] = optiune;
            }
            if(c==null)
                candidati.Add(new Candidat(cod, textBox2.Text, medie, optiuniCandidat));
            else
            {
                c.CodCandidat = cod;
                c.NumeCandidat = textBox2.Text;
                c.MedieConcurs = medie;
                c.VectorOptiuni = optiuniCandidat;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
