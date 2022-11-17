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
namespace WindowsFormsApp1
{
   
    public partial class DanhMuc : Form
    {
        
        public int Money = 0;
        public static string GetName;
        public static int id_kh;
        public static string HinhThucThanhToan;
        public static string discount;
        public static Flowlayoutpanel_GioHang flowLayoutPanel_Porfolio = new Flowlayoutpanel_GioHang();
        public DanhMuc()
        {
            InitializeComponent();
            panel_label.Controls.Add(ManHinhChinh.Amount_Total_Price);
            panel_flow.Controls.Add(flowLayoutPanel_Porfolio);
            ManHinhChinh.Amount_Total_Price.SendToBack();
            ManHinhChinh.Amount_Total_Price.Visible = true;
            ManHinhChinh.Amount_Total_Price.Show();
            Random rd = new Random();
            id_kh = rd.Next(100000000);
            string id_kh_string = string.Format("{0:00000000}", id_kh);
            id_kh_string = "KH" + id_kh_string;
            txt_MaKH.Text =  id_kh_string;
            GetName = txt_HoTen.Text;
            
        }
        private bool Validate_IF()
        {
            bool ok = true;
            if (txt_HoTen.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txt_HoTen, "Yêu cầu nhập họ tên.");
            }
            if (txt_DiaChi.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txt_DiaChi, "Yêu cầu nhập Địa Chỉ.");
            }
            if (txt_SDT.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txt_SDT, "Yêu cầu nhập Số Điện Thoại.");
            }

            return ok;
        }
        public void DanhMuc_Load(object sender, EventArgs e)
        {
            foreach(Food_DATA_Item item in FoodItem.listfood)
            {
                ShoppingCart_item _food = new ShoppingCart_item();
               
                flowLayoutPanel_Porfolio.flowLayoutPanel_porfolio.Controls.Add(_food);
                _food.BackColor = Color.YellowGreen;
                _food.lbl_ID.Text = item.id;
                _food.lbl_FoodName.Text = item.name;
                _food.lbl_Prices.Text = String.Format("{0:#,##0}",item.price) + " VNĐ";

                _food.lbl_Amount.Text = item.num_order.ToString() ;
                _food.lbl_Type.Text = item.type.ToString();
                _food.lbl_total_prices.Text = String.Format("{0:#,##0}",(item.num_order * item.price)) + " VNĐ";
                _food.picturebox_food.ImageLocation = item.url;
                _food.picturebox_food.SizeMode=PictureBoxSizeMode.StretchImage;
                _food.picturebox_food.Show();
            }
        }
        private void btn_HuyDon_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có chắc muốn hủy đơn không?", "", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                flowLayoutPanel_Porfolio.Controls.Clear();
            }
        }
        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            if (rdb_TienMat.Checked)
                HinhThucThanhToan = "TienMat";
            if (rdb_TheTinDung.Checked)
                HinhThucThanhToan = "TheTinDung";
            if (rdb_momo.Checked)
                HinhThucThanhToan = "Momo";
            GetName = txt_HoTen.Text;
            errorProvider1.SetError(txt_HoTen, "");
            errorProvider1.SetError(txt_DiaChi, "");
            errorProvider1.SetError(txt_SDT, "");
            if (Validate_IF() == false)
            {
                MessageBox.Show("Bạn cần cung cấp đầy đủ thông tin.", "THIẾU THÔNG TIN ĐẶT HÀNG", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (FoodItem.listfood.Count == 0)
                {
                    MessageBox.Show("Bạn chưa có lựa chọn nào trong giỏ hàng.", "Nhắc ==!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {

                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-JMN4VSF\SQLEXPRESS;Initial Catalog=FOODS;Integrated Security=True");
                    SqlCommand cmd = null;
                    con.Open();
                    foreach (Food_DATA_Item item in FoodItem.listfood)
                    {
                        cmd = new SqlCommand("INSERT INTO FOOD_ORDERED(MAKH, F_ID,F_NAME" +
                            ",F_NUM_ORDER,F_PRICES,F_TYPE,F_GHICHU) VALUES ('"+txt_MaKH.Text+"','" + item.id + "',N'" + item.name + "','" + item.num_order + "','" + item.price + "','" + item.type + "',N'"+txt_GhiChu.Text+"')", con);
                        int i = cmd.ExecuteNonQuery();
                    }
                   
                    con.Close();
                    this.Hide();
                    Report_review RR = new Report_review();
                    RR.ShowDialog();

                }

            }
        }
        private void btn_back_Click_1(object sender, EventArgs e)
        {
            lbl_TongSoMon.Visible = true;
            lbl_TongTien.Visible = true;
            labell1.Visible = true;
            labell2.Visible = true;
            lbl_TongSoMon.Text = ManHinhChinh.Amount_Total_Price.lbl_TongSoMon.Text;
            lbl_TongTien.Text = ManHinhChinh.Amount_Total_Price.lbl_TongTien.Text;


            this.Close();
        }
        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            discount=txt_discount.Text;
        }
        private IEnumerable<Control> ChildControls(Control parent)
        {
            List<Control> controls = new List<Control>();
            controls.Add(parent);
            foreach (Control ctrl in parent.Controls)
            {
                controls.AddRange(ChildControls(ctrl));
            }
            return controls;
        }
        #region MouseMove_MouseLeave
        private void rdb_TienMat_MouseMove(object sender, MouseEventArgs e)
        {
            rdb_TienMat.BackColor = Color.BurlyWood;
        }
        private void rdb_TienMat_MouseLeave(object sender, EventArgs e)
        {
            rdb_TienMat.BackColor = Color.PeachPuff;
        }

        private void rdb_TheTinDung_MouseMove(object sender, MouseEventArgs e)
        {
            rdb_TheTinDung.BackColor=Color.BurlyWood;
        }

        private void rdb_TheTinDung_MouseLeave(object sender, EventArgs e)
        {
            rdb_TheTinDung.BackColor=Color.PeachPuff;
        }
        private void rdb_momo_MouseMove(object sender, MouseEventArgs e)
        {
            rdb_momo.BackColor = Color.BurlyWood;
        }
        private void rdb_momo_MouseLeave(object sender, EventArgs e)
        {
            rdb_momo.BackColor = Color.PeachPuff;
        }
        private void btn_ThanhToan_MouseMove(object sender, MouseEventArgs e)
        {
            btn_ThanhToan.BackColor = Color.Khaki;
        }
        private void btn_ThanhToan_MouseLeave(object sender, EventArgs e)
        {
            btn_ThanhToan.BackColor = Color.LemonChiffon;
        }
        private void btn_HuyDon_MouseMove(object sender, MouseEventArgs e)
        {
            btn_HuyDon.BackColor = Color.Khaki;
        }
        private void btn_HuyDon_MouseLeave(object sender, EventArgs e)
        {
            btn_HuyDon.BackColor=Color.LemonChiffon;
        }
        private void btn_back_MouseMove(object sender, MouseEventArgs e)
        {
            btn_back.BackColor = Color.Khaki;
        }
        private void btn_back_MouseLeave(object sender, EventArgs e)
        {
            btn_back.BackColor=Color.LemonChiffon;
        }
        #endregion
        private void txt_discount_Leave(object sender, EventArgs e)
        {
            if(txt_discount.Text == "")
            {
                txt_discount.Text = "Nhập mã giảm giá";
                txt_discount.ForeColor = Color.Silver;
            }
        }
        private void txt_discount_Enter(object sender, EventArgs e)
        {
            if(txt_discount.Text=="Nhập mã giảm giá")
            {
                txt_discount.Text = "";
                txt_discount.ForeColor = Color.Black;
            }
        }
    }
}
