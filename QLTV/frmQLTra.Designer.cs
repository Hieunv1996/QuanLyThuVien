namespace QLTV
{
    partial class frmQLTra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLTra));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTimKiemCTPT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCTPT = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTimKiemPT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPT = new System.Windows.Forms.DataGridView();
            this.btnTimKiemPT = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamTuoi = new System.Windows.Forms.Button();
            this.btnTimKiemCTPT = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPT)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPT)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel1.Controls.Add(this.btnXuat);
            this.panel1.Controls.Add(this.btnQuayLai);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnLamTuoi);
            this.panel1.Location = new System.Drawing.Point(12, 404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 68);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.txtTimKiemCTPT);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnTimKiemCTPT);
            this.panel2.Controls.Add(this.dgvCTPT);
            this.panel2.Location = new System.Drawing.Point(468, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 386);
            this.panel2.TabIndex = 0;
            // 
            // txtTimKiemCTPT
            // 
            this.txtTimKiemCTPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemCTPT.Location = new System.Drawing.Point(66, 38);
            this.txtTimKiemCTPT.Name = "txtTimKiemCTPT";
            this.txtTimKiemCTPT.Size = new System.Drawing.Size(252, 23);
            this.txtTimKiemCTPT.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tìm Kiếm Theo Mã CTPT";
            // 
            // dgvCTPT
            // 
            this.dgvCTPT.AllowUserToAddRows = false;
            this.dgvCTPT.AllowUserToDeleteRows = false;
            this.dgvCTPT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCTPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPT.Location = new System.Drawing.Point(3, 93);
            this.dgvCTPT.MultiSelect = false;
            this.dgvCTPT.Name = "dgvCTPT";
            this.dgvCTPT.ReadOnly = true;
            this.dgvCTPT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTPT.Size = new System.Drawing.Size(448, 290);
            this.dgvCTPT.TabIndex = 0;
            this.dgvCTPT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTPT_CellClick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.txtTimKiemPT);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnTimKiemPT);
            this.panel3.Controls.Add(this.dgvPT);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(453, 386);
            this.panel3.TabIndex = 0;
            // 
            // txtTimKiemPT
            // 
            this.txtTimKiemPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemPT.Location = new System.Drawing.Point(60, 38);
            this.txtTimKiemPT.Name = "txtTimKiemPT";
            this.txtTimKiemPT.Size = new System.Drawing.Size(252, 23);
            this.txtTimKiemPT.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm Kiếm Theo Mã Phiếu Trả";
            // 
            // dgvPT
            // 
            this.dgvPT.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPT.Location = new System.Drawing.Point(3, 93);
            this.dgvPT.MultiSelect = false;
            this.dgvPT.Name = "dgvPT";
            this.dgvPT.ReadOnly = true;
            this.dgvPT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPT.Size = new System.Drawing.Size(447, 290);
            this.dgvPT.TabIndex = 0;
            this.dgvPT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPT_CellClick);
            // 
            // btnTimKiemPT
            // 
            this.btnTimKiemPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemPT.Image = global::QLTV.Properties.Resources.find;
            this.btnTimKiemPT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemPT.Location = new System.Drawing.Point(318, 29);
            this.btnTimKiemPT.Name = "btnTimKiemPT";
            this.btnTimKiemPT.Size = new System.Drawing.Size(94, 41);
            this.btnTimKiemPT.TabIndex = 0;
            this.btnTimKiemPT.Text = "Tìm Kiếm";
            this.btnTimKiemPT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemPT.UseVisualStyleBackColor = true;
            this.btnTimKiemPT.Click += new System.EventHandler(this.btnTimKiemPT_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Image = global::QLTV.Properties.Resources.back;
            this.btnQuayLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuayLai.Location = new System.Drawing.Point(729, 14);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(103, 48);
            this.btnQuayLai.TabIndex = 0;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QLTV.Properties.Resources.delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(404, 13);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 45);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::QLTV.Properties.Resources.add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(225, 14);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 45);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLamTuoi
            // 
            this.btnLamTuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamTuoi.Image = global::QLTV.Properties.Resources.refresh;
            this.btnLamTuoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamTuoi.Location = new System.Drawing.Point(41, 14);
            this.btnLamTuoi.Name = "btnLamTuoi";
            this.btnLamTuoi.Size = new System.Drawing.Size(106, 45);
            this.btnLamTuoi.TabIndex = 0;
            this.btnLamTuoi.Text = "Làm Tươi";
            this.btnLamTuoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamTuoi.UseVisualStyleBackColor = true;
            this.btnLamTuoi.Click += new System.EventHandler(this.btnLamTuoi_Click);
            // 
            // btnTimKiemCTPT
            // 
            this.btnTimKiemCTPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemCTPT.Image = global::QLTV.Properties.Resources.find;
            this.btnTimKiemCTPT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemCTPT.Location = new System.Drawing.Point(324, 29);
            this.btnTimKiemCTPT.Name = "btnTimKiemCTPT";
            this.btnTimKiemCTPT.Size = new System.Drawing.Size(96, 41);
            this.btnTimKiemCTPT.TabIndex = 0;
            this.btnTimKiemCTPT.Text = "Tìm Kiếm";
            this.btnTimKiemCTPT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiemCTPT.UseVisualStyleBackColor = true;
            this.btnTimKiemCTPT.Click += new System.EventHandler(this.btnTimKiemCTPT_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(582, 13);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(90, 45);
            this.btnXuat.TabIndex = 1;
            this.btnXuat.Text = "Xuất PT";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // frmQLTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 475);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQLTra";
            this.Text = "Quản Lý Trả Sách | Phần Mềm Quản Lý Thư Viện";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQLTra_FormClosing);
            this.Load += new System.EventHandler(this.frmQLTra_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPT)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvCTPT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvPT;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamTuoi;
        private System.Windows.Forms.TextBox txtTimKiemCTPT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiemCTPT;
        private System.Windows.Forms.TextBox txtTimKiemPT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiemPT;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnXuat;
    }
}