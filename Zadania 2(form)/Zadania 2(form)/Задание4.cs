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
    public partial class Задание4 : Form
    {
        public Задание4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int nachalo = 7;
            int d = 1;
            for (int i = 0; i < 5; i++, textBox1.Text += " " +  Environment.NewLine)
            {
                for (int j = 0; j < d; j++)
                {
                    textBox1.Text += " " + nachalo;
                }
                d++;
                nachalo--;
            }
        }
    }
}
