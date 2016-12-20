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

        }

        private void frmHeThong_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn muốn thoát ứng dụng?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }else
            {
                e.Cancel = true;
            }
        }
    }
}
