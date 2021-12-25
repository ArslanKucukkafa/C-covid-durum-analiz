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
namespace RealProject
{
    public partial class KullanıcıGiriş : Form
    {
        public KullanıcıGiriş()
        {
            InitializeComponent();
        }
       
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            GirişPanel giriş = new GirişPanel();
            giriş.Show();
            this.Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            KayıtPanel panel = new KayıtPanel();
            panel.Show();
            this.Hide();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlConnecteds connecteds = new SqlConnecteds();
            SqlDataAdapter adapter = new SqlDataAdapter("Select *From Taslak3 Where Ad=@Ad and Soyad=@Soyad and Password=@Password", connecteds.sqlConnectionOn());
            adapter.SelectCommand.Parameters.AddWithValue("@Ad", textBox3.Text.ToUpper().TrimEnd());
            adapter.SelectCommand.Parameters.AddWithValue("@Soyad", textBox5.Text.ToUpper().TrimEnd());
            adapter.SelectCommand.Parameters.AddWithValue("@Password", textBox4.Text.ToUpper().TrimEnd());
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 0) { MessageBox.Show("Geçersiz kullanıcı adı veya şifre girişi"); } else { this.Hide();
                Form1 form1 = new Form1(); form1.Show();
            }          

        }



        private void KullanıcıGiriş_Load(object sender, EventArgs e)
        {
            textBox4.PasswordChar = '*';
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) { textBox4.PasswordChar = '\0'; } else { textBox4.PasswordChar = '*'; }
        }
    }
}
