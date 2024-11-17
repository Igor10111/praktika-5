using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter нажимать нечестно,пользуйся мышкой!");
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            int Index = rnd.Next(4);

            switch (Index)
            {
                case 0:
                    bClick.Left += bClick.Width;
                    break;
                case 1:
                    bClick.Left -= bClick.Width;
                    break;
                case 2:
                    bClick.Top += bClick.Height;
                    break;
                case 3:
                    bClick.Top -= bClick.Height;
                    break;

                default:
                    break;
            }
            if (bClick.Left < 0)
            {
                bClick.Left = 0;
            }
            if (bClick.Top < 0)
            {
                bClick.Top = 0;
            }
            if (bClick.Left + bClick.Width > this.Width)
            {
                bClick.Left = this.Width - bClick.Width;
            }
            if (bClick.Top + bClick.Height > this.Height)
            {
                bClick.Top = this.Height - bClick.Height;
            }
        }
    }
}
    

