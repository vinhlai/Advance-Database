using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace QuanLyThuVien
{
    class NhaXuatBan
    {
        public ObjectId id { get; set; }
        public string maNhaXuatBan { get; set; }
        public string tenNhaXuatBan { get; set; }
        public DateTime ngayThanhLap { get; set; }
        public string thanhPho { get; set; }
    }
}
