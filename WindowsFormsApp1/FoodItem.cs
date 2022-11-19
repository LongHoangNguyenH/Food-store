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
    public partial class FoodItem : UserControl
    {
        
        public static List<Food_DATA_Item> listfood = new List<Food_DATA_Item>();
        
        public FoodItem( )
        {
            InitializeComponent();
            btn_minus.Enabled = false;     
        }
        public static int TongSoMon = 0;
        public static int TongSoTien = 0;
        private void btn_add_Click(object sender, EventArgs e)
        {
            Food_DATA_Item item = new Food_DATA_Item();
            item.url = this.pic_food.ImageLocation;
            item.type = this.lbl_Type.Text;
            item.id = this.lbl_FoodID.Text;
            item.name = this.lbl_FoodName.Text;
            string money = lbl_Prices.Text.Replace(" VNĐ", "");
            money = money.Replace(",", "");

            item.price = int.Parse(money);
            item.num_order = int.Parse(this.lbl_SoLuong.Text);
            if (listfood.Count == 0)
            {
                item.num_order++;
                this.lbl_SoLuong.Text=item.num_order.ToString();
                this.lbl_SoLuong.BackColor = Color.DarkMagenta;
                TongSoTien += item.num_order * item.price;
                TongSoMon += 1;
                listfood.Add(item);
            }
            else
            {
                int index = 0; 
                foreach (Food_DATA_Item fdi in listfood.ToList())
                {
                    if (item.id == fdi.id)
                    {
                        fdi.num_order += 1;
                        this.lbl_SoLuong.Text = fdi.num_order.ToString();
                        this.lbl_SoLuong.BackColor = Color.DarkMagenta;
                        TongSoMon += 1;
                        TongSoTien+= item.price;
                    }
                    else if (item.id != fdi.id && index == listfood.Count - 1)
                    {
                        item.num_order++;
                        this.lbl_SoLuong.Text = item.num_order.ToString();
                        this.lbl_SoLuong.BackColor = Color.DarkMagenta;
                        TongSoMon += 1;
                        TongSoTien += item.num_order * item.price;
                        listfood.Add(item);
                    }
                    index++;
                }
            }
            ManHinhChinh.Amount_Total_Price.lbl_TongSoMon.Text= String.Format("{0:#,##0}", TongSoMon) ;
            ManHinhChinh.Amount_Total_Price.lbl_TongTien.Text = String.Format("{0:#,##0}", TongSoTien) + " VNĐ";

        }
        private void btn_minus_Click(object sender, EventArgs e)
        {
            int index = 0;
            foreach(Food_DATA_Item item in listfood)
            {
                if (this.lbl_FoodID.Text == item.id)
                {
                    TongSoMon -= 1;
                    TongSoTien -=  item.price;
                    item.num_order -= 1;
                    this.lbl_SoLuong.Text=item.num_order.ToString();
                    if (item.num_order == 0)
                    {
                        this.lbl_SoLuong.BackColor = Color.Gray;
                        listfood.RemoveAt(index);

                        break;
                    }
                }
                index++;
            }
            ManHinhChinh.Amount_Total_Price.lbl_TongTien.Text = String.Format("{0:#,##0}", TongSoTien) + " VNĐ" ;
            ManHinhChinh.Amount_Total_Price.lbl_TongSoMon.Text = String.Format("{0:#,##0}", TongSoMon)  ;

        }
        private void lbl_SoLuong_TextChanged(object sender, EventArgs e)
        {
            if (lbl_SoLuong.Text == "0")
                btn_minus.Enabled = false;
            else
                btn_minus.Enabled=true;
        }

        private void lbl_Prices_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_MouseMove(object sender, MouseEventArgs e)
        {
            btn_add.BackColor = Color.DarkSlateBlue;
        }

        private void btn_add_MouseLeave(object sender, EventArgs e)
        {
            btn_add.BackColor = Color.White;
        }

        private void btn_minus_MouseMove(object sender, MouseEventArgs e)
        {
            btn_minus.BackColor = Color.DarkSlateBlue;
        }

        private void btn_minus_MouseLeave(object sender, EventArgs e)
        {
            btn_minus.BackColor = Color.White;
        }
    }
}
