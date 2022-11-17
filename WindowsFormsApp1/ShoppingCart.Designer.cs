namespace WindowsFormsApp1
{
    partial class ShoppingCart_item
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
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.lbl_total_prices = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_DeleteItem = new System.Windows.Forms.Button();
            this.btn_Minus = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.picturebox_food = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_food)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_FoodName
            // 
            this.lbl_FoodName.AutoSize = true;
            this.lbl_FoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FoodName.ForeColor = System.Drawing.Color.Brown;
            this.lbl_FoodName.Location = new System.Drawing.Point(491, 49);
            this.lbl_FoodName.Name = "lbl_FoodName";
            this.lbl_FoodName.Size = new System.Drawing.Size(66, 24);
            this.lbl_FoodName.TabIndex = 1;
            this.lbl_FoodName.Text = "Name:";
            // 
            // lbl_Prices
            // 
            this.lbl_Prices.AutoSize = true;
            this.lbl_Prices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Prices.ForeColor = System.Drawing.Color.Brown;
            this.lbl_Prices.Location = new System.Drawing.Point(515, 117);
            this.lbl_Prices.Name = "lbl_Prices";
            this.lbl_Prices.Size = new System.Drawing.Size(20, 24);
            this.lbl_Prices.TabIndex = 1;
            this.lbl_Prices.Text = "0";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Amount.ForeColor = System.Drawing.Color.Brown;
            this.lbl_Amount.Location = new System.Drawing.Point(515, 84);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(20, 24);
            this.lbl_Amount.TabIndex = 1;
            this.lbl_Amount.Text = "0";
            // 
            // lbl_total_prices
            // 
            this.lbl_total_prices.AutoSize = true;
            this.lbl_total_prices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_prices.ForeColor = System.Drawing.Color.Brown;
            this.lbl_total_prices.Location = new System.Drawing.Point(515, 152);
            this.lbl_total_prices.Name = "lbl_total_prices";
            this.lbl_total_prices.Size = new System.Drawing.Size(20, 24);
            this.lbl_total_prices.TabIndex = 1;
            this.lbl_total_prices.Text = "0";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(501, 200);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(40, 24);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(362, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "FOOD ID: ";
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Type.ForeColor = System.Drawing.Color.Brown;
            this.lbl_Type.Location = new System.Drawing.Point(361, 16);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(58, 24);
            this.lbl_Type.TabIndex = 1;
            this.lbl_Type.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(362, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(361, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số Lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(362, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Đơn Giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(358, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tổng tiền:";
            // 
            // btn_DeleteItem
            // 
            this.btn_DeleteItem.BackColor = System.Drawing.Color.Khaki;
            this.btn_DeleteItem.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_DeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteItem.Image = global::WindowsFormsApp1.Properties.Resources.deletitem;
            this.btn_DeleteItem.Location = new System.Drawing.Point(799, 0);
            this.btn_DeleteItem.Name = "btn_DeleteItem";
            this.btn_DeleteItem.Size = new System.Drawing.Size(105, 241);
            this.btn_DeleteItem.TabIndex = 3;
            this.btn_DeleteItem.UseVisualStyleBackColor = false;
            this.btn_DeleteItem.Click += new System.EventHandler(this.btn_DeleteItem_Click);
            this.btn_DeleteItem.MouseLeave += new System.EventHandler(this.btn_DeleteItem_MouseLeave);
            this.btn_DeleteItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_DeleteItem_MouseMove);
            // 
            // btn_Minus
            // 
            this.btn_Minus.Image = global::WindowsFormsApp1.Properties.Resources.minus;
            this.btn_Minus.Location = new System.Drawing.Point(632, 192);
            this.btn_Minus.Name = "btn_Minus";
            this.btn_Minus.Size = new System.Drawing.Size(58, 45);
            this.btn_Minus.TabIndex = 2;
            this.btn_Minus.UseVisualStyleBackColor = true;
            this.btn_Minus.Click += new System.EventHandler(this.btn_Minus_Click);
            this.btn_Minus.MouseLeave += new System.EventHandler(this.btn_Minus_MouseLeave);
            this.btn_Minus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_Minus_MouseMove);
            // 
            // btn_Add
            // 
            this.btn_Add.Image = global::WindowsFormsApp1.Properties.Resources.add;
            this.btn_Add.Location = new System.Drawing.Point(708, 192);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(59, 45);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            this.btn_Add.MouseLeave += new System.EventHandler(this.btn_Add_MouseLeave);
            this.btn_Add.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_Add_MouseMove);
            // 
            // picturebox_food
            // 
            this.picturebox_food.Dock = System.Windows.Forms.DockStyle.Left;
            this.picturebox_food.Location = new System.Drawing.Point(0, 0);
            this.picturebox_food.Name = "picturebox_food";
            this.picturebox_food.Size = new System.Drawing.Size(344, 241);
            this.picturebox_food.TabIndex = 0;
            this.picturebox_food.TabStop = false;
            // 
            // ShoppingCart_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btn_DeleteItem);
            this.Controls.Add(this.btn_Minus);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_Type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_total_prices);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Prices);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_FoodName);
            this.Controls.Add(this.picturebox_food);
            this.Name = "ShoppingCart_item";
            this.Size = new System.Drawing.Size(904, 241);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_food)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picturebox_food;
        public System.Windows.Forms.Label lbl_FoodName;
        public System.Windows.Forms.Label lbl_Prices;
        public System.Windows.Forms.Label lbl_Amount;
        public System.Windows.Forms.Label lbl_total_prices;
        public System.Windows.Forms.Button btn_Add;
        public System.Windows.Forms.Button btn_DeleteItem;
        public System.Windows.Forms.Button btn_Minus;
        public System.Windows.Forms.Label lbl_ID;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_Type;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
    }
}
