using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sam6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Настройка автозаполнения для textBoxSpecialty
            SetupAutoComplete();
        }

        // Метод для настройки автозаполнения
        private void SetupAutoComplete()
        {
            // Создаем коллекцию строк с названиями специальностей
            var specialties = new AutoCompleteStringCollection
            {
                "Программирование в компьютерных системах",
                "Информационные системы и программирование",
                "Конструирование, моделирование и технологий швейных изделий",
                "Конструирование, моделирование и технология изделий из кожи"
            };

            // Настройка TextBox для автозаполнения
            textBox1.AutoCompleteCustomSource = specialties;                // Устанавливаем список специальностей
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;      // Показывать и дополнять текст
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;   // Используем пользовательский список
        }
    }
}
