using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dz_5_Benz
{
    public partial class Registr : Form
    {
        static int x = 0;

        public Registr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string line = $"Пользователь {x}\n"; x++;

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox2.Text == textBox3.Text)
            {
                StreamWriter sw = new StreamWriter("Users.txt", true);
                line += textBox1.Text + "\n" + textBox2.Text + "\n\n";
                sw.WriteLine(line);
                sw.Close();

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else if (textBox1.Text != "" && textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Пароль не совпадает"); 
                textBox2.Clear();
                textBox3.Clear();
            }
            else if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                MessageBox.Show("Заполните все поля");   
        }
    }
} 