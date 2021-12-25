using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;

namespace RealProject
{
    public partial class KayıtPanel : Form
    {
        public KayıtPanel()
        {
            InitializeComponent();
        }

        private static bool IsValidEmail(string EmailToCheck)
        {
            try
            {
                MailAddress mail = new MailAddress(EmailToCheck);
                return true;
            }
            catch (Exception e) { return false; }
        }
        private void KayıtPanel_Load(object sender, EventArgs e)
        {
            textBox4.PasswordChar = '*'; textBox5.PasswordChar = '*';
            PictureSee();

        }

        private void PictureSee() {
            pictureBox1.Hide();          
            pictureBox3.Hide();
            pictureBox5.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();        }

        public Boolean CombinationControl()
        {
            bool z = false;
            SqlConnecteds connecteds = new SqlConnecteds();
            SqlDataAdapter adapter = new SqlDataAdapter("Select Ad,Soyad,Password,Mail From Taslak3", connecteds.sqlConnectionOn());
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count != 0) { z = true; }
            connecteds.sqlConnectionOff();
            return z;
        }  

        public Boolean MailControl() { SqlConnecteds connecteds = new SqlConnecteds();
            bool a = false;
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Taslak3  Where Mail=@Mail",connecteds.sqlConnectionOn());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Mail", textBox2.Text.TrimEnd());
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            connecteds.sqlConnectionOff();
            if (table.Rows.Count!=0) { a = true; }
            return a;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bool a = true;
            if (textBox1.Text.TrimEnd().Length < 3) { a = false;  pictureBox8.Show(); label7.Show(); }
            if (textBox3.Text.TrimEnd().Length < 3) { a = false; pictureBox5.Show(); label6.Show(); }
            if (textBox4.Text.TrimEnd().Length < 8) { a = false; pictureBox1.Show(); label8.Show(); }
            if (a == false) { MessageBox.Show("Yetersiz karakter girişi"); }
            else
            {
                if (CombinationControl() == true) { MessageBox.Show("Aynı ad soyad ve password kombinasyonunna sahip başka birisi vardır. Lütfen başka bir kombinasyon deneyiniz"); }
                else
                {
                    if (MailControl() == true) { MessageBox.Show("Girilen mail adresi başka bir kullancı tarafından kullanılmaktadır."); pictureBox9.Show(); }
                    else
                    {
                        if (textBox4.Text.TrimEnd() == textBox5.Text.TrimEnd())
                        {
                            if (IsValidEmail(textBox2.Text.TrimEnd()))
                            {

                                SqlConnecteds connecteds = new SqlConnecteds();
                                SqlCommand command = new SqlCommand("Insert Into Taslak3(Ad,Soyad,Mail,Password)Values(@Ad,@Soyad,@Mail,@Password)", connecteds.sqlConnectionOn());
                                command.Parameters.AddWithValue("@Ad", textBox3.Text.TrimEnd().ToUpper());
                                command.Parameters.AddWithValue("@SoyAd", textBox1.Text.TrimEnd().ToUpper());
                                command.Parameters.AddWithValue("@Mail", textBox2.Text.TrimEnd());
                                command.Parameters.AddWithValue("@Password", textBox4.Text.TrimEnd());
                                command.ExecuteNonQuery();
                                connecteds.sqlConnectionOff();
                            }
                            else { MessageBox.Show("Geçersiz mail adresi"); pictureBox9.Show(); }
                        }
                        else { label9.Show(); pictureBox1.Show();pictureBox3.Show();}
                    }
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) { textBox4.PasswordChar = '\0'; textBox5.PasswordChar = '\0'; }
            else { textBox4.PasswordChar = '*'; textBox5.PasswordChar = '*'; }
        }
    }
}
