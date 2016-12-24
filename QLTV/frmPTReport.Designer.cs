namespace QLTV
{
    partial class frmPTReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rpPT = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLTVDataSet = new QLTV.QLTVDataSet();
            this.tb_CTPTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_CTPTTableAdapter = new QLTV.QLTVDataSetTableAdapters.tb_CTPTTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLTVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CTPTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rpPT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 451);
            this.panel1.TabIndex = 0;
            // 
            // rpPT
            // 
            this.rpPT.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.tb_CTPTBindingSource;
            this.rpPT.LocalReport.DataSources.Add(reportDataSource3);
            this.rpPT.LocalReport.ReportEmbeddedResource = "QLTV.rpPT.rdlc";
            this.rpPT.Location = new System.Drawing.Point(0, 0);
            this.rpPT.Name = "rpPT";
            this.rpPT.Size = new System.Drawing.Size(827, 451);
            this.rpPT.TabIndex = 0;
            // 
            // QLTVDataSet
            // 
            this.QLTVDataSet.DataSetName = "QLTVDataSet";
            this.QLTVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_CTPTBindingSource
            // 
            this.tb_CTPTBindingSource.DataMember = "tb_CTPT";
            this.tb_CTPTBindingSource.DataSource = this.QLTVDataSet;
            // 
            // tb_CTPTTableAdapter
            // 
            this.tb_CTPTTableAdapter.ClearBeforeFill = true;
            // 
            // frmPTReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 451);
            this.Controls.Add(this.panel1);
            this.Name = "frmPTReport";
            this.Text = "Phiếu Trả Sách | Phần Mềm Quản Lý Thư Viện";
            this.Load += new System.EventHandler(this.frmPTReport_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QLTVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CTPTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer rpPT;
        private System.Windows.Forms.BindingSource tb_CTPTBindingSource;
        private QLTVDataSet QLTVDataSet;
        private QLTVDataSetTableAdapters.tb_CTPTTableAdapter tb_CTPTTableAdapter;
    }
}