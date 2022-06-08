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
    public partial class AdminPanel : Form
    {
        Benz benz = new Benz();
        Kafe kafe = new Kafe();

        public AdminPanel()
        {
            InitializeComponent();

            for (int i = 0; i < benz.benz.Length; i++)
                comboBox1.Items.Add(benz.benz[i]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < benz.benz.Length; i++)
                if (comboBox1.SelectedItem == benz.benz[i])
                    benz.price_benz[i] = Convert.ToInt32(Price.Text);   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vhod vh = new Vhod();
            vh.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
                kafe.price_kafe[0] = Convert.ToInt32(textBox4.Text);
            if (textBox5.Text != "")
                kafe.price_kafe[1] = Convert.ToInt32(textBox5.Text);
            if (textBox6.Text != "")
                kafe.price_kafe[2] = Convert.ToInt32(textBox6.Text);
            if (textBox7.Text != "")
                kafe.price_kafe[3] = Convert.ToInt32(textBox7.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                textBox4.Enabled = true;
            else
            {
                textBox4.Enabled = false;
                textBox4.Clear();
            }
        } 
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                textBox5.Enabled = true;
            else
            {
                textBox5.Enabled = false;
                textBox5.Clear();
            }

        } 
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
                textBox6.Enabled = true;
            else
            {
                textBox6.Enabled = false;
                textBox6.Clear();
            }
        } 
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
                textBox7.Enabled = true;
            else
            {
                textBox7.Clear();
                textBox7.Enabled = false;
            }
        } 
    }
}
