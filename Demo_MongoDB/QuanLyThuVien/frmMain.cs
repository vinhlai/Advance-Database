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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            LoadGridControl_Sach();
            LoadGridControl_LoaiSach();
            LoadGridControl_NXB();
            LoadGridControl_NgonNgu();
        }
        /*********************************************
         *********************************************
         Tab 1: Sách
         ********************************************* 
         *********************************************/
        private void btnSach_Them_Click(object sender, EventArgs e)
        {
            frmQuanLySach frmQLSach = new frmQuanLySach();
            frmQLSach.ShowDialog();
        }

        private void btnSach_Sua_Click(object sender, EventArgs e)
        {
            //Sach sachTemplate = new Sach();
            //var filter = Builders<Sach>.Filter
            //gridControlSach.
            
        }

        private void btnSach_Xoa_Click(object sender, EventArgs e)
        {
            var db = Module.GetDatabase("QLTHUVIEN");
            var collection_Sach = db.GetCollection<Sach>("SACH");
            var query_Sach = collection_Sach.AsQueryable<Sach>().Select(p => new { p.id });
        }

        public void LoadGridControl_Sach()
        {
            var db = Module.GetDatabase("QLTHUVIEN");            
            var collection_Sach = db.GetCollection<Sach>("SACH");
            var query_Sach = collection_Sach.AsQueryable<Sach>().Select
                    (p => new { p.tenSach, p.tenTacGia, p.soTrang, p.soLuong,
                                p.ngonNgu, p.theLoai, p.nhaXuatBan, p.tinhTrang,
                                p.giaCa, p.ngayNhap});
            gridControlSach.DataSource = query_Sach;
        }
        /*********************************************
        *********************************************
        Tab 2: Thể Loại Sách
        ********************************************* 
        *********************************************/
        private void btnTheLoai_Xoa_Click(object sender, EventArgs e)
        {
            
        }

        public void LoadGridControl_LoaiSach()
        {
            var db = Module.GetDatabase("QLTHUVIEN");
            var collection_loaiSach = db.GetCollection<TheLoai>("LOAISACH");
            var query_loaiSach = collection_loaiSach.AsQueryable<TheLoai>().ToList();
            gridControlLoaiSach.DataSource = query_loaiSach;
        }

        private void btnTheLoai_Them_Click(object sender, EventArgs e)
        {
            frmTheLoaiSach frmtlSach = new frmTheLoaiSach();
            frmtlSach.ShowDialog(this);
        }

        /*********************************************
       *********************************************
       Tab 3: Tác Giả
       ********************************************* 
       *********************************************/
        private void btnTacGia_Them_Click(object sender, EventArgs e)
        {
            frmTacGia frmtacGia = new frmTacGia();
            frmtacGia.ShowDialog(this);
        }

        public void LoadGridControl_TacGia()
        {
            var db = Module.GetDatabase("QLTHUVIEN");
            var collection_tenTacGia = db.GetCollection<TacGia>("TACGIA");
            var query_tenTacGia = collection_tenTacGia.AsQueryable<TacGia>().ToList();
            gridControlTenTacGia.DataSource = query_tenTacGia;
        }
        /*********************************************
        *********************************************
        Tab 4: Nhà Xuất Bản
        ********************************************* 
        *********************************************/
        private void btnNXB_Them_Click(object sender, EventArgs e)
        {
            frmNhaXuatBan frmNXB = new frmNhaXuatBan();
            frmNXB.ShowDialog(this);
        }
        
        public void LoadGridControl_NXB()
        {
            var db = Module.GetDatabase("QLTHUVIEN");

            var collection_NXB = db.GetCollection<NhaXuatBan>("NHAXUATBAN");
            var query_NXB = collection_NXB.AsQueryable<NhaXuatBan>().ToList();
            gridControlTenNXB.DataSource = query_NXB;
        }
        /*********************************************
        *********************************************
        Tab 5: Ngôn Ngữ
        ********************************************* 
        *********************************************/
        private void btnNgonNgu_Them_Click(object sender, EventArgs e)
        {
            frmNgonNgu frmNgonNgu = new frmNgonNgu();
            frmNgonNgu.ShowDialog(this);
        }

        public void LoadGridControl_NgonNgu()
        {
            var db = Module.GetDatabase("QLTHUVIEN");
            var collection_NgonNgu = db.GetCollection<NgonNgu>("NGONNGU");
            var query_NgonNgu = collection_NgonNgu.AsQueryable<NgonNgu>().ToList();
            gridControlTenNgonNgu.DataSource = query_NgonNgu;
        }

      
    }
}
