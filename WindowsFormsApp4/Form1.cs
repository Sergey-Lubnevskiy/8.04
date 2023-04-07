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

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Value = 0;
            progressBar1.Maximum = 1000;
            progressBar1.Step = 1;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Text Files (.txt)|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                string fileText = File.ReadAllText(filePath);

                this.listBox1.Items.Add(fileText);

                for (int i = 0; i < fileText.Length; i++)
                {
                    progressBar1.Value = i + 1;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.maskedTextBox1.Text))
            {
                this.listBox2.Items.Add(this.maskedTextBox1.Text);
            }
            else
                MessageBox.Show("Empty string");
            if (!String.IsNullOrEmpty(this.maskedTextBox2.Text))
            {
                this.listBox2.Items.Add(this.maskedTextBox2.Text);
            }
            else
                MessageBox.Show("Empty string");
            if (!String.IsNullOrEmpty(this.maskedTextBox3.Text))
            {
                this.listBox2.Items.Add(this.maskedTextBox3.Text);
            }
            else
                MessageBox.Show("Empty string");
            if (!String.IsNullOrEmpty(this.maskedTextBox4.Text))
            {
                this.listBox2.Items.Add(this.maskedTextBox4.Text);
            }
            else
                MessageBox.Show("Empty string");
        }
    }
}
