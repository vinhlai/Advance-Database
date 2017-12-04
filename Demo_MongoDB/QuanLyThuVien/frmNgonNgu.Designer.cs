namespace QuanLyThuVien
{
    partial class frmNgonNgu
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
            this.txtMaNgonNgu = new System.Windows.Forms.TextBox();
            this.lblMaNgonNgu = new System.Windows.Forms.Label();
            this.txtTenNgonNgu = new System.Windows.Forms.TextBox();
            this.lblTenNgonNgu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(253, 106);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(103, 106);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtMaNgonNgu
            // 
            this.txtMaNgonNgu.Location = new System.Drawing.Point(103, 12);
            this.txtMaNgonNgu.Name = "txtMaNgonNgu";
            this.txtMaNgonNgu.Size = new System.Drawing.Size(225, 20);
            this.txtMaNgonNgu.TabIndex = 11;
            // 
            // lblMaNgonNgu
            // 
            this.lblMaNgonNgu.AutoSize = true;
            this.lblMaNgonNgu.Location = new System.Drawing.Point(11, 19);
            this.lblMaNgonNgu.Name = "lblMaNgonNgu";
            this.lblMaNgonNgu.Size = new System.Drawing.Size(74, 13);
            this.lblMaNgonNgu.TabIndex = 9;
            this.lblMaNgonNgu.Text = "Mã Ngôn Ngữ";
            // 
            // txtTenNgonNgu
            // 
            this.txtTenNgonNgu.Location = new System.Drawing.Point(103, 61);
            this.txtTenNgonNgu.Name = "txtTenNgonNgu";
            this.txtTenNgonNgu.Size = new System.Drawing.Size(225, 20);
            this.txtTenNgonNgu.TabIndex = 12;
            // 
            // lblTenNgonNgu
            // 
            this.lblTenNgonNgu.AutoSize = true;
            this.lblTenNgonNgu.Location = new System.Drawing.Point(11, 64);
            this.lblTenNgonNgu.Name = "lblTenNgonNgu";
            this.lblTenNgonNgu.Size = new System.Drawing.Size(78, 13);
            this.lblTenNgonNgu.TabIndex = 10;
            this.lblTenNgonNgu.Text = "Tên Ngôn Ngữ";
            // 
            // frmNgonNgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 149);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtMaNgonNgu);
            this.Controls.Add(this.lblMaNgonNgu);
            this.Controls.Add(this.txtTenNgonNgu);
            this.Controls.Add(this.lblTenNgonNgu);
            this.Name = "frmNgonNgu";
            this.Text = "frmNgonNgu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtMaNgonNgu;
        private System.Windows.Forms.Label lblMaNgonNgu;
        private System.Windows.Forms.TextBox txtTenNgonNgu;
        private System.Windows.Forms.Label lblTenNgonNgu;
    }
}