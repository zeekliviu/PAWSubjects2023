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
    public partial class Form2 : Form
    {
        private Vagon v;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Vagon v):this()
        {
            this.v = v;
            codVTb.Text = v.CodV.ToString();
            descCb.Text = v.DescriereTIP;
            capTb.Text = v.Capacitate.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ValidateChildren();
            if(errorProvider1.GetError(capTb)!="")
            {
                MessageBox.Show("Verifica campurile!");
                return;
            }
            v.CodV = int.Parse(codVTb.Text);
            v.Capacitate = float.Parse(capTb.Text);
            v.DescriereTIP = descCb.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void capTb_Validating(object sender, CancelEventArgs e)
        {
            float cap = -1;
            float.TryParse(capTb.Text, out cap);
            if (cap == 0)
            {
                errorProvider1.SetError(capTb, "Valoarea nu e numar real cu separator zecimal virgula!");
                return;
            }
            if(cap < 0f)
            {
                errorProvider1.SetError(capTb, "Valoarea trebuie sa fie pozitiva!");
                return;
            }
        }


    }
}
