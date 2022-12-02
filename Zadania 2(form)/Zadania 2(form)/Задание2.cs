using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadania_2_form_
{
    public partial class Задание2 : Form
    {
        public Задание2()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                int m = int.Parse(textBox3.Text);

                while (m >= 12)
                {
                    m -= 12;
                }
                int localDate = Int32.Parse(DateTime.Now.ToString("MM"));
                int date = localDate - m;

                if (date == 1)
                {
                    textBox4.Text += "Январь";
                }
                if (date == 2)
                {
                    textBox4.Text += "Февраль";
                }
                if (date == 3)
                {
                    textBox4.Text += "Март";
                }
                if (date == 4)
                {
                    textBox4.Text += "Апрель";
                }
                if (date == 5)
                {
                    textBox4.Text += "Май";
                }
                if (date == 6)
                {
                    textBox4.Text += "Июнь";
                }
                if (date == 7)
                {
                    textBox4.Text += "Июль";
                }
                if (date == 8)
                {
                    textBox4.Text += "Август";
                }
                if (date == 9)
                {
                    textBox4.Text += "Сентябрь";
                }
                if (date == 10)
                {
                    textBox4.Text += "Октябрь";
                }
                if (date == 11)
                {
                    textBox4.Text += "Ноябрь";
                }
                if (date == 12)
                {
                    textBox4.Text += "Декабрь";
                }
            
            }
            catch
            {
                
            }
        }

       

       

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Введите положительное число ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            textBox3.Text = "";
            textBox3.Clear();
            textBox4.Text = "";
            textBox4.Clear();
        }

        private void Задание2_Load(object sender, EventArgs e)
        {

        }
    }
}
