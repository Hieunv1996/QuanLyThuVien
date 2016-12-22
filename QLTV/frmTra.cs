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
    public partial class frmTra : Form
    {
        PhieuTraDLL objpt = new PhieuTraDLL();
        SachDLL objs = new SachDLL();
        CTPTDLL objctpt = new CTPTDLL();
        CTPMDLL objctpm = new CTPMDLL();
        DocGiaDLL objdg = new DocGiaDLL();
        PhieuMuonDLL objpm = new PhieuMuonDLL();
        List<CTPM> lst = new List<CTPM>();
        List<CTPM> lstctpm = new List<CTPM>();
        List<SachTra> lstctpt = new List<SachTra>();
        frmQLTra frm = new frmQLTra();
        public frmTra()
        {
            InitializeComponent();
        }

        private void frmTra_Load(object sender, EventArgs e)
        {
            binDataMaDG();
            binDataTenDG();
            binDataCmbSach();
        }
        void binDataMaDG()
        {
            List<DocGia> lst = objdg.getAll("", "", "");
            cmbMaDocGia.DataSource = lst;
            cmbMaDocGia.ValueMember = "maDocGia";
            cmbMaDocGia.DisplayMember = "maDocGia";
            cmbMaDocGia.SelectedIndex = -1;
        }
        void binDataTenDG()
        {
            List<DocGia> lst = objdg.getAll("", "", "");
            cmbTenDocGia.DataSource = lst;
            cmbTenDocGia.ValueMember = "maDocGia";
            cmbTenDocGia.DisplayMember = "tenDocGia";
            cmbTenDocGia.SelectedIndex = -1;
        }
        void binDataCmbSach()
        {
            List<Sach> lst = new List<Sach>();
            lst = objs.getAll("", "", "");
            cmbTieuDeSach.DataSource = lst;
            cmbTieuDeSach.ValueMember = "maSach";
            cmbTieuDeSach.DisplayMember = "tieuDe";
            cmbTieuDeSach.SelectedIndex = -1;
        }

        void binDataCTPM()
        {
            dgvSachMuon.DataSource = lstctpm;
            dgvSachMuon.Columns[0].Visible = false;
        }
        void binDataCTPT()
        {
            dgvSachTra.DataSource = lstctpt;
            dgvSachTra.Columns["maCTPM"].Visible = false;
        }
        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbMaDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaDocGia.SelectedIndex >= 0)
                cmbTenDocGia.SelectedValue = cmbMaDocGia.SelectedValue;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {

        }

        private void btnThemPT_Click(object sender, EventArgs e)
        {

        }

        private void dgvHienThi_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvHienThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = -1;
            try
            {
                r = dgvSachMuon.CurrentCell.RowIndex;
            }
            catch { }
            if(r < 0) { return; }
            cmbTieuDeSach.SelectedValue = dgvSachMuon.CurrentRow.Cells[2].Value.ToString();
            int dateDiff = objctpt.dateDiff(dgvSachMuon.CurrentRow.Cells[3].Value.ToString().Substring(0,10),DateTime.Today.ToShortDateString());

            if(dateDiff <= 0)
            {
                rdbKhong.Text = "Không";
            }else
            {
                rdbKhong.Text = "Quá hạn " + dateDiff + " ngày";
                nbPhatQuaHan.Value = dateDiff * 1000;
            }
        }

        private void cmbTenDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenDocGia.SelectedIndex >= 0)
                cmbMaDocGia.SelectedValue = cmbTenDocGia.SelectedValue;
            if (cmbMaDocGia.SelectedIndex >= 0)
            {
                //lstctpt.Clear();
                //clearAll();

                cmbTenDocGia.SelectedValue = cmbMaDocGia.SelectedValue;
                lstctpm = objctpm.getCTPM(cmbMaDocGia.SelectedValue.ToString());
                binDataCTPM();
                List<DocGia> lst = new List<DocGia>();
                lst = objdg.getAll("", "maDocGia = '" + cmbMaDocGia.SelectedValue.ToString() + "'", "");
                string s = "";
                if (lst.Count > 0)
                    s = "Mã Độc Giả: " + lst[0].MaDocGia + "\nTên Độc Giả: " + lst[0].TenDocGia + "\nEmail: " + lst[0].Email + "\nĐiện Thoại: " + lst[0].DienThoai + "\n\nSố Sách Đang Mượn: " + lstctpm.Count;
                lbInfo.Text = s;
            }
            else
                lbInfo.Text = "";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int r = -1;
            try
            {
                r = dgvSachMuon.CurrentCell.RowIndex;
            }
            catch { }
            if(r < 0 || cmbTieuDeSach.SelectedIndex < 0)
            {
                MessageBox.Show("Chọn sách trả trước!");
                return;
            }
            SachTra st = new SachTra();
            st.MaSach = cmbTieuDeSach.SelectedValue.ToString();
            st.PhatHuHong = (int)nbPhatHuHong.Value;
            st.PhatQuaHan = (int)nbPhatQuaHan.Value;
            st.ThanhTien = st.PhatQuaHan + st.PhatHuHong - int.Parse(dgvSachMuon.CurrentRow.Cells[4].Value.ToString());
            st.MaCTPM = dgvSachMuon.CurrentRow.Cells[0].Value.ToString();
            lstctpt.Add(st);
            String ctpm = dgvSachMuon.CurrentRow.Cells[0].Value.ToString();
            for(int i = 0;i < lstctpm.Count; i++)
            {
                if (lstctpm[i].MaCTPM.Equals(ctpm))
                {
                    MessageBox.Show(lstctpm[i].MaCTPM + " " + ctpm + " " + lstctpm.Count.ToString());
                    lstctpm.Remove(lstctpm[i]);
                    MessageBox.Show(lstctpm.Count.ToString());
                    break;
                }
            }
            int thanhTien = 0;
            for (int i = 0; i < lstctpt.Count; i++) thanhTien += lstctpt[i].ThanhTien;
            if(thanhTien < 0)
            { 
                lbTien.Text = "Số Sách Trả: " + lstctpt.Count + " - Trả Lại Độc Giả: " + thanhTien * (-1) + " VNĐ";
            }else
            {
                lbTien.Text = "Số Sách Trả: " + lstctpt.Count + " - Độc Giả Thanh Toán: " + thanhTien +" VNĐ";
            }
            dgvSachMuon.DataSource = null;
            dgvSachTra.DataSource = null;
            binDataCTPM();
            binDataCTPT();
            //cmbTieuDeSach.SelectedIndex = -1;
            //nbPhatHuHong.Value = 0;
            //nbPhatQuaHan.Value = 0;
            rdbKhong.Text = "Không";
        }
        void clearAll()
        {
            lstctpm.Clear();
            lstctpt.Clear();
            dgvSachMuon.DataSource = null;
            dgvSachTra.DataSource = null;
            binDataCTPM();
            binDataCTPT();
            cmbMaDocGia.SelectedIndex = -1;
            cmbTieuDeSach.SelectedIndex = -1;
            cmbTenDocGia.SelectedIndex = -1;
            nbPhatHuHong.Value = 0;
            nbPhatQuaHan.Value = 0;
            lbTien.Text = "";
        }
        private void btnTaoLai_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnTaoPT_Click(object sender, EventArgs e)
        {
            if(cmbMaDocGia.SelectedIndex < 0)
            {
                MessageBox.Show("Chọn mã độc giả trước!");
                return;
            }
            if(lstctpt.Count < 1)
            {
                MessageBox.Show("Dữ liệu trống!");
                return;
            }
            PhieuTra data = new PhieuTra();
            string idPT = frm.getIDPT();
            data.MaPhieuTra = idPT;
            data.MaDocGia = cmbMaDocGia.SelectedValue.ToString();
            data.NgayTra = DateTime.Today.ToShortDateString();
            data.ThanhTien = 0;
            for(int i = 0;i < lstctpt.Count; i++)
            {
                data.ThanhTien += lstctpt[i].ThanhTien;
            }
            bool check = false;
            check = objpt.insertData(data);

            String idPM = "";
            List<CTPM> temp = new List<CTPM>();

            for(int i = 0;i < lstctpt.Count; i++)
            {
                CTPT pt = new CTPT();
                pt.MaCTPT = frm.getIDCTPT();
                MessageBox.Show(pt.MaCTPT);
                pt.MaPhieuTra = idPT;
                pt.MaSach = lstctpt[i].MaSach;
                pt.ThanhTien = lstctpt[i].ThanhTien;
                temp = objctpm.getAll("", "maCTPM= '"+lstctpt[i].MaCTPM+"'", "");
                idPM = temp[0].MaPM;
                temp = objctpm.getAll("", "maPM= '" + idPM + "'", "");
                check = objctpt.insertData(pt);
                objctpm.deleteData(lstctpt[i].MaCTPM);
                if (temp.Count == 1)
                {
                    objpm.deleteData(idPM);
                }
            }
            if (check)
            {
                MessageBox.Show("Tạo phiếu trả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show("Tạo phiếu trả không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Hide();
        }

        private void btnHuyBo_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
