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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Задание1 one = new Задание1();
            one.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Задание2 two = new Задание2();
            two.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Задание_3 three = new Задание_3();
            three.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Задание4 four = new Задание4();
            four.Show();
        }
    }
}
