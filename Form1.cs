using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Laba5
{
    public partial class Form1 : Form
    {
        private ToolStripMenuItem currentCheckedItem;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.SelectedIndex = 0;
        }

        // Обработчики для главного меню
        private void ToolStripComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (toolStripComboBox1.Text)
            {
                case "белый": BackColor = Color.White; break;
                case "красный": BackColor = Color.Red; break;
                case "синий": BackColor = Color.Blue; break;
                case "желтый": BackColor = Color.Yellow; break;
                case "черный": BackColor = Color.Black; break;
                default: BackColor = SystemColors.Control; break;
            }
        }

        // Обработчик для RGB текстовых полей
        private void ToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int red = Convert.ToInt32(toolStripTextBox1.Text);
                int green = Convert.ToInt32(toolStripTextBox2.Text);
                int blue = Convert.ToInt32(toolStripTextBox3.Text);

                // Проверка диапазона
                if (red >= 0 && red <= 255 && green >= 0 && green <= 255 && blue >= 0 && blue <= 255)
                {
                    BackColor = Color.FromArgb(red, green, blue);
                }
            }
            catch
            {
                MessageBox.Show("Необходимо ввести целое число от 0 до 255", "Ошибка в задании цвета");
            }
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}