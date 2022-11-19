namespace WindowsFormsApp1
{
    partial class ManHinhChinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel_Food = new System.Windows.Forms.FlowLayoutPanel();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_drink = new System.Windows.Forms.Button();
            this.btn_food = new System.Windows.Forms.Button();
            this.lbl_TongTien = new System.Windows.Forms.Label();
            this.lbl_TongSoMon = new System.Windows.Forms.Label();
            this.labell1 = new System.Windows.Forms.Label();
            this.labell2 = new System.Windows.Forms.Label();
            this.pictureBox_hotline = new System.Windows.Forms.PictureBox();
            this.btn_food_and_drinks = new System.Windows.Forms.Button();
            this.btn_shopping_cart = new System.Windows.Forms.Button();
            this.Panel_label = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hotline)).BeginInit();
            this.Panel_label.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_Food
            // 
            this.flowLayoutPanel_Food.AutoScroll = true;
            this.flowLayoutPanel_Food.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_Food.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel_Food.Location = new System.Drawing.Point(0, 152);
            this.flowLayoutPanel_Food.Name = "flowLayoutPanel_Food";
            this.flowLayoutPanel_Food.Size = new System.Drawing.Size(1225, 487);
            this.flowLayoutPanel_Food.TabIndex = 5;
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.ForeColor = System.Drawing.Color.Silver;
            this.txt_Search.Location = new System.Drawing.Point(40, 75);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(346, 43);
            this.txt_Search.TabIndex = 4;
            this.txt_Search.Text = "Tìm kiếm món ăn";
            this.txt_Search.Enter += new System.EventHandler(this.txt_Search_Enter);
            this.txt_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Search_KeyPress_1);

            this.txt_Search.Leave += new System.EventHandler(this.txt_Search_Leave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(58, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "DANH SÁCH MÓN ĂN";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_Search);
            this.panel2.Controls.Add(this.btn_drink);
            this.panel2.Controls.Add(this.btn_food);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 150);
            this.panel2.TabIndex = 6;
            // 
            // btn_drink
            // 
            this.btn_drink.Image = global::WindowsFormsApp1.Properties.Resources.Drinks;
            this.btn_drink.Location = new System.Drawing.Point(483, 58);
            this.btn_drink.Name = "btn_drink";
            this.btn_drink.Size = new System.Drawing.Size(85, 70);
            this.btn_drink.TabIndex = 2;
            this.btn_drink.UseVisualStyleBackColor = true;
            this.btn_drink.Click += new System.EventHandler(this.btn_drink_Click);
            this.btn_drink.MouseLeave += new System.EventHandler(this.btn_drink_MouseLeave);
            this.btn_drink.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_drink_MouseMove);
            // 
            // btn_food
            // 
            this.btn_food.Image = global::WindowsFormsApp1.Properties.Resources.Food;
            this.btn_food.Location = new System.Drawing.Point(574, 58);
            this.btn_food.Name = "btn_food";
            this.btn_food.Size = new System.Drawing.Size(85, 70);
            this.btn_food.TabIndex = 3;
            this.btn_food.UseVisualStyleBackColor = true;
            this.btn_food.Click += new System.EventHandler(this.btn_food_Click);
            this.btn_food.MouseLeave += new System.EventHandler(this.btn_food_MouseLeave);
            this.btn_food.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_food_MouseMove);
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.AutoSize = true;
            this.lbl_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongTien.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_TongTien.Location = new System.Drawing.Point(126, 35);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(19, 20);
            this.lbl_TongTien.TabIndex = 8;
            this.lbl_TongTien.Text = "0";
            this.lbl_TongTien.Visible = false;
            // 
            // lbl_TongSoMon
            // 
            this.lbl_TongSoMon.AutoSize = true;
            this.lbl_TongSoMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongSoMon.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_TongSoMon.Location = new System.Drawing.Point(143, 90);
            this.lbl_TongSoMon.Name = "lbl_TongSoMon";
            this.lbl_TongSoMon.Size = new System.Drawing.Size(19, 20);
            this.lbl_TongSoMon.TabIndex = 9;
            this.lbl_TongSoMon.Text = "0";
            this.lbl_TongSoMon.Visible = false;
            // 
            // labell1
            // 
            this.labell1.AutoSize = true;
            this.labell1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labell1.ForeColor = System.Drawing.Color.Maroon;
            this.labell1.Location = new System.Drawing.Point(9, 90);
            this.labell1.Name = "labell1";
            this.labell1.Size = new System.Drawing.Size(120, 20);
            this.labell1.TabIndex = 10;
            this.labell1.Text = "Tổng Số Món:";
            this.labell1.Visible = false;
            // 
            // labell2
            // 
            this.labell2.AutoSize = true;
            this.labell2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labell2.ForeColor = System.Drawing.Color.Maroon;
            this.labell2.Location = new System.Drawing.Point(9, 35);
            this.labell2.Name = "labell2";
            this.labell2.Size = new System.Drawing.Size(93, 20);
            this.labell2.TabIndex = 11;
            this.labell2.Text = "Tổng Tiền:";
            this.labell2.Visible = false;
            // 
            // pictureBox_hotline
            // 
            this.pictureBox_hotline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_hotline.Image = global::WindowsFormsApp1.Properties.Resources.Food_order_sysbol;
            this.pictureBox_hotline.Location = new System.Drawing.Point(675, 3);
            this.pictureBox_hotline.Name = "pictureBox_hotline";
            this.pictureBox_hotline.Size = new System.Drawing.Size(177, 150);
            this.pictureBox_hotline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_hotline.TabIndex = 3;
            this.pictureBox_hotline.TabStop = false;
            this.pictureBox_hotline.Click += new System.EventHandler(this.pictureBox_hotline_Click);
            // 
            // btn_food_and_drinks
            // 
            this.btn_food_and_drinks.Image = global::WindowsFormsApp1.Properties.Resources.food_and_drinks;
            this.btn_food_and_drinks.Location = new System.Drawing.Point(393, 62);
            this.btn_food_and_drinks.Name = "btn_food_and_drinks";
            this.btn_food_and_drinks.Size = new System.Drawing.Size(85, 70);
            this.btn_food_and_drinks.TabIndex = 1;
            this.btn_food_and_drinks.UseVisualStyleBackColor = true;
            this.btn_food_and_drinks.Click += new System.EventHandler(this.btn_food_and_drinks_Click);
            this.btn_food_and_drinks.MouseLeave += new System.EventHandler(this.btn_food_and_drinks_MouseLeave);
            this.btn_food_and_drinks.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_food_and_drinks_MouseMove);
            // 
            // btn_shopping_cart
            // 
            this.btn_shopping_cart.Image = global::WindowsFormsApp1.Properties.Resources.Shoppingcart;
            this.btn_shopping_cart.Location = new System.Drawing.Point(1124, 71);
            this.btn_shopping_cart.Name = "btn_shopping_cart";
            this.btn_shopping_cart.Size = new System.Drawing.Size(89, 78);
            this.btn_shopping_cart.TabIndex = 0;
            this.btn_shopping_cart.UseVisualStyleBackColor = true;
            this.btn_shopping_cart.Click += new System.EventHandler(this.btn_shopping_cart_Click);
            this.btn_shopping_cart.MouseLeave += new System.EventHandler(this.btn_shopping_cart_MouseLeave);
            this.btn_shopping_cart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_shopping_cart_MouseMove);
            // 
            // Panel_label
            // 
            this.Panel_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_label.Controls.Add(this.lbl_TongTien);
            this.Panel_label.Controls.Add(this.labell2);
            this.Panel_label.Controls.Add(this.labell1);
            this.Panel_label.Controls.Add(this.lbl_TongSoMon);
            this.Panel_label.Location = new System.Drawing.Point(849, 3);
            this.Panel_label.Name = "Panel_label";
            this.Panel_label.Size = new System.Drawing.Size(376, 150);
            this.Panel_label.TabIndex = 7;
            // 
            // ManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1225, 639);
            this.Controls.Add(this.btn_shopping_cart);
            this.Controls.Add(this.pictureBox_hotline);
            this.Controls.Add(this.btn_food_and_drinks);
            this.Controls.Add(this.flowLayoutPanel_Food);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Panel_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManHinhChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManHinhChinh";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hotline)).EndInit();
            this.Panel_label.ResumeLayout(false);
            this.Panel_label.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Food;
        private System.Windows.Forms.Button btn_food;
        private System.Windows.Forms.Button btn_drink;
        private System.Windows.Forms.Button btn_food_and_drinks;
        private System.Windows.Forms.PictureBox pictureBox_hotline;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lbl_TongTien;
        public System.Windows.Forms.Label lbl_TongSoMon;
        private System.Windows.Forms.Label labell1;
        private System.Windows.Forms.Label labell2;
        private System.Windows.Forms.Button btn_shopping_cart;
        private System.Windows.Forms.Panel Panel_label;
    }
}