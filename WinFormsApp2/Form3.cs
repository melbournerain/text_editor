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
    public partial class Form3 : Form
    {
        public Form3()
        {
            Program.f3 = this;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Program.f2.buttonCancel.Enabled = true;
            Program.f2.button2.Enabled = true;
            Program.f2.button3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                string fileName = saveFileDialog1.FileName;
                File.WriteAllText(fileName, Program.f2.richTextBox1.Text);
            }

            Close();
            Program.f2.buttonCancel.Enabled = true;
            Program.f2.button2.Enabled = true;
            Program.f2.button3.Enabled = true;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.f2.buttonCancel.Enabled = true;
            Program.f2.button2.Enabled = true;
            Program.f2.button3.Enabled = true;
        }
    }
}
