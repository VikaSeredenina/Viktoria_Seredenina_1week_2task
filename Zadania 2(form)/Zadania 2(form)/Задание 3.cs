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
    public partial class Задание_3 : Form
    {
        public Задание_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Считывание значения a 
            int A = int.Parse(textBox1.Text);

            // Считывание значения b
            int B = int.Parse(textBox2.Text);



            if (A > B)
            {
                MessageBox.Show("Должно быть A<=B");

            }              

         
           int i = B;
            while (i >= A)
            {
               textBox3.Text += Convert.ToString (" В кубе " + i * i * i);
                i--;
            }

           
           

            i = B;
            do
            {
                textBox4.Text+= Convert.ToString(" В кубе " + i * i * i);
                i--;
            }
            while (i >= A);
           
           
            for ( i = B; i >= A; i--)
            {
                textBox5.Text += Convert.ToString(" В кубе " + i * i * i);
            }


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
            textBox4.Text = "";
            textBox4.Clear();
            textBox5.Text = "";
            textBox5.Clear();
        }
    }
}
