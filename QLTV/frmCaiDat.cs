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
    public partial class frmCaiDat : Form
    {
        public static int phatQH = 1000;
        public frmCaiDat()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            phatQH = (int)nbPhatQuaHan.Value;
            MessageBox.Show("Thay đổi thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
