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
    public partial class ThanhToanVoiTheATM : Form
    {
        public ThanhToanVoiTheATM()
        {
            InitializeComponent();

            string donhang = "";
            foreach (Food_DATA_Item item in FoodItem.listfood)
            {
                donhang += "\n\nTên món: " + item.name + "\nSố lượng: " + item.num_order + "\nĐơn giá: " + item.price + "\nTổng: " + item.total + "\n";
            }
            lbl_TongSoTien.Text = String.Format("{0:#,##0}", Report_review.tongthanhtien) + " VNĐ";
            string NoiDung = "Bạn đã thanh toán đơn hàng Gồm:\n" +
                donhang +
                "\nTổng số tiền là " + lbl_TongSoTien.Text + " VNĐ";


            lbl_TongSoTien.Text = String.Format("{0:#,##0}", Report_review.tongthanhtien) + " VNĐ";

            QRCodeGenerator QR = new QRCodeGenerator();
            QRCodeData data = QR.CreateQrCode(NoiDung, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pic_QR_code.Image = code.GetGraphic(3);
        }



        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBank.SelectedIndex != -1)
            {
                pic_QR_code.Visible = true;
            }
            
            
                if (comboBoxBank.Text == "VietcomBank")
                {
                    Vietcombank.Visible = true;
                    Vietcombank.Show();
                    Sacombank.Visible = false;
                    MBBank.Visible = false;
                    ACB.Visible = false;
                    TPbank.Visible = false;
                    VPbank.Visible = false;
                    BIDV.Visible = false;
                    Agribank.Visible = false;
                }
                if (comboBoxBank.Text == "SacomBank")
                {
                    Vietcombank.Visible = false;
                    Sacombank.Visible = true;
                    Sacombank.Show();
                    MBBank.Visible = false;
                    ACB.Visible = false;
                    TPbank.Visible = false;
                    VPbank.Visible = false;
                    BIDV.Visible = false;
                    Agribank.Visible = false;
                }
                if (comboBoxBank.Text == "MBBank")
                {
                    Vietcombank.Visible = false;
                    Sacombank.Visible = false;
                    MBBank.Visible = true;
                    MBBank.Show();
                    ACB.Visible = false;
                    TPbank.Visible = false;
                    VPbank.Visible = false;
                    BIDV.Visible = false;
                    Agribank.Visible = false;
                }
                if (comboBoxBank.Text == "ACB")
                {
                    Vietcombank.Visible = false;
                    Sacombank.Visible = false;
                    MBBank.Visible = false;
                    ACB.Visible = true;
                    ACB.Show();
                    TPbank.Visible = false;
                    VPbank.Visible = false;
                    BIDV.Visible = false;
                    Agribank.Visible = false;
                }
                if (comboBoxBank.Text == "TPBank")
                {
                    Vietcombank.Visible = false;
                    Sacombank.Visible = false;
                    MBBank.Visible = false;
                    ACB.Visible = false;
                    TPbank.Visible = true;
                    TPbank.Show();
                    VPbank.Visible = false;
                    BIDV.Visible = false;
                    Agribank.Visible = false;
                }
                if (comboBoxBank.Text == "VPBank")
                {
                    Vietcombank.Visible = false;
                    Sacombank.Visible = false;
                    MBBank.Visible = false;
                    ACB.Visible = false;
                    TPbank.Visible = false;
                    VPbank.Visible = true;
                    VPbank.Show();
                    BIDV.Visible = false;
                    Agribank.Visible = false;
                }
                if (comboBoxBank.Text == "BIDV")
                {
                    Vietcombank.Visible = false;
                    Sacombank.Visible = false;
                    MBBank.Visible = false;
                    ACB.Visible = false;
                    TPbank.Visible = false;
                    VPbank.Visible = false;
                    BIDV.Visible = true;
                    BIDV.Show();
                    Agribank.Visible = false;
                }
                if (comboBoxBank.Text == "AgriBank")
                {
                    Vietcombank.Visible = false;
                    Sacombank.Visible = false;
                    MBBank.Visible = false;
                    ACB.Visible = false;
                    TPbank.Visible = false;
                    VPbank.Visible = false;
                    BIDV.Visible = false;
                    Agribank.Visible = true;
                    Agribank.Show();
                }
            
        }

        private void btn_DanhGia_Click(object sender, EventArgs e)
        {
            this.Hide();
            Review_and_Comment rac = new Review_and_Comment();
            rac.ShowDialog();
        }

        private void btn_DanhGia_MouseMove(object sender, MouseEventArgs e)
        {
            btn_DanhGia.BackColor = Color.Khaki;
        }

        private void btn_DanhGia_MouseLeave(object sender, EventArgs e)
        {
            btn_DanhGia.BackColor = Color.White;
        }

        private void btn_Back_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Back.BackColor = Color.Khaki;
        }

        private void btn_Back_MouseLeave(object sender, EventArgs e)
        {
            btn_Back.BackColor=Color.White;
        }
    }
}
