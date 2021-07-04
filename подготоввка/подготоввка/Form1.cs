using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace подготоввка
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void домашняяСтраницаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            стр1 newForm = new стр1();
            newForm.Show();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            стр2 newForm = new стр2();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double X = Convert.ToDouble(textBox1.Text);
            double Y = Convert.ToDouble(textBox2.Text);
            if (X > 0 && Y > 0)
            {
                MessageBox.Show("Поздравляю, все прошло успешно. Заданная вами точка, находится в 1 координатной четвверти!");
            }
            else if (X < 0 && Y > 0)
            {
                MessageBox.Show("Поздравляю, все прошло успешно. Заданная вами точка, находится в 2 координатной четвверти!");
            }
            else if (X < 0 && Y < 0)
            {
                MessageBox.Show("Поздравляю, все прошло успешно. Заданная вами точка, находится в 3 координатной четвверти!");
            }
            else if (X > 0 && Y < 0)
            {
                MessageBox.Show("Поздравляю, все прошло успешно. Заданная вами точка, находится в 4 координатной четвверти!");
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}
