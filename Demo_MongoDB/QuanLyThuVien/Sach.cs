using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using System.Drawing;

namespace QuanLyThuVien
{
    class Sach
    {
        public ObjectId id { get; set; }
        public string tenSach { get; set; }//
        public string tenTacGia { get; set; } //
        public int soTrang { get; set; }//
        public int soLuong { get; set; }
        public string ngonNgu { get; set; }//
        public string theLoai { get; set; }//       
        public NhaXuatBan nhaXuatBan { get; set; }//
        public Boolean tinhTrang { get; set; }
        public string giaCa { get; set; }// chưa xử lý kiểu tiền tệ
        public DateTime ngayNhap { get; set; }//

        //public byte[] hinhSach { get; set; }//    
        public ObjectId ImageId { get; set; }                
    }
}
