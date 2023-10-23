using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace QuanLyDienThoai.Classes
{
    internal class CommonFunctions
    {
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        public void FillComBox(ComboBox cb,DataTable dt, string dis, string value)
        {
            cb.DataSource = dt;
            cb.DisplayMember = dis;
            cb.ValueMember = value;
        }
        public string SinhMa(string TenBang, string MaBatDau, string TruongMa)
        {
            string ma = "";
            DataTable dt = dtbase.DataReader("select TOP 1 * from " + TenBang + " order by " + TruongMa + " DESC");
            if (dt.Rows.Count != 0)
            {
                string id = dt.Rows[0][TruongMa].ToString();
                int number = Convert.ToInt32(id.Substring(MaBatDau.Length));
                if (number < 10)
                {
                    ma = MaBatDau + "0" + (number + 1).ToString();
                }
                else ma = MaBatDau + (number + 1).ToString();
            }
            else ma = MaBatDau + "01";
            return ma;
        }
    }
}
