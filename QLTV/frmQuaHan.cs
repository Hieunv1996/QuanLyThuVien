using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    public partial class frmQuaHan : Form
    {
        public frmQuaHan()
        {
            InitializeComponent();
        }

        private void frmQuaHan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLTVDataSet.vw_QuaHan' table. You can move, or remove it, as needed.
            this.vw_QuaHanTableAdapter.Fill(this.QLTVDataSet.vw_QuaHan);

            this.reportViewer1.RefreshReport();
        }
    }
}
