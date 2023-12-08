using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace У.П
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            float totalCost = 0;
            float Cost = 0;
            // Проверяем заполнены ли поля
            if (string.IsNullOrEmpty(cBRou.Text) &&
                string.IsNullOrEmpty(cBDate.Text) &&
                string.IsNullOrEmpty(cBVan.Text) &&
                (UpDOld.Value != 0))
                // Выводим сообщение об ошибке если не поля заполнены
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                // Проверка выбранного маршрута
                string selectedRoute = cBRou.SelectedItem.ToString();
                if (selectedRoute == "Москва-Санкт-Петербург")
                {
                    Cost += 3600;
                }
                else if (selectedRoute == "Москва-Краснодар")
                {
                    Cost += 8100;
                }
                else if (selectedRoute == "Москва-Новокузнецк")
                {
                    Cost += 5800;
                }
                // Проверка типа вагона
                string selectedClass = cBVan.SelectedItem.ToString();
                if (selectedClass == "Плацкарт")
                {
                    totalCost += 0;
                }
                else if (selectedClass == "СВ")
                {
                    totalCost += 4000;
                }
                else if (selectedClass == "Купе")
                {
                    totalCost += 2000;
                }
                else if (selectedClass == "Для инвалидов")
                {
                    totalCost += 0;
                }
                // Проверка выбранных опций
                if (cBLug.Checked == true)
                {
                    totalCost = Cost / 100 * 1 + Cost;
                }
                if (cBBack.Checked == true)
                {
                    totalCost *= 2;
                }
                // Подсчет цены билета для детей
                if (UpDChild.Value != 0)
                {
                    totalCost += (Cost / 100 * 5 + Cost) * (int)UpDChild.Value;
                }
                // Подсчет цены билета для взрослых
                if (UpDOld.Value != 0)
                {
                    totalCost += Cost * (int)UpDOld.Value;
                }
                // Отображение окна с итоговой стоимостью
                MessageBox.Show($"Стоимость билета: {totalCost} рублей", "Стоимость билета", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
