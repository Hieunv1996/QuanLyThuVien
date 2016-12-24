namespace QLTV
{
    partial class frmQLMuon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLMuon));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimKiemPM = new System.Windows.Forms.TextBox();
            this.btnTimKiemPM = new System.Windows.Forms.Button();
            this.dgvPhieuMuon = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTimKiemCTPM = new System.Windows.Forms.TextBox();
            this.btnTimKiemCTPM = new System.Windows.Forms.Button();
            this.dgvCTPM = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamTuoi = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPM)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.txtTimKiemPM);
            this.panel1.Controls.Add(this.btnTimKiemPM);
            this.panel1.Controls.Add(this.dgvPhieuMuon);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 418);
            this.panel1.TabIndex = 0;
            // 
            // txtTimKiemPM
            // 
            this.txtTimKiemPM.Location = new System.Drawing.Point(22, 43);
            this.txtTimKiemPM.Name = "txtTimKiemPM";
            this.txtTimKiemPM.Size = new System.Drawing.Size(250, 20);
            this.txtTimKiemPM.TabIndex = 2;
            // 
            // btnTimKiemPM
            // 
            this.btnTimKiemPM.Location = new System.Drawing.Point(297, 33);
            this.btnTimKiemPM.Name = "btnTimKiemPM";
            this.btnTimKiemPM.Size = new System.Drawing.Size(75, 38);
            this.btnTimKiemPM.TabIndex = 1;
            this.btnTimKiemPM.Text = "Tìm Kiếm";
            this.btnTimKiemPM.UseVisualStyleBackColor = true;
            this.btnTimKiemPM.Click += new System.EventHandler(this.btnTimKiemPM_Click);
            // 
            // dgvPhieuMuon
            // 
            this.dgvPhieuMuon.AllowUserToAddRows = false;
            this.dgvPhieuMuon.AllowUserToDeleteRows = false;
            this.dgvPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuMuon.Location = new System.Drawing.Point(4, 105);
            this.dgvPhieuMuon.Name = "dgvPhieuMuon";
            this.dgvPhieuMuon.ReadOnly = true;
            this.dgvPhieuMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuMuon.Size = new System.Drawing.Size(452, 310);
            this.dgvPhieuMuon.TabIndex = 0;
            this.dgvPhieuMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuMuon_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.txtTimKiemCTPM);
            this.panel2.Controls.Add(this.btnTimKiemCTPM);
            this.panel2.Controls.Add(this.dgvCTPM);
            this.panel2.Location = new System.Drawing.Point(478, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 418);
            this.panel2.TabIndex = 0;
            // 
            // txtTimKiemCTPM
            // 
            this.txtTimKiemCTPM.Location = new System.Drawing.Point(74, 43);
            this.txtTimKiemCTPM.Name = "txtTimKiemCTPM";
            this.txtTimKiemCTPM.Size = new System.Drawing.Size(320, 20);
            this.txtTimKiemCTPM.TabIndex = 2;
            // 
            // btnTimKiemCTPM
            // 
            this.btnTimKiemCTPM.Location = new System.Drawing.Point(433, 33);
            this.btnTimKiemCTPM.Name = "btnTimKiemCTPM";
            this.btnTimKiemCTPM.Size = new System.Drawing.Size(75, 38);
            this.btnTimKiemCTPM.TabIndex = 1;
            this.btnTimKiemCTPM.Text = "Tìm Kiếm";
            this.btnTimKiemCTPM.UseVisualStyleBackColor = true;
            this.btnTimKiemCTPM.Click += new System.EventHandler(this.btnTimKiemCTPM_Click);
            // 
            // dgvCTPM
            // 
            this.dgvCTPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPM.Location = new System.Drawing.Point(3, 105);
            this.dgvCTPM.MultiSelect = false;
            this.dgvCTPM.Name = "dgvCTPM";
            this.dgvCTPM.ReadOnly = true;
            this.dgvCTPM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTPM.Size = new System.Drawing.Size(549, 310);
            this.dgvCTPM.TabIndex = 0;
            this.dgvCTPM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTPM_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.btnXuat);
            this.panel3.Controls.Add(this.btnQuayLai);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.btnLamTuoi);
            this.panel3.Location = new System.Drawing.Point(13, 438);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1020, 61);
            this.panel3.TabIndex = 0;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(849, 6);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(75, 48);
            this.btnQuayLai.TabIndex = 1;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(520, 6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 48);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(353, 6);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 48);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(197, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 48);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLamTuoi
            // 
            this.btnLamTuoi.Location = new System.Drawing.Point(54, 6);
            this.btnLamTuoi.Name = "btnLamTuoi";
            this.btnLamTuoi.Size = new System.Drawing.Size(75, 48);
            this.btnLamTuoi.TabIndex = 1;
            this.btnLamTuoi.Text = "&Làm Tươi";
            this.btnLamTuoi.UseVisualStyleBackColor = true;
            this.btnLamTuoi.Click += new System.EventHandler(this.btnLamTuoi_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(686, 6);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(75, 46);
            this.btnXuat.TabIndex = 2;
            this.btnXuat.Text = "Xuất Phiếu Mượn";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // frmQLMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 502);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQLMuon";
            this.Text = "Quản Lý Mượn Sách | Phần Mềm Quản Lý Thư Viện";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQLMuon_FormClosing);
            this.Load += new System.EventHandler(this.frmQLMuon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPM)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTimKiemPM;
        private System.Windows.Forms.Button btnTimKiemPM;
        private System.Windows.Forms.DataGridView dgvPhieuMuon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTimKiemCTPM;
        private System.Windows.Forms.Button btnTimKiemCTPM;
        private System.Windows.Forms.DataGridView dgvCTPM;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamTuoi;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnXuat;
    }
}