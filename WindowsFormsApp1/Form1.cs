using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a;
            if(!int.TryParse(textBox1.Text,out a))
            {
                MessageBox.Show("Введите новое число", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (a<1 || a>7)
            {
                MessageBox.Show("Введите новое число", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (a)
            {
                case 1: label1.Text = "Понедельник ";
                    break;
                case 2:
                    label1.Text = "Вторник ";
                    break;
                case 3:
                    label1.Text = "Среда ";
                    break;
                case 4:
                    label1.Text = "Четверг ";
                    break;
                case 5:
                    label1.Text = "Пятница ";
                    break;
                case 6:
                    label1.Text = "Суббота ";
                    break;
                case 7:
                    label1.Text = "Воскресенье";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a;
            if (!int.TryParse(textBox2.Text, out a))
            {
                MessageBox.Show("Введите новое число", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (a < 1 || a > 12)
            {
                MessageBox.Show("Введите новое число", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (a)
            {
                case 1:
                    label2.Text = "Январь ";
                    break;
                case 2:
                    label2.Text = "Февраль ";
                    break;
                case 3:
                    label2.Text = "Март ";
                    break;
                case 4:
                    label2.Text = "Апрель ";
                    break;
                case 5:
                    label2.Text = "Май ";
                    break;
                case 6:
                    label2.Text = "Июнь ";
                    break;
                case 7:
                    label2.Text = "Июль";
                    break;
                case 8:
                    label2.Text = "Август ";
                    break;
                case 9:
                    label2.Text = "Сентябрь ";
                    break;
                case 10:
                    label2.Text = "Октябрь ";
                    break;
                case 11:
                    label2.Text = "Ноябрь ";
                    break;
                case 12:
                    label2.Text = "Декабрь";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            if (!double.TryParse(textBox2.Text, out a))
            {
                MessageBox.Show("Введите новое число", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(textBox3.Text, out b))
            {
                MessageBox.Show("Введите новое число", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var q = textBox4.Text;
            if (q!= "+" && q!= "-" && q!= "*" && q!= "/")
            {
                MessageBox.Show("Введите новый символ", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (q == "+")
            { 
                c = a + b;
                label4.Text = ($"{c}");
            }
            if (q == "-")
            {
                c = a - b;
                label4.Text = ($"{c}");
            }
            if (q == "*")
            {
                c = a * b;
                label4.Text = ($"{c}");
            }
            if (q == "/")
            {
                c = a / b;
                label4.Text = ($"{c}");
            }
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
