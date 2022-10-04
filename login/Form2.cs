using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            using (StreamWriter outputFile = new StreamWriter(System.IO.Path.Combine(docPath, "uczen.txt"),true))
            {
                outputFile.WriteLine(textBox2.Text+" "+textBox3.Text+" "+textBox4.Text);
                SaveFileDialog theDialog = new SaveFileDialog();
            }
        }

        private void wyszukaj_Click(object sender, EventArgs e)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\student\Desktop\uczen.txt");
        }
    }
}
