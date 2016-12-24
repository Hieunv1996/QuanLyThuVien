namespace QLTV
{
    partial class frmSachReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tb_SachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLTVDataSet = new QLTV.QLTVDataSet();
            this.tb_SachTableAdapter = new QLTV.QLTVDataSetTableAdapters.tb_SachTableAdapter();
            this.vw_SachViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_SachViewTableAdapter = new QLTV.QLTVDataSetTableAdapters.vw_SachViewTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rpSach = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbLoaiSach = new System.Windows.Forms.ComboBox();
            this.btnLoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tb_SachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLTVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_SachViewBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_SachBindingSource
            // 
            this.tb_SachBindingSource.DataMember = "tb_Sach";
            this.tb_SachBindingSource.DataSource = this.QLTVDataSet;
            // 
            // QLTVDataSet
            // 
            this.QLTVDataSet.DataSetName = "QLTVDataSet";
            this.QLTVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_SachTableAdapter
            // 
            this.tb_SachTableAdapter.ClearBeforeFill = true;
            // 
            // vw_SachViewBindingSource
            // 
            this.vw_SachViewBindingSource.DataMember = "vw_SachView";
            this.vw_SachViewBindingSource.DataSource = this.QLTVDataSet;
            // 
            // vw_SachViewTableAdapter
            // 
            this.vw_SachViewTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rpSach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 482);
            this.panel1.TabIndex = 0;
            // 
            // rpSach
            // 
            this.rpSach.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.vw_SachViewBindingSource;
            this.rpSach.LocalReport.DataSources.Add(reportDataSource2);
            this.rpSach.LocalReport.ReportEmbeddedResource = "QLTV.rpSach.rdlc";
            this.rpSach.Location = new System.Drawing.Point(0, 0);
            this.rpSach.Name = "rpSach";
            this.rpSach.Size = new System.Drawing.Size(904, 482);
            this.rpSach.TabIndex = 0;
            // 
            // cmbLoaiSach
            // 
            this.cmbLoaiSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaiSach.FormattingEnabled = true;
            this.cmbLoaiSach.Location = new System.Drawing.Point(183, 21);
            this.cmbLoaiSach.Name = "cmbLoaiSach";
            this.cmbLoaiSach.Size = new System.Drawing.Size(285, 33);
            this.cmbLoaiSach.TabIndex = 1;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(495, 18);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(98, 43);
            this.btnLoc.TabIndex = 2;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // frmSachReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 555);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.cmbLoaiSach);
            this.Controls.Add(this.panel1);
            this.Name = "frmSachReport";
            this.Text = "Danh Sách Sách Thư Viện | Phần Mềm Quản Lý Thư Viện";
            this.Load += new System.EventHandler(this.frmSachReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_SachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLTVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_SachViewBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource tb_SachBindingSource;
        private QLTVDataSet QLTVDataSet;
        private QLTVDataSetTableAdapters.tb_SachTableAdapter tb_SachTableAdapter;
        private System.Windows.Forms.BindingSource vw_SachViewBindingSource;
        private QLTVDataSetTableAdapters.vw_SachViewTableAdapter vw_SachViewTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer rpSach;
        private System.Windows.Forms.ComboBox cmbLoaiSach;
        private System.Windows.Forms.Button btnLoc;
    }
}