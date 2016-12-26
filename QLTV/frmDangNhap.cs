using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.DLL;
using QLTV.Entity;


namespace QLTV
{
    public partial class frmDangNhap : Form
    {
        

        NguoiDungDLL obj = new NguoiDungDLL();
        public static NguoiDung user = new NguoiDung();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (obj.getLogin(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                user.TaiKhoan = txtTaiKhoan.Text;
                user.MatKhau = txtMatKhau.Text;
                lbInfo.Text = "Đăng Nhập Thành Công!";
                MessageBox.Show("Bạn đã đăng nhập với tên " + txtTaiKhoan.Text + "!","Thông báo!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                new frmHeThong().Show();
                this.Hide();
            }
            else
            {
                lbInfo.Text = "Sai Tài Khoản hoặc Mật Khẩu";
                txtTaiKhoan.Text = "";
                txtMatKhau.Text = "";
                txtTaiKhoan.Focus();
                return;
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn muốn thoát phần mềm?", "Thoát phần mềm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
                Application.Exit();
        }

        private void lbInfo_Click(object sender, EventArgs e)
        {
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void ckbHienMK_CheckedChanged_1(object sender, EventArgs e)
        {
            if(ckbHienMK.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }
    }
}
