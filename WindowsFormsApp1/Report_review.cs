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
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApp1
{
    public partial class Report_review : Form
    {

        public Report_review()
        {
            InitializeComponent();
            string id_kh_string = string.Format("{0:00000000}", DanhMuc.id_kh);
            id_kh_string = "KH" + id_kh_string;

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JMN4VSF\SQLEXPRESS;Initial Catalog=FOOD_ORDER;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT *FROM FOOD_ORDERED WHERE MAKH = ('"+id_kh_string+"')" , conn);
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            d.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet1",dt);
            reportViewer1.LocalReport.ReportPath = @"P:\CS511\BTH\Drugstore\WindowsFormsApp1\Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();

        }
        public static int chiphi;
        public static int discount;
        public static int tongthanhtien;
        private void Report_review_Load(object sender, EventArgs e)
        {

            chiphi = 0;
            discount = 0;
            if (DanhMuc.discount != null)
            {
                discount = int.Parse(DanhMuc.discount.Remove(2));
            }
            foreach (Food_DATA_Item item in FoodItem.listfood)
            {
                chiphi += item.total;
            }
            tongthanhtien = chiphi - chiphi * discount/100;
            string discount_convert = discount.ToString();
            string chiphi_convert = chiphi.ToString();
            string tongthanhtien_convert = tongthanhtien.ToString();


            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[] {

                new Microsoft.Reporting.WinForms.ReportParameter("Discount", discount_convert+"%"),
                new Microsoft.Reporting.WinForms.ReportParameter("TongThanhTien", String.Format("{0:#,##0}",int.Parse(tongthanhtien_convert))+" VNĐ"),
                new Microsoft.Reporting.WinForms.ReportParameter("ChiPhi", String.Format("{0:#,##0}",int.Parse(chiphi_convert))+" VNĐ"),
            };
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
        }
        private void btn_Oke_Click(object sender, EventArgs e)
        {
            if (DanhMuc.HinhThucThanhToan == "TienMat")
            {
                this.Hide();
                Review_and_Comment RC = new Review_and_Comment();
                RC.ShowDialog();
            }
            else if (DanhMuc.HinhThucThanhToan == "Momo")
            {
                this.Hide();
                ThanhToanCreditCard_Momo momo = new ThanhToanCreditCard_Momo();
                momo.ShowDialog();
            }
            else
            {
                this.Hide();
                ThanhToanVoiTheATM ATM = new ThanhToanVoiTheATM();
                 ATM.ShowDialog();

            }
        }
        private void btn_Oke_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Oke.BackColor = Color.Khaki;
        }
        private void btn_Oke_MouseLeave(object sender, EventArgs e)
        {
            btn_Oke.BackColor = Color.White;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
