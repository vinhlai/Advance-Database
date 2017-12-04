using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace QuanLyThuVien
{
    class NgonNgu
    {
        public ObjectId id { get; set; }
        public string maNgonNgu { get; set; }
        public string tenNgonNgu { get; set; }
    }
}
