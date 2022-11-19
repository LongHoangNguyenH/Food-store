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
    public partial class ManHinhChinh : Form
    {
        string str_connect = @"Data Source=DESKTOP-JMN4VSF\SQLEXPRESS;Initial Catalog=FOOD_ORDER;Integrated Security=True";
        SqlConnection conn = null;
        public static int tongTien = 0;
        public static int TongSoMon = 0;
        private DataTable dataTable = new DataTable();
        public static Label_SoMon_TongSoTiens Amount_Total_Price = new Label_SoMon_TongSoTiens();
        public ManHinhChinh()
        {

            InitializeComponent();
            Panel_label.Controls.Add(Amount_Total_Price);
            Amount_Total_Price.Dock = System.Windows.Forms.DockStyle.Fill;
            Load_Food_Beverage_from_DataTable_to_UserControls();
        }
        private void PullData_to_DataTable()
        {
            string query = "SELECT * FROM FoodItem";
            conn = new SqlConnection(str_connect);
            SqlCommand cmd = new SqlCommand(query, conn);
            // create data adapter
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(dataTable);
            conn.Close();
            da.Dispose();
        }
        private void Load_Food_Beverage_from_DataTable_to_UserControls()
        {
            PullData_to_DataTable();
            foreach (DataRow r in dataTable.Rows)
            {
                FoodItem item = new FoodItem();
                flowLayoutPanel_Food.Controls.Add(item);
                item.pic_food.ImageLocation = r["URL_FOOD_PICTURE"].ToString();
                item.pic_food.SizeMode = PictureBoxSizeMode.StretchImage;
                item.pic_food.Show();
                item.lbl_FoodName.Text = r["FOOD_NAME"].ToString();
                item.lbl_FoodID.Text = r["FOOD_ID"].ToString();
                item.lbl_SoLuong.Text = r["FOOD_NUM_ORDER"].ToString();
                item.lbl_Prices.Text = String.Format("{0:#,##0}", r["FOOD_PRICES"]) + " VNĐ";
                item.lbl_Type.Text = r["FOOD_TYPE"].ToString();
                item.BackColor = Color.Crimson;
                item.ForeColor = Color.Gold;
            }
        }
        private void btn_shopping_cart_Click(object sender, EventArgs e)
        {
            lbl_TongSoMon.Text = Amount_Total_Price.lbl_TongSoMon.Text;
            lbl_TongTien.Text = Amount_Total_Price.lbl_TongTien.Text;
            lbl_TongSoMon.Visible = true;
            lbl_TongTien.Visible = true;
            labell1.Visible = true;
            labell2.Visible = true;


            if (FoodItem.listfood.Count == 0)
            {
                MessageBox.Show("Bạn chưa có lựa chọn nào trong giỏ hàng.", "Nhắc Nhở", MessageBoxButtons.OK);
            }
            else
            {
                this.Hide();
                DanhMuc danhMuc = new DanhMuc();
                danhMuc.ShowDialog(this);
                this.Show();
            }
        }
        private void btn_food_and_drinks_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_Food.Controls.Clear();
            foreach (DataRow r in dataTable.Rows)
            {
                FoodItem item = new FoodItem();
                flowLayoutPanel_Food.Controls.Add(item);
                item.pic_food.ImageLocation = r["URL_FOOD_PICTURE"].ToString();
                item.pic_food.SizeMode = PictureBoxSizeMode.StretchImage;
                item.pic_food.Show();
                item.lbl_FoodName.Text = r["FOOD_NAME"].ToString();
                item.lbl_FoodID.Text = r["FOOD_ID"].ToString();
                item.lbl_SoLuong.Text = r["FOOD_NUM_ORDER"].ToString();
                item.lbl_Prices.Text = r["FOOD_PRICES"].ToString();
                item.lbl_Type.Text = r["FOOD_TYPE"].ToString();
                item.BackColor = Color.Crimson;
                item.ForeColor = Color.Gold;
            }
        }
        private void btn_drink_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_Food.Controls.Clear();
            foreach (DataRow r in dataTable.Rows)
            {
                if (r["food_type"].ToString() == "BEVERAGE")
                {
                    FoodItem item = new FoodItem();
                    flowLayoutPanel_Food.Controls.Add(item);
                    item.pic_food.ImageLocation = r["url_food_picture"].ToString();
                    item.pic_food.SizeMode = PictureBoxSizeMode.StretchImage;
                    item.pic_food.Show();
                    item.lbl_FoodName.Text = r["food_name"].ToString();
                    item.lbl_FoodID.Text = r["food_id"].ToString();
                    item.lbl_SoLuong.Text = r["food_num_order"].ToString();
                    item.lbl_Prices.Text = r["food_prices"].ToString();
                    item.lbl_Type.Text = r["food_type"].ToString();
                    item.BackColor = Color.Crimson;
                    item.ForeColor = Color.Gold;
                    if (item.lbl_FoodID.Text == "032")
                        break;
                }

            }
        }
        private void btn_food_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_Food.Controls.Clear();
            foreach (DataRow r in dataTable.Rows)
            {
                if (r["FOOD_TYPE"].ToString() == "FOOD")
                {
                    FoodItem item = new FoodItem();
                    flowLayoutPanel_Food.Controls.Add(item);
                    item.pic_food.ImageLocation = r["URL_FOOD_PICTURE"].ToString();
                    item.pic_food.SizeMode = PictureBoxSizeMode.StretchImage;
                    item.pic_food.Show();
                    item.lbl_FoodName.Text = r["FOOD_NAME"].ToString();
                    item.lbl_FoodID.Text = r["FOOD_ID"].ToString();
                    item.lbl_SoLuong.Text = r["FOOD_NUM_ORDER"].ToString();
                    item.lbl_Prices.Text = r["FOOD_PRICES"].ToString();
                    item.lbl_Type.Text = r["FOOD_TYPE"].ToString();
                    item.BackColor = Color.Crimson;
                    item.ForeColor = Color.Gold;
                    if (item.lbl_FoodID.Text == "016")
                        break;
                }
            }
        }
        private void pictureBox_hotline_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/thuyentruong.hook.9");
        }
        private void txt_Search_Leave(object sender, EventArgs e)
        {
            if (txt_Search.Text == "")
            {
                txt_Search.Text = "Tìm kiếm món ăn";
                txt_Search.ForeColor = Color.Silver;
            }
        }
        private void txt_Search_Enter(object sender, EventArgs e)
        {
            if (txt_Search.Text == "Tìm kiếm món ăn")
            {
                txt_Search.Text = "";
                txt_Search.ForeColor = Color.Black;
            }
        }
        #region mouse
        private void btn_food_and_drinks_MouseMove(object sender, MouseEventArgs e)
        {
            btn_food_and_drinks.BackColor = Color.Khaki;
        }
        private void btn_food_and_drinks_MouseLeave(object sender, EventArgs e)
        {
            btn_food_and_drinks.BackColor = Color.White;
        }
        private void btn_drink_MouseMove(object sender, MouseEventArgs e)
        {
            btn_drink.BackColor = Color.Khaki;
        }
        private void btn_drink_MouseLeave(object sender, EventArgs e)
        {
            btn_drink.BackColor = Color.White;
        }
        private void btn_food_MouseMove(object sender, MouseEventArgs e)
        {
            btn_food.BackColor = Color.Khaki;
        }
        private void btn_food_MouseLeave(object sender, EventArgs e)
        {
            btn_food.BackColor = Color.White;
        }
        private void btn_shopping_cart_MouseMove(object sender, MouseEventArgs e)
        {
            btn_shopping_cart.BackColor = Color.Khaki;
        }
        private void btn_shopping_cart_MouseLeave(object sender, EventArgs e)
        {
            btn_shopping_cart.BackColor = Color.White;
        }
        #endregion
        private void txt_Search_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txt_Search.Text.Length == 0)
                {
                    flowLayoutPanel_Food.Controls.Clear();
                    foreach (DataRow r in dataTable.Rows)
                    {
                        FoodItem item = new FoodItem();
                        flowLayoutPanel_Food.Controls.Add(item);
                        item.pic_food.ImageLocation = r["URL_FOOD_PICTURE"].ToString();
                        item.pic_food.SizeMode = PictureBoxSizeMode.StretchImage;
                        item.pic_food.Show();
                        item.lbl_FoodName.Text = r["FOOD_NAME"].ToString();
                        item.lbl_FoodID.Text = r["FOOD_ID"].ToString();
                        item.lbl_SoLuong.Text = r["FOOD_NUM_ORDER"].ToString();
                        item.lbl_Prices.Text = r["FOOD_PRICES"].ToString();
                        item.lbl_Type.Text = r["FOOD_TYPE"].ToString();
                        item.BackColor = Color.Crimson;
                        item.ForeColor = Color.Gold;
                    }
                }
                else
                {
                    flowLayoutPanel_Food.Controls.Clear();
                    DataRow[] filteredRows = new DataRow[dataTable.Rows.Count];
                    filteredRows = dataTable.Select("FOOD_NAME LIKE '%" + txt_Search.Text + "%'");
                    foreach (DataRow r in filteredRows)
                    {
                            FoodItem item = new FoodItem();
                            flowLayoutPanel_Food.Controls.Add(item);
                            item.pic_food.ImageLocation = r["URL_FOOD_PICTURE"].ToString();
                            item.pic_food.SizeMode = PictureBoxSizeMode.StretchImage;
                            item.pic_food.Show();
                            item.lbl_FoodName.Text = r["FOOD_NAME"].ToString();
                            item.lbl_FoodID.Text = r["FOOD_ID"].ToString();
                            item.lbl_SoLuong.Text = r["FOOD_NUM_ORDER"].ToString();
                            item.lbl_Prices.Text = r["FOOD_PRICES"].ToString();
                            item.lbl_Type.Text = r["FOOD_TYPE"].ToString();
                            item.BackColor = Color.Crimson;
                            item.ForeColor = Color.Gold;
                    }
                    
                }
            }


        }
    }
}
