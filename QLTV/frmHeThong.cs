using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class frmHeThong : Form
    {

        
        public frmHeThong()
        {
            InitializeComponent();
        }

        private void frmHeThong_Load(object sender, EventArgs e)
        {
            lbXinChao.Text = frmDangNhap.user.TaiKhoan;
        }

        private void frmHeThong_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new frmQLMuon().Show();
            this.Hide();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnQLSach_Click(object sender, EventArgs e)
        {
            new frmSach().Visible = true;
            this.Hide();
        }

        private void btnQLDocGia_Click(object sender, EventArgs e)
        {
            new frmDocGia().Show();
            this.Hide();
        }

        private void btnQLLoaiSach_Click(object sender, EventArgs e)
        {
            new frmLoaiSach().Show();
            this.Hide();
        }

        private void btnQLTra_Click(object sender, EventArgs e)
        {
            new frmQLTra().Show();
            this.Hide();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            new frmDangNhap().Show();
            this.Hide();
        }

        private void lb1_Click(object sender, EventArgs e)
        {

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            new frmDoiMatKhau().ShowDialog();
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            new frmCaiDat().ShowDialog();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            new frmThongTin().ShowDialog();
        }
    }
}
