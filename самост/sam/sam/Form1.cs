using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = textBox1.Text;

            // Проверка, что URL не пустой и имеет правильный формат
            if (!string.IsNullOrEmpty(url))
            {
                try
                {
                    // Открытие веб-страницы по URL
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при открытии страницы: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите URL.");
            }
        }
    }
}
    

