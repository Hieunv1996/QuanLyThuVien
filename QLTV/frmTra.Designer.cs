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
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnThemPT = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmbMaDocGia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTenDocGia = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvHienThi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Location = new System.Drawing.Point(47, 72);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(106, 44);
            this.btnHuyBo.TabIndex = 0;
            this.btnHuyBo.Text = "Hủy Bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnThemPT
            // 
            this.btnThemPT.Location = new System.Drawing.Point(47, 9);
            this.btnThemPT.Name = "btnThemPT";
            this.btnThemPT.Size = new System.Drawing.Size(106, 44);
            this.btnThemPT.TabIndex = 0;
            this.btnThemPT.Text = "Tạo Phiếu Trả";
            this.btnThemPT.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(353, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 257);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnHuyBo);
            this.panel4.Controls.Add(this.btnThemPT);
            this.panel4.Location = new System.Drawing.Point(479, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(211, 119);
            this.panel4.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dgvHienThi);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 390);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cmbTenDocGia);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.cmbMaDocGia);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(469, 116);
            this.panel5.TabIndex = 2;
            // 
            // cmbMaDocGia
            // 
            this.cmbMaDocGia.FormattingEnabled = true;
            this.cmbMaDocGia.Location = new System.Drawing.Point(56, 52);
            this.cmbMaDocGia.Name = "cmbMaDocGia";
            this.cmbMaDocGia.Size = new System.Drawing.Size(133, 21);
            this.cmbMaDocGia.TabIndex = 0;
            this.cmbMaDocGia.SelectedIndexChanged += new System.EventHandler(this.cmbMaDocGia_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã KH";
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
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Thông tin";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // cmbTenDocGia
            // 
            this.cmbTenDocGia.FormattingEnabled = true;
            this.cmbTenDocGia.Location = new System.Drawing.Point(240, 52);
            this.cmbTenDocGia.Name = "cmbTenDocGia";
            this.cmbTenDocGia.Size = new System.Drawing.Size(186, 21);
            this.cmbTenDocGia.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chọn mã KH hoặc Tên KH";
            // 
            // dgvHienThi
            // 
            this.dgvHienThi.AllowUserToAddRows = false;
            this.dgvHienThi.AllowUserToDeleteRows = false;
            this.dgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThi.Location = new System.Drawing.Point(4, 160);
            this.dgvHienThi.Name = "dgvHienThi";
            this.dgvHienThi.ReadOnly = true;
            this.dgvHienThi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHienThi.Size = new System.Drawing.Size(343, 226);
            this.dgvHienThi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DS Sách Đang Mượn";
            this.label1.Click += new System.EventHandler(this.label6_Click);
            // 
            // frmTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 408);
            this.Controls.Add(this.panel1);
            this.Name = "frmTra";
            this.Text = "frmTra";
            this.Load += new System.EventHandler(this.frmTra_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnThemPT;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cmbTenDocGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMaDocGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvHienThi;
        private System.Windows.Forms.Label label1;
    }
}