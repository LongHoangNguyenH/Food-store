namespace WindowsFormsApp1
{
    partial class Label_SoMon_TongSoTiens
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
            this.lbl_TongTien = new System.Windows.Forms.Label();
            this.lbl_TongSoMon = new System.Windows.Forms.Label();
            this.labell1 = new System.Windows.Forms.Label();
            this.labell2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.AutoSize = true;
            this.lbl_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongTien.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_TongTien.Location = new System.Drawing.Point(145, 37);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(19, 20);
            this.lbl_TongTien.TabIndex = 4;
            this.lbl_TongTien.Text = "0";
            // 
            // lbl_TongSoMon
            // 
            this.lbl_TongSoMon.AutoSize = true;
            this.lbl_TongSoMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TongSoMon.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_TongSoMon.Location = new System.Drawing.Point(145, 92);
            this.lbl_TongSoMon.Name = "lbl_TongSoMon";
            this.lbl_TongSoMon.Size = new System.Drawing.Size(19, 20);
            this.lbl_TongSoMon.TabIndex = 5;
            this.lbl_TongSoMon.Text = "0";
            // 
            // labell1
            // 
            this.labell1.AutoSize = true;
            this.labell1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labell1.ForeColor = System.Drawing.Color.Maroon;
            this.labell1.Location = new System.Drawing.Point(13, 92);
            this.labell1.Name = "labell1";
            this.labell1.Size = new System.Drawing.Size(120, 20);
            this.labell1.TabIndex = 6;
            this.labell1.Text = "Tổng Số Món:";
            // 
            // labell2
            // 
            this.labell2.AutoSize = true;
            this.labell2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labell2.ForeColor = System.Drawing.Color.Maroon;
            this.labell2.Location = new System.Drawing.Point(13, 37);
            this.labell2.Name = "labell2";
            this.labell2.Size = new System.Drawing.Size(93, 20);
            this.labell2.TabIndex = 7;
            this.labell2.Text = "Tổng Tiền:";
            // 
            // Label_SoMon_TongSoTiens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_TongTien);
            this.Controls.Add(this.lbl_TongSoMon);
            this.Controls.Add(this.labell1);
            this.Controls.Add(this.labell2);
            this.Name = "Label_SoMon_TongSoTiens";
            this.Size = new System.Drawing.Size(343, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_TongTien;
        private System.Windows.Forms.Label labell1;
        private System.Windows.Forms.Label labell2;
        public System.Windows.Forms.Label lbl_TongSoMon;
    }
}
