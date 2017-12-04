namespace QuanLyThuVien
{
    partial class frmNhaXuatBan
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtMaNXB = new System.Windows.Forms.TextBox();
            this.lblMaNXB = new System.Windows.Forms.Label();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.lblTenNXB = new System.Windows.Forms.Label();
            this.dtpkNXB_NgayThanhLap = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChiNXB = new System.Windows.Forms.TextBox();
            this.lblNgayThanhLapNXB = new System.Windows.Forms.Label();
            this.lblDiaChiNXB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(284, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(134, 198);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.Location = new System.Drawing.Point(134, 24);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.Size = new System.Drawing.Size(225, 20);
            this.txtMaNXB.TabIndex = 11;
            // 
            // lblMaNXB
            // 
            this.lblMaNXB.AutoSize = true;
            this.lblMaNXB.Location = new System.Drawing.Point(14, 31);
            this.lblMaNXB.Name = "lblMaNXB";
            this.lblMaNXB.Size = new System.Drawing.Size(92, 13);
            this.lblMaNXB.TabIndex = 9;
            this.lblMaNXB.Text = "Mã Nhà Xuất Bản";
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Location = new System.Drawing.Point(134, 73);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(225, 20);
            this.txtTenNXB.TabIndex = 12;
            // 
            // lblTenNXB
            // 
            this.lblTenNXB.AutoSize = true;
            this.lblTenNXB.Location = new System.Drawing.Point(14, 76);
            this.lblTenNXB.Name = "lblTenNXB";
            this.lblTenNXB.Size = new System.Drawing.Size(96, 13);
            this.lblTenNXB.TabIndex = 10;
            this.lblTenNXB.Text = "Tên Nhà Xuất Bản";
            // 
            // dtpkNXB_NgayThanhLap
            // 
            this.dtpkNXB_NgayThanhLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNXB_NgayThanhLap.Location = new System.Drawing.Point(134, 157);
            this.dtpkNXB_NgayThanhLap.Name = "dtpkNXB_NgayThanhLap";
            this.dtpkNXB_NgayThanhLap.Size = new System.Drawing.Size(225, 20);
            this.dtpkNXB_NgayThanhLap.TabIndex = 15;
            // 
            // txtDiaChiNXB
            // 
            this.txtDiaChiNXB.Location = new System.Drawing.Point(134, 110);
            this.txtDiaChiNXB.Name = "txtDiaChiNXB";
            this.txtDiaChiNXB.Size = new System.Drawing.Size(225, 20);
            this.txtDiaChiNXB.TabIndex = 18;
            // 
            // lblNgayThanhLapNXB
            // 
            this.lblNgayThanhLapNXB.AutoSize = true;
            this.lblNgayThanhLapNXB.Location = new System.Drawing.Point(12, 163);
            this.lblNgayThanhLapNXB.Name = "lblNgayThanhLapNXB";
            this.lblNgayThanhLapNXB.Size = new System.Drawing.Size(87, 13);
            this.lblNgayThanhLapNXB.TabIndex = 16;
            this.lblNgayThanhLapNXB.Text = "Ngày Thành Lập";
            // 
            // lblDiaChiNXB
            // 
            this.lblDiaChiNXB.AutoSize = true;
            this.lblDiaChiNXB.Location = new System.Drawing.Point(12, 113);
            this.lblDiaChiNXB.Name = "lblDiaChiNXB";
            this.lblDiaChiNXB.Size = new System.Drawing.Size(41, 13);
            this.lblDiaChiNXB.TabIndex = 17;
            this.lblDiaChiNXB.Text = "Địa Chỉ";
            // 
            // frmNhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 233);
            this.Controls.Add(this.txtDiaChiNXB);
            this.Controls.Add(this.lblNgayThanhLapNXB);
            this.Controls.Add(this.lblDiaChiNXB);
            this.Controls.Add(this.dtpkNXB_NgayThanhLap);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtMaNXB);
            this.Controls.Add(this.lblMaNXB);
            this.Controls.Add(this.txtTenNXB);
            this.Controls.Add(this.lblTenNXB);
            this.Name = "frmNhaXuatBan";
            this.Text = "Nhà Xuất Bản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtMaNXB;
        private System.Windows.Forms.Label lblMaNXB;
        private System.Windows.Forms.TextBox txtTenNXB;
        private System.Windows.Forms.Label lblTenNXB;
        private System.Windows.Forms.DateTimePicker dtpkNXB_NgayThanhLap;
        private System.Windows.Forms.TextBox txtDiaChiNXB;
        private System.Windows.Forms.Label lblNgayThanhLapNXB;
        private System.Windows.Forms.Label lblDiaChiNXB;
    }
}