namespace LabManager.Views
{
    partial class frmAddProject
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProject));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dgrDanhSachCongViec = new System.Windows.Forms.DataGridView();
            this.clmTenCongViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNhanVienDamNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtMaSoDuAn = new System.Windows.Forms.TextBox();
            this.txtTenDuAn = new System.Windows.Forms.TextBox();
            this.dtpThoiGianBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpThoiGianKetThuc = new System.Windows.Forms.DateTimePicker();
            this.btnThemDuAn = new System.Windows.Forms.Button();
            this.btnThemCongViec = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgrDanhSachCongViec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(14, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(234, 15);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Mã số dự án";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(14, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(234, 15);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Tên dự án";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(14, 167);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(234, 15);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Thời gian bắt đầu";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(14, 250);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(234, 15);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Thời gian dự kiến hoàn thành";
            // 
            // dgrDanhSachCongViec
            // 
            this.dgrDanhSachCongViec.AllowUserToAddRows = false;
            this.dgrDanhSachCongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDanhSachCongViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmTenCongViec,
            this.clmNhanVienDamNhan});
            this.dgrDanhSachCongViec.Location = new System.Drawing.Point(325, 88);
            this.dgrDanhSachCongViec.Name = "dgrDanhSachCongViec";
            this.dgrDanhSachCongViec.Size = new System.Drawing.Size(457, 340);
            this.dgrDanhSachCongViec.TabIndex = 7;
            // 
            // clmTenCongViec
            // 
            this.clmTenCongViec.HeaderText = "Tên công việc";
            this.clmTenCongViec.Name = "clmTenCongViec";
            this.clmTenCongViec.ReadOnly = true;
            this.clmTenCongViec.Width = 250;
            // 
            // clmNhanVienDamNhan
            // 
            this.clmNhanVienDamNhan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmNhanVienDamNhan.HeaderText = "Nhân viên đảm nhận";
            this.clmNhanVienDamNhan.Name = "clmNhanVienDamNhan";
            this.clmNhanVienDamNhan.ReadOnly = true;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(326, 67);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(448, 15);
            this.textBox6.TabIndex = 8;
            this.textBox6.Text = "Danh sách phân công công việc trong dự án";
            // 
            // txtMaSoDuAn
            // 
            this.txtMaSoDuAn.Location = new System.Drawing.Point(14, 39);
            this.txtMaSoDuAn.Name = "txtMaSoDuAn";
            this.txtMaSoDuAn.Size = new System.Drawing.Size(234, 22);
            this.txtMaSoDuAn.TabIndex = 0;
            // 
            // txtTenDuAn
            // 
            this.txtTenDuAn.Location = new System.Drawing.Point(14, 127);
            this.txtTenDuAn.Name = "txtTenDuAn";
            this.txtTenDuAn.Size = new System.Drawing.Size(234, 22);
            this.txtTenDuAn.TabIndex = 10;
            // 
            // dtpThoiGianBatDau
            // 
            this.dtpThoiGianBatDau.Location = new System.Drawing.Point(15, 205);
            this.dtpThoiGianBatDau.Name = "dtpThoiGianBatDau";
            this.dtpThoiGianBatDau.Size = new System.Drawing.Size(233, 22);
            this.dtpThoiGianBatDau.TabIndex = 14;
            // 
            // dtpThoiGianKetThuc
            // 
            this.dtpThoiGianKetThuc.Location = new System.Drawing.Point(15, 286);
            this.dtpThoiGianKetThuc.Name = "dtpThoiGianKetThuc";
            this.dtpThoiGianKetThuc.Size = new System.Drawing.Size(233, 22);
            this.dtpThoiGianKetThuc.TabIndex = 15;
            // 
            // btnThemDuAn
            // 
            this.btnThemDuAn.Location = new System.Drawing.Point(42, 350);
            this.btnThemDuAn.Name = "btnThemDuAn";
            this.btnThemDuAn.Size = new System.Drawing.Size(187, 46);
            this.btnThemDuAn.TabIndex = 1;
            this.btnThemDuAn.Text = "Thêm dự án";
            this.btnThemDuAn.UseVisualStyleBackColor = true;
            this.btnThemDuAn.Click += new System.EventHandler(this.btnThemDuAn_Click);
            // 
            // btnThemCongViec
            // 
            this.btnThemCongViec.Location = new System.Drawing.Point(326, 39);
            this.btnThemCongViec.Name = "btnThemCongViec";
            this.btnThemCongViec.Size = new System.Drawing.Size(456, 22);
            this.btnThemCongViec.TabIndex = 16;
            this.btnThemCongViec.Text = "Thêm công việc";
            this.btnThemCongViec.UseVisualStyleBackColor = true;
            this.btnThemCongViec.Click += new System.EventHandler(this.btnThemCongViec_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(786, 440);
            this.Controls.Add(this.btnThemCongViec);
            this.Controls.Add(this.btnThemDuAn);
            this.Controls.Add(this.dtpThoiGianKetThuc);
            this.Controls.Add(this.dtpThoiGianBatDau);
            this.Controls.Add(this.txtTenDuAn);
            this.Controls.Add(this.txtMaSoDuAn);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.dgrDanhSachCongViec);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm dự án";
            ((System.ComponentModel.ISupportInitialize)(this.dgrDanhSachCongViec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dgrDanhSachCongViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTenCongViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNhanVienDamNhan;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtMaSoDuAn;
        private System.Windows.Forms.TextBox txtTenDuAn;
        private System.Windows.Forms.DateTimePicker dtpThoiGianBatDau;
        private System.Windows.Forms.DateTimePicker dtpThoiGianKetThuc;
        private System.Windows.Forms.Button btnThemDuAn;
        private System.Windows.Forms.Button btnThemCongViec;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}