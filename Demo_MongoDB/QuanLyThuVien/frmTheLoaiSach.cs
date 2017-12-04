using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace QuanLyThuVien
{
    public partial class frmTheLoaiSach : Form
    {   
        public frmTheLoaiSach()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var db = Module.GetDatabase("QLTHUVIEN");
            var collection = db.GetCollection<TheLoai>("LOAISACH");
            var query = collection.AsQueryable<TheLoai>().ToList();

            TheLoai templateTLS = new TheLoai();

            templateTLS.maLoaiSach = txtMaLoaiSach.Text;
            templateTLS.tenLoaiSach = txtTenLoaiSach.Text;

            collection.InsertOne(templateTLS);

            txtMaLoaiSach.Text = "";
            txtTenLoaiSach.Text = "";
            MessageBox.Show("Insert thành công");
        }
    }
}
