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
using System.Data.Sql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace login
{
    public partial class Form2 : Form
    {
        string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\kosmi\\source\\repos\\login-zupelnie-inny\\login\\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        public Form2()
        {
            
            InitializeComponent();
            com1.SelectedIndex = 0;
            com2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(conn);
            connect.Open();
            SqlCommand dodajemy = new SqlCommand("INSERT INTO [Table] ([Imie],[Nazwisko],[Klasa]) VALUES ('"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"')",connect);
            dodajemy.ExecuteNonQuery();
            connect.Close();
        }

        private void wyszukaj_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(conn);
            connect.Open();
            
            textBox1.Text = "";
                if (com1.SelectedIndex == 0)
                {
                    switch (com2.SelectedIndex)
                    {
                        case 0:
                        SqlCommand szukamy = new SqlCommand("SELECT * FROM [Table] WHERE [Imie] = '" + textBox5.Text+"'", connect);
                        SqlDataReader czytaj = szukamy.ExecuteReader();
                        while (czytaj.Read())
                        {
                            textBox1.AppendText(czytaj.GetString(1)+" "+czytaj.GetString(2)+" "+czytaj.GetString(3)+"\r\n");
                        }
                        break;
                        case 1:
                        SqlCommand szukamy2 = new SqlCommand("SELECT* FROM[Table] WHERE[Imie] LIKE '%" + textBox5.Text + "%'", connect);
                        SqlDataReader czytaj2 = szukamy2.ExecuteReader();
                        while (czytaj2.Read())
                        {
                            textBox1.AppendText(czytaj2.GetString(1) + " " + czytaj2.GetString(2) + " " + czytaj2.GetString(3) + "\r\n");
                        }
                        break;
                        case 2:
                        SqlCommand szukamy3 = new SqlCommand("SELECT* FROM[Table] WHERE[Imie] LIKE '" + textBox5.Text + "%'", connect);
                        SqlDataReader czytaj3 = szukamy3.ExecuteReader();
                        while (czytaj3.Read())
                        {
                            textBox1.AppendText(czytaj3.GetString(1) + " " + czytaj3.GetString(2) + " " + czytaj3.GetString(3) + "\r\n");
                        }
                        break;
                    }
                }
                if (com1.SelectedIndex == 1)
                {
                switch (com2.SelectedIndex)
                {
                    case 0:
                        SqlCommand szukamy = new SqlCommand("SELECT * FROM [Table] WHERE [Nazwisko] = '" + textBox5.Text + "'", connect);
                        SqlDataReader czytaj = szukamy.ExecuteReader();
                        while (czytaj.Read())
                        {
                            textBox1.AppendText(czytaj.GetString(1) + " " + czytaj.GetString(2) + " " + czytaj.GetString(3) + "\r\n");
                        }
                        break;
                    case 1:
                        SqlCommand szukamy2 = new SqlCommand("SELECT* FROM[Table] WHERE[Nazwisko] LIKE '%" + textBox5.Text + "%'", connect);
                        SqlDataReader czytaj2 = szukamy2.ExecuteReader();
                        while (czytaj2.Read())
                        {
                            textBox1.AppendText(czytaj2.GetString(1) + " " + czytaj2.GetString(2) + " " + czytaj2.GetString(3) + "\r\n");
                        }
                        break;
                    case 2:
                        SqlCommand szukamy3 = new SqlCommand("SELECT* FROM[Table] WHERE[Nazwisko] LIKE '" + textBox5.Text + "%'", connect);
                        SqlDataReader czytaj3 = szukamy3.ExecuteReader();
                        while (czytaj3.Read())
                        {
                            textBox1.AppendText(czytaj3.GetString(1) + " " + czytaj3.GetString(2) + " " + czytaj3.GetString(3) + "\r\n");
                        }
                        break;
                }
            }
                if (com1.SelectedIndex == 2)
                {
                switch (com2.SelectedIndex)
                {
                    case 0:
                        SqlCommand szukamy = new SqlCommand("SELECT * FROM [Table] WHERE [Klasa] = '" + textBox5.Text + "'", connect);
                        SqlDataReader czytaj = szukamy.ExecuteReader();
                        while (czytaj.Read())
                        {
                            textBox1.AppendText(czytaj.GetString(1) + " " + czytaj.GetString(2) + " " + czytaj.GetString(3) + "\r\n");
                        }
                        break;
                    case 1:
                        SqlCommand szukamy2 = new SqlCommand("SELECT* FROM[Table] WHERE[Klasa] LIKE '%" + textBox5.Text + "%'", connect);
                        SqlDataReader czytaj2 = szukamy2.ExecuteReader();
                        while (czytaj2.Read())
                        {
                            textBox1.AppendText(czytaj2.GetString(1) + " " + czytaj2.GetString(2) + " " + czytaj2.GetString(3) + "\r\n");
                        }
                        break;
                    case 2:
                        SqlCommand szukamy3 = new SqlCommand("SELECT* FROM[Table] WHERE[Klasa] LIKE '" + textBox5.Text + "%'", connect);
                        SqlDataReader czytaj3 = szukamy3.ExecuteReader();
                        while (czytaj3.Read())
                        {
                            textBox1.AppendText(czytaj3.GetString(1) + " " + czytaj3.GetString(2) + " " + czytaj3.GetString(3) + "\r\n");
                        }
                        break;
                }
            }
                connect.Close();
        }
    }
}
