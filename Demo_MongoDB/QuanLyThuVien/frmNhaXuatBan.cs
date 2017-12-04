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

namespace QuanLyThuVien
{
    public partial class frmNhaXuatBan : Form
    {
        public frmNhaXuatBan()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var db = Module.GetDatabase("QLTHUVIEN");
            var collection = db.GetCollection<NhaXuatBan>("NHAXUATBAN");

            NhaXuatBan nhaXuatBanTemplate = new NhaXuatBan();

            nhaXuatBanTemplate.maNhaXuatBan = txtMaNXB.Text;
            nhaXuatBanTemplate.tenNhaXuatBan = txtTenNXB.Text;
            nhaXuatBanTemplate.thanhPho = txtDiaChiNXB.Text;
            nhaXuatBanTemplate.ngayThanhLap = dtpkNXB_NgayThanhLap.Value;

            collection.InsertOne(nhaXuatBanTemplate);
            txtMaNXB.Text = "";
            txtTenNXB.Text = "";
            txtDiaChiNXB.Text = "";
            MessageBox.Show("Insert thành công");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
