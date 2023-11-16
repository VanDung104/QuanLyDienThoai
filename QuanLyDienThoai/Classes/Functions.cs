using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDienThoai.Classes
{
    internal class Functions
    {
        DataBaseProcess dataBase = new DataBaseProcess();
        public string SinhMaTuDong(string TenBang, string MaBatDau, string TruongMa)
        {
            int id = 0;
            bool dung = false;
            string ma = "";
            DataTable dm = new DataTable();
            while (dung == false)
            {
                dm = dataBase.DataReader("Select * from " + TenBang + " where " + TruongMa + "='" + MaBatDau +
                    id.ToString() + "'");
                if (dm.Rows.Count == 0)
                {
                    dung = true;
                }
                else
                {
                    id++;
                    dung = false;
                }
            }
            ma = MaBatDau + id.ToString();
            return ma;
        }
    }
}
