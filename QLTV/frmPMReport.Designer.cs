namespace QLTV
{
    partial class frmPMReport
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
            this.rpPM = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLTVDataSet = new QLTV.QLTVDataSet();
            this.tb_CTPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_CTPMTableAdapter = new QLTV.QLTVDataSetTableAdapters.tb_CTPMTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLTVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CTPMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rpPM);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 485);
            this.panel1.TabIndex = 0;
            // 
            // rpPM
            // 
            this.rpPM.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "dsPM";
            reportDataSource3.Value = this.tb_CTPMBindingSource;
            this.rpPM.LocalReport.DataSources.Add(reportDataSource3);
            this.rpPM.LocalReport.ReportEmbeddedResource = "QLTV.rpPM.rdlc";
            this.rpPM.Location = new System.Drawing.Point(0, 0);
            this.rpPM.Name = "rpPM";
            this.rpPM.Size = new System.Drawing.Size(850, 485);
            this.rpPM.TabIndex = 0;
            // 
            // QLTVDataSet
            // 
            this.QLTVDataSet.DataSetName = "QLTVDataSet";
            this.QLTVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_CTPMBindingSource
            // 
            this.tb_CTPMBindingSource.DataMember = "tb_CTPM";
            this.tb_CTPMBindingSource.DataSource = this.QLTVDataSet;
            // 
            // tb_CTPMTableAdapter
            // 
            this.tb_CTPMTableAdapter.ClearBeforeFill = true;
            // 
            // frmPMReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 485);
            this.Controls.Add(this.panel1);
            this.Name = "frmPMReport";
            this.Text = "Phiếu Mượn Sách | Phần Mềm Quản Lý Thư Viện";
            this.Load += new System.EventHandler(this.frmPMReport_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QLTVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_CTPMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer rpPM;
        private System.Windows.Forms.BindingSource tb_CTPMBindingSource;
        private QLTVDataSet QLTVDataSet;
        private QLTVDataSetTableAdapters.tb_CTPMTableAdapter tb_CTPMTableAdapter;
    }
}