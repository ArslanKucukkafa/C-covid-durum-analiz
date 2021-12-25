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
    public partial class GirişPanel : Form
    {
        public GirişPanel()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            KullanıcıGiriş giriş = new KullanıcıGiriş();
            giriş.Show();
        }
        
        string bildiri = "Fırat Güvenlik kodu";
        Random rast = new Random();
        public string MailBack() { return Onaykodu; }


        string Onaykodu;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            pictureBox10.Hide();
          

            Onaykodu = rast.Next(0, 100).ToString().TrimEnd();
            SqlConnecteds connecteds = new SqlConnecteds();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Taslak3 Where Mail=@Mail",connecteds.sqlConnectionOn());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Mail", textBox3.Text.TrimEnd());
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
           
            
            
            if (table.Rows.Count == 1) {
                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp.gmail.com";
                sc.EnableSsl = true;
                sc.Credentials = new System.Net.NetworkCredential("TekfurMansur@gmail.com", "krfnc1234");
                MailMessage message = new MailMessage();
                message.From = new MailAddress("TekfurMansur@gmail.com");
                message.To.Add(textBox3.Text);
                message.Subject = bildiri;
                message.IsBodyHtml = true;

                message.Body = "Güvenlik kodunu " + Onaykodu + " igili alana giriniz lütfen ";
                sc.Send(message); MessageBox.Show("Onay Kodu Gönderildi"); }
            else { MessageBox.Show("Girilen mail.adresi sisteme kayıtlı degildir ! Lütfen mail adresinizi kotrol edin veya kayıt olun."); pictureBox10.Show(); }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            if (Onaykodu == textBox1.Text.TrimEnd()) { this.Hide();
                YenilemePanel panel = new YenilemePanel();
                panel.Show();
            }
            else { MessageBox.Show("Geçersiz OnayKodu"); pictureBox1.Show(); }
            

        }

        private void GirişPanel_Load(object sender, EventArgs e)
        {
            pictureBox10.Hide();
            pictureBox1.Hide();
        }
    }
}
