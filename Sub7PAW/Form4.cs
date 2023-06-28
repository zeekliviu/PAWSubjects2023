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
    public partial class Form4 : Form
    {
        private List<Topping> toppings;
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(List<Topping> top): this()
        {
            toppings = top;
            foreach(var topp in toppings)
            {
                var lvi = new ListViewItem(topp.Cod.ToString());
                lvi.Tag = topp;
                lvi.SubItems.Add(topp.Denumire);
                lvi.SubItems.Add(topp.Pret.ToString("C"));
                listView1.Items.Add(lvi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toppings.Clear();
            foreach(ListViewItem item in listView1.CheckedItems)
            {
                toppings.Add(item.Tag as Topping);
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
