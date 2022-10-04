using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        int liczba;
        string txt0;

        public Form1()
        {
            
            InitializeComponent();
            Random rnd = new Random();
            liczba = rnd.Next(6);
            pictureBox1.Image = imageList1.Images[liczba];
            if (liczba == 0)
                txt0 = "mxyxw";
            if (liczba == 1)
                txt0 = "b5nmm";
            if (liczba == 2)
                txt0 = "74853";
            if (liczba == 3)
                txt0 = "cg5dd";
            if (liczba == 4)
                txt0 = "x3deb";
            if (liczba == 5)
                txt0 = "befhd";
            if (liczba == 6)
                txt0 = "c7gb3";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            liczba = rnd.Next(6);
            pictureBox1.Image = imageList1.Images[liczba];
            if (liczba == 0)
                txt0 = "mxyxw";
            if (liczba == 1)
                txt0 = "b5nmm";
            if (liczba == 2)
                txt0 = "74853";
            if (liczba == 3)
                txt0 = "cg5dd";
            if (liczba == 4)
                txt0 = "x3deb";
            if (liczba == 5)
                txt0 = "befhd";
            if (liczba == 6)
                txt0 = "c7gb3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool tak1 = false;
            bool tak2 = false;
            bool tak3 = false;
            if (login.Text!="admin")
                MessageBox.Show("Nieprawidłowy login");
            else
                tak1 = true;
            if (haslo.Text!="Qwerty1@34")
                MessageBox.Show("Nieprawidłowe hasło");
            else
                tak2 = true;
            if (cap.Text != txt0)
                MessageBox.Show("Nieprawidłowa CZAPAcza");
            else
                tak3 = true;
            if (tak1 && tak2 && tak3 == true)
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }




        }
    }
}
