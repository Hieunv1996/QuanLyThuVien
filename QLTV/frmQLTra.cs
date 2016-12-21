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
    public partial class frmQLTra : Form
    {
        PhieuTraDLL objpt = new PhieuTraDLL();
        CTPTDLL objctpt = new CTPTDLL();

        public frmQLTra()
        {
            InitializeComponent();
        }

        private void frmQLTra_Load(object sender, EventArgs e)
        {
            binDataPT("", "", "");
            binDataCTPT("", "", "");
        }
        void binDataPT(string t, string w, string o)
        {
            List<PhieuTra> lst = new List<PhieuTra>();
            lst = objpt.getAll(t, w, o);
            dgvPT.DataSource = lst;
            dgvPT.Columns[0].HeaderText = "Mã Phiếu Trả";
            dgvPT.Columns[1].HeaderText = "Mã Độc Giả";
            dgvPT.Columns[2].HeaderText = "Ngày Trả";
            dgvPT.Columns[3].HeaderText = "Thành Tiền";
        }
        void binDataCTPT(string t, string w, string o)
        {
            List<CTPT> lst = new List<CTPT>();
            lst = objctpt.getAll(t, w, o);
            dgvCTPT.DataSource = lst;
            dgvCTPT.Columns[0].HeaderText = "Mã CTPT";
            dgvCTPT.Columns[1].HeaderText = "Mã Phiếu Trả";
            dgvCTPT.Columns[2].HeaderText = "Mã Sách";
            dgvCTPT.Columns[3].HeaderText = "Thành Tiền";
        }
        void clearText()
        {
            txtTimKiemCTPT.Text = "";
            txtTimKiemPT.Text = "";
        }

        private void btnLamTuoi_Click(object sender, EventArgs e)
        {
            clearText();
            binDataCTPT("", "", "");
            binDataPT("", "", "");
        }

        private void btnTimKiemPT_Click(object sender, EventArgs e)
        {
            binDataPT("", "maPT = '" + txtTimKiemPT.Text + "'", ""); 
        }

        private void btnTimKiemCTPT_Click(object sender, EventArgs e)
        {
            binDataPT("", "maCTPT = '" + txtTimKiemCTPT.Text + "'", "");
        }

        private void dgvPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            binDataCTPT("", "maPT = '"+dgvPT.CurrentRow.Cells[0].Value.ToString()+"'", "");
        }

        private void dgvCTPT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            binDataPT("", "maPT = '" + dgvCTPT.CurrentRow.Cells[1].Value.ToString() + "'", "");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new frmTra().ShowDialog();
        }
    }
}
