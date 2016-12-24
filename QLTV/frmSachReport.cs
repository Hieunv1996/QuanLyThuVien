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
using Microsoft.Reporting.WinForms;

namespace QLTV
{
    public partial class frmSachReport : Form
    {
        List<LoaiSach> lst = new List<LoaiSach>();
        LoaiSachDLL obj = new LoaiSachDLL();
        public frmSachReport()
        {
            InitializeComponent();
        }

        private void frmSachReport_Load(object sender, EventArgs e)
        {
            binCmbLoaiSach();
            // TODO: This line of code loads data into the 'QLTVDataSet.vw_SachView' table. You can move, or remove it, as needed.
            this.vw_SachViewTableAdapter.Fill(this.QLTVDataSet.vw_SachView);

            this.rpSach.RefreshReport();
        }

        void binCmbLoaiSach()
        {
            LoaiSach item = new LoaiSach();
            lst = obj.getAll("", "", "");
            item.MaLoaiSach = "";
            item.TenLoaiSach = "<All>";
            lst.Insert(0, item);
            cmbLoaiSach.DataSource = lst;
            cmbLoaiSach.ValueMember = "maLoaiSach";
            cmbLoaiSach.DisplayMember = "tenLoaiSach";
        }
        private void btnLoc_Click(object sender, EventArgs e)
        {
            if(cmbLoaiSach.SelectedIndex >= 0)
            {
                    //ReportParameter rp = new ReportParameter("maLoaiSach");
                    //rp.Values.Add(cmbLoaiSach.SelectedValue.ToString());
                    //rpSach.LocalReport.SetParameters(rp);
                    //this.rpSach.RefreshReport();
            }
        }
    }
}
