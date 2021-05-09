namespace LabManager.Views
{
    partial class frmListMember
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListMember));
            this.dgrDanhSachThanhVien = new System.Windows.Forms.DataGridView();
            this.clmMaSoNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmThoiGianBatDauLamViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGioBatDauLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGioNghi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.btnIn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.cbbTimKiemTheo = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDanhSachThanhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrDanhSachThanhVien
            // 
            this.dgrDanhSachThanhVien.AllowUserToAddRows = false;
            this.dgrDanhSachThanhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDanhSachThanhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMaSoNhanVien,
            this.clmTenNhanVien,
            this.clmSDT,
            this.clmEmail,
            this.clmNgaySinh,
            this.clmLuong,
            this.clmDiaChi,
            this.clmThoiGianBatDauLamViec,
            this.clmGioBatDauLam,
            this.clmGioNghi});
            this.dgrDanhSachThanhVien.Location = new System.Drawing.Point(12, 38);
            this.dgrDanhSachThanhVien.Name = "dgrDanhSachThanhVien";
            this.dgrDanhSachThanhVien.Size = new System.Drawing.Size(1049, 370);
            this.dgrDanhSachThanhVien.TabIndex = 2;
            this.dgrDanhSachThanhVien.Tag = "";
            this.dgrDanhSachThanhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDanhSachThanhVien_CellClick);
            this.dgrDanhSachThanhVien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDanhSachThanhVien_CellDoubleClick);
            // 
            // clmMaSoNhanVien
            // 
            this.clmMaSoNhanVien.HeaderText = "Mã số nhân viên";
            this.clmMaSoNhanVien.Name = "clmMaSoNhanVien";
            this.clmMaSoNhanVien.ReadOnly = true;
            this.clmMaSoNhanVien.Width = 80;
            // 
            // clmTenNhanVien
            // 
            this.clmTenNhanVien.HeaderText = "Tên nhân viên";
            this.clmTenNhanVien.Name = "clmTenNhanVien";
            this.clmTenNhanVien.ReadOnly = true;
            this.clmTenNhanVien.Width = 120;
            // 
            // clmSDT
            // 
            this.clmSDT.HeaderText = "Số điện thoại";
            this.clmSDT.Name = "clmSDT";
            this.clmSDT.ReadOnly = true;
            // 
            // clmEmail
            // 
            this.clmEmail.HeaderText = "Email";
            this.clmEmail.Name = "clmEmail";
            this.clmEmail.ReadOnly = true;
            this.clmEmail.Width = 140;
            // 
            // clmNgaySinh
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.clmNgaySinh.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmNgaySinh.HeaderText = "Ngày sinh";
            this.clmNgaySinh.Name = "clmNgaySinh";
            this.clmNgaySinh.ReadOnly = true;
            this.clmNgaySinh.Width = 80;
            // 
            // clmLuong
            // 
            this.clmLuong.HeaderText = "Lương (vnđ)";
            this.clmLuong.Name = "clmLuong";
            this.clmLuong.ReadOnly = true;
            this.clmLuong.Width = 80;
            // 
            // clmDiaChi
            // 
            this.clmDiaChi.HeaderText = "Địa chỉ";
            this.clmDiaChi.Name = "clmDiaChi";
            this.clmDiaChi.ReadOnly = true;
            // 
            // clmThoiGianBatDauLamViec
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.clmThoiGianBatDauLamViec.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmThoiGianBatDauLamViec.HeaderText = "Thời gian bắt đầu làm việc";
            this.clmThoiGianBatDauLamViec.Name = "clmThoiGianBatDauLamViec";
            this.clmThoiGianBatDauLamViec.ReadOnly = true;
            // 
            // clmGioBatDauLam
            // 
            dataGridViewCellStyle3.Format = "t";
            dataGridViewCellStyle3.NullValue = null;
            this.clmGioBatDauLam.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmGioBatDauLam.HeaderText = "Giờ bắt đầu làm";
            this.clmGioBatDauLam.Name = "clmGioBatDauLam";
            this.clmGioBatDauLam.ReadOnly = true;
            // 
            // clmGioNghi
            // 
            this.clmGioNghi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "t";
            dataGridViewCellStyle4.NullValue = null;
            this.clmGioNghi.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmGioNghi.HeaderText = "Giờ nghỉ";
            this.clmGioNghi.Name = "clmGioNghi";
            this.clmGioNghi.ReadOnly = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(273, 414);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(155, 35);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(444, 414);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(155, 36);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(605, 413);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(155, 36);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // cbbTimKiemTheo
            // 
            this.cbbTimKiemTheo.FormattingEnabled = true;
            this.cbbTimKiemTheo.Items.AddRange(new object[] {
            "Tên nhân viên",
            "Mã nhân viên"});
            this.cbbTimKiemTheo.Location = new System.Drawing.Point(785, 11);
            this.cbbTimKiemTheo.Name = "cbbTimKiemTheo";
            this.cbbTimKiemTheo.Size = new System.Drawing.Size(97, 21);
            this.cbbTimKiemTheo.TabIndex = 13;
            this.cbbTimKiemTheo.SelectedIndexChanged += new System.EventHandler(this.cbbTimKiemTheo_SelectedIndexChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(671, 16);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(117, 15);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "Tìm kiếm dự án theo:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(888, 11);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(173, 20);
            this.txtTimKiem.TabIndex = 11;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // frmListMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 450);
            this.Controls.Add(this.cbbTimKiemTheo);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgrDanhSachThanhVien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Thành Viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgrDanhSachThanhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrDanhSachThanhVien;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaSoNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThoiGianBatDauLamViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGioBatDauLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGioNghi;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btnIn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ComboBox cbbTimKiemTheo;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}