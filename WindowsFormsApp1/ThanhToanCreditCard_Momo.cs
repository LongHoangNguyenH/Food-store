using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ThanhToanCreditCard_Momo : Form
    {
        public ThanhToanCreditCard_Momo()
        {
            InitializeComponent();
            string donhang = "";
            foreach(Food_DATA_Item item in FoodItem.listfood)
            {
                donhang += "\n\nTên món: " + item.name + "\nSố lượng: " + item.num_order + "\nĐơn giá: " + item.price + "\nTổng: " + item.total+"\n";
            }
            lbl_TongSoTien.Text=String.Format("{0:#,##0}", Report_review.tongthanhtien)+" VNĐ";
            string NoiDung = "Bạn đã thanh toán đơn hàng Gồm:\n" +
                donhang+
                "\nTổng số tiền là "+lbl_TongSoTien.Text +" VNĐ";
            QRCodeGenerator QR = new QRCodeGenerator();
            QRCodeData data = QR.CreateQrCode(NoiDung, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pic_QR_code.Image = code.GetGraphic(3);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_DanhGia_Click(object sender, EventArgs e)
        {
            this.Hide();
            Review_and_Comment RAC = new Review_and_Comment();
            RAC.ShowDialog();
        } 
        private void btn_DanhGia_MouseMove(object sender, MouseEventArgs e)
        {
            btn_DanhGia.BackColor = Color.Khaki;
        }
        private void btn_DanhGia_MouseLeave(object sender, EventArgs e)
        {
            btn_DanhGia.BackColor = Color.White;
        }
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Khaki;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor=Color.White;
        }
    }
}
