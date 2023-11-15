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
		string strCon = "Data Source=DESKTOP-KASIRH6;Initial Catalog=QLDienThoai_Csharp;Integrated Security=True";
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
		public double Thongke(string ma)
		{
			double tien = 0;

			OpenConnect();

			using (SqlCommand sqlCommand = new SqlCommand("TTKH", sqlCon))
			{
				sqlCommand.CommandType = CommandType.StoredProcedure;

				// Add parameters to the stored procedure
				sqlCommand.Parameters.AddWithValue("@maKH", ma);

				// Define and add the output parameter
				SqlParameter tienParameter = new SqlParameter("@Tien", SqlDbType.Float);
				tienParameter.Direction = ParameterDirection.Output;
				sqlCommand.Parameters.Add(tienParameter);

				// Execute the stored procedure
				sqlCommand.ExecuteNonQuery();

				// Retrieve the output parameter value
				tien = Convert.ToDouble(tienParameter.Value);
			}

			CloseConnect();
			return tien;
		}
	}
}
