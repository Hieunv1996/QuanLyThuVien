using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QLTV
{
    public partial class frmPMReport : Form
    {
        public frmPMReport(string maDG, string thanhTien,string maPM)
        {
            InitializeComponent();
            ReportParameter rp1 = new ReportParameter("maPM");
            rp1.Values.Add(maPM);
            rpPM.LocalReport.SetParameters(rp1);
            ReportParameter rp2 = new ReportParameter("thanhTien");
            rp2.Values.Add(thanhTien);
            rpPM.LocalReport.SetParameters(rp2);
            ReportParameter rp3 = new ReportParameter("maDG");
            rp3.Values.Add(maDG);
            rpPM.LocalReport.SetParameters(rp3);
            this.rpPM.RefreshReport();
        }

        private void frmPMReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLTVDataSet.tb_CTPM' table. You can move, or remove it, as needed.
            this.tb_CTPMTableAdapter.Fill(this.QLTVDataSet.tb_CTPM);

            this.rpPM.RefreshReport();
        }
    }
}
