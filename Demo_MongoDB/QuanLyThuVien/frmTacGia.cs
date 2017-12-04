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
using System.Collections;

namespace QuanLyThuVien
{
    public partial class frmTacGia : Form
    {
        public frmTacGia()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var db = Module.GetDatabase("QLTHUVIEN");
            var collection = db.GetCollection<TacGia>("TACGIA");

            TacGia tacGiaTemplate = new TacGia();
            tacGiaTemplate.maTacGia = txtMaTacGia.Text;
            tacGiaTemplate.hoTen = txtTenTacGia.Text;
           
            collection.InsertOne(tacGiaTemplate);
            txtMaTacGia.Text = "";
            txtTenTacGia.Text = "";
            MessageBox.Show("Insert thành công");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
