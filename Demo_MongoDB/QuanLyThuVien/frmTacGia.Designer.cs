namespace QuanLyThuVien
{
    partial class frmTacGia
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
            this.txtMaTacGia = new System.Windows.Forms.TextBox();
            this.lblMaTacGia = new System.Windows.Forms.Label();
            this.txtTenTacGia = new System.Windows.Forms.TextBox();
            this.lblTenTacGia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(254, 128);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(104, 119);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtMaTacGia
            // 
            this.txtMaTacGia.Location = new System.Drawing.Point(104, 18);
            this.txtMaTacGia.Name = "txtMaTacGia";
            this.txtMaTacGia.Size = new System.Drawing.Size(225, 20);
            this.txtMaTacGia.TabIndex = 5;
            // 
            // lblMaTacGia
            // 
            this.lblMaTacGia.AutoSize = true;
            this.lblMaTacGia.Location = new System.Drawing.Point(12, 25);
            this.lblMaTacGia.Name = "lblMaTacGia";
            this.lblMaTacGia.Size = new System.Drawing.Size(63, 13);
            this.lblMaTacGia.TabIndex = 3;
            this.lblMaTacGia.Text = "Mã Tác Giả";
            // 
            // txtTenTacGia
            // 
            this.txtTenTacGia.Location = new System.Drawing.Point(104, 67);
            this.txtTenTacGia.Name = "txtTenTacGia";
            this.txtTenTacGia.Size = new System.Drawing.Size(225, 20);
            this.txtTenTacGia.TabIndex = 6;
            // 
            // lblTenTacGia
            // 
            this.lblTenTacGia.AutoSize = true;
            this.lblTenTacGia.Location = new System.Drawing.Point(12, 70);
            this.lblTenTacGia.Name = "lblTenTacGia";
            this.lblTenTacGia.Size = new System.Drawing.Size(67, 13);
            this.lblTenTacGia.TabIndex = 4;
            this.lblTenTacGia.Text = "Tên Tác Giả";
            // 
            // frmTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 183);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtMaTacGia);
            this.Controls.Add(this.lblMaTacGia);
            this.Controls.Add(this.txtTenTacGia);
            this.Controls.Add(this.lblTenTacGia);
            this.Name = "frmTacGia";
            this.Text = "frmTacGia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtMaTacGia;
        private System.Windows.Forms.Label lblMaTacGia;
        private System.Windows.Forms.TextBox txtTenTacGia;
        private System.Windows.Forms.Label lblTenTacGia;
    }
}