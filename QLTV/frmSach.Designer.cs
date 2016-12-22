namespace QLTV
{
    partial class frmSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSach));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nbSoLuongTon = new System.Windows.Forms.NumericUpDown();
            this.nbNamXuatBan = new System.Windows.Forms.NumericUpDown();
            this.nbGiaBia = new System.Windows.Forms.NumericUpDown();
            this.cmbLoaiSach = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLamTuoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbSoLuongTon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbNamXuatBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbGiaBia)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.nbSoLuongTon);
            this.panel1.Controls.Add(this.nbNamXuatBan);
            this.panel1.Controls.Add(this.nbGiaBia);
            this.panel1.Controls.Add(this.cmbLoaiSach);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTacGia);
            this.panel1.Controls.Add(this.txtTieuDe);
            this.panel1.Controls.Add(this.txtMaSach);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 441);
            this.panel1.TabIndex = 0;
            // 
            // nbSoLuongTon
            // 
            this.nbSoLuongTon.Location = new System.Drawing.Point(19, 334);
            this.nbSoLuongTon.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nbSoLuongTon.Name = "nbSoLuongTon";
            this.nbSoLuongTon.Size = new System.Drawing.Size(174, 20);
            this.nbSoLuongTon.TabIndex = 7;
            // 
            // nbNamXuatBan
            // 
            this.nbNamXuatBan.Location = new System.Drawing.Point(19, 275);
            this.nbNamXuatBan.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nbNamXuatBan.Name = "nbNamXuatBan";
            this.nbNamXuatBan.Size = new System.Drawing.Size(174, 20);
            this.nbNamXuatBan.TabIndex = 5;
            // 
            // nbGiaBia
            // 
            this.nbGiaBia.Location = new System.Drawing.Point(19, 160);
            this.nbGiaBia.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nbGiaBia.Name = "nbGiaBia";
            this.nbGiaBia.Size = new System.Drawing.Size(174, 20);
            this.nbGiaBia.TabIndex = 5;
            // 
            // cmbLoaiSach
            // 
            this.cmbLoaiSach.FormattingEnabled = true;
            this.cmbLoaiSach.Location = new System.Drawing.Point(19, 395);
            this.cmbLoaiSach.Name = "cmbLoaiSach";
            this.cmbLoaiSach.Size = new System.Drawing.Size(174, 21);
            this.cmbLoaiSach.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Loại Sách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Số Lượng Tồn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Năm Xuất Bản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tác Giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giá Bìa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tiêu Đề";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Sách";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(19, 215);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(174, 20);
            this.txtTacGia.TabIndex = 2;
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Location = new System.Drawing.Point(19, 104);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(174, 20);
            this.txtTieuDe.TabIndex = 2;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(19, 45);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(174, 20);
            this.txtMaSach.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.dgvSach);
            this.panel2.Location = new System.Drawing.Point(239, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 441);
            this.panel2.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(211, 24);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(409, 20);
            this.txtTimKiem.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(644, 11);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 44);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AllowUserToDeleteRows = false;
            this.dgvSach.AllowUserToOrderColumns = true;
            this.dgvSach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(4, 77);
            this.dgvSach.MultiSelect = false;
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(741, 364);
            this.dgvSach.TabIndex = 0;
            this.dgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.btnLamTuoi);
            this.panel3.Controls.Add(this.btnQuayLai);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Location = new System.Drawing.Point(13, 460);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(971, 54);
            this.panel3.TabIndex = 1;
            // 
            // btnLamTuoi
            // 
            this.btnLamTuoi.Location = new System.Drawing.Point(74, 3);
            this.btnLamTuoi.Name = "btnLamTuoi";
            this.btnLamTuoi.Size = new System.Drawing.Size(75, 44);
            this.btnLamTuoi.TabIndex = 3;
            this.btnLamTuoi.Text = "Làm Tươi";
            this.btnLamTuoi.UseVisualStyleBackColor = true;
            this.btnLamTuoi.Click += new System.EventHandler(this.btnLamTuoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(611, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 44);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(412, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 44);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(230, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 44);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(794, 3);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(75, 44);
            this.btnQuayLai.TabIndex = 3;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // frmSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 514);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSach";
            this.Text = "Quản Lý Sách | Phần Mềm Quản Lý Thư Viện";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSach_FormClosing);
            this.Load += new System.EventHandler(this.frmSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbSoLuongTon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbNamXuatBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbGiaBia)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamTuoi;
        private System.Windows.Forms.NumericUpDown nbSoLuongTon;
        private System.Windows.Forms.NumericUpDown nbNamXuatBan;
        private System.Windows.Forms.NumericUpDown nbGiaBia;
        private System.Windows.Forms.ComboBox cmbLoaiSach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Button btnQuayLai;
    }
}