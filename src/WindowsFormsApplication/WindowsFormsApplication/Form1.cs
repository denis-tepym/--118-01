using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication
{

    public partial class Form1 : Form
    {
        string zxc;
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                webBrowser1.Navigate("about:blank");
                zxc = openFileDialog1.FileName;
                webBrowser1.Navigate(zxc);
                this.Size = new Size(1200, 800);
                webBrowser1.Visible = true;
                webBrowser1.Size = new Size(1000, 300);
                label1.Visible = true;
                label2.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                button1.Visible = true;
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            О_программе newForm = new О_программе();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double X = Convert.ToDouble(textBox1.Text);
            double Y = Convert.ToDouble(textBox2.Text);

            if (((X <=5) && (X >=-2)) && ((Y <= 4) && (Y>=-3)))
            {
                MessageBox.Show("Поздравляю, все прошло успешно. Точка лежит в границе!");
                toolStripStatusLabel1.Text = "Поздравляю, все прошло успешно. Точка лежит в границе!";
            }
            else
            {
                MessageBox.Show("Извините, заданная вами точка, не лежит в закрашенной области!");
                toolStripStatusLabel1.Text = "Извините, заданная вами точка, не лежит в закрашенной области!";
            }
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
