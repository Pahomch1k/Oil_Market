using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dz_5_Benz
{
    public partial class Vhod : Form
    {
        public Vhod()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registr reg = new Registr();
            reg.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                AdminPanel adm = new AdminPanel();
                adm.ShowDialog();
            }
            else
            {
                Form1 frm = new Form1();
                frm.ShowDialog();
            }
        }
    }
}
