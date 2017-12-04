using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace QuanLyThuVien
{
    class TacGia
    {
        public ObjectId id { get; set; }
        public string maTacGia { get; set; }
        public string hoTen { get; set; }
    }
}
