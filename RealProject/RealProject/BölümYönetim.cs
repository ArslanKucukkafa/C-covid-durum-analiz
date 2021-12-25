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
    public partial class BölümYönetim : Form
    {
        public BölümYönetim()
        {
            InitializeComponent();
        }

        private void RefreshGridView() {
            SqlConnecteds connecteds = new SqlConnecteds();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select *From Taslak2", connecteds.sqlConnectionOn());
            connecteds.sqlConnectionOff();
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void BölümYönetim_Load(object sender, EventArgs e)
        {
            RefreshGridView();
            }

        private void SmplEkle_Click(object sender, EventArgs e)
        {



            SqlConnecteds sqlConnecteds = new SqlConnecteds();
            if (sqlConnecteds.Control(txbxBlmNo.Text.TrimEnd(), txbxBölüm.Text.TrimEnd()) == 0)
            {
                SqlCommand command = new SqlCommand("Insert Into Taslak2(BölümNo,Bölüm,Faklülte) Values(@BölümNo,@Bölüm,@Fakülte)", sqlConnecteds.sqlConnectionOn());
                command.Parameters.AddWithValue("@Bölüm", txbxBölüm.Text);
                command.Parameters.AddWithValue("@BölümNo", txbxBlmNo.Text);
                command.Parameters.AddWithValue("@Fakülte", txbxFakülte.Text);
                sqlConnecteds.sqlConnectionOff();
                command.ExecuteNonQuery();
                RefreshGridView();
            }
            else { MessageBox.Show("Girilen Bölüm bilgileri zaten mevcutdur"); }

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txbxBölüm.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txbxFakülte.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txbxBlmNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void SmplSil_Click(object sender, EventArgs e)
        {
            SqlConnecteds sqlConnecteds = new SqlConnecteds();
            SqlCommand command = new SqlCommand("Delete From Taslak2 Where BölümNo=@BölümNo",sqlConnecteds.sqlConnectionOn());
            command.Parameters.AddWithValue("@BölümNo",txbxBlmNo.Text);
            command.ExecuteNonQuery();
            sqlConnecteds.sqlConnectionOff();
            RefreshGridView();
        }

        private void SmplGüncelle_Click(object sender, EventArgs e)
        {
            SqlConnecteds sqlConnecteds = new SqlConnecteds();
            SqlCommand command = new SqlCommand("Update Taslak2 SET Bölüm=@Bölüm,Faklülte=@Fakülte WHERE BölümNo=@BölümNo",sqlConnecteds.sqlConnectionOn());
            command.Parameters.AddWithValue("@BölümNo",txbxBlmNo.Text);
            command.Parameters.AddWithValue("@Bölüm", txbxBölüm.Text);
            command.Parameters.AddWithValue("@Fakülte",txbxFakülte.Text);
            command.ExecuteNonQuery();
            RefreshGridView();
        }
    }
}
