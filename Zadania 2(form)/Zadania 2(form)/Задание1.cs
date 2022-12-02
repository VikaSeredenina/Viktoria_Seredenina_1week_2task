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
    public partial class Задание1 : Form
    {
        public Задание1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Считывание значения x
            double x = double.Parse(textBox1.Text);

            // Считывание значения y
            double y = double.Parse(textBox2.Text);

            if (y < 12 && y > Math.Abs(x))
                textBox3.Text = "Да";
            else if (y > 12 || y < Math.Abs(x))
                textBox3.Text = "Нет";
            else textBox3.Text = "На границе";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

          char number = e.KeyChar;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.') && (e.KeyChar != '-'))

            {
                e.Handled = true;
            MessageBox.Show("Введите число");
            }
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.') && (e.KeyChar != '-'))

            {
                e.Handled = true;
                MessageBox.Show("Введите число");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Clear();
            textBox2.Text = "";
            textBox2.Clear();
            textBox3.Text = "";
            textBox3.Clear();
        }

        
    }
}
