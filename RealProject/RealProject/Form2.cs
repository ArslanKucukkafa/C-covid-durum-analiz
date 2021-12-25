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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void ÖgrenciSet() { SqlConnecteds connecteds = new SqlConnecteds();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select *From Taslak1", connecteds.sqlConnectionOn());
            connecteds.sqlConnectionOff();
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;

        }
        public void gizle() {
            panel4.Hide();
            panel1.Hide();
            panel2.Hide();
            panel3.Hide();
            panel5.Hide();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
            pictureBox10.Hide();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            gizle();

            ÖgrenciSet();


        }
        //ÖgrenciNo Ayrıştırılıp deger döndermesi bu ControlÖgNo metodunda yapılur. 
        public string ControlÖgNo(string No)
        {
            SqlConnecteds connecteds = new SqlConnecteds();
            string BölümNo;
            BölümNo = tbxÖgrenciNo.Text.TrimEnd().Substring(3, 3);
            SqlDataAdapter adapter = new SqlDataAdapter("Select Bölüm,Faklülte From Taslak2 Where BölümNo=@BölümNo", connecteds.sqlConnectionOn());
            adapter.SelectCommand.Parameters.AddWithValue("@BölümNo", BölümNo);
            DataTable table = new DataTable();
            adapter.Fill(table);
            string BölümName, FakülteName;
            BölümName = table.Rows[0][0].ToString().TrimEnd();
            FakülteName = table.Rows[0][1].ToString().TrimEnd();
            return BölümName + "#" + FakülteName;


        }
        public int adSoyad() {
            SqlConnecteds connecteds = new SqlConnecteds();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select *From Taslak1 Where Ad=@Ad and Soyad=@Soyad", connecteds.sqlConnectionOn());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Ad",TbxAd.Text.TrimEnd().ToUpper());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Soyad", tbxSoyad.Text.TrimEnd().ToUpper());
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            return table.Rows.Count;
        }

        

        private void SmplEkle_Click(object sender, EventArgs e)
        {
            gizle();

            SqlConnecteds connecteds = new SqlConnecteds();
            SqlDataAdapter adapter = new SqlDataAdapter("Select Bölüm,Faklülte From Taslak2 Where BölümNo=@BölümNo", connecteds.sqlConnectionOn());
            adapter.SelectCommand.Parameters.AddWithValue("@BölümNo", tbxÖgrenciNo.Text.Substring(3, 3));
            DataTable table = new DataTable();
            adapter.Fill(table);
            connecteds.sqlConnectionOff();
            string BölümName1, FakülteName1;
            BölümName1 = table.Rows[0][0].ToString().TrimEnd();
            FakülteName1 = table.Rows[0][1].ToString().TrimEnd();

            if (connecteds.BölümControl(tbxÖgrenciNo.Text) == 0) { MessageBox.Show("Girilen ögrenci numrası ile ilgili Bölüm bulunamamıştır. Lütfen Ögrenci numranızı konrtol edin veya Bölüm eklenmesi için yöneticiyle iletişime geçin"); panel2.Show(); pictureBox8.Show(); }
            else if (adSoyad() != 0) { MessageBox.Show("Girilen Ögrenci ad ve Soyadı daha önce sisteme kaydedilmiştir."); panel4.Show(); pictureBox10.Show();panel3.Show(); pictureBox9.Show();  }
            else if (NoControl() != 0) { MessageBox.Show("Girilen ögrenci no ile daha önce ögrenci kaydı yapılmıştır" + Environment.NewLine + "Lütfen ögrenci numaranızı kontol edin"); panel2.Show(); pictureBox10.Show(); }
            else if (TbxAd.Text.TrimEnd() ==""|| tbxSoyad.Text.TrimEnd() ==""|| cbxAşı.Text ==""||cbxPcr.Text=="") { if (TbxAd.Text.TrimEnd() == "") { panel4.Show(); pictureBox10.Show(); } else { pictureBox6.Show(); }
                if (tbxSoyad.Text.TrimEnd() == "") { pictureBox9.Show(); panel3.Show(); } else { pictureBox5.Show();}
                if (cbxAşı.Text == "") { pictureBox7.Show(); panel5.Show(); } else { pictureBox3.Show(); }
                if (cbxPcr.Text == "") { panel1.Show(); pictureBox2.Show(); } else { pictureBox1.Show(); }
            }
            else
            {
                SqlCommand command = new SqlCommand("INSERT INTO Taslak1(ÖgrenciNo,Ad,Soyad,Pcr,Aşı,Tarih,Bölüm,Fakülte) VALUES(@ÖgrenciNo,@Ad,@Soyad,@Pcr,@Aşı,@Tarih,@Bölüm,@Fakülte)", connecteds.sqlConnectionOn());
                command.Parameters.AddWithValue("@Fakülte", FakülteName1.TrimEnd());
                command.Parameters.AddWithValue("@Bölüm", BölümName1.TrimEnd());
                command.Parameters.AddWithValue("@ÖgrenciNo", tbxÖgrenciNo.Text.TrimEnd());
                command.Parameters.AddWithValue("@Ad", TbxAd.Text.TrimEnd().ToUpper());
                command.Parameters.AddWithValue("Soyad", tbxSoyad.Text.TrimEnd().ToUpper());
                command.Parameters.AddWithValue("@Pcr", cbxPcr.Text);
                command.Parameters.AddWithValue("@Aşı", cbxAşı.Text);
                connecteds.sqlConnectionOff();
                if (cbxPcr.Text.TrimEnd() == "Negatif") { command.Parameters.AddWithValue("@Tarih", "9998/12/31"); }
                else { command.Parameters.AddWithValue("@Tarih", dateTimePicker1.Value); }
                command.ExecuteNonQuery();
                ÖgrenciSet();
            }
            
        }

        private void SmplSil_Click(object sender, EventArgs e)
        {
            SqlConnecteds connecteds = new SqlConnecteds();
            SqlCommand command = new SqlCommand("Delete From Taslak1 Where ÖgrenciNo=@ÖgrenciNo",connecteds.sqlConnectionOn());
            command.Parameters.AddWithValue("@ÖgrenciNo", tbxÖgrenciNo.Text);
            command.ExecuteNonQuery();  connecteds.sqlConnectionOff();
            ÖgrenciSet();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            TbxAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxSoyad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbxÖgrenciNo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[6].Value);
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString().TrimEnd() == "Negatif") { cbxPcr.Text = "Negatif"; }
            else { cbxPcr.Text = "Pozitif"; }
            if (dataGridView1.CurrentRow.Cells[5].Value.ToString().TrimEnd() == "Aşılı") { cbxAşı.Text = "Aşılı"; }
            else { cbxAşı.Text = "Aşısız"; }
        }

        public int NoControl() { SqlConnecteds connecteds = new SqlConnecteds();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Taslak1 Where ÖgrenciNo=@ÖgrenciNo",connecteds.sqlConnectionOn());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@ÖgrenciNo",tbxÖgrenciNo.Text.TrimEnd());
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            return table.Rows.Count;

        }

        private void SmplGüncelle_Click(object sender, EventArgs e)
        {
            SqlConnecteds connecteds = new SqlConnecteds();
            SqlCommand command = new SqlCommand("UPDATE Taslak1 SET Ad=@Ad,Soyad=@Soyad,Pcr=@Pcr,Aşı=@Aşı,Tarih=@Tarih WHERE ÖgrenciNo=@ÖgrenciNo",connecteds.sqlConnectionOn());
            command.Parameters.AddWithValue("@Ad",TbxAd.Text);
            command.Parameters.AddWithValue("@Soyad",tbxSoyad.Text);
            command.Parameters.AddWithValue("@Pcr", cbxPcr.Text);
            command.Parameters.AddWithValue("@Aşı", cbxAşı.Text);
            command.Parameters.AddWithValue("@ÖgrenciNo",tbxÖgrenciNo.Text);
            if (cbxPcr.Text == "Negatif") { command.Parameters.AddWithValue("@Tarih", "9998/12/31"); }
            else{  command.Parameters.AddWithValue("@Tarih", dateTimePicker1.Value);  }
            command.ExecuteNonQuery();
            connecteds.sqlConnectionOff();
            ÖgrenciSet();

        }

       
    }
}
