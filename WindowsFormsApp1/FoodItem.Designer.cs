namespace WindowsFormsApp1
{
    partial class FoodItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_FoodName = new System.Windows.Forms.Label();
            this.lbl_Prices = new System.Windows.Forms.Label();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.lbl_FoodID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.pic_food = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_food)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_FoodName
            // 
            this.lbl_FoodName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_FoodName.AutoSize = true;
            this.lbl_FoodName.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FoodName.Location = new System.Drawing.Point(62, 250);
            this.lbl_FoodName.Name = "lbl_FoodName";
            this.lbl_FoodName.Size = new System.Drawing.Size(94, 19);
            this.lbl_FoodName.TabIndex = 1;
            this.lbl_FoodName.Text = "Food name";
            // 
            // lbl_Prices
            // 
            this.lbl_Prices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Prices.AutoSize = true;
            this.lbl_Prices.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Prices.Location = new System.Drawing.Point(62, 308);
            this.lbl_Prices.Name = "lbl_Prices";
            this.lbl_Prices.Size = new System.Drawing.Size(53, 19);
            this.lbl_Prices.TabIndex = 1;
            this.lbl_Prices.Text = "Prices";
            this.lbl_Prices.Click += new System.EventHandler(this.lbl_Prices_Click);
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.BackColor = System.Drawing.Color.Gray;
            this.lbl_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuong.Location = new System.Drawing.Point(253, 0);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(39, 44);
            this.lbl_SoLuong.TabIndex = 3;
            this.lbl_SoLuong.Text = "0";
            this.lbl_SoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_SoLuong.TextChanged += new System.EventHandler(this.lbl_SoLuong_TextChanged);
            // 
            // lbl_FoodID
            // 
            this.lbl_FoodID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_FoodID.AutoSize = true;
            this.lbl_FoodID.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FoodID.Location = new System.Drawing.Point(97, 278);
            this.lbl_FoodID.Name = "lbl_FoodID";
            this.lbl_FoodID.Size = new System.Drawing.Size(68, 19);
            this.lbl_FoodID.TabIndex = 1;
            this.lbl_FoodID.Text = "Food ID";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "FOOD ID:";
            // 
            // lbl_Type
            // 
            this.lbl_Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Type.Location = new System.Drawing.Point(3, 221);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(46, 19);
            this.lbl_Type.TabIndex = 1;
            this.lbl_Type.Text = "Type";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prices:";
            this.label2.Click += new System.EventHandler(this.lbl_Prices_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name:";
            // 
            // btn_minus
            // 
            this.btn_minus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minus.Image = global::WindowsFormsApp1.Properties.Resources.minus;
            this.btn_minus.Location = new System.Drawing.Point(200, 288);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(43, 39);
            this.btn_minus.TabIndex = 2;
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            this.btn_minus.MouseLeave += new System.EventHandler(this.btn_minus_MouseLeave);
            this.btn_minus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_minus_MouseMove);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Image = global::WindowsFormsApp1.Properties.Resources.add;
            this.btn_add.Location = new System.Drawing.Point(249, 288);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(43, 39);
            this.btn_add.TabIndex = 2;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            this.btn_add.MouseLeave += new System.EventHandler(this.btn_add_MouseLeave);
            this.btn_add.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_add_MouseMove);
            // 
            // pic_food
            // 
            this.pic_food.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic_food.Location = new System.Drawing.Point(0, 0);
            this.pic_food.Name = "pic_food";
            this.pic_food.Size = new System.Drawing.Size(295, 208);
            this.pic_food.TabIndex = 0;
            this.pic_food.TabStop = false;
            // 
            // FoodItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_SoLuong);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Prices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_FoodID);
            this.Controls.Add(this.lbl_Type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_FoodName);
            this.Controls.Add(this.pic_food);
            this.Name = "FoodItem";
            this.Size = new System.Drawing.Size(295, 331);
            ((System.ComponentModel.ISupportInitialize)(this.pic_food)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox pic_food;
        public System.Windows.Forms.Label lbl_FoodName;
        public System.Windows.Forms.Label lbl_Prices;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.Button btn_minus;
        public System.Windows.Forms.Label lbl_SoLuong;
        public System.Windows.Forms.Label lbl_FoodID;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_Type;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
    }
}
