using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sub10PAW
{
    public partial class Form2 : Form
    {
        List<ExtrasCont> extrase;
        string filepath;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(List<ExtrasCont> extrase,  string filepath):this()
        {
            this.extrase = extrase;
            this.filepath = filepath;
        }

    }
}
