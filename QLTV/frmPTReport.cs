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
    public partial class frmPTReport : Form
    {
        public frmPTReport(string maPT, string maDG, string thanhTien)
        {
            InitializeComponent();
            ReportParameter rp1 = new ReportParameter("maPT");
            rp1.Values.Add(maPT);
            rpPT.LocalReport.SetParameters(rp1);
            ReportParameter rp2 = new ReportParameter("thanhTien");
            rp2.Values.Add(thanhTien);
            rpPT.LocalReport.SetParameters(rp2);
            ReportParameter rp3 = new ReportParameter("maDG");
            rp3.Values.Add(maDG);
            rpPT.LocalReport.SetParameters(rp3);
            this.rpPT.RefreshReport();
        }

        private void frmPTReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLTVDataSet.tb_CTPT' table. You can move, or remove it, as needed.
            this.tb_CTPTTableAdapter.Fill(this.QLTVDataSet.tb_CTPT);

            this.rpPT.RefreshReport();
        }
    }
}
