using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sam4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Настройка текстового поля для ввода пароля
            SetupPasswordTextBox();
        }

        // Метод для настройки TextBox как поля ввода пароля
        private void SetupPasswordTextBox()
        {
            // Устанавливаем символ, который будет отображаться вместо вводимых символов
            textBox1.PasswordChar = '*';

            // Если хотите использовать системный символ пароля вместо '*', можно использовать:
            // textBoxPassword.UseSystemPasswordChar = true;
        }
    }
}
