using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sam5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Инициализация начального текста для метки
            label1.Text = "Введите текст в поле";
        }

        // Обработчик события TextChanged для textBox1
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Обновляем текст метки в соответствии с введенным текстом в textBox1
            label1.Text = textBox1.Text;
        }
    }
}
