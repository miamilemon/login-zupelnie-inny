using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();
            com1.SelectedIndex = 0;
            com2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // zapisywanie do pliku
            using (StreamWriter outputFile = new StreamWriter(System.IO.Path.Combine(docPath, "uczen.txt"), true))
            {
                outputFile.WriteLine(textBox2.Text + " " + textBox3.Text + " " + textBox4.Text);
                SaveFileDialog theDialog = new SaveFileDialog();
            }
        }

        private void wyszukaj_Click(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\student\Desktop\uczen.txt");
            textBox1.Text = "";
            foreach (string line in lines)
            {
                if (com1.SelectedIndex == 0)
                {
                    if (com2.SelectedIndex == 0)
                    {
                        if (textBox5.Text == line.Split(' ')[0])
                            textBox1.AppendText(line + "\r\n");
                    }
                    if (com2.SelectedIndex == 1)
                    {
                        if (line.Split(' ')[0].Contains(textBox5.Text))
                            textBox1.AppendText(line + "\r\n");
                    }
                    if (com2.SelectedIndex == 2)
                    {
                        if (line.Split(' ')[0].StartsWith(textBox5.Text))
                            textBox1.AppendText(line + "\r\n");
                    }
                }
                if (com1.SelectedIndex == 1)
                {
                    if (com2.SelectedIndex == 0)
                    {
                        if (textBox5.Text == line.Split(' ')[1])
                            textBox1.AppendText(line + "\r\n");
                    }
                    if (com2.SelectedIndex == 1)
                    {
                        if (line.Split(' ')[1].Contains(textBox5.Text))
                            textBox1.AppendText(line + "\r\n");
                    }
                    if (com2.SelectedIndex == 2)
                    {
                        if (line.Split(' ')[1].StartsWith(textBox5.Text))
                            textBox1.AppendText(line + "\r\n");
                    }
                }
                if (com1.SelectedIndex == 2)
                {
                    if (com2.SelectedIndex == 0)
                    {
                        if (textBox5.Text == line.Split(' ')[2])
                            textBox1.AppendText(line + "\r\n");
                    }
                    if (com2.SelectedIndex == 1)
                    {
                        if (line.Split(' ')[2].Contains(textBox5.Text))
                            textBox1.AppendText(line + "\r\n");
                    }
                    if (com2.SelectedIndex == 2)
                    {
                        if (line.Split(' ')[2].StartsWith(textBox5.Text))
                            textBox1.AppendText(line + "\r\n");
                    }
                }
            }
        }

    }
}
