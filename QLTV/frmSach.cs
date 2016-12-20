using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.Entity;
using QLTV.DLL;

namespace QLTV
{
    public partial class frmSach : Form
    {
        SachDLL objs = new SachDLL();
        public frmSach()
        {
            InitializeComponent();
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            binData("", "", "");
        }

        void binData(String t, String w, String o)
        {
            List<Sach> lsts = new List<Sach>();
            lsts = objs.getAll(t, w, o);
            dgvSach.DataSource = lsts;
            dgvSach.Columns[0].Name = "Mã Sách";
            dgvSach.Columns[1].Name = "Tiêu Đề";
            dgvSach.Columns[2].Name = "Giá Bìa";
            dgvSach.Columns[3].Name = "Tác Giả";
            dgvSach.Columns[4].Name = "Năm Xuất Bản";
            dgvSach.Columns[5].Name = "Số Lượng Tồn";
            dgvSach.Columns[6].Name = "Mã Loại Sách";
        }
        void binCmbLoaiSach()
        {

        }
    }
}
