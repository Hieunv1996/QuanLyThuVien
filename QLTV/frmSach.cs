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
    public partial class frmSach : Form
    {
        

        SachDLL objs = new SachDLL();
        LoaiSachDLL objls = new LoaiSachDLL();
        public frmSach()
        {
            InitializeComponent();
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            binData("", "", "");
            binCmbLoaiSach();

        }

        void binData(String t, String w, String o)
        {
            List<Sach> lsts = new List<Sach>();
            lsts = objs.getAll(t, w, o);
            dgvSach.DataSource = lsts;
            dgvSach.Columns[0].HeaderText = "Mã Sách";
            dgvSach.Columns[1].HeaderText = "Tiêu Đề";
            dgvSach.Columns[2].HeaderText = "Giá Bìa";
            dgvSach.Columns[3].HeaderText = "Tác Giả";
            dgvSach.Columns[4].HeaderText = "Năm Xuất Bản";
            dgvSach.Columns[5].HeaderText = "Số Lượng Tồn";
            dgvSach.Columns[6].HeaderText = "Loại Sách";
        }
        void binCmbLoaiSach()
        {
            List<LoaiSach> lstls = new List<LoaiSach>();
            lstls = objls.getAll("", "", "");
            cmbLoaiSach.DataSource = lstls;
            cmbLoaiSach.ValueMember = "maLoaiSach";
            cmbLoaiSach.DisplayMember = "tenLoaiSach";
            cmbLoaiSach.SelectedIndex = -1;
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Enabled = false;
            txtMaSach.Enabled = false;
            txtMaSach.Text = dgvSach.CurrentRow.Cells["MaSach"].Value.ToString();
            txtTieuDe.Text = dgvSach.CurrentRow.Cells["TieuDe"].Value.ToString();
            nbGiaBia.Value = Convert.ToInt64(dgvSach.CurrentRow.Cells["giaBia"].Value.ToString());
            txtTacGia.Text = dgvSach.CurrentRow.Cells["TacGia"].Value.ToString();
            nbNamXuatBan.Value = Convert.ToInt64(dgvSach.CurrentRow.Cells["namXuatBan"].Value.ToString());
            nbSoLuongTon.Value = Convert.ToInt64(dgvSach.CurrentRow.Cells["soLuongTon"].Value.ToString());
            cmbLoaiSach.SelectedValue = dgvSach.CurrentRow.Cells["MaLoaiSach"].Value.ToString();
        }

        void clearText()
        {
            txtMaSach.Text = "";
            txtTacGia.Text = "";
            txtTieuDe.Text = "";
            txtTimKiem.Text = "";
            nbGiaBia.Value = 0;
            nbNamXuatBan.Value = 0;
            nbSoLuongTon.Value = 0;
            cmbLoaiSach.SelectedIndex = -1;
        }
        private void btnLamTuoi_Click(object sender, EventArgs e)
        {
            clearText();
            btnThem.Enabled = true;
            txtMaSach.Enabled = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            String w = "tieuDe like '%" + txtTimKiem.Text + "%'";
            binData("", w, "");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int r = dgvSach.CurrentCell.RowIndex;
            if(r < 0)
            {
                MessageBox.Show("Chọn một bản ghi trước!");
                return;
            }
            String id = dgvSach.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn muốn xóa bản ghi?","Cảnh báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (objs.deleteData(id))
                {
                    MessageBox.Show("Xóa thành công!");
                    binData("", "", "");
                }else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Sach data = new Sach();
            data.MaSach = txtMaSach.Text;
            if (data.MaSach.Equals(""))
            {
                MessageBox.Show("Mã sách không được trống!");
                return;
            }
            data.TieuDe = txtTieuDe.Text;
            if (data.TieuDe.Equals(""))
            {
                MessageBox.Show("Tiêu đề không được trống!");
                return;
            }
            data.TacGia = txtTacGia.Text;
            if (data.TacGia.Equals(""))
            {
                MessageBox.Show("Tác giả không được trống!");
                return;
            }
            data.GiaBia = (int)nbGiaBia.Value;
            if(data.GiaBia <= 0)
            {
                MessageBox.Show("Giá bìa phải là số dương!");
                return;
            }
            data.MaLoaiSach = cmbLoaiSach.SelectedValue.ToString();
            if(cmbLoaiSach.SelectedIndex < 0)
            {
                MessageBox.Show("Cần chọn một loại sách!");
                return;
            }
            data.SoLuongTon = (int)nbSoLuongTon.Value;
            data.NamXuatBan = (int)nbNamXuatBan.Value;
            if (objs.insertData(data))
            {
                MessageBox.Show("Thêm mới thành công!");
                binData("", "", "");
            }else
            {
                MessageBox.Show("Thêm mới thất bại!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int r = dgvSach.CurrentCell.RowIndex;
            if(r < 0)
            {
                MessageBox.Show("Chọn một bản ghi trước!");
                return;
            }
            String id = dgvSach.CurrentRow.Cells[0].Value.ToString();
            Sach data = new Sach();
            data.TieuDe = txtTieuDe.Text;
            if (data.TieuDe.Equals(""))
            {
                MessageBox.Show("Tiêu đề không được trống!");
                return;
            }
            data.TacGia = txtTacGia.Text;
            if (data.TacGia.Equals(""))
            {
                MessageBox.Show("Tác giả không được trống!");
                return;
            }
            data.GiaBia = (int)nbGiaBia.Value;
            if (data.GiaBia <= 0)
            {
                MessageBox.Show("Giá bìa phải là số dương!");
                return;
            }
            data.MaLoaiSach = cmbLoaiSach.SelectedValue.ToString();
            if (cmbLoaiSach.SelectedIndex < 0)
            {
                MessageBox.Show("Cần chọn một loại sách!");
                return;
            }
            data.SoLuongTon = (int)nbSoLuongTon.Value;
            data.NamXuatBan = (int)nbNamXuatBan.Value;
            data.MaSach = id;
            if(MessageBox.Show("Bạn muốn sửa bản ghi?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (objs.updateData(data))
                {
                    binData("", "", "");
                    MessageBox.Show("Sửa thành công","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            new frmHeThong().Show();
            this.Hide();
        }

        private void frmSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            new frmSachReport().ShowDialog();
        }
    }
}
