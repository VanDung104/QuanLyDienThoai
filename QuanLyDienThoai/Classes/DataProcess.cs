using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyDienThoai.Classes
{
    internal class DataBaseProcess
    {
        string strCon = "Data Source=DESKTOP-RF89ARN\\SQLEXPRESS;Initial Catalog=QLDienThoai_Csharp;Integrated Security=True";
        SqlConnection sqlCon = null;
        void OpenConnect()
        {
            sqlCon = new SqlConnection(strCon);
            if (sqlCon.State != ConnectionState.Open)
            {
                sqlCon.Open();
            }
        }
        void CloseConnect()
        {
            if (sqlCon.State != ConnectionState.Closed)
            {
                sqlCon.Close();
                sqlCon.Dispose();
            }
        }
        public DataTable DataReader(string sqlSelect)
        {
            DataTable tblData = new DataTable();
            OpenConnect();
            SqlDataAdapter sqlData = new SqlDataAdapter(sqlSelect, sqlCon);
            sqlData.Fill(tblData);
            CloseConnect();
            sqlData.Dispose();
            return tblData;
        }

        public void DataChange(string sql)
        {
            OpenConnect();
            SqlCommand sqlCommand = new SqlCommand(sql);
            sqlCommand.Connection = sqlCon;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = sql;
            sqlCommand.ExecuteNonQuery();
            CloseConnect();
            sqlCommand.Dispose();
        }


    }
}
