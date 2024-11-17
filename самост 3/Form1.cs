using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sam_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Вызов метода для настройки автозаполнения
            SetupAutoComplete();
        }

        // Метод для настройки автозаполнения
        private void SetupAutoComplete()
        {
            // Список фамилий для автозаполнения
            var surnames = new AutoCompleteStringCollection
            {
                 "Иванов", "Петров", "Сидоров", "Никифоров", "Мальцев"
            };

            // Настройка свойств TextBox
            textBox1.AutoCompleteCustomSource = surnames;            // Источник данных
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;    // Отображать список предложений
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource; // Использовать пользовательский источник данных
        }
    }
}
