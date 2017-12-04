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
using MongoDB.Driver.GridFS;
using System.IO;

namespace QuanLyThuVien
{
    public partial class frmQuanLySach : Form
    {
        public frmQuanLySach()
        {
            InitializeComponent();
            LoadData();
            
        }

        public void LoadData()
        {
            LoadCombobox_TenTacGia();
            LoadCombobox_NhaXuatBan();
            LoadCombobox_TheLoaiSach();
            LoadCombobox_NgonNgu();
            //test load hình
            //GridFSBucket gbucket = new GridFSBucket(db);
        }

        public void LoadCombobox_TenTacGia()
        {
            var db = Module.GetDatabase("QLTHUVIEN");
            var collection = db.GetCollection<TacGia>("TACGIA");
            var query = collection.AsQueryable<TacGia>().ToList();

            cbQLSach_TenTacGia.DataSource = query;
            cbQLSach_TenTacGia.DisplayMember = "HOTEN";
            cbQLSach_TenTacGia.ValueMember = "MATACGIA";
        }

        public void LoadCombobox_NhaXuatBan()
        {
            var db = Module.GetDatabase("QLTHUVIEN");
            var collection = db.GetCollection<NhaXuatBan>("NHAXUATBAN");
            var query = collection.AsQueryable<NhaXuatBan>().ToList();

            cbQLSach_NhaXuatBan.DataSource = query;
            cbQLSach_NhaXuatBan.DisplayMember = "TENNHAXUATBAN";
            cbQLSach_NhaXuatBan.ValueMember = "MANHAXUATBAN";
        }

        public void LoadCombobox_TheLoaiSach()
        {
            var db = Module.GetDatabase("QLTHUVIEN");
            var collection = db.GetCollection<TheLoai>("LOAISACH");
            var query = collection.AsQueryable<TheLoai>().ToList();

            cbQLSach_TheLoai.DataSource = query;
            cbQLSach_TheLoai.DisplayMember = "tenLoaiSach";
            cbQLSach_TheLoai.ValueMember = "maLoaiSach";
        }

        public void LoadCombobox_NgonNgu()
        {
            var db = Module.GetDatabase("QLTHUVIEN");
            var collection = db.GetCollection<NgonNgu>("NGONNGU");
            var query = collection.AsQueryable<NgonNgu>().ToList();

            cbQLSach_NgonNgu.DataSource = query;
            cbQLSach_NgonNgu.DisplayMember = "TENNGONNGU";
            cbQLSach_NgonNgu.ValueMember = "MANGONNGU";
        }
        private void btnQLSach_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQLSach_OK_Click(object sender, EventArgs e)
        {
            var db = Module.GetDatabase("QLTHUVIEN");
            var collection = db.GetCollection<Sach>("SACH");

            Sach sachTemplate = new Sach();

            sachTemplate.tenSach = txtQLSach_TenSach.Text;
            sachTemplate.soTrang = Convert.ToInt32(Math.Round(nudQLSach_SoTrang.Value,0));
            sachTemplate.giaCa = txtQLSach_Gia.Text; //chưa xử lý kiểu tiền tệ
            sachTemplate.soLuong = Convert.ToInt32(Math.Round(nudQLSach_SoLuong.Value, 0));
            sachTemplate.tenTacGia = cbQLSach_TenTacGia.Text;
            //sachTempte.nhaXuatBan.tenNhaXuatBan = cbQLSach_NhaXuatBan.Text; Chưa xử lý nhà xuất bản
            //chua xu ly tinh trang
            sachTemplate.theLoai = cbQLSach_TheLoai.Text;
            sachTemplate.ngonNgu = cbQLSach_NgonNgu.Text;
            sachTemplate.ngayNhap = dtpkQLSach_NgayNhap.Value;

            //Xử lý hình ảnh
            GridFSBucket gbucket = new GridFSBucket(db);
            var id = gbucket.UploadFromBytes("filename", File.ReadAllBytes(@pbQLSach_Hinh.ImageLocation));
            sachTemplate.ImageId = id;

            collection.InsertOne(sachTemplate);
            txtQLSach_TenSach.Text = "";
            nudQLSach_SoTrang.Value = 0;
            txtQLSach_Gia.Text = "";
            MessageBox.Show("Insert thành công");
        }

        private void btnQLSach_LoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Bitmaps|*.bmp|jpeps|*.jpg";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbQLSach_Hinh.Image = Bitmap.FromFile(openFileDialog.FileName);
                pbQLSach_Hinh.ImageLocation = openFileDialog.FileName;
            }
        }
    }
}
