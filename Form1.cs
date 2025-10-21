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

        // ����������� ��� �������� ����
        private void ToolStripComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (toolStripComboBox1.Text)
            {
                case "�����": BackColor = Color.White; break;
                case "�������": BackColor = Color.Red; break;
                case "�����": BackColor = Color.Blue; break;
                case "������": BackColor = Color.Yellow; break;
                case "������": BackColor = Color.Black; break;
                default: BackColor = SystemColors.Control; break;
            }
        }

        // ���������� ��� RGB ��������� �����
        private void ToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int red = Convert.ToInt32(toolStripTextBox1.Text);
                int green = Convert.ToInt32(toolStripTextBox2.Text);
                int blue = Convert.ToInt32(toolStripTextBox3.Text);

                // �������� ���������
                if (red >= 0 && red <= 255 && green >= 0 && green <= 255 && blue >= 0 && blue <= 255)
                {
                    BackColor = Color.FromArgb(red, green, blue);
                }
            }
            catch
            {
                MessageBox.Show("���������� ������ ����� ����� �� 0 �� 255", "������ � ������� �����");
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