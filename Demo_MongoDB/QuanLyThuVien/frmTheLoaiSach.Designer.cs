namespace QuanLyThuVien
{
    partial class frmTheLoaiSach
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
            this.lblTenLoaiSach = new System.Windows.Forms.Label();
            this.txtTenLoaiSach = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblMaLoaiSach = new System.Windows.Forms.Label();
            this.txtMaLoaiSach = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTenLoaiSach
            // 
            this.lblTenLoaiSach.AutoSize = true;
            this.lblTenLoaiSach.Location = new System.Drawing.Point(0, 89);
            this.lblTenLoaiSach.Name = "lblTenLoaiSach";
            this.lblTenLoaiSach.Size = new System.Drawing.Size(77, 13);
            this.lblTenLoaiSach.TabIndex = 0;
            this.lblTenLoaiSach.Text = "Tên Loại Sách";
            // 
            // txtTenLoaiSach
            // 
            this.txtTenLoaiSach.Location = new System.Drawing.Point(94, 89);
            this.txtTenLoaiSach.Name = "txtTenLoaiSach";
            this.txtTenLoaiSach.Size = new System.Drawing.Size(225, 20);
            this.txtTenLoaiSach.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(94, 138);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(244, 138);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblMaLoaiSach
            // 
            this.lblMaLoaiSach.AutoSize = true;
            this.lblMaLoaiSach.Location = new System.Drawing.Point(0, 38);
            this.lblMaLoaiSach.Name = "lblMaLoaiSach";
            this.lblMaLoaiSach.Size = new System.Drawing.Size(73, 13);
            this.lblMaLoaiSach.TabIndex = 0;
            this.lblMaLoaiSach.Text = "Mã Loại Sách";
            // 
            // txtMaLoaiSach
            // 
            this.txtMaLoaiSach.Location = new System.Drawing.Point(94, 38);
            this.txtMaLoaiSach.Name = "txtMaLoaiSach";
            this.txtMaLoaiSach.Size = new System.Drawing.Size(225, 20);
            this.txtMaLoaiSach.TabIndex = 1;
            // 
            // frmTheLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 199);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtMaLoaiSach);
            this.Controls.Add(this.lblMaLoaiSach);
            this.Controls.Add(this.txtTenLoaiSach);
            this.Controls.Add(this.lblTenLoaiSach);
            this.Name = "frmTheLoaiSach";
            this.Text = "frmTheLoaiSach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenLoaiSach;
        private System.Windows.Forms.TextBox txtTenLoaiSach;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblMaLoaiSach;
        private System.Windows.Forms.TextBox txtMaLoaiSach;
    }
}