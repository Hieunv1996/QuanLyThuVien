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
        public static List<CTPT> lstctpt = new List<CTPT>();
        public frmQLTra()
        {
            InitializeComponent();
        }

        public string getIDPT()
        {
            string id = "PT";
            int a = 0;
            List<PhieuTra> lst = new List<PhieuTra>();
            lst = objpt.getAll("", "", "");
            try
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    if (int.Parse(lst[i].MaPhieuTra.Substring(2)) > a) a = int.Parse(lst[i].MaPhieuTra.Substring(2));
                }
            }
            catch { }
            return id + (a + 1);
        }
        public string getIDCTPT()
        {
            string id = "CTPT";
            int a = 0;
            List<CTPT> lst = new List<CTPT>();
            lst = objctpt.getAll("", "", "");
            try
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    if (int.Parse(lst[i].MaCTPT.Substring(4)) > a) a = int.Parse(lst[i].MaCTPT.Substring(4));
                }
            }
            catch { }
            return (id + (a + 1));
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int r = -1;
            try
            {
                r = dgvPT.CurrentCell.RowIndex;
            }
            catch { }
            if(r < 0)
            {
                MessageBox.Show("Chọn một phiếu trả trước!");
                return;
            }
            String id = dgvPT.CurrentRow.Cells[0].Value.ToString();
            bool check = false;
            if(MessageBox.Show("Bạn muốn xóa phiếu trả này?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                check = objctpt.deleteAllData(id);
                check = objpt.deleteData(id);
                if (check)
                {
                    binDataPT("", "", "");
                    binDataCTPT("", "", "");
                    MessageBox.Show("Xóa phiếu trả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa phiếu trả không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            new frmHeThong().Show();
            this.Hide();
        }

        private void frmQLTra_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            int r = -1;
            try
            {
                r = dgvPT.CurrentCell.RowIndex;
            }
            catch { }
            if (r < 0)
            {
                MessageBox.Show("Chọn một phiếu trả trước!");
                return;
            }
            new frmPTReport(dgvPT.CurrentRow.Cells[0].Value.ToString(), dgvPT.CurrentRow.Cells[1].Value.ToString(), dgvPT.CurrentRow.Cells[3].Value.ToString()).ShowDialog();
        }
    }
}
