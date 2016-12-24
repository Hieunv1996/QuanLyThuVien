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
    public partial class frmLoaiSach : Form
    {

        
        LoaiSachDLL objls = new LoaiSachDLL();
        public frmLoaiSach()
        {
            InitializeComponent();
        }

        private void frmLoaiSach_Load(object sender, EventArgs e)
        {
            binData("", "", "");
        }

        void binData(String t, String w, String o)
        {
            List<LoaiSach> lst = new List<LoaiSach>();
            lst = objls.getAll(t, w, o);
            dgvLoaiSach.DataSource = lst;
            dgvLoaiSach.Columns[0].HeaderText = "Mã Loại Sách";
            dgvLoaiSach.Columns[1].HeaderText = "Tên Loại Sách";
            dgvLoaiSach.Columns[2].HeaderText = "Mô Tả";
            dgvLoaiSach.Columns[2].Width = 260;
        }

        private void dgvLoaiSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Enabled = false;
            txtMaLoaiSach.Enabled = false;
            int r = dgvLoaiSach.CurrentCell.RowIndex;
            if(r < 0)
            {
                MessageBox.Show("Chọn một bản ghi trước!");
                return;
            }
            txtMaLoaiSach.Text = dgvLoaiSach.CurrentRow.Cells["maLoaiSach"].Value.ToString();
            txtTenLoaiSach.Text = dgvLoaiSach.CurrentRow.Cells["tenLoaiSach"].Value.ToString();
            txtMota.Text = dgvLoaiSach.CurrentRow.Cells["moTa"].Value.ToString();
        }

        void clearText()
        {
            txtMaLoaiSach.Text = "";
            txtTenLoaiSach.Text = "";
            txtMota.Text = "";
            btnThem.Enabled = true;
            txtTimKiem.Text = "";
            txtMaLoaiSach.Enabled = true;
        }

        private void btnLamTuoi_Click(object sender, EventArgs e)
        {
            clearText();
            binData("","","");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int r = dgvLoaiSach.CurrentCell.RowIndex;
            if (r < 0)
            {
                MessageBox.Show("Chọn một bản ghi trước!");
                return;
            }
            String id = dgvLoaiSach.CurrentRow.Cells[0].Value.ToString();
            if(MessageBox.Show("Bạn muốn xóa bản ghi?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (objls.deleteData(id))
                {
                    binData("", "", "");
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    MessageBox.Show("Xoá không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LoaiSach data = new LoaiSach();
            data.MaLoaiSach = txtMaLoaiSach.Text;
            if (data.MaLoaiSach.Equals(""))
            {
                MessageBox.Show("Mã loại sách không được trống!");
                return;
            }
            data.TenLoaiSach = txtTenLoaiSach.Text;
            if (data.TenLoaiSach.Equals(""))
            {
                MessageBox.Show("Tên loại sách không được trống!");
                return;
            }
            data.MoTa = txtMota.Text;
            if (objls.insertData(data))
            {
                binData("", "", "");
                MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show("Thêm mới không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int r = dgvLoaiSach.CurrentCell.RowIndex;
            if (r < 0)
            {
                MessageBox.Show("Chọn một bản ghi trước!");
                return;
            }
            String id = dgvLoaiSach.CurrentRow.Cells[0].Value.ToString();
            LoaiSach data = new LoaiSach();
            data.TenLoaiSach = txtTenLoaiSach.Text;
            data.MaLoaiSach = id;
            if (data.TenLoaiSach.Equals(""))
            {
                MessageBox.Show("Tên loại sách không được trống!");
                return;
            }
            data.MoTa = txtMota.Text;
            if(MessageBox.Show("Bạn muốn sửa bản ghi?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (objls.updateData(data))
                {
                    binData("", "", "");
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string w = "tenLoaiSach like '%" + txtTimKiem.Text + "%'";
            binData("", w, "");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new frmHeThong().Show();
            this.Hide();
        }

        private void frmLoaiSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
