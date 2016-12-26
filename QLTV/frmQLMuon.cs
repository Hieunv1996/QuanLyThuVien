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
    public partial class frmQLMuon : Form
    {

        

        PhieuMuonDLL objpm = new PhieuMuonDLL();
        CTPMDLL objctpm = new CTPMDLL();

        public static List<CTPM> lstctpm = new List<CTPM>();
        public static string idDocGia = "";

        public frmQLMuon()
        {
            InitializeComponent();
        }

        private void frmQLMuon_Load(object sender, EventArgs e)
        {
            binDataCTPM("", "", "");
            binDataPM("", "", "");
        }
        void binDataPM(string t, string w, string o)
        {
            List<PhieuMuon> lstpm = new List<PhieuMuon>();
            lstpm = objpm.getAll(t, w, o);
            dgvPhieuMuon.DataSource = lstpm;
            dgvPhieuMuon.Columns[0].HeaderText = "Mã Phiếu Mượn";
            dgvPhieuMuon.Columns[0].DataPropertyName = "maPM";
            dgvPhieuMuon.Columns[1].HeaderText = "Mã Độc Giả";
            dgvPhieuMuon.Columns[1].DataPropertyName = "maDocGia";
            dgvPhieuMuon.Columns[2].HeaderText = "Ngày Mượn";
            dgvPhieuMuon.Columns[2].DataPropertyName = "ngayMuon";
            dgvPhieuMuon.Columns[3].HeaderText = "Thành Tiền";
            dgvPhieuMuon.Columns[3].DataPropertyName = "thanhTien";
        }
        void binDataCTPM(string t, string w, string o)
        {
            List<CTPM> lstctpm = new List<CTPM>();
            lstctpm = objctpm.getAll(t, w, o);
            dgvCTPM.DataSource = lstctpm;
            dgvCTPM.Columns[0].HeaderText = "Mã CTPM";
            dgvCTPM.Columns[1].HeaderText = "Mã Phiếu Mượn";
            dgvCTPM.Columns[2].HeaderText = "Mã Sách";
            dgvCTPM.Columns[3].HeaderText = "Ngày Trả";
            dgvCTPM.Columns[4].HeaderText = "Tiền Cọc";
        }

        public String getIDPM()
        {
            String s = "PM";
            List<PhieuMuon> lst = new List<PhieuMuon>();
            lst = objpm.getAll("", "", "");
            int a = 0,l = lst.Count;
            for(int i = 0;i < l;i++)
            {
                try
                {
                    if (int.Parse(lst[i].MaPM.Substring(2)) > a) a = int.Parse(lst[i].MaPM.Substring(2));
                }
                catch { }
            }
            return (s + (a+1));
        }

        public String getIDCTPM()
        {
            String s = "CTPM";
            List<CTPM> lst = new List<CTPM>();
            lst = objctpm.getAll("", "", "");
            int a = 0, l = lst.Count;
            for (int i = 0; i < l; i++)
            {
                try
                {
                    if (int.Parse(lst[i].MaCTPM.Substring(4)) > a) a = int.Parse(lst[i].MaCTPM.Substring(4));
                }
                catch { }
            }
            return (s + (a + 1));
        }

        private void btnTimKiemCTPM_Click(object sender, EventArgs e)
        {
            binDataCTPM("", "maCTPM = '" + txtTimKiemCTPM.Text + "'","");
        }

        private void dgvPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String id = dgvPhieuMuon.CurrentRow.Cells[0].Value.ToString();
            binDataCTPM("", "maPM = '" + id + "'", "");
        }

        private void btnTimKiemPM_Click(object sender, EventArgs e)
        {
            binDataPM("", "maPM = '" + txtTimKiemPM.Text + "'", "");
        }

        void clearText()
        {
            txtTimKiemCTPM.Text = "";
            txtTimKiemPM.Text = "";
            binDataCTPM("", "", "");
            binDataPM("", "", "");
        }
        private void btnLamTuoi_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int r = dgvPhieuMuon.CurrentCell.RowIndex;
            if(r < 0)
            {
                MessageBox.Show("Chọn một bản ghi trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String id = dgvPhieuMuon.CurrentRow.Cells[0].Value.ToString();
            if(MessageBox.Show("Bạn muốn xóa phiếu mượn?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                objctpm.deleteAllData(id);
                if (objpm.deleteData(id))
                {
                    binDataPM("", "", "");
                    binDataCTPM("", "", "");
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new frmMuon().ShowDialog();
            binDataCTPM("", "", "");
            binDataPM("", "", "");
        }

        private void dgvCTPM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String id = dgvCTPM.CurrentRow.Cells[1].Value.ToString();
            binDataPM("", "maPM = '" + id + "'", "");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int r = dgvPhieuMuon.CurrentCell.RowIndex;
            if (r < 0)
            {
                MessageBox.Show("Chọn một bản ghi trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String id = dgvPhieuMuon.CurrentRow.Cells[0].Value.ToString();
            lstctpm = objctpm.getAll("", "maPM = '" + id + "'", "");
            idDocGia = dgvPhieuMuon.CurrentRow.Cells[1].Value.ToString();
            new frmMuon(true).ShowDialog();
            binDataCTPM("", "", "");
            binDataPM("", "", "");
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            new frmHeThong().Show();
            this.Hide();
        }

        private void frmQLMuon_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            int r = dgvPhieuMuon.CurrentCell.RowIndex;
            if (r < 0)
            {
                MessageBox.Show("Chọn một bản ghi trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string maPM = dgvPhieuMuon.CurrentRow.Cells[0].Value.ToString();
            string maDG = dgvPhieuMuon.CurrentRow.Cells[1].Value.ToString();
            string thanhTien = dgvPhieuMuon.CurrentRow.Cells[3].Value.ToString();
            new frmPMReport(maDG, thanhTien, maPM).ShowDialog();
        }

        private void btnQH_Click(object sender, EventArgs e)
        {
            new frmQuaHan().ShowDialog();
        }
    }
}
