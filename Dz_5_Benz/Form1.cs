using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; 

namespace Dz_5_Benz
{
    
    public partial class Form1 : Form
    {
        Benz benz = new Benz();
        Kafe kafe = new Kafe();
        MainMenu MyMenu;
        MenuItem m1, m2, subm1, subm2;  

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < benz.benz.Length; i++)
                comboBox2.Items.Add(benz.benz[i]);

            MyMenu = new MainMenu();

            m1 = new MenuItem("Загрузить"); 
            MyMenu.MenuItems.Add(m1);

            subm1 = new MenuItem("Бензин");
            subm1.Click += new EventHandler(бензинToolStripMenuItem_Click); 
            m1.MenuItems.Add(subm1);

            subm2 = new MenuItem("Кафе");
            subm2.Click += new EventHandler(кафеToolStripMenuItem_Click);
            m1.MenuItems.Add(subm2);

            m2 = new MenuItem("Сохранить");
            m2.Select += new EventHandler(сохранитьToolStripMenuItem_Click);
            MyMenu.MenuItems.Add(m2);
             
            Menu = MyMenu;
        } 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            object obj = comboBox1.SelectedItem;
            string op = obj.ToString();
            switch (op)
            {
                case "92": Price.Text = benz.price_benz[0].ToString(); break;
                case "95": Price.Text = benz.price_benz[1].ToString(); break;
                case "100": Price.Text = benz.price_benz[2].ToString(); break;
                case "ДТ": Price.Text = benz.price_benz[3].ToString(); break;
            } 
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            object obj = comboBox2.SelectedItem;
            string op = obj.ToString();
            switch (op)
            {
                case "92": Price.Text = benz.price_benz[0].ToString(); break;
                case "95": Price.Text = benz.price_benz[1].ToString(); break;
                case "100": Price.Text = benz.price_benz[2].ToString(); break;
                case "ДТ": Price.Text = benz.price_benz[3].ToString(); break;
            } 
            subm1.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Price.Text);
            int y = Convert.ToInt32(textBox2.Text);

            textBox3.Text = (x * y).ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        { 
            if (checkBox1.Checked == true) 
                textBox8.Enabled = true;
            else
            {
                textBox8.Enabled = false;
                textBox8.Clear();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                textBox9.Enabled = true;
            else
            {
                textBox9.Enabled = false;
                textBox9.Clear();
            }
                
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
                textBox10.Enabled = true;
            else
            {
                textBox10.Enabled = false;
                textBox10.Clear();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
                textBox11.Enabled = true;
            else
            {
                textBox11.Clear();
                textBox11.Enabled = false; 
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox4.Text);
            int y = Convert.ToInt32(textBox8.Text);

            if (textBox12.Text != "")
            {
                int z = Convert.ToInt32(textBox12.Text);
                textBox12.Text = (z + x * y).ToString();
            }
            else textBox12.Text = (x * y).ToString(); 
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox5.Text);
            int y = Convert.ToInt32(textBox9.Text);

            if (textBox12.Text != "")
            {
                int z = Convert.ToInt32(textBox12.Text);
                textBox12.Text = (z + x * y).ToString();
            }
            else textBox12.Text = (x * y).ToString();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox6.Text);
            int y = Convert.ToInt32(textBox10.Text);

            if (textBox12.Text != "")
            {
                int z = Convert.ToInt32(textBox12.Text);
                textBox12.Text = (z + x * y).ToString();
            }
            else textBox12.Text = (x * y).ToString();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox7.Text);
            int y = Convert.ToInt32(textBox11.Text);

            if (textBox12.Text != "")
            {
                int z = Convert.ToInt32(textBox12.Text);
                textBox12.Text = (z + x * y).ToString();
            }
            else textBox12.Text = (x * y).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox12.Text == "" && textBox3.Text == "") 
                MessageBox.Show("Суммы нет"); 
            else if (textBox3.Text != "" && textBox12.Text == "")
                textBox13.Text = textBox3.Text;
            else if (textBox12.Text != "" && textBox3.Text == "")
                textBox13.Text = textBox12.Text;
            else
            {
                int x = Convert.ToInt32(textBox3.Text);
                int y = Convert.ToInt32(textBox12.Text);
                textBox13.Text = (x + y).ToString();
            }
        }

        private void бензинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < benz.benz.Length; i++)
                comboBox1.Items.Add(benz.benz[i]);
            comboBox2.Enabled = false;
        }

        private void кафеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkBox1.Text = kafe.kafe[0];
            checkBox2.Text = kafe.kafe[1];
            checkBox3.Text = kafe.kafe[2];
            checkBox4.Text = kafe.kafe[3];

            textBox4.Text = Convert.ToString(kafe.price_kafe[0]);
            textBox5.Text = Convert.ToString(kafe.price_kafe[1]);
            textBox6.Text = Convert.ToString(kafe.price_kafe[2]);
            textBox7.Text = Convert.ToString(kafe.price_kafe[3]);
        }
          
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            StreamWriter sw = new StreamWriter("Chek.log", true);
            string line = "Заправка - WOG\nАдресс - Пушкина дом колотушкина\nВремя - "; 
            line += Convert.ToString(DateTime.Now) + "\n\n";

            if (comboBox1.SelectedItem == null && comboBox2.SelectedItem != null)
            {
                string x = Convert.ToString(benz.benz[0]);
                switch (comboBox2.Text)
                {
                    
                    case "92": line += $"Бензин:\nНазвание - 92\nЦена - {benz.price_benz[0]} грн\n";
                        break;
                    case "95": line += $"Бензин:\nНазвание - 95\nЦена - {benz.price_benz[1]} грн\n";
                        break;
                    case "100": line += $"Бензин:\nНазвание - 100\nЦена - {benz.price_benz[2]} грн\n";
                        break;
                    case "ДТ": line += $"Бензин:\nНазвание - ДТ\nЦена - {benz.price_benz[3]} грн\n";
                        break;
                } 
            }
            else if (comboBox2.SelectedItem == null && comboBox1.SelectedItem != null)
            {
                switch (comboBox1.Text)
                {
                    case "92": line += $"Бензин:\nНазвание - 92\nЦена - {benz.price_benz[0]} грн\n"; break;
                    case "95": line += $"Бензин:\nНазвание - 95\nЦена - {benz.price_benz[1]} грн\n"; break;
                    case "100": line += $"Бензин:\nНазвание - 100\nЦена - {benz.price_benz[2]} грн\n"; break;
                    case "ДТ": line += $"Бензин:\nНазвание - ДТ\nЦена - {benz.price_benz[3]} грн\n"; break;
                }
            }

            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox4.Checked == true)
            {
                line += $"\nКафе:\n";
                if (checkBox1.Checked == true) line += $"Название - {checkBox1.Text}\nЦена - {kafe.price_kafe[0]} грн\n";
                if (checkBox2.Checked == true) line += $"Название - {checkBox2.Text}\nЦена - {kafe.price_kafe[1]} грн\n"; 
                if (checkBox3.Checked == true) line += $"Название - {checkBox3.Text}\nЦена - {kafe.price_kafe[2]} грн\n";
                if (checkBox4.Checked == true) line += $"Название - {checkBox4.Text}\nЦена - {kafe.price_kafe[3]} грн\n"; 
            }

            line += $"\nСумма - {textBox13.Text}\n";

            sw.WriteLine(line); 
            sw.Close();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            m2.Enabled = true;
        }
    }

    public class Benz
    {
        public string[] benz = new string[4] { "92", "95", "100", "ДТ" };
        public int[] price_benz = new int[4] { 29, 33, 40, 36 };
    }

    public class Kafe
    {
        public string[] kafe = new string[4] { "HotDog", "HotDog XL", "Late", "Late XL" };
        public int[] price_kafe = new int[4] { 50, 65, 25, 40 };
    }
}