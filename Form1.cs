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
        // Изменяем видимость полей при выборе rB_custom
        private void rB_custom_CheckedChanged(object sender, EventArgs e)
        {
            txtDate.Visible = false;
            lblDate.Visible = false;
            txtNum.Visible = true;
            lblNum.Visible = true;
        }
        // Изменяем видимость полей при выборе rB_empl
        private void rB_empl_CheckedChanged(object sender, EventArgs e)
        {
            txtDate.Visible = true;
            lblDate.Visible = true;
            txtNum.Visible = false;
            lblNum.Visible = false;
        }
        // Вызываем событие при нажатии кнопки btnGen
        private void btnGen_Click(object sender, EventArgs e)
        {
            {
                // Получаем фамилию из txtFname
                string fname = txtFname.Text;
                // Получаем имя из txtName
                string name = txtName.Text;
                // Получаем отчество из txtSname
                string sname = txtSname.Text;
                // Получаем номер из txtNum
                string num = txtNum.Text;
                // Получаем дату рождения из txtDate
                string date = txtDate.Text;
                // Вызываем генератор случайных чисел
                Random random = new Random();
                // Получаем 1 и 2 букву имени
                char let1 = (char)('a' + random.Next(0, 26));
                char let2 = (char)('a' + random.Next(0, 26));
                char let3 = (char)('A' + random.Next(0, 26));
                char let4 = (char)('A' + random.Next(0, 26));
                // Получаем 2 случайные цифры
                Random rnd = new Random();
                int numb1 = rnd.Next(10);
                int numb2 = rnd.Next(10);

                // Формируем пароль в виде xxXX00XX
                string password = $"{let1}{let2}{let3}{let4}{numb1}{numb2}{let3}{let4}";

                // Вывод пароля в элемент в txtPas
                txtPas.Text = password;
                // Проверяем, выбран ли радиобаттон rb_custom
                if (rB_custom.Checked)
                {
                    // Проверяем, чтобы все текстбоксы были заполнены
                    if (!string.IsNullOrEmpty(fname) && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(sname) && !string.IsNullOrEmpty(num))
                    {
                        // Извлекаем первые буквы фамилии, имени и отчества
                        string fio = $"{fname[0]}{name[0]}{sname[0]}";

                        // Получаем последние 3 цифры из номера и преобразуем в число
                        int lastThreeDigits = int.Parse(num.Substring(num.Length - 2));
                        // Генерируем финальный логин вида "фио00Последние3Цифры"
                        string login = $"{fio}{lastThreeDigits}";
                        txtLog.Text = login; // Выводим логин в txtlog
                    }
                    else
                    {
                        MessageBox.Show("Пожалуйста, заполните все текстовые поля.");
                    }
                }
                else
                {
                    // Проверяем, выбран ли радиобаттон rB_empl
                    if (rB_empl.Checked)
                    {
                        // Проверяем, чтобы все текстбоксы были заполнены
                        if (!string.IsNullOrEmpty(fname) && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(sname) && !string.IsNullOrEmpty(date))
                        {
                            string birthYear = txtDate.Text.Substring(6, 4);
                            // Создаём переменную для хранения ФИО
                            string fio = $"{fname[0]}{name[0]}{sname[0]}";
                            string login = $"{fio}{birthYear}";
                            // Выводим логин в txtlog
                            txtLog.Text = login;
                        }
                        else
                        {
                            MessageBox.Show("Пожалуйста, заполните все текстовые поля.");
                        }
                    }
                }
            }
        }
    }
}
