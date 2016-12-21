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
    public partial class frmMuon : Form
    {
        SachDLL objs = new SachDLL();
        DocGiaDLL objdg = new DocGiaDLL();
        PhieuMuonDLL objpm = new PhieuMuonDLL();
        CTPMDLL objctpm = new CTPMDLL();

        List<CTPM> lstctpm = new List<CTPM>();
        List<string> lstms = new List<string>();

        frmQLMuon frmqlm = new frmQLMuon();

        bool isEdit = false;


        public frmMuon()
        {
            InitializeComponent();
        }
        public frmMuon(bool _isEdit)
        {
            InitializeComponent();
            isEdit = _isEdit;
            int l = frmQLMuon.lstctpm.Count;
            for (int i = 0;i < l; i++)
            {
                lstctpm.Add(frmQLMuon.lstctpm[i]);
                lstms.Add(frmQLMuon.lstctpm[i].MaSach);
            }
            btnThemPM.Text = "Sửa Phiếu Mượn";
            binDataView();
        }

        private void frmMuon_Load(object sender, EventArgs e)
        {
            if(!isEdit) dtpkNgayTra.MinDate = DateTime.Today;
            binCmbSach();
            binCmbDocGia();
        }

        void binCmbSach()
        {
            List<Sach> lst = new List<Sach>();
            lst = objs.getAll("", "", "");
            cmbMaSach.DataSource = lst;
            cmbMaSach.DisplayMember = "tieuDe";
            cmbMaSach.ValueMember = "maSach";
            cmbMaSach.SelectedIndex = -1;
        }
        void binCmbDocGia()
        {
            List<DocGia> lst = new List<DocGia>();
            lst = objdg.getAll("", "", "");
            cmbDocGia.DataSource = lst;
            cmbDocGia.DisplayMember = "tenDocGia";
            cmbDocGia.ValueMember = "maDocGia";
            cmbDocGia.SelectedIndex = -1;
            if (isEdit) cmbDocGia.SelectedValue = frmQLMuon.idDocGia;
        }

        void binDataView()
        {
            dgvHienThi.DataSource = lstctpm;
            dgvHienThi.Columns[0].Visible = false;
            dgvHienThi.Columns[1].Visible = false;
            dgvHienThi.Columns[2].HeaderText = "Mã Sách";
            dgvHienThi.Columns[3].HeaderText = "Ngày Trả";
            dgvHienThi.Columns[4].HeaderText = "Tiền Cọc";
        }
        void clearText()
        {
            cmbMaSach.SelectedIndex = -1;
            nbTienCoc.Value = 0;
            dtpkNgayTra.Value = DateTime.Today;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            CTPM data = new CTPM();
            if(cmbMaSach.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn sách!");
                return;
            }
            data.MaSach = cmbMaSach.SelectedValue.ToString();
            for (int i = 0; i < lstms.Count; i++)
            {
                if (data.MaSach.Equals(lstms[i]))
                {
                    MessageBox.Show("Không thể mượn 2 cuốn sách cùng loại!");
                    return;
                }
            }
            data.NgayTra = dtpkNgayTra.Value.ToShortDateString();
            data.TienCoc = (int)nbTienCoc.Value;
            lstms.Add(data.MaSach);
            lstctpm.Add(data);
            dgvHienThi.DataSource = null;
            binDataView();
            clearText();
        }

        private void dgvHienThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cmbMaSach.SelectedValue = dgvHienThi.CurrentRow.Cells["maSach"].Value.ToString();
            }
            catch { }
            DateTime date = DateTime.ParseExact(dgvHienThi.CurrentRow.Cells["ngayTra"].Value.ToString().Substring(0,10), "MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            dtpkNgayTra.Value = date;
            nbTienCoc.Value = int.Parse(dgvHienThi.CurrentRow.Cells["tienCoc"].Value.ToString());
        }

        private void btnThemPM_Click(object sender, EventArgs e)
        {
            if(lstctpm.Count == 0)
            {
                MessageBox.Show("Dữ liệu trống!");
                return;
            }
            if(cmbDocGia.SelectedIndex < 0)
            {
                MessageBox.Show("Chọn 1 độc giả!");
                return;
            }
            if (!isEdit)
            {
                string idPM = frmqlm.getIDPM();
                PhieuMuon pm = new PhieuMuon();
                pm.MaPM = idPM;
                pm.NgayMuon = DateTime.Now.ToShortDateString();
                pm.MaDocGia = cmbDocGia.SelectedValue.ToString();
                pm.ThanhTien = 0;
                int l = lstctpm.Count;
                for (int i = 0; i < l; i++)
                {
                    pm.ThanhTien += lstctpm[i].TienCoc;
                }

                objpm.insertData(pm);
                bool check = false;
                for (int i = 0; i < l; i++)
                {
                    lstctpm[i].MaCTPM = frmqlm.getIDCTPM();
                    lstctpm[i].MaPM = idPM;
                    //MessageBox.Show(lstctpm[i].MaCTPM + " " + lstctpm[i].MaSach + " " + lstctpm[i].NgayTra + " " + lstctpm[i].TienCoc);
                    check = objctpm.insertData(lstctpm[i]);
                }
                if (check)
                {
                    MessageBox.Show("Tạo phiếu mượn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tạo phiếu mượn không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }else
            {
                //isEdit
                String idPM = frmQLMuon.lstctpm[0].MaPM;
                PhieuMuon pm = new PhieuMuon();
                pm.MaPM = idPM;
                pm.MaDocGia = cmbDocGia.SelectedValue.ToString();
                pm.ThanhTien = 0;
                int l = lstctpm.Count;
                for(int i = 0;i < l; i++)
                {
                    pm.ThanhTien += lstctpm[i].TienCoc;
                }
                bool check = false;
                check = objpm.updateData(pm);
                if (check)
                {
                    for(int i = 0;i < l; i++)
                    {
                        check = false;
                        for(int j = 0;j < frmQLMuon.lstctpm.Count; j++)
                        {
                            if (lstctpm[i].MaSach.Equals(frmQLMuon.lstctpm[j].MaSach))
                            {
                                lstctpm[i].MaCTPM = frmQLMuon.lstctpm[j].MaCTPM;
                                //MessageBox.Show(lstctpm[i].MaCTPM + " " + lstctpm[i].MaPM + " " + lstctpm[i].MaSach + " " + lstctpm[i].NgayTra + " " + lstctpm[i].TienCoc);
                                check = objctpm.updateData(lstctpm[i]);
                                //MessageBox.Show(check.ToString());
                                frmQLMuon.lstctpm.RemoveAt(j);
                                break;
                            }
                        }
                        if (!check)
                        {
                            lstctpm[i].MaCTPM = frmqlm.getIDCTPM();
                            lstctpm[i].MaPM = idPM;
                            check = objctpm.insertData(lstctpm[i]);
                        }

                    }
                    for(int i = 0;i < frmQLMuon.lstctpm.Count; i++)
                    {
                        check = objctpm.deleteData(frmQLMuon.lstctpm[i].MaCTPM);
                    }
                    if (check)
                    {
                        MessageBox.Show("Sửa phiếu mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else
                    {
                        MessageBox.Show("Sửa phiếu mượn không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            this.Hide();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int r = -1;
            try
            {
                r = dgvHienThi.CurrentCell.RowIndex;
            }
            catch { }
            if (r < 0)
            {
                MessageBox.Show("Chọn một bản ghi trước!");
                return;
            }
            string maS = dgvHienThi.CurrentRow.Cells[2].Value.ToString();
            for(int i = 0;i < lstms.Count; i++)
            {
                if (lstms[i].Equals(maS))
                {
                    lstms.RemoveAt(i);
                    break;
                }
            }
            for(int i = 0;i < lstctpm.Count; i++)
            {
                if (lstctpm[i].MaSach.Equals(maS))
                {
                    lstctpm.RemoveAt(i);
                    break;
                }
            }
            dgvHienThi.DataSource = null;
            binDataView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int r = -1;
            try
            {
                r = dgvHienThi.CurrentCell.RowIndex;
            }
            catch { }
            if (r < 0)
            {
                MessageBox.Show("Chọn một bản ghi trước!");
                return;
            }
            lstms.Remove(dgvHienThi.CurrentRow.Cells[2].Value.ToString());
            CTPM data = new CTPM();
            data.MaSach = cmbMaSach.SelectedValue.ToString();
            if(cmbMaSach.SelectedIndex < 0)
            {
                MessageBox.Show("Chọn sách trước!");
                return;
            }
            for (int i = 0; i < lstms.Count; i++)
            {
                if (data.MaSach.Equals(lstms[i]))
                {
                    MessageBox.Show("Không thể mượn 2 cuốn sách cùng loại!");
                    return;
                }
            }
            data.NgayTra = dtpkNgayTra.Value.ToShortDateString();
            data.TienCoc = (int)nbTienCoc.Value;
            String maSach = dgvHienThi.CurrentRow.Cells[2].Value.ToString();
            int l = lstctpm.Count;
            for(int i = 0;i < l; i++)
            {
                if (lstctpm[i].MaSach.Equals(maSach))
                {
                    lstctpm[i].MaSach = data.MaSach;
                    lstctpm[i].NgayTra = data.NgayTra;
                    lstctpm[i].TienCoc = data.TienCoc;
                    break;
                }
            }
            lstms.Add(data.MaSach);
            dgvHienThi.DataSource = null;
            binDataView();
        }
    }
}
