using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace QuanLyThuVien
{
    class User
    {
        public ObjectId id { get; set; }
        public string maUser { get; set; }
        public string userName { get; set; }
        public string passWord { get; set; }
    }
}
