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
    public partial class frmDoiMatKhau : Form
    {
        NguoiDungDLL obj = new NguoiDungDLL();
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            new frmHeThong().Show();
            this.Hide();
        }
        
        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (!txtmk1.Text.Equals(frmDangNhap.user.MatKhau))
            {
                MessageBox.Show("Mật khẩu cũ không đúng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmk1.Text = "";
                txtmk2.Text = "";
                txtmk3.Text = "";
                return;
            }else if (txtmk2.Text.Equals(""))
            {
                MessageBox.Show("Mật khẩu mới không được bỏ trống!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmk1.Text = "";
                txtmk2.Text = "";
                txtmk3.Text = "";
                return;
            }else if (!txtmk2.Text.Equals(txtmk3.Text))
            {
                MessageBox.Show("Mật khẩu mới không khớp nhau!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmk1.Text = "";
                txtmk2.Text = "";
                txtmk3.Text = "";
            }else if (txtmk2.Text.Equals(frmDangNhap.user.MatKhau))
            {
                MessageBox.Show("Mật khẩu mới phải khác mật khẩu hiện tại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmk1.Text = "";
                txtmk2.Text = "";
                txtmk3.Text = "";
            }else
            {
                NguoiDung data = new NguoiDung();
                data.TaiKhoan = frmDangNhap.user.TaiKhoan;
                data.MatKhau = txtmk2.Text;
                if (obj.updateData(data))
                {
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    MessageBox.Show("Đổi mật khẩu không thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Hide();
            }
        }
    }
}
