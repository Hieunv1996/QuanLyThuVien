namespace QLTV
{
    partial class frmCaiDat
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
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.nbPhatQuaHan = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nbPhatQuaHan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(29, 184);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(75, 44);
            this.btnXacNhan.TabIndex = 0;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Location = new System.Drawing.Point(167, 184);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(75, 44);
            this.btnHuyBo.TabIndex = 0;
            this.btnHuyBo.Text = "Hủy Bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // nbPhatQuaHan
            // 
            this.nbPhatQuaHan.Location = new System.Drawing.Point(70, 115);
            this.nbPhatQuaHan.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nbPhatQuaHan.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nbPhatQuaHan.Name = "nbPhatQuaHan";
            this.nbPhatQuaHan.Size = new System.Drawing.Size(172, 20);
            this.nbPhatQuaHan.TabIndex = 1;
            this.nbPhatQuaHan.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phạt Quá Hạn/Ngày";
            // 
            // frmCaiDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nbPhatQuaHan);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnXacNhan);
            this.Name = "frmCaiDat";
            this.Text = "Cài Đặt | Phần Mềm Quản Lý Thư Viện";
            ((System.ComponentModel.ISupportInitialize)(this.nbPhatQuaHan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.NumericUpDown nbPhatQuaHan;
        private System.Windows.Forms.Label label1;
    }
}