using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealProject
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        public void FakülteList() {           
            SqlConnecteds sqlConnecteds = new SqlConnecteds();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Faklülte From Taslak2",sqlConnecteds.sqlConnectionOn());
            DataTable dataTable = new DataTable();
            sqlConnecteds.sqlConnectionOff();
            dataAdapter.Fill(dataTable);
            for (int i = 0; i <dataTable.Rows.Count; i++)
            {cmbxFakülte.Items.Add(dataTable.Rows[i][0]);}
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Hide();
            FakülteList();


        }

        private void cmbxFakülte_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbxBölüm.Items.Clear();
            SqlConnecteds connecteds = new SqlConnecteds();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Bölüm From Taslak2 Where Faklülte=@Fakülte",connecteds.sqlConnectionOn());
            dataAdapter.SelectCommand.Parameters.AddWithValue("Fakülte",cmbxFakülte.Text);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                cmbxBölüm.Items.Add(table.Rows[i][0]);
            }



        }

        public void GenelControl() {
           
            DateTime now = DateTime.Now;
            DateTime Before = now.AddDays(-14);
            SqlConnecteds connecteds = new SqlConnecteds();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select *From Taslak1 Where Pcr=@Pcr and Aşı=@Aşı and Tarih Between @14DaysBefore and @Now", connecteds.sqlConnectionOn());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Now",now);
            dataAdapter.SelectCommand.Parameters.AddWithValue("14DaysBefore",Before);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Pcr", cmbxPcr.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Aşı", cmbxAşı.Text);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
            dataAdapter.SelectCommand.ExecuteNonQuery();
        }


        public void AşıAll() {
            SqlConnecteds connecteds = new SqlConnecteds();
            DataTable table = new DataTable();
            if (cmbxFakülte.Text.TrimEnd() == "Üniversite Geneli")
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Ad,Soyad,ÖgrenciNo,Bölüm,Fakülte From Taslak1 Where Pcr=@Pcr", connecteds.sqlConnectionOn());
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@Pcr", cmbxPcr.Text);
                sqlDataAdapter.Fill(table);
            }
            else {SqlDataAdapter dataAdapter=new SqlDataAdapter("Select Ad,Soyad,ÖgrenciNo,Aşı,Tarih From Taslak1 Where Pcr=@Pcr and Fakülte=@Fakülte and Bölüm=@Bölüm",connecteds.sqlConnectionOn());
                dataAdapter.SelectCommand.Parameters.AddWithValue("@Pcr",cmbxPcr.Text);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@Fakülte", cmbxFakülte.Text);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@Bölüm", cmbxBölüm.Text);
                dataAdapter.Fill(table);
            }
            dataGridView1.DataSource = table;
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (cmbxAşı.Text.TrimEnd() == "Hepsi") { AşıAll(); }
            else
            {
                if (cmbxFakülte.Text.TrimEnd() == "Üniversite Geneli") { GenelControl(); }
                else
                {
                    DateTime now = DateTime.Now;
                    DateTime before = now.AddDays(-14);
                    SqlConnecteds connecteds = new SqlConnecteds();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Ad,Soyad,ÖgrenciNo From Taslak1 Where Fakülte=@Fakülte and Bölüm=@Bölüm and Pcr=@Pcr and Aşı=@Aşı and Tarih Between @14DaysBefore and @Now", connecteds.sqlConnectionOn());
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@14DaysBefore", before);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@Now", now);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@Fakülte", cmbxFakülte.Text);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@Bölüm", cmbxBölüm.Text);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@Pcr", cmbxPcr.Text);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@Aşı", cmbxAşı.Text);
                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    dataGridView1.DataSource = table;
                    dataAdapter.SelectCommand.ExecuteNonQuery();
                    connecteds.sqlConnectionOff();
                    dataGridView1.Refresh();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox1.Show();
            
            if (textBox1.Text.TrimEnd() == "") { }
            else
            {
                SqlConnecteds connecteds = new SqlConnecteds();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Ad,Soyad,Fakülte,Bölüm,Aşı,Pcr From Taslak1 Where ÖgrenciNo=@ÖgrenciNo", connecteds.sqlConnectionOn());
                dataAdapter.SelectCommand.Parameters.AddWithValue("@ÖgrenciNo", textBox1.Text.TrimEnd());
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;
                dataAdapter.SelectCommand.ExecuteNonQuery();

            }
        }

        
    }
}
