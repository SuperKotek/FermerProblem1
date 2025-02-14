using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Задача.Фермера.Библиотека;

namespace WinFormsApp1
{
    public partial class FormNpoint : Form
    {
        public FormNpoint()
        {
            InitializeComponent();
        }
        double perimetr = 0;    // Обьявление периметра
        int n_uglov = 3;        // Обьявление количества углов
        double ploshad = 0;     // Обьявление площади
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                perimetr = 0;    // Обрабатывается исключение, если пользователь ничего не ввел
            }
            else
            {
                try
                {
                    perimetr = double.Parse(textBox1.Text);   // Если пользователь что-то ввел
                }
                catch (FormatException)
                {
                }
            }
        }        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                n_uglov = 3;    // Обрабатывается исключение, если пользователь ничего не ввел
            }
            else
            {
                try
                {
                    n_uglov = int.Parse(textBox1.Text);   // Если пользователь что-то ввел
                }
                catch (FormatException)
                {
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ploshad = 0;
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";    // Если пользователь ничего не ввел, то автоматически периметр берется за ноль и это выводиться
            }
            if (textBox3.Text == "")
            {
                textBox3.Text = "3";    // Если пользователь ничего не ввел, то автоматически количетсво углов берется за ноль и это выводиться
            }
            if (!double.TryParse(textBox1.Text, out perimetr) | perimetr < 0)
            {
                textBox2.Text = "Некорректный ввод периметра!";
            }
            else
            {
                if (!int.TryParse(textBox3.Text, out n_uglov) | n_uglov < 3)
                {
                    textBox2.Text = "Некорректный ввод количества углов!";
                }
                else
                {
                    if (perimetr == 0)
                    {
                        textBox2.Text = "0";
                    }
                    else
                    {
                        ploshad = Farmer.nangel(perimetr, n_uglov);
                        ploshad = Math.Round(ploshad, 5);
                        textBox2.Text = ploshad.ToString();     // Здесь выводиться результат - получившияся площадь
                    }
                }
            }
        }
    }
}
