using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace QuanLyThuVien
{
    class TheLoai
    {
        public ObjectId id { get; set; }
        public string maLoaiSach { get; set; }
        public string tenLoaiSach { get; set; }
    }
}
