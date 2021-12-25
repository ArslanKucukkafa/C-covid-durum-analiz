using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace RealProject
{
    class SqlConnecteds
    {
        SqlConnection connection;
        

        public SqlConnection sqlConnectionOn()
        {
            connection = new SqlConnection("Data Source=ARSKK\\SQLEXPRESS;Initial Catalog=Test; Integrated Security=True;");
            if (connection.State == ConnectionState.Closed) { connection.Open(); }
            return connection;
        }
        public SqlConnection sqlConnectionOff()
        {
            connection = new SqlConnection("Data Source=ARSKK\\SQLEXPRESS;Initial Catalog=Test; Integrated Security=True;");
            if (connection.State == ConnectionState.Open) { connection.Close(); }
            return connection;
        }

        //Control metodu Smpl ekle metodunda çalışmakta.
        public int Control(string text1,string text2) {
            SqlDataAdapter command = new SqlDataAdapter("Select BölümNo,Bölüm From Taslak2",sqlConnectionOn());
            command.SelectCommand.Parameters.AddWithValue("@BölümNo",text1);
            command.SelectCommand.Parameters.AddWithValue("Bölüm", text2);
            DataTable table = new DataTable();
            command.Fill(table);
            int z;
            if (table.Rows.Count == 0) { z = 0; } else { z = 1; }
            return z;}

        public int BölümControl(string no) {
            SqlDataAdapter adapter = new SqlDataAdapter("Select *From Taslak2 Where BölümNo=@BölümNo",sqlConnectionOn());
            adapter.SelectCommand.Parameters.AddWithValue("@BölümNo",no.Substring(3,3));
            DataTable table = new DataTable();
            sqlConnectionOff();
            adapter.Fill(table);
            int z;
            if (table.Rows.Count == 0) { z = 0; } else { z = 1; }
            return z;       }


    }
}
