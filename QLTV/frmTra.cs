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
        CTPTDLL objctpt = new CTPTDLL();
        CTPMDLL objctpm = new CTPMDLL();
        DocGiaDLL objdg = new DocGiaDLL();
        List<CTPM> lst = new List<CTPM>();
        public frmTra()
        {
            InitializeComponent();
        }

        private void frmTra_Load(object sender, EventArgs e)
        {
            binDataDG();
        }
        void binDataDG()
        {
            List<DocGia> lst = objdg.getAll("", "", "");
            cmbMaDocGia.DataSource = lst;
            cmbTenDocGia.DataSource = lst;
            cmbMaDocGia.ValueMember = "maDocGia";
            cmbTenDocGia.ValueMember = "maDocGia";
            cmbMaDocGia.DisplayMember = "maDocGia";
            cmbTenDocGia.DisplayMember = "tenDocGia";
            cmbMaDocGia.SelectedIndex = -1;
            cmbTenDocGia.SelectedIndex = -1;
        }

        void binDataView(String maKH)
        {
            lst = objctpm.getCTPM(maKH);
            dgvHienThi.DataSource = lst;
        }
        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbMaDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbMaDocGia.SelectedIndex >= 0)
                binDataView(cmbMaDocGia.SelectedValue.ToString());
        }
    }
}
