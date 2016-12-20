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

namespace QLTV
{
    public partial class frmDangNhap : Form
    {
        NguoiDungDLL obj = new NguoiDungDLL();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (obj.getLogin(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                MessageBox.Show("Success!");
                new frmHeThong().Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Fail!");
            }
        }
    }
}
