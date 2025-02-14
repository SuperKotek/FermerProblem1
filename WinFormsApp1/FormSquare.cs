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
    public partial class FormSquare : Form
    {
        public FormSquare()
        {
            InitializeComponent();
        }
        double perimetr = 0;    // Обьявление периметра
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
        private void button1_Click(object sender, EventArgs e)
        {
            ploshad = 0;
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";    // Если пользователь ничего не ввел, то автоматически периметр берется за ноль и это выводиться
            }
            if (!double.TryParse(textBox1.Text, out perimetr))
            {
                textBox2.Text = "Некорректный ввод!";         // Если пользователь ввел недопустимые символы, то выводиться ошибка
            }
            else
            {
                if (perimetr < 0)
                {
                    textBox2.Text = "Некорректный ввод!";    // Если пользователь ввел отрицательное число, то выводиться ошибка
                }
                else
                {
                    if (perimetr == 0)
                    {
                        textBox2.Text = "0";         // Если периметр равен 0, то автоматически площадь равна 0, и это выводиться.
                    }
                    else
                    {
                        ploshad = Farmer.Quadrat(perimetr);
                    }
                    ploshad = Math.Round(ploshad, 5);
                    textBox2.Text = ploshad.ToString();     // Здесь выводиться результат - получившияся площадь
                }
            }
        }
    }
}
