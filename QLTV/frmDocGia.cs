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
    public partial class frmDocGia : Form
    {
        DocGiaDLL objdg = new DocGiaDLL();
        public frmDocGia()
        {
            InitializeComponent();
        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            binData("", "", "");
        }
        void binData(string t, string w, string o)
        {
            List<DocGia> lst = new List<DocGia>();
            lst = objdg.getAll(t, w, o);
            dgvDocGia.DataSource = lst;
            dgvDocGia.Columns[0].HeaderText = "Mã Độc Giả";
            dgvDocGia.Columns[1].HeaderText = "Tên Độc Giả";
            dgvDocGia.Columns[2].HeaderText = "Email";
            dgvDocGia.Columns[3].HeaderText = "Điện Thoại";
        }

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDocGia.Enabled = false;
            btnThem.Enabled = false;
            txtMaDocGia.Text = dgvDocGia.CurrentRow.Cells["maDocGia"].Value.ToString();
            txtTenDocGia.Text = dgvDocGia.CurrentRow.Cells["tenDocGia"].Value.ToString();
            txtEmail.Text = dgvDocGia.CurrentRow.Cells["email"].Value.ToString();
            txtDienThoai.Text = dgvDocGia.CurrentRow.Cells["dienThoai"].Value.ToString();
        }
        void clearText()
        {
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            txtMaDocGia.Text = "";
            txtTimKiem.Text = "";
            txtTenDocGia.Text = "";
            btnThem.Enabled = true;
            txtMaDocGia.Enabled = true;
        }
        private void btnLamTuoi_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DocGia data = new DocGia();
            data.MaDocGia = txtMaDocGia.Text;
            if (data.MaDocGia.Equals(""))
            {
                MessageBox.Show("Mã độc giả không được trống!");
                return;
            }
            data.TenDocGia = txtTenDocGia.Text;
            if (data.TenDocGia.Equals(""))
            {
                MessageBox.Show("Tên độc giả không được trống!");
                return;
            }
            data.Email = txtEmail.Text;
            data.DienThoai = txtDienThoai.Text;
            if (objdg.insertData(data))
            {
                clearText();
                MessageBox.Show("Thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show("Thêm mới không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int r = dgvDocGia.CurrentCell.RowIndex;
            if(r < 0)
            {
                MessageBox.Show("Chọn một bản ghi trước!");
                return;
            }
            string id = dgvDocGia.CurrentRow.Cells[0].Value.ToString();
            if(MessageBox.Show("Bạn muốn xóa bản ghi?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (objdg.deleteData(id))
                {
                    binData("", "", "");
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    MessageBox.Show("Xóa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int r = dgvDocGia.CurrentCell.RowIndex;
            if (r < 0)
            {
                MessageBox.Show("Chọn một bản ghi trước!");
                return;
            }
            string id = dgvDocGia.CurrentRow.Cells[0].Value.ToString();
            DocGia data = new DocGia();
            data.TenDocGia = txtTenDocGia.Text;
            if (data.TenDocGia.Equals(""))
            {
                MessageBox.Show("Tên độc giả không được trống!");
                return;
            }
            data.Email = txtEmail.Text;
            data.DienThoai = txtDienThoai.Text;
            data.MaDocGia = id;
            if (MessageBox.Show("Bạn muốn sửa bản ghi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (objdg.updateData(data))
                {
                    binData("", "", "");
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            String w = "tenDocGia like '%" + txtTimKiem.Text + "%'";
            binData("", w, "");
        }
    }
}
