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

        bool formClose = true;
        public frmHeThong()
        {
            InitializeComponent();
        }

        private void frmHeThong_Load(object sender, EventArgs e)
        {

        }

        private void frmHeThong_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formClose)
            {
                formClose = false;
                if (MessageBox.Show("Bạn muốn đóng phần mềm?", "Thông báo!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                    formClose = true;
                }
            }
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
    }
}
