namespace LabManager.Views
{
    partial class frmListProject
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListProject));
            this.dgrDanhSachDuAn = new System.Windows.Forms.DataGridView();
            this.clmMSDuAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTenDuAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNgayDuKienHoanThanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChuDuAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgrDanhSachCongViec = new System.Windows.Forms.DataGridView();
            this.clmSoTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTenCongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaNhanVienThucHien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmlinkdrive = new System.Windows.Forms.DataGridViewLinkColumn();
            this.clmDaHoanThanh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnThemCongViec = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnLinkCongViec = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cbbTimKiemTheo = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDanhSachDuAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDanhSachCongViec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrDanhSachDuAn
            // 
            this.dgrDanhSachDuAn.AllowUserToAddRows = false;
            this.dgrDanhSachDuAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDanhSachDuAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMSDuAn,
            this.clmTenDuAn,
            this.clmNgayBatDau,
            this.clmNgayDuKienHoanThanh,
            this.clmChuDuAn});
            this.dgrDanhSachDuAn.Location = new System.Drawing.Point(14, 39);
            this.dgrDanhSachDuAn.Name = "dgrDanhSachDuAn";
            this.dgrDanhSachDuAn.Size = new System.Drawing.Size(578, 417);
            this.dgrDanhSachDuAn.TabIndex = 1;
            this.dgrDanhSachDuAn.Click += new System.EventHandler(this.dgrDanhSachDuAn_Click);
            // 
            // clmMSDuAn
            // 
            this.clmMSDuAn.HeaderText = "Mã số dự án";
            this.clmMSDuAn.Name = "clmMSDuAn";
            this.clmMSDuAn.ReadOnly = true;
            this.clmMSDuAn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmMSDuAn.Width = 91;
            // 
            // clmTenDuAn
            // 
            this.clmTenDuAn.HeaderText = "Tên dự án";
            this.clmTenDuAn.Name = "clmTenDuAn";
            this.clmTenDuAn.ReadOnly = true;
            this.clmTenDuAn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmTenDuAn.Width = 150;
            // 
            // clmNgayBatDau
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.clmNgayBatDau.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmNgayBatDau.HeaderText = "Ngày bắt đầu";
            this.clmNgayBatDau.Name = "clmNgayBatDau";
            this.clmNgayBatDau.ReadOnly = true;
            this.clmNgayBatDau.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmNgayDuKienHoanThanh
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.clmNgayDuKienHoanThanh.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmNgayDuKienHoanThanh.HeaderText = "Ngày dự kiến hoàn thành";
            this.clmNgayDuKienHoanThanh.Name = "clmNgayDuKienHoanThanh";
            this.clmNgayDuKienHoanThanh.ReadOnly = true;
            this.clmNgayDuKienHoanThanh.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmChuDuAn
            // 
            this.clmChuDuAn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmChuDuAn.HeaderText = "Chủ dự án";
            this.clmChuDuAn.Name = "clmChuDuAn";
            this.clmChuDuAn.ReadOnly = true;
            this.clmChuDuAn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(189, 464);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 42);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(633, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(182, 15);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Danh sách công việc của dự án";
            // 
            // dgrDanhSachCongViec
            // 
            this.dgrDanhSachCongViec.AllowUserToAddRows = false;
            this.dgrDanhSachCongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDanhSachCongViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSoTT,
            this.clmTenCongViec,
            this.clmMaNhanVienThucHien,
            this.clmlinkdrive,
            this.clmDaHoanThanh});
            this.dgrDanhSachCongViec.Location = new System.Drawing.Point(598, 64);
            this.dgrDanhSachCongViec.Name = "dgrDanhSachCongViec";
            this.dgrDanhSachCongViec.Size = new System.Drawing.Size(446, 456);
            this.dgrDanhSachCongViec.TabIndex = 4;
            this.dgrDanhSachCongViec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDanhSachCongViec_CellClick);
            this.dgrDanhSachCongViec.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDanhSachCongViec_CellContentDoubleClick);
            this.dgrDanhSachCongViec.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDanhSachCongViec_CellEndEdit);
            // 
            // clmSoTT
            // 
            this.clmSoTT.HeaderText = "STT";
            this.clmSoTT.Name = "clmSoTT";
            this.clmSoTT.ReadOnly = true;
            this.clmSoTT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmSoTT.Width = 40;
            // 
            // clmTenCongViec
            // 
            this.clmTenCongViec.HeaderText = "Tên công việc";
            this.clmTenCongViec.Name = "clmTenCongViec";
            this.clmTenCongViec.ReadOnly = true;
            this.clmTenCongViec.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmMaNhanVienThucHien
            // 
            this.clmMaNhanVienThucHien.HeaderText = "Mã nhân viên thực hiện";
            this.clmMaNhanVienThucHien.Name = "clmMaNhanVienThucHien";
            this.clmMaNhanVienThucHien.ReadOnly = true;
            this.clmMaNhanVienThucHien.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmlinkdrive
            // 
            this.clmlinkdrive.HeaderText = "Link công việc";
            this.clmlinkdrive.Name = "clmlinkdrive";
            this.clmlinkdrive.ReadOnly = true;
            this.clmlinkdrive.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmlinkdrive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmDaHoanThanh
            // 
            this.clmDaHoanThanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmDaHoanThanh.HeaderText = "Đã hoàn thành";
            this.clmDaHoanThanh.Name = "clmDaHoanThanh";
            this.clmDaHoanThanh.ReadOnly = true;
            // 
            // btnThemCongViec
            // 
            this.btnThemCongViec.Location = new System.Drawing.Point(1050, 450);
            this.btnThemCongViec.Name = "btnThemCongViec";
            this.btnThemCongViec.Size = new System.Drawing.Size(113, 58);
            this.btnThemCongViec.TabIndex = 0;
            this.btnThemCongViec.Text = "Thêm công việc";
            this.btnThemCongViec.UseVisualStyleBackColor = true;
            this.btnThemCongViec.Visible = false;
            this.btnThemCongViec.Click += new System.EventHandler(this.btnThemCongViec_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(14, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(102, 15);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Danh sách dự án";
            // 
            // btnLinkCongViec
            // 
            this.btnLinkCongViec.Location = new System.Drawing.Point(880, 41);
            this.btnLinkCongViec.Name = "btnLinkCongViec";
            this.btnLinkCongViec.Size = new System.Drawing.Size(101, 22);
            this.btnLinkCongViec.TabIndex = 7;
            this.btnLinkCongViec.Text = "Chỉnh sửa link";
            this.btnLinkCongViec.UseVisualStyleBackColor = true;
            this.btnLinkCongViec.Visible = false;
            this.btnLinkCongViec.Click += new System.EventHandler(this.btnLinkCongViec_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(419, 13);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(173, 22);
            this.txtTimKiem.TabIndex = 8;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(202, 18);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(117, 15);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "Tìm kiếm dự án theo:";
            // 
            // cbbTimKiemTheo
            // 
            this.cbbTimKiemTheo.FormattingEnabled = true;
            this.cbbTimKiemTheo.Items.AddRange(new object[] {
            "Tên dự án",
            "Mã dự án",
            "Chủ dự án"});
            this.cbbTimKiemTheo.Location = new System.Drawing.Point(316, 13);
            this.cbbTimKiemTheo.Name = "cbbTimKiemTheo";
            this.cbbTimKiemTheo.Size = new System.Drawing.Size(97, 23);
            this.cbbTimKiemTheo.TabIndex = 10;
            this.cbbTimKiemTheo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(1050, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(1088, 97);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(38, 15);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "QR";
            // 
            // frmListProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1164, 520);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbbTimKiemTheo);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnLinkCongViec);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnThemCongViec);
            this.Controls.Add(this.dgrDanhSachCongViec);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgrDanhSachDuAn);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách dự án";
            ((System.ComponentModel.ISupportInitialize)(this.dgrDanhSachDuAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDanhSachCongViec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrDanhSachDuAn;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgrDanhSachCongViec;
        private System.Windows.Forms.Button btnThemCongViec;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMSDuAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenDuAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNgayDuKienHoanThanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChuDuAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSoTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenCongViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaNhanVienThucHien;
        private System.Windows.Forms.DataGridViewLinkColumn clmlinkdrive;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmDaHoanThanh;
        private System.Windows.Forms.Button btnLinkCongViec;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox cbbTimKiemTheo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox3;
    }
}