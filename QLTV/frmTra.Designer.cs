namespace QLTV
{
    partial class frmTra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTra));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmbTenDocGia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMaDocGia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSachMuon = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTieuDeSach = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nbPhatHuHong = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.rdbKhong = new System.Windows.Forms.RadioButton();
            this.nbPhatQuaHan = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvSachTra = new System.Windows.Forms.DataGridView();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btnTaoPT = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnTaoLai = new System.Windows.Forms.Button();
            this.lbTien = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbPhatHuHong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPhatQuaHan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachTra)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.lbInfo);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(601, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 147);
            this.panel3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Thông tin độc giả";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHuyBo);
            this.panel1.Controls.Add(this.btnTaoPT);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dgvSachTra);
            this.panel1.Controls.Add(this.dgvSachMuon);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 496);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel5.Controls.Add(this.btnTaoLai);
            this.panel5.Controls.Add(this.cmbTenDocGia);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.cmbMaDocGia);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(591, 53);
            this.panel5.TabIndex = 2;
            // 
            // cmbTenDocGia
            // 
            this.cmbTenDocGia.FormattingEnabled = true;
            this.cmbTenDocGia.Location = new System.Drawing.Point(219, 22);
            this.cmbTenDocGia.Name = "cmbTenDocGia";
            this.cmbTenDocGia.Size = new System.Drawing.Size(209, 21);
            this.cmbTenDocGia.TabIndex = 0;
            this.cmbTenDocGia.SelectedIndexChanged += new System.EventHandler(this.cmbTenDocGia_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Độc Giả";
            // 
            // cmbMaDocGia
            // 
            this.cmbMaDocGia.FormattingEnabled = true;
            this.cmbMaDocGia.Location = new System.Drawing.Point(37, 22);
            this.cmbMaDocGia.Name = "cmbMaDocGia";
            this.cmbMaDocGia.Size = new System.Drawing.Size(133, 21);
            this.cmbMaDocGia.TabIndex = 0;
            this.cmbMaDocGia.SelectedIndexChanged += new System.EventHandler(this.cmbMaDocGia_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Độc Giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DS Sách Đang Mượn";
            this.label1.Click += new System.EventHandler(this.label6_Click);
            // 
            // dgvSachMuon
            // 
            this.dgvSachMuon.AllowUserToAddRows = false;
            this.dgvSachMuon.AllowUserToDeleteRows = false;
            this.dgvSachMuon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachMuon.Location = new System.Drawing.Point(4, 176);
            this.dgvSachMuon.Name = "dgvSachMuon";
            this.dgvSachMuon.ReadOnly = true;
            this.dgvSachMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSachMuon.Size = new System.Drawing.Size(449, 210);
            this.dgvSachMuon.TabIndex = 0;
            this.dgvSachMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHienThi_CellClick);
            this.dgvSachMuon.Click += new System.EventHandler(this.dgvHienThi_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.btnXacNhan);
            this.panel2.Controls.Add(this.rdbKhong);
            this.panel2.Controls.Add(this.nbPhatQuaHan);
            this.panel2.Controls.Add(this.nbPhatHuHong);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cmbTieuDeSach);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(4, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 88);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tiêu Đề Sách";
            // 
            // cmbTieuDeSach
            // 
            this.cmbTieuDeSach.Cursor = System.Windows.Forms.Cursors.No;
            this.cmbTieuDeSach.FormattingEnabled = true;
            this.cmbTieuDeSach.Location = new System.Drawing.Point(11, 39);
            this.cmbTieuDeSach.Name = "cmbTieuDeSach";
            this.cmbTieuDeSach.Size = new System.Drawing.Size(187, 21);
            this.cmbTieuDeSach.TabIndex = 0;
            this.cmbTieuDeSach.SelectedIndexChanged += new System.EventHandler(this.cmbMaDocGia_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Phạt Hư Hỏng";
            // 
            // nbPhatHuHong
            // 
            this.nbPhatHuHong.Location = new System.Drawing.Point(219, 40);
            this.nbPhatHuHong.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.nbPhatHuHong.Name = "nbPhatHuHong";
            this.nbPhatHuHong.Size = new System.Drawing.Size(120, 20);
            this.nbPhatHuHong.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(358, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Quá Hạn";
            // 
            // rdbKhong
            // 
            this.rdbKhong.AutoSize = true;
            this.rdbKhong.Checked = true;
            this.rdbKhong.Cursor = System.Windows.Forms.Cursors.No;
            this.rdbKhong.Location = new System.Drawing.Point(361, 29);
            this.rdbKhong.Name = "rdbKhong";
            this.rdbKhong.Size = new System.Drawing.Size(56, 17);
            this.rdbKhong.TabIndex = 5;
            this.rdbKhong.TabStop = true;
            this.rdbKhong.Text = "Không";
            this.rdbKhong.UseVisualStyleBackColor = true;
            // 
            // nbPhatQuaHan
            // 
            this.nbPhatQuaHan.Cursor = System.Windows.Forms.Cursors.No;
            this.nbPhatQuaHan.Location = new System.Drawing.Point(361, 52);
            this.nbPhatQuaHan.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.nbPhatQuaHan.Name = "nbPhatQuaHan";
            this.nbPhatQuaHan.Size = new System.Drawing.Size(120, 20);
            this.nbPhatQuaHan.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(631, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "DS Sách Trả";
            this.label10.Click += new System.EventHandler(this.label6_Click);
            // 
            // dgvSachTra
            // 
            this.dgvSachTra.AllowUserToAddRows = false;
            this.dgvSachTra.AllowUserToDeleteRows = false;
            this.dgvSachTra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvSachTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachTra.Location = new System.Drawing.Point(450, 176);
            this.dgvSachTra.Name = "dgvSachTra";
            this.dgvSachTra.ReadOnly = true;
            this.dgvSachTra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSachTra.Size = new System.Drawing.Size(425, 210);
            this.dgvSachTra.TabIndex = 0;
            this.dgvSachTra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHienThi_CellClick);
            this.dgvSachTra.Click += new System.EventHandler(this.dgvHienThi_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(504, 29);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(75, 43);
            this.btnXacNhan.TabIndex = 6;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Location = new System.Drawing.Point(8, 30);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(67, 13);
            this.lbInfo.TabIndex = 4;
            this.lbInfo.Text = "__________";
            // 
            // btnTaoPT
            // 
            this.btnTaoPT.Location = new System.Drawing.Point(634, 417);
            this.btnTaoPT.Name = "btnTaoPT";
            this.btnTaoPT.Size = new System.Drawing.Size(75, 52);
            this.btnTaoPT.TabIndex = 6;
            this.btnTaoPT.Text = "Tạo Phiếu Trả";
            this.btnTaoPT.UseVisualStyleBackColor = true;
            this.btnTaoPT.Click += new System.EventHandler(this.btnTaoPT_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Location = new System.Drawing.Point(771, 417);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(75, 52);
            this.btnHuyBo.TabIndex = 6;
            this.btnHuyBo.Text = "Hủy Bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbTien);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(6, 392);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(589, 94);
            this.panel4.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 3;
            // 
            // btnTaoLai
            // 
            this.btnTaoLai.Location = new System.Drawing.Point(504, 6);
            this.btnTaoLai.Name = "btnTaoLai";
            this.btnTaoLai.Size = new System.Drawing.Size(75, 43);
            this.btnTaoLai.TabIndex = 6;
            this.btnTaoLai.Text = "Tạo Lại";
            this.btnTaoLai.UseVisualStyleBackColor = true;
            this.btnTaoLai.Click += new System.EventHandler(this.btnTaoLai_Click);
            // 
            // lbTien
            // 
            this.lbTien.AutoSize = true;
            this.lbTien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTien.Location = new System.Drawing.Point(21, 45);
            this.lbTien.Name = "lbTien";
            this.lbTien.Size = new System.Drawing.Size(68, 22);
            this.lbTien.TabIndex = 4;
            this.lbTien.Text = "label11";
            // 
            // frmTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 510);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTra";
            this.Text = "Thêm - Sửa Phiếu Trả | Phần Mềm Quản Lý Thư Viện";
            this.Load += new System.EventHandler(this.frmTra_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbPhatHuHong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbPhatQuaHan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachTra)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cmbTenDocGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMaDocGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nbPhatHuHong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTieuDeSach;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdbKhong;
        private System.Windows.Forms.DataGridView dgvSachMuon;
        private System.Windows.Forms.NumericUpDown nbPhatQuaHan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.DataGridView dgvSachTra;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnTaoPT;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnTaoLai;
        private System.Windows.Forms.Label lbTien;
    }
}