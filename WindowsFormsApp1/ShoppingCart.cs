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
    public partial class ShoppingCart_item : UserControl
    {

        public ShoppingCart_item()
        {
            InitializeComponent(); 
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {

            int amount = int.Parse(this.lbl_Amount.Text);
            string money = lbl_Prices.Text.Replace(" VNĐ", "");
            money = money.Replace(",", "");
            int prices = int.Parse(money);
            amount++;
            int total_prices = amount * prices;
            FoodItem.TongSoMon += 1;
            FoodItem.TongSoTien += prices;
            foreach(Food_DATA_Item item in FoodItem.listfood)
            {
                if (lbl_ID.Text == item.id)
                {
                    item.num_order++;
                }
            }
            ManHinhChinh.Amount_Total_Price.lbl_TongTien.Text = String.Format("{0:#,##0}", FoodItem.TongSoTien) + " VNĐ";
            ManHinhChinh.Amount_Total_Price.lbl_TongSoMon.Text = String.Format("{0:#,##0}", FoodItem.TongSoMon);
            lbl_total_prices.Text = String.Format("{0:#,##0}",total_prices) + " VNĐ";
            lbl_Amount.Text = amount.ToString();
        }
        private void btn_Minus_Click(object sender, EventArgs e)
        {
            foreach (Food_DATA_Item item in FoodItem.listfood)
            {
                if (item.name == lbl_FoodName.Text)
                {
     
                    int price = item.price;
                    if (item.num_order == 1)
                    {
                        DialogResult d = MessageBox.Show("Bạn có chắc muốn xóa " + lbl_FoodName.Text +
                            " khỏi giỏ hàng không?", "", MessageBoxButtons.YesNo);
                        if (d == DialogResult.Yes)
                        {
                            FoodItem.TongSoMon -= item.num_order;
                            FoodItem.TongSoTien -= item.num_order*item.price;
                            ManHinhChinh.Amount_Total_Price.lbl_TongTien.Text = String.Format("{0:#,##0}", FoodItem.TongSoTien) + " VNĐ";
                            ManHinhChinh.Amount_Total_Price.lbl_TongSoMon.Text = String.Format("{0:#,##0}", FoodItem.TongSoMon);

                            DanhMuc.flowLayoutPanel_Porfolio.flowLayoutPanel_porfolio.Controls.Remove(this);
                        }
                    }
                    else
                    {
                        FoodItem.TongSoMon -= 1;
                        FoodItem.TongSoTien -= price;
                        ManHinhChinh.Amount_Total_Price.lbl_TongTien.Text = String.Format("{0:#,##0}", FoodItem.TongSoTien) + " VNĐ";
                        ManHinhChinh.Amount_Total_Price.lbl_TongSoMon.Text = String.Format("{0:#,##0}", FoodItem.TongSoMon);

                        item.num_order -= 1;

                        lbl_total_prices.Text = String.Format("{0:#,##0}", item.num_order * price) + " VNĐ";
                        lbl_Amount.Text = String.Format("{0:#,##0}", item.num_order);
                    }
                }
            }

        }
        private void btn_DeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có chắc muốn xóa " + lbl_FoodName.Text +
                              " khỏi giỏ hàng không?", "", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {


                foreach(Food_DATA_Item item in FoodItem.listfood)
                {
                    if (this.lbl_FoodName.Text == item.name)
                    {
                        FoodItem.TongSoTien -= item.total;
                        FoodItem.TongSoMon -= item.num_order;
                    }
                }

                ManHinhChinh.Amount_Total_Price.lbl_TongTien.Text = String.Format("{0:#,##0}", FoodItem.TongSoTien) + " VNĐ";
                ManHinhChinh.Amount_Total_Price.lbl_TongSoMon.Text = String.Format("{0:#,##0}", FoodItem.TongSoMon);
                DanhMuc.flowLayoutPanel_Porfolio.flowLayoutPanel_porfolio.Controls.Remove(this);
}
            
        }
        #region Mouse
        private void btn_Add_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Add.BackColor = Color.DarkSlateBlue;
        }

        private void btn_Add_MouseLeave(object sender, EventArgs e)
        {
            btn_Add.BackColor = Color.White;
        }

        private void btn_Minus_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Minus.BackColor = Color.DarkSlateBlue;
        }

        private void btn_Minus_MouseLeave(object sender, EventArgs e)
        {
            btn_Minus.BackColor=Color.White;
        }

        private void btn_DeleteItem_MouseMove(object sender, MouseEventArgs e)
        {
            btn_DeleteItem.BackColor = Color.OrangeRed;
        }

        private void btn_DeleteItem_MouseLeave(object sender, EventArgs e)
        {
            btn_DeleteItem.BackColor = Color.Khaki;
        } 
        #endregion
        
    }
}
