namespace QLL.UI
{
    partial class frmBangLuong
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBangLuong = new System.Windows.Forms.TabPage();
            this.tabThongKe = new System.Windows.Forms.TabPage();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.nudThang = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudNam = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.btnTinhLuong = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.lblTongLuong = new System.Windows.Forms.Label();
            this.dgvBangLuong = new System.Windows.Forms.DataGridView();
            this.pnlTK = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.nudThangTK = new System.Windows.Forms.NumericUpDown();
            this.labelll = new System.Windows.Forms.Label();
            this.nudNamTK = new System.Windows.Forms.NumericUpDown();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvQuyLuong = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvTopLuong = new System.Windows.Forms.DataGridView();
            this.pnlTitle.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabBangLuong.SuspendLayout();
            this.tabThongKe.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).BeginInit();
            this.pnlTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThangTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNamTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1067, 55);
            this.pnlTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(312, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "TÍNH LƯƠNG VÀ BẢNG LƯƠNG ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBangLuong);
            this.tabControl1.Controls.Add(this.tabThongKe);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1067, 548);
            this.tabControl1.TabIndex = 1;
            // 
            // tabBangLuong
            // 
            this.tabBangLuong.Controls.Add(this.dgvBangLuong);
            this.tabBangLuong.Controls.Add(this.lblTongLuong);
            this.tabBangLuong.Controls.Add(this.pnlTop);
            this.tabBangLuong.Location = new System.Drawing.Point(4, 25);
            this.tabBangLuong.Name = "tabBangLuong";
            this.tabBangLuong.Padding = new System.Windows.Forms.Padding(3);
            this.tabBangLuong.Size = new System.Drawing.Size(1059, 519);
            this.tabBangLuong.TabIndex = 0;
            this.tabBangLuong.Text = "Bảng Lương";
            this.tabBangLuong.UseVisualStyleBackColor = true;
            // 
            // tabThongKe
            // 
            this.tabThongKe.Controls.Add(this.splitContainer1);
            this.tabThongKe.Controls.Add(this.pnlTK);
            this.tabThongKe.Location = new System.Drawing.Point(4, 25);
            this.tabThongKe.Name = "tabThongKe";
            this.tabThongKe.Padding = new System.Windows.Forms.Padding(3);
            this.tabThongKe.Size = new System.Drawing.Size(1059, 519);
            this.tabThongKe.TabIndex = 1;
            this.tabThongKe.Text = "Thống Kê";
            this.tabThongKe.UseVisualStyleBackColor = true;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(246)))));
            this.pnlTop.Controls.Add(this.btnXem);
            this.pnlTop.Controls.Add(this.btnTinhLuong);
            this.pnlTop.Controls.Add(this.cboPhong);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.nudNam);
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Controls.Add(this.nudThang);
            this.pnlTop.Controls.Add(this.label);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(3, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1053, 52);
            this.pnlTop.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(10, 14);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(53, 17);
            this.label.TabIndex = 0;
            this.label.Text = "Tháng: ";
            // 
            // nudThang
            // 
            this.nudThang.CausesValidation = false;
            this.nudThang.Location = new System.Drawing.Point(57, 14);
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
            this.nudThang.Size = new System.Drawing.Size(55, 22);
            this.nudThang.TabIndex = 1;
            this.nudThang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Năm: ";
            // 
            // nudNam
            // 
            this.nudNam.Location = new System.Drawing.Point(166, 14);
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
            this.nudNam.Size = new System.Drawing.Size(80, 22);
            this.nudNam.TabIndex = 3;
            this.nudNam.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phòng: ";
            // 
            // cboPhong
            // 
            this.cboPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(328, 12);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(180, 24);
            this.cboPhong.TabIndex = 5;
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.btnTinhLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinhLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhLuong.ForeColor = System.Drawing.Color.White;
            this.btnTinhLuong.Location = new System.Drawing.Point(552, 9);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(120, 32);
            this.btnTinhLuong.TabIndex = 6;
            this.btnTinhLuong.Text = "Tính lương";
            this.btnTinhLuong.UseVisualStyleBackColor = false;
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(698, 9);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(120, 32);
            this.btnXem.TabIndex = 7;
            this.btnXem.Text = "Xem ";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // lblTongLuong
            // 
            this.lblTongLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.lblTongLuong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTongLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongLuong.ForeColor = System.Drawing.Color.White;
            this.lblTongLuong.Location = new System.Drawing.Point(3, 480);
            this.lblTongLuong.Name = "lblTongLuong";
            this.lblTongLuong.Size = new System.Drawing.Size(1053, 36);
            this.lblTongLuong.TabIndex = 1;
            this.lblTongLuong.Text = "Tổng quỹ lương: 0 VND";
            this.lblTongLuong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvBangLuong
            // 
            this.dgvBangLuong.AllowUserToAddRows = false;
            this.dgvBangLuong.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvBangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBangLuong.Location = new System.Drawing.Point(3, 55);
            this.dgvBangLuong.Name = "dgvBangLuong";
            this.dgvBangLuong.ReadOnly = true;
            this.dgvBangLuong.RowHeadersWidth = 51;
            this.dgvBangLuong.RowTemplate.Height = 24;
            this.dgvBangLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBangLuong.Size = new System.Drawing.Size(1053, 425);
            this.dgvBangLuong.TabIndex = 2;
            // 
            // pnlTK
            // 
            this.pnlTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(231)))), ((int)(((byte)(246)))));
            this.pnlTK.Controls.Add(this.btnThongKe);
            this.pnlTK.Controls.Add(this.nudNamTK);
            this.pnlTK.Controls.Add(this.labelll);
            this.pnlTK.Controls.Add(this.nudThangTK);
            this.pnlTK.Controls.Add(this.label4);
            this.pnlTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTK.Location = new System.Drawing.Point(3, 3);
            this.pnlTK.Name = "pnlTK";
            this.pnlTK.Size = new System.Drawing.Size(1053, 52);
            this.pnlTK.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tháng: ";
            // 
            // nudThangTK
            // 
            this.nudThangTK.Location = new System.Drawing.Point(69, 14);
            this.nudThangTK.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudThangTK.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThangTK.Name = "nudThangTK";
            this.nudThangTK.Size = new System.Drawing.Size(55, 22);
            this.nudThangTK.TabIndex = 1;
            this.nudThangTK.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelll
            // 
            this.labelll.AutoSize = true;
            this.labelll.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelll.Location = new System.Drawing.Point(142, 14);
            this.labelll.Name = "labelll";
            this.labelll.Size = new System.Drawing.Size(40, 17);
            this.labelll.TabIndex = 2;
            this.labelll.Text = "Năm:";
            this.labelll.Click += new System.EventHandler(this.labelll_Click);
            // 
            // nudNamTK
            // 
            this.nudNamTK.Location = new System.Drawing.Point(188, 14);
            this.nudNamTK.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudNamTK.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudNamTK.Name = "nudNamTK";
            this.nudNamTK.Size = new System.Drawing.Size(80, 22);
            this.nudNamTK.TabIndex = 3;
            this.nudNamTK.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(312, 12);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(110, 32);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 55);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvQuyLuong);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvTopLuong);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Size = new System.Drawing.Size(1053, 461);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1053, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quỹ lương theo phòng ban";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvQuyLuong
            // 
            this.dgvQuyLuong.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvQuyLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuyLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuyLuong.Location = new System.Drawing.Point(0, 30);
            this.dgvQuyLuong.Name = "dgvQuyLuong";
            this.dgvQuyLuong.ReadOnly = true;
            this.dgvQuyLuong.RowHeadersWidth = 51;
            this.dgvQuyLuong.RowTemplate.Height = 24;
            this.dgvQuyLuong.Size = new System.Drawing.Size(1053, 190);
            this.dgvQuyLuong.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1053, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Top 5 lương cao nhất ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvTopLuong
            // 
            this.dgvTopLuong.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvTopLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTopLuong.Location = new System.Drawing.Point(0, 30);
            this.dgvTopLuong.Name = "dgvTopLuong";
            this.dgvTopLuong.ReadOnly = true;
            this.dgvTopLuong.RowHeadersWidth = 51;
            this.dgvTopLuong.RowTemplate.Height = 24;
            this.dgvTopLuong.Size = new System.Drawing.Size(1053, 207);
            this.dgvTopLuong.TabIndex = 1;
            // 
            // frmBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 603);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBangLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính lương & Bảng lương";
            this.Load += new System.EventHandler(this.frmBangLuong_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabBangLuong.ResumeLayout(false);
            this.tabThongKe.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).EndInit();
            this.pnlTK.ResumeLayout(false);
            this.pnlTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThangTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNamTK)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBangLuong;
        private System.Windows.Forms.TabPage tabThongKe;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.NumericUpDown nudThang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudNam;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnTinhLuong;
        private System.Windows.Forms.Label lblTongLuong;
        private System.Windows.Forms.DataGridView dgvBangLuong;
        private System.Windows.Forms.Panel pnlTK;
        private System.Windows.Forms.NumericUpDown nudNamTK;
        private System.Windows.Forms.Label labelll;
        private System.Windows.Forms.NumericUpDown nudThangTK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvQuyLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvTopLuong;
    }
}