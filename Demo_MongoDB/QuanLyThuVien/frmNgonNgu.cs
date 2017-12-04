using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmNgonNgu : Form
    {
        public frmNgonNgu()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var db = Module.GetDatabase("QLTHUVIEN");
            var collection = db.GetCollection<NgonNgu>("NGONNGU");

            NgonNgu ngonNguTemplate = new NgonNgu();
            ngonNguTemplate.maNgonNgu = txtMaNgonNgu.Text;
            ngonNguTemplate.tenNgonNgu = txtTenNgonNgu.Text;

            collection.InsertOne(ngonNguTemplate);
            txtMaNgonNgu.Text = "";
            txtTenNgonNgu.Text = "";
            MessageBox.Show("Insert thành công");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
