using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextEditorProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            Program.f2 = this;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();

            Program.f1.button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Text files (*.txt) | *.txt";
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                StreamReader input = new(openFileDialog1.FileName);
                this.Text = openFileDialog1.FileName.Split("\\")[^1];
                richTextBox1.Text = "";
                richTextBox1.Text = input.ReadToEnd();
                input.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonCancel.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            Form3 form3 = new();
            form3.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.f1.button1.Enabled = true;
        }
    }
}
