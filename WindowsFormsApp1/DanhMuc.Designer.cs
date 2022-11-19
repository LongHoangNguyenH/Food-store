namespace WindowsFormsApp1
{
    partial class DanhMuc
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_GhiChu = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel_flow = new System.Windows.Forms.Panel();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.panel_label = new System.Windows.Forms.Panel();
            this.lbl_TongTien = new System.Windows.Forms.Label();
            this.lbl_TongSoMon = new System.Windows.Forms.Label();
            this.labell1 = new System.Windows.Forms.Label();
            this.labell2 = new System.Windows.Forms.Label();
            this.rdb_momo = new System.Windows.Forms.RadioButton();
            this.rdb_TienMat = new System.Windows.Forms.RadioButton();
            this.rdb_TheTinDung = new System.Windows.Forms.RadioButton();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_HuyDon = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel_label.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 47);
            this.label1.TabIndex = 6;
            this.label1.Text = "DANH SÁCH MÓN ĂN ĐÃ CHỌN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_discount
            // 
            this.txt_discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_discount.ForeColor = System.Drawing.Color.Silver;
            this.txt_discount.Location = new System.Drawing.Point(320, 94);
            this.txt_discount.Multiline = true;
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(212, 44);
            this.txt_discount.TabIndex = 2;
            this.txt_discount.Text = "Nhập mã giảm giá";
            this.txt_discount.TextChanged += new System.EventHandler(this.txt_discount_TextChanged);
            this.txt_discount.Enter += new System.EventHandler(this.txt_discount_Enter);
            this.txt_discount.Leave += new System.EventHandler(this.txt_discount_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(8, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(7, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ Tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(7, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Địa Chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(8, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số ĐT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(3, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(327, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "HÌNH THỨC THANH TOÁN";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(89, 142);
            this.txt_SDT.Multiline = true;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(211, 26);
            this.txt_SDT.TabIndex = 2;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(8, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ghi Chú";
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GhiChu.Location = new System.Drawing.Point(89, 189);
            this.txt_GhiChu.Multiline = true;
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(211, 26);
            this.txt_GhiChu.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_HoTen);
            this.panel2.Controls.Add(this.txt_DiaChi);
            this.panel2.Controls.Add(this.txt_GhiChu);
            this.panel2.Controls.Add(this.txt_MaKH);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_SDT);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(912, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 647);
            this.panel2.TabIndex = 0;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen.Location = new System.Drawing.Point(89, 60);
            this.txt_HoTen.Multiline = true;
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(211, 26);
            this.txt_HoTen.TabIndex = 0;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Location = new System.Drawing.Point(89, 102);
            this.txt_DiaChi.Multiline = true;
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(211, 26);
            this.txt_DiaChi.TabIndex = 1;
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaKH.Location = new System.Drawing.Point(137, 230);
            this.txt_MaKH.Multiline = true;
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.ReadOnly = true;
            this.txt_MaKH.Size = new System.Drawing.Size(163, 27);
            this.txt_MaKH.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(8, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Mã Khách Hàng: ";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 324);
            this.panel3.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rdb_momo);
            this.panel4.Controls.Add(this.rdb_TienMat);
            this.panel4.Controls.Add(this.rdb_TheTinDung);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 319);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 326);
            this.panel4.TabIndex = 20;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txt_discount);
            this.panel5.Controls.Add(this.btn_back);
            this.panel5.Controls.Add(this.btn_HuyDon);
            this.panel5.Location = new System.Drawing.Point(0, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(537, 150);
            this.panel5.TabIndex = 8;
            // 
            // panel_flow
            // 
            this.panel_flow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_flow.Location = new System.Drawing.Point(0, 152);
            this.panel_flow.Name = "panel_flow";
            this.panel_flow.Size = new System.Drawing.Size(916, 497);
            this.panel_flow.TabIndex = 10;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_ThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.ForeColor = System.Drawing.Color.Maroon;
            this.btn_ThanhToan.Location = new System.Drawing.Point(256, 3);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(117, 140);
            this.btn_ThanhToan.TabIndex = 0;
            this.btn_ThanhToan.Text = "Thanh Toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = false;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            this.btn_ThanhToan.MouseLeave += new System.EventHandler(this.btn_ThanhToan_MouseLeave);
            this.btn_ThanhToan.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_ThanhToan_MouseMove);
            // 
            // panel_label
            // 
            this.panel_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_label.Controls.Add(this.lbl_TongTien);
            this.panel_label.Controls.Add(this.lbl_TongSoMon);
            this.panel_label.Controls.Add(this.labell1);
            this.panel_label.Controls.Add(this.labell2);
            this.panel_label.Controls.Add(this.btn_ThanhToan);
            this.panel_label.Location = new System.Drawing.Point(540, 2);
            this.panel_label.Name = "panel_label";
            this.panel_label.Size = new System.Drawing.Size(376, 150);
            this.panel_label.TabIndex = 9;
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.AutoSize = true;
            this.lbl_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongTien.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_TongTien.Location = new System.Drawing.Point(131, 36);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(19, 20);
            this.lbl_TongTien.TabIndex = 12;
            this.lbl_TongTien.Text = "0";
            this.lbl_TongTien.Visible = false;
            // 
            // lbl_TongSoMon
            // 
            this.lbl_TongSoMon.AutoSize = true;
            this.lbl_TongSoMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongSoMon.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_TongSoMon.Location = new System.Drawing.Point(131, 87);
            this.lbl_TongSoMon.Name = "lbl_TongSoMon";
            this.lbl_TongSoMon.Size = new System.Drawing.Size(19, 20);
            this.lbl_TongSoMon.TabIndex = 13;
            this.lbl_TongSoMon.Text = "0";
            this.lbl_TongSoMon.Visible = false;
            // 
            // labell1
            // 
            this.labell1.AutoSize = true;
            this.labell1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labell1.ForeColor = System.Drawing.Color.Maroon;
            this.labell1.Location = new System.Drawing.Point(2, 87);
            this.labell1.Name = "labell1";
            this.labell1.Size = new System.Drawing.Size(120, 20);
            this.labell1.TabIndex = 14;
            this.labell1.Text = "Tổng Số Món:";
            this.labell1.Visible = false;
            // 
            // labell2
            // 
            this.labell2.AutoSize = true;
            this.labell2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labell2.ForeColor = System.Drawing.Color.Maroon;
            this.labell2.Location = new System.Drawing.Point(14, 36);
            this.labell2.Name = "labell2";
            this.labell2.Size = new System.Drawing.Size(93, 20);
            this.labell2.TabIndex = 15;
            this.labell2.Text = "Tổng Tiền:";
            this.labell2.Visible = false;
            // 
            // rdb_momo
            // 
            this.rdb_momo.BackColor = System.Drawing.Color.PeachPuff;
            this.rdb_momo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_momo.Image = global::WindowsFormsApp1.Properties.Resources.momo;
            this.rdb_momo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdb_momo.Location = new System.Drawing.Point(26, 247);
            this.rdb_momo.Name = "rdb_momo";
            this.rdb_momo.Size = new System.Drawing.Size(274, 62);
            this.rdb_momo.TabIndex = 18;
            this.rdb_momo.TabStop = true;
            this.rdb_momo.Text = "Momo";
            this.rdb_momo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdb_momo.UseVisualStyleBackColor = false;
            this.rdb_momo.MouseLeave += new System.EventHandler(this.rdb_momo_MouseLeave);
            this.rdb_momo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rdb_momo_MouseMove);
            // 
            // rdb_TienMat
            // 
            this.rdb_TienMat.BackColor = System.Drawing.Color.PeachPuff;
            this.rdb_TienMat.Checked = true;
            this.rdb_TienMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_TienMat.Image = global::WindowsFormsApp1.Properties.Resources.cash;
            this.rdb_TienMat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdb_TienMat.Location = new System.Drawing.Point(26, 81);
            this.rdb_TienMat.Name = "rdb_TienMat";
            this.rdb_TienMat.Size = new System.Drawing.Size(274, 62);
            this.rdb_TienMat.TabIndex = 17;
            this.rdb_TienMat.TabStop = true;
            this.rdb_TienMat.Text = "Tiền Mặt";
            this.rdb_TienMat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdb_TienMat.UseVisualStyleBackColor = false;
            this.rdb_TienMat.MouseLeave += new System.EventHandler(this.rdb_TienMat_MouseLeave);
            this.rdb_TienMat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rdb_TienMat_MouseMove);
            // 
            // rdb_TheTinDung
            // 
            this.rdb_TheTinDung.BackColor = System.Drawing.Color.PeachPuff;
            this.rdb_TheTinDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_TheTinDung.Image = global::WindowsFormsApp1.Properties.Resources.credit;
            this.rdb_TheTinDung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdb_TheTinDung.Location = new System.Drawing.Point(26, 166);
            this.rdb_TheTinDung.Name = "rdb_TheTinDung";
            this.rdb_TheTinDung.Size = new System.Drawing.Size(274, 62);
            this.rdb_TheTinDung.TabIndex = 18;
            this.rdb_TheTinDung.TabStop = true;
            this.rdb_TheTinDung.Text = "Thẻ Tín Dụng";
            this.rdb_TheTinDung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdb_TheTinDung.UseVisualStyleBackColor = false;
            this.rdb_TheTinDung.MouseLeave += new System.EventHandler(this.rdb_TheTinDung_MouseLeave);
            this.rdb_TheTinDung.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rdb_TheTinDung_MouseMove);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Image = global::WindowsFormsApp1.Properties.Resources.btn_Back;
            this.btn_back.Location = new System.Drawing.Point(2, 79);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(150, 65);
            this.btn_back.TabIndex = 5;
            this.btn_back.Tag = "haha";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            this.btn_back.MouseLeave += new System.EventHandler(this.btn_back_MouseLeave);
            this.btn_back.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_back_MouseMove);
            // 
            // btn_HuyDon
            // 
            this.btn_HuyDon.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_HuyDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HuyDon.Image = global::WindowsFormsApp1.Properties.Resources.cancelation;
            this.btn_HuyDon.Location = new System.Drawing.Point(158, 79);
            this.btn_HuyDon.Name = "btn_HuyDon";
            this.btn_HuyDon.Size = new System.Drawing.Size(150, 65);
            this.btn_HuyDon.TabIndex = 4;
            this.btn_HuyDon.Tag = "haha";
            this.btn_HuyDon.UseVisualStyleBackColor = false;
            this.btn_HuyDon.Click += new System.EventHandler(this.btn_HuyDon_Click);
            this.btn_HuyDon.MouseLeave += new System.EventHandler(this.btn_HuyDon_MouseLeave);
            this.btn_HuyDon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_HuyDon_MouseMove);
            // 
            // DanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1267, 653);
            this.Controls.Add(this.panel_flow);
            this.Controls.Add(this.panel_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhMuc";
            this.Load += new System.EventHandler(this.DanhMuc_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel_label.ResumeLayout(false);
            this.panel_label.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_HuyDon;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_GhiChu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdb_momo;
        private System.Windows.Forms.RadioButton rdb_TienMat;
        private System.Windows.Forms.RadioButton rdb_TheTinDung;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel_flow;
        private System.Windows.Forms.Panel panel_label;
        private System.Windows.Forms.Button btn_ThanhToan;
        public System.Windows.Forms.Label lbl_TongTien;
        public System.Windows.Forms.Label lbl_TongSoMon;
        private System.Windows.Forms.Label labell1;
        private System.Windows.Forms.Label labell2;
    }
}