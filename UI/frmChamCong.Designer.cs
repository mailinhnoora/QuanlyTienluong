namespace QLL.UI
{
    partial class frmChamCong
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.nudNghiKhong = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudNghiPhep = new System.Windows.Forms.NumericUpDown();
            this.NghiPhep = new System.Windows.Forms.Label();
            this.nudThucTe = new System.Windows.Forms.NumericUpDown();
            this.label = new System.Windows.Forms.Label();
            this.nudChuanChi = new System.Windows.Forms.NumericUpDown();
            this.lebell = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThemLoat = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.nudNam = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudThang = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSoNV = new System.Windows.Forms.Label();
            this.dgvChamCong = new System.Windows.Forms.DataGridView();
            this.pnlTitle.SuspendLayout();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNghiKhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNghiPhep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThucTe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChuanChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(882, 60);
            this.pnlTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(297, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "CHẤM CÔNG NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInput
            // 
            this.pnlInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlInput.Controls.Add(this.btnXoa);
            this.pnlInput.Controls.Add(this.btnLuu);
            this.pnlInput.Controls.Add(this.nudNghiKhong);
            this.pnlInput.Controls.Add(this.label5);
            this.pnlInput.Controls.Add(this.nudNghiPhep);
            this.pnlInput.Controls.Add(this.NghiPhep);
            this.pnlInput.Controls.Add(this.nudThucTe);
            this.pnlInput.Controls.Add(this.label);
            this.pnlInput.Controls.Add(this.nudChuanChi);
            this.pnlInput.Controls.Add(this.lebell);
            this.pnlInput.Controls.Add(this.cboNhanVien);
            this.pnlInput.Controls.Add(this.label4);
            this.pnlInput.Controls.Add(this.btnThemLoat);
            this.pnlInput.Controls.Add(this.btnXem);
            this.pnlInput.Controls.Add(this.nudNam);
            this.pnlInput.Controls.Add(this.label3);
            this.pnlInput.Controls.Add(this.nudThang);
            this.pnlInput.Controls.Add(this.label2);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInput.Location = new System.Drawing.Point(0, 60);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(882, 105);
            this.pnlInput.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(68)))), ((int)(((byte)(55)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(790, 8);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(704, 8);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 30);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu ";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // nudNghiKhong
            // 
            this.nudNghiKhong.Location = new System.Drawing.Point(757, 55);
            this.nudNghiKhong.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudNghiKhong.Name = "nudNghiKhong";
            this.nudNghiKhong.Size = new System.Drawing.Size(50, 22);
            this.nudNghiKhong.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(675, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Không phép:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // nudNghiPhep
            // 
            this.nudNghiPhep.Location = new System.Drawing.Point(613, 55);
            this.nudNghiPhep.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudNghiPhep.Name = "nudNghiPhep";
            this.nudNghiPhep.Size = new System.Drawing.Size(50, 22);
            this.nudNghiPhep.TabIndex = 13;
            // 
            // NghiPhep
            // 
            this.NghiPhep.AutoSize = true;
            this.NghiPhep.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NghiPhep.Location = new System.Drawing.Point(540, 56);
            this.NghiPhep.Name = "NghiPhep";
            this.NghiPhep.Size = new System.Drawing.Size(79, 17);
            this.NghiPhep.TabIndex = 12;
            this.NghiPhep.Text = "Nghỉ phép: ";
            // 
            // nudThucTe
            // 
            this.nudThucTe.Location = new System.Drawing.Point(481, 55);
            this.nudThucTe.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudThucTe.Name = "nudThucTe";
            this.nudThucTe.Size = new System.Drawing.Size(50, 22);
            this.nudThucTe.TabIndex = 11;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(428, 56);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(56, 17);
            this.label.TabIndex = 10;
            this.label.Text = "Thực tế:";
            // 
            // nudChuanChi
            // 
            this.nudChuanChi.Location = new System.Drawing.Point(367, 55);
            this.nudChuanChi.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudChuanChi.Name = "nudChuanChi";
            this.nudChuanChi.Size = new System.Drawing.Size(50, 22);
            this.nudChuanChi.TabIndex = 9;
            this.nudChuanChi.Value = new decimal(new int[] {
            26,
            0,
            0,
            0});
            // 
            // lebell
            // 
            this.lebell.AutoSize = true;
            this.lebell.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lebell.Location = new System.Drawing.Point(320, 56);
            this.lebell.Name = "lebell";
            this.lebell.Size = new System.Drawing.Size(50, 17);
            this.lebell.TabIndex = 8;
            this.lebell.Text = "Chuẩn:";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(85, 52);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(220, 31);
            this.cboNhanVien.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nhân viên: ";
            // 
            // btnThemLoat
            // 
            this.btnThemLoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnThemLoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLoat.ForeColor = System.Drawing.Color.White;
            this.btnThemLoat.Location = new System.Drawing.Point(431, 7);
            this.btnThemLoat.Name = "btnThemLoat";
            this.btnThemLoat.Size = new System.Drawing.Size(110, 30);
            this.btnThemLoat.TabIndex = 5;
            this.btnThemLoat.Text = "Thêm loạt";
            this.btnThemLoat.UseVisualStyleBackColor = false;
            this.btnThemLoat.Click += new System.EventHandler(this.btnThemLoat_Click);
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(303, 7);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(110, 30);
            this.btnXem.TabIndex = 4;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // nudNam
            // 
            this.nudNam.Location = new System.Drawing.Point(198, 8);
            this.nudNam.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudNam.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudNam.Name = "nudNam";
            this.nudNam.Size = new System.Drawing.Size(75, 22);
            this.nudNam.TabIndex = 3;
            this.nudNam.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudNam.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Năm: ";
            // 
            // nudThang
            // 
            this.nudThang.Location = new System.Drawing.Point(67, 8);
            this.nudThang.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudThang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThang.Name = "nudThang";
            this.nudThang.Size = new System.Drawing.Size(75, 22);
            this.nudThang.TabIndex = 1;
            this.nudThang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tháng:";
            // 
            // lblSoNV
            // 
            this.lblSoNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.lblSoNV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSoNV.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNV.Location = new System.Drawing.Point(0, 525);
            this.lblSoNV.Name = "lblSoNV";
            this.lblSoNV.Size = new System.Drawing.Size(882, 28);
            this.lblSoNV.TabIndex = 18;
            this.lblSoNV.Text = "Tổng: 0 nhân viên ";
            this.lblSoNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvChamCong
            // 
            this.dgvChamCong.AllowUserToAddRows = false;
            this.dgvChamCong.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChamCong.Location = new System.Drawing.Point(0, 165);
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.ReadOnly = true;
            this.dgvChamCong.RowHeadersWidth = 51;
            this.dgvChamCong.RowTemplate.Height = 24;
            this.dgvChamCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChamCong.Size = new System.Drawing.Size(882, 360);
            this.dgvChamCong.TabIndex = 19;
            this.dgvChamCong.SelectionChanged += new System.EventHandler(this.dgvChamCong_SelectionChanged);
            // 
            // frmChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.dgvChamCong);
            this.Controls.Add(this.lblSoNV);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlTitle);
            this.Name = "frmChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chấm công";
            this.Load += new System.EventHandler(this.frmChamCong_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNghiKhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNghiPhep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThucTe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChuanChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudNam;
        private System.Windows.Forms.Button btnThemLoat;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudThucTe;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.NumericUpDown nudChuanChi;
        private System.Windows.Forms.Label lebell;
        private System.Windows.Forms.NumericUpDown nudNghiPhep;
        private System.Windows.Forms.Label NghiPhep;
        private System.Windows.Forms.NumericUpDown nudNghiKhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblSoNV;
        private System.Windows.Forms.DataGridView dgvChamCong;
    }
}