using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyDienThoai.Forms
{
    public partial class ThongKeDoanhThu : Form
    {
        Classes.DataBaseProcess dtbase = new Classes.DataBaseProcess();
        Classes.CommonFunctions ft = new Classes.CommonFunctions();
        public ThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void ThongKeDoanhThu_Load(object sender, EventArgs e)
        {

        }
        private void DrawPieChart(DataTable dataTable)
        {
            // Xóa các dữ liệu và series cũ trước khi vẽ mới
            chrtThongKe.Series.Clear();
            chrtThongKe.Legends.Clear();

            // Tạo một series mới cho Pie Chart
            Series series = new Series("PieSeries");
            series.ChartType = SeriesChartType.Pie;

            // Thêm dữ liệu từ DataTable vào Pie Chart
            foreach (DataRow row in dataTable.Rows)
            {
                string label = row["TenHH"].ToString(); // Thay "LabelColumn" bằng tên cột chứa nhãn
                int value = Convert.ToInt32(row["So_luong_ban"]); // Thay "ValueColumn" bằng tên cột chứa giá trị

                series.Points.AddXY(label, value);
            }

            // Thêm series vào biểu đồ
            chrtThongKe.Series.Add(series);

            // Hiển thị hướng dẫn
            chrtThongKe.Legends.Add(new Legend("Legend"));
            chrtThongKe.Series[0].Legend = "Legend";
            chrtThongKe.Series[0].IsVisibleInLegend = true;
            //chrtThongKe.Legends[0].Docking = Docking.Top;
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DataTable dataTable = dtbase.DataReader("select top 5 * from Thong_ke('2023') order by So_luong_ban desc"); // Thay thế bằng phương thức lấy dữ liệu thực tế của bạn

            if(dataTable.Rows.Count > 0 )
            {
                DrawPieChart(dataTable);
                dgvThongKe.DataSource = dataTable;
            }
            // Vẽ Pie Chart từ DataTable
            
        }
    }
}
