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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void comboList() {
            CmbxFakülte.Items.Clear();
            SqlConnecteds connecteds = new SqlConnecteds();
            SqlDataAdapter adapter = new SqlDataAdapter("Select Faklülte From Taslak2", connecteds.sqlConnectionOn());
            DataTable table = new DataTable();
            adapter.Fill(table);
            for (int x = 0; x < table.Rows.Count; x++) { CmbxFakülte.Items.Add(table.Rows[x][0].ToString()); }
            adapter.SelectCommand.ExecuteNonQuery();
            connecteds.sqlConnectionOff();

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            comboList();

        }

        private void CmbxFakülte_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbxBölüm.Items.Clear();
            SqlConnecteds connecteds = new SqlConnecteds();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Bölüm From Taslak2 Where Faklülte=@Faklülte", connecteds.sqlConnectionOn());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Faklülte", CmbxFakülte.Text);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            for (int f = 0; f < table.Rows.Count; f++) {
                CmbxBölüm.Items.Add(table.Rows[f][0].ToString()); }
            dataAdapter.SelectCommand.ExecuteNonQuery();
            connecteds.sqlConnectionOff();


        }

        private void CmbxBölüm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public int VakaSorgu(DateTime now1, DateTime now2) {

                

            SqlConnecteds connecteds = new SqlConnecteds();
            SqlDataAdapter adapter = new SqlDataAdapter("Select *From Taslak1 Where Pcr=@Pcr and Fakülte=@Fakülte and Bölüm=@Bölüm and Tarih Between @Begin and @Finish ", connecteds.sqlConnectionOn());
            adapter.SelectCommand.Parameters.AddWithValue("@Fakülte", CmbxFakülte.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@Bölüm", CmbxBölüm.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@Begin", now1);
            adapter.SelectCommand.Parameters.AddWithValue("@Finish", now2);
            adapter.SelectCommand.Parameters.AddWithValue("Pcr", "Pozitif");
            DataTable table = new DataTable();
            adapter.Fill(table);
            connecteds.sqlConnectionOff();

            return table.Rows.Count;
        }

        public int VakaGenel(DateTime now1, DateTime now2) {
            SqlConnecteds sqlConnecteds = new SqlConnecteds();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Taslak1 Where Pcr=@Pcr and Tarih Between @Begin and @Finish", sqlConnecteds.sqlConnectionOn());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Begin", now1);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Finish", now2);
            dataAdapter.SelectCommand.Parameters.AddWithValue("Pcr", "Pozitif");
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            sqlConnecteds.sqlConnectionOff();
            return table.Rows.Count;
        }
        public int ToplamKişi(){ SqlConnecteds connecteds = new SqlConnecteds();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select *From Taslak1 Where Fakülte=@Fakülte and Bölüm=@Bölüm",connecteds.sqlConnectionOn());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Fakülte", CmbxFakülte.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Bölüm", CmbxBölüm.Text);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            connecteds.sqlConnectionOff();
            return table.Rows.Count;
        }
        public int ToplamGenelKişi() {
            SqlConnecteds connecteds = new SqlConnecteds();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select *From Taslak1", connecteds.sqlConnectionOn());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Fakülte", CmbxFakülte.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Bölüm", CmbxBölüm.Text);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            connecteds.sqlConnectionOff();
            return table.Rows.Count;
        }


        private void SmplGöster_Click(object sender, EventArgs e)
        {
            PcrGrafik.Series[0].Points.Clear();

            SqlConnecteds connecteds = new SqlConnecteds();
            DateTime now1 = DateTime.Now;
            DateTime now2 = DateTime.Now.AddMonths(-1);
            int[] vakalar = new int[12];
            double ToplamVaka=0;
            string[] aylar = {"Ocak","Şubat","Mart","Nisan","Mayıs","Haziran","Temmuz","Agustos","Eylül","Ekim","Kasım","Aralık"};
            for (int z = 0; z < 12; z++) {
                if (CmbxFakülte.Text.TrimEnd() == "Üniversite Geneli") { vakalar[z] = VakaGenel(now2, now1); ToplamVaka = ToplamGenelKişi(); }
                else
                {
                    ToplamVaka = ToplamKişi();
                    vakalar[z] = VakaSorgu(now2, now1);
                }
                now1 = now2;
                now2 = DateTime.Now.AddMonths((z*-1)-2);
            }DateTime ay = DateTime.Now;
            string Ay = Convert.ToString(DateTime.Now).Substring(3, 2);
            int Ay1 = Convert.ToInt32(Ay)-1;
            int Ay2= Convert.ToInt32(Ay)-1;
            for (int f = 0; f < 12; f++)
            {
                PcrGrafik.Series["Aylar"].Points.AddXY(aylar[Ay1-f], vakalar[f]);
            }
            double toplamvaka=0;
            foreach (int s in vakalar) {
                toplamvaka = toplamvaka + s;
            }

            int oran = (int)(toplamvaka / ToplamVaka * 100);
            
            CrcleYogunluk.Minimum = 0;
            CrcleYogunluk.Value = oran;
            CrcleYogunluk.Maximum = 100;
            CrcleYogunluk.Text = oran+"%";
                    }
    }
}
