using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace У.П
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Метод очистки поля результата
        private void Clear()
        {
            lblRes.Text = "";
        }
//Метод вычисления факториала
        private int Fac(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        //Вычисление сочитаний
        private void Coch_Click(object sender, EventArgs e)
        {
            Clear();
            //Берём значения заданные пользователем
            int n = int.Parse(txtN.Text);
            int m = int.Parse(txtM.Text);
            //Вычисления по формуле
            int num = Fac(n);
            int denom = Fac(n - m) * Fac(m);
            float res1 = num / denom;
            //Вывод с преобразованием типа данных
            string str1 = res1.ToString();
            lblRes.Text = str1;
        }

        private void Razm_Click(object sender, EventArgs e)
        {
            Clear();
            //Берём значения заданные пользователем
            int n = int.Parse(txtN.Text);
            int m = int.Parse(txtM.Text);
            //Вычисления по формуле
            int num = Fac(n);
            int denom = Fac(n - m);
            float res2 = num / denom;
            //Вывод с преобразованием типа данных
            string str2 = res2.ToString();
            lblRes.Text = str2;
        }

        private void Per_Click(object sender, EventArgs e)
        {
            Clear();
            //Берём значения заданные пользователем
            int n = int.Parse(txtN.Text);
            //Вычисления по формуле
            float res3 = Fac(n);
            //Вывод с преобразованием типа данных
            string str3 = res3.ToString();
            lblRes.Text = str3;
        }
        //Ограничение на ввод только числовых данных
        private void txtM_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
        //Ограничение на ввод только числовых данных
        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
