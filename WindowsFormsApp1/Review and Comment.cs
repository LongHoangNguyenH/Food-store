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
    public partial class Review_and_Comment : Form
    {
        public Review_and_Comment()
        {
            InitializeComponent();
            lbl_TenUser.Text = DanhMuc.GetName;
            pic_star1.ImageLocation = path_star;
            pic_star2.ImageLocation = path_star;
            pic_star3.ImageLocation = path_star;
            pic_star4.ImageLocation = path_star;
            pic_star5.ImageLocation = path_star;

        }
        string path_shine_star = "P:\\CS511\\BTH\\Drugstore\\WindowsFormsApp1\\Resources\\shine_star.png";
        string path_star = "P:\\CS511\\BTH\\Drugstore\\WindowsFormsApp1\\Resources\\star.png";
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                USERComment c = new USERComment();
                flowLayoutPanel2.Controls.Add(c);
                c.lbl_Ten.Text = DanhMuc.GetName;
                c.lbl_NoiDung.Text = richTextBox1.Text;
                c.lbl_NoiDung.BackColor = Color.White;
                richTextBox1.Text = "";
            }
        }
        private void btn_ManHinhChinh_Click(object sender, EventArgs e)
        {
            FoodItem.listfood.Clear();
            this.Close();
            
        }
        private void pic_star1_Click_1(object sender, EventArgs e)
        {
            if (pic_star1.ImageLocation == path_star)
            {
                pic_star1.ImageLocation = path_shine_star;
                pic_star1.Show();
                pic_star2.ImageLocation = path_star;
                pic_star3.ImageLocation = path_star;
                pic_star4.ImageLocation = path_star;
                pic_star5.ImageLocation = path_star;
                pic_star2.Show();
                pic_star3.Show();
                pic_star4.Show();
                pic_star5.Show();
            }
            else
            {
                pic_star2.ImageLocation = path_star;
                pic_star3.ImageLocation = path_star;
                pic_star4.ImageLocation = path_star;
                pic_star5.ImageLocation = path_star;
                pic_star2.Show();
                pic_star3.Show();
                pic_star4.Show();
                pic_star5.Show();
                pic_star1.Show();
            }
        }
        private void pic_star2_Click_1(object sender, EventArgs e)
        {
            if (pic_star2.ImageLocation == path_star)
            {
                pic_star1.ImageLocation = path_shine_star;
                pic_star2.ImageLocation = path_shine_star;
                pic_star1.Show();
                pic_star2.Show();
            }
            else
            {
                pic_star3.ImageLocation = path_star;
                pic_star4.ImageLocation = path_star;
                pic_star5.ImageLocation = path_star;
                pic_star1.Show();
                pic_star2.Show();
                pic_star1.Show();
                pic_star2.Show();
                pic_star3.Show();
            }
        }
        private void pic_star3_Click_1(object sender, EventArgs e)
        {
            if (pic_star3.ImageLocation == path_star)
            {
                pic_star1.ImageLocation = path_shine_star;
                pic_star2.ImageLocation = path_shine_star;
                pic_star3.ImageLocation = path_shine_star;
                pic_star1.Show();
                pic_star2.Show();
                pic_star3.Show();

            }
            else
            {
                pic_star4.ImageLocation = path_star;
                pic_star5.ImageLocation = path_star;
                pic_star1.Show();
                pic_star2.Show();
                pic_star3.Show();
                pic_star4.Show();
                pic_star5.Show();
            }
        }
        private void pic_star4_Click_1(object sender, EventArgs e)
        {
            if (pic_star4.ImageLocation == path_star)
            {
                pic_star1.ImageLocation = path_shine_star;
                pic_star2.ImageLocation = path_shine_star;
                pic_star3.ImageLocation = path_shine_star;
                pic_star4.ImageLocation = path_shine_star;
                pic_star1.Show();
                pic_star2.Show();
                pic_star3.Show();
                pic_star4.Show();
            }
            else
            {
                pic_star5.ImageLocation = path_star;
                pic_star1.Show();
                pic_star2.Show();
                pic_star3.Show();
                pic_star4.Show();
                pic_star5.Show();
            }
        }
        private void pic_star5_Click_1(object sender, EventArgs e)
        {
            if (pic_star5.ImageLocation == path_star)
            {

                pic_star1.ImageLocation = path_shine_star;
                pic_star2.ImageLocation = path_shine_star;
                pic_star3.ImageLocation = path_shine_star;
                pic_star4.ImageLocation = path_shine_star;
                pic_star5.ImageLocation = path_shine_star;
                pic_star1.Show();
                pic_star2.Show();
                pic_star3.Show();
                pic_star4.Show();
                pic_star5.Show();
            }
        }
        private void btn_Thoat_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Thoat.BackColor = Color.Khaki;
        }
        private void btn_Thoat_MouseLeave(object sender, EventArgs e)
        {
            btn_Thoat.BackColor = Color.White;
        }
        private void btn_ManHinhChinh_MouseMove(object sender, MouseEventArgs e)
        {
            btn_ManHinhChinh.BackColor = Color.Khaki;
        }
        private void btn_ManHinhChinh_MouseLeave(object sender, EventArgs e)
        {
            btn_ManHinhChinh.BackColor=Color.White;
        }
    }
}
