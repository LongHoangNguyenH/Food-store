namespace WindowsFormsApp1
{
    partial class ThanhToanVoiTheATM
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxBank = new System.Windows.Forms.ComboBox();
            this.btn_DanhGia = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.Sacombank = new System.Windows.Forms.PictureBox();
            this.lbl_TongSoTien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BIDV = new System.Windows.Forms.PictureBox();
            this.MBBank = new System.Windows.Forms.PictureBox();
            this.Agribank = new System.Windows.Forms.PictureBox();
            this.ACB = new System.Windows.Forms.PictureBox();
            this.VPbank = new System.Windows.Forms.PictureBox();
            this.TPbank = new System.Windows.Forms.PictureBox();
            this.Vietcombank = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pic_QR_code = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sacombank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BIDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MBBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Agribank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ACB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VPbank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TPbank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vietcombank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_QR_code)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.comboBoxBank);
            this.panel1.Controls.Add(this.btn_DanhGia);
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Controls.Add(this.Sacombank);
            this.panel1.Controls.Add(this.lbl_TongSoTien);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BIDV);
            this.panel1.Controls.Add(this.MBBank);
            this.panel1.Controls.Add(this.Agribank);
            this.panel1.Controls.Add(this.ACB);
            this.panel1.Controls.Add(this.VPbank);
            this.panel1.Controls.Add(this.TPbank);
            this.panel1.Controls.Add(this.Vietcombank);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 447);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxBank
            // 
            this.comboBoxBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBank.FormattingEnabled = true;
            this.comboBoxBank.Items.AddRange(new object[] {
            "SacomBank",
            "VietcomBank",
            "AgriBank",
            "BIDV",
            "VPBank",
            "TPBank",
            "ACB",
            "MBBank"});
            this.comboBoxBank.Location = new System.Drawing.Point(23, 72);
            this.comboBoxBank.Name = "comboBoxBank";
            this.comboBoxBank.Size = new System.Drawing.Size(235, 32);
            this.comboBoxBank.TabIndex = 6;
            this.comboBoxBank.SelectedIndexChanged += new System.EventHandler(this.comboBoxBank_SelectedIndexChanged);
            // 
            // btn_DanhGia
            // 
            this.btn_DanhGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DanhGia.Image = global::WindowsFormsApp1.Properties.Resources.review;
            this.btn_DanhGia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DanhGia.Location = new System.Drawing.Point(57, 277);
            this.btn_DanhGia.Name = "btn_DanhGia";
            this.btn_DanhGia.Size = new System.Drawing.Size(164, 78);
            this.btn_DanhGia.TabIndex = 5;
            this.btn_DanhGia.Text = "Đánh giá";
            this.btn_DanhGia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DanhGia.UseVisualStyleBackColor = true;
            this.btn_DanhGia.Click += new System.EventHandler(this.btn_DanhGia_Click);
            this.btn_DanhGia.MouseLeave += new System.EventHandler(this.btn_DanhGia_MouseLeave);
            this.btn_DanhGia.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_DanhGia_MouseMove);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Image = global::WindowsFormsApp1.Properties.Resources.btn_Back;
            this.btn_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Back.Location = new System.Drawing.Point(57, 356);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(164, 78);
            this.btn_Back.TabIndex = 4;
            this.btn_Back.Text = "Quay Lại";
            this.btn_Back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            this.btn_Back.MouseLeave += new System.EventHandler(this.btn_Back_MouseLeave);
            this.btn_Back.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_Back_MouseMove);
            // 
            // Sacombank
            // 
            this.Sacombank.Image = global::WindowsFormsApp1.Properties.Resources.Sacombank;
            this.Sacombank.Location = new System.Drawing.Point(23, 122);
            this.Sacombank.Name = "Sacombank";
            this.Sacombank.Size = new System.Drawing.Size(235, 149);
            this.Sacombank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Sacombank.TabIndex = 2;
            this.Sacombank.TabStop = false;
            this.Sacombank.Visible = false;
            // 
            // lbl_TongSoTien
            // 
            this.lbl_TongSoTien.AutoSize = true;
            this.lbl_TongSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongSoTien.Location = new System.Drawing.Point(133, 26);
            this.lbl_TongSoTien.Name = "lbl_TongSoTien";
            this.lbl_TongSoTien.Size = new System.Drawing.Size(20, 22);
            this.lbl_TongSoTien.TabIndex = 3;
            this.lbl_TongSoTien.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tổng Tiền:";
            // 
            // BIDV
            // 
            this.BIDV.Image = global::WindowsFormsApp1.Properties.Resources.BIDV;
            this.BIDV.Location = new System.Drawing.Point(23, 122);
            this.BIDV.Name = "BIDV";
            this.BIDV.Size = new System.Drawing.Size(235, 149);
            this.BIDV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BIDV.TabIndex = 2;
            this.BIDV.TabStop = false;
            this.BIDV.Visible = false;
            // 
            // MBBank
            // 
            this.MBBank.Location = new System.Drawing.Point(23, 122);
            this.MBBank.Name = "MBBank";
            this.MBBank.Size = new System.Drawing.Size(235, 149);
            this.MBBank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MBBank.TabIndex = 2;
            this.MBBank.TabStop = false;
            this.MBBank.Visible = false;
            // 
            // Agribank
            // 
            this.Agribank.Image = global::WindowsFormsApp1.Properties.Resources.Agribank;
            this.Agribank.Location = new System.Drawing.Point(23, 122);
            this.Agribank.Name = "Agribank";
            this.Agribank.Size = new System.Drawing.Size(235, 149);
            this.Agribank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Agribank.TabIndex = 2;
            this.Agribank.TabStop = false;
            this.Agribank.Visible = false;
            // 
            // ACB
            // 
            this.ACB.Image = global::WindowsFormsApp1.Properties.Resources.ACB1;
            this.ACB.Location = new System.Drawing.Point(23, 122);
            this.ACB.Name = "ACB";
            this.ACB.Size = new System.Drawing.Size(235, 149);
            this.ACB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ACB.TabIndex = 2;
            this.ACB.TabStop = false;
            this.ACB.Visible = false;
            // 
            // VPbank
            // 
            this.VPbank.Image = global::WindowsFormsApp1.Properties.Resources.VPbank;
            this.VPbank.Location = new System.Drawing.Point(23, 122);
            this.VPbank.Name = "VPbank";
            this.VPbank.Size = new System.Drawing.Size(235, 149);
            this.VPbank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VPbank.TabIndex = 2;
            this.VPbank.TabStop = false;
            this.VPbank.Visible = false;
            // 
            // TPbank
            // 
            this.TPbank.Image = global::WindowsFormsApp1.Properties.Resources.Tpbank;
            this.TPbank.Location = new System.Drawing.Point(23, 122);
            this.TPbank.Name = "TPbank";
            this.TPbank.Size = new System.Drawing.Size(235, 149);
            this.TPbank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TPbank.TabIndex = 2;
            this.TPbank.TabStop = false;
            this.TPbank.Visible = false;
            // 
            // Vietcombank
            // 
            this.Vietcombank.Image = global::WindowsFormsApp1.Properties.Resources.Vietcombank;
            this.Vietcombank.Location = new System.Drawing.Point(23, 122);
            this.Vietcombank.Name = "Vietcombank";
            this.Vietcombank.Size = new System.Drawing.Size(235, 149);
            this.Vietcombank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Vietcombank.TabIndex = 2;
            this.Vietcombank.TabStop = false;
            this.Vietcombank.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DeepPink;
            this.label10.Location = new System.Drawing.Point(356, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "Quét mã để thanh toán";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(306, 396);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(325, 25);
            this.label11.TabIndex = 4;
            this.label11.Text = "Sử dụng App banking để thanh toán";
            // 
            // pic_QR_code
            // 
            this.pic_QR_code.Location = new System.Drawing.Point(320, 72);
            this.pic_QR_code.Name = "pic_QR_code";
            this.pic_QR_code.Size = new System.Drawing.Size(324, 286);
            this.pic_QR_code.TabIndex = 5;
            this.pic_QR_code.TabStop = false;
            this.pic_QR_code.Visible = false;
            // 
            // ThanhToanVoiTheATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(667, 447);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_QR_code);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ThanhToanVoiTheATM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sacombank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BIDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MBBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Agribank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ACB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VPbank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TPbank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vietcombank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_QR_code)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox Sacombank;
        private System.Windows.Forms.PictureBox BIDV;
        private System.Windows.Forms.PictureBox MBBank;
        private System.Windows.Forms.PictureBox Agribank;
        private System.Windows.Forms.PictureBox ACB;
        private System.Windows.Forms.PictureBox VPbank;
        private System.Windows.Forms.PictureBox TPbank;
        private System.Windows.Forms.PictureBox Vietcombank;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pic_QR_code;
        private System.Windows.Forms.Label lbl_TongSoTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_DanhGia;
        private System.Windows.Forms.ComboBox comboBoxBank;
    }
}