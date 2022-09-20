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
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = imageList1.Images.Count > 0 ? imageList1.Images[0] : null;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int liczba = rnd.Next(6);
            pictureBox1.Image = imageList1.Images[liczba];
        }
    }
}
