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
    public partial class YenilemePanel : Form
    {
        public YenilemePanel()
        {
            InitializeComponent();
        }

        private void YenilemePanel_Load(object sender, EventArgs e)
        {
            pictureBox9.Hide();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            pictureBox9.Hide();
            GirişPanel girişPanel = new GirişPanel();
            SqlConnecteds connecteds = new SqlConnecteds();
            if (textBox1.Text.TrimEnd() == textBox3.Text.TrimEnd())
            {
                SqlDataAdapter adapter = new SqlDataAdapter("Update Taslak3 Set Password=@Password Where Mail=@Mail", connecteds.sqlConnectionOn());
                adapter.SelectCommand.Parameters.AddWithValue("@Mail", girişPanel.MailBack());
                adapter.SelectCommand.Parameters.AddWithValue("@Password", textBox1.Text.TrimEnd());
                connecteds.sqlConnectionOff();
                MessageBox.Show("Şifreniz Başarı ile degiştirildi");

            }
            else { MessageBox.Show("Girilen Şifreler birbiri ile uyuşmamaktadır !! "); pictureBox9.Show(); }

        }
    }
}
