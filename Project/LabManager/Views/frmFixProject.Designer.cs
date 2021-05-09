namespace LabManager.Views
{
    partial class frmFixProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFixProject));
            this.dtpThoiGianKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpThoiGianBatDau = new System.Windows.Forms.DateTimePicker();
            this.txtTenDuAn = new System.Windows.Forms.TextBox();
            this.txtMaSoDuAn = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtChuDA = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpThoiGianKetThuc
            // 
            this.dtpThoiGianKetThuc.Location = new System.Drawing.Point(21, 337);
            this.dtpThoiGianKetThuc.Name = "dtpThoiGianKetThuc";
            this.dtpThoiGianKetThuc.Size = new System.Drawing.Size(194, 20);
            this.dtpThoiGianKetThuc.TabIndex = 23;
            // 
            // dtpThoiGianBatDau
            // 
            this.dtpThoiGianBatDau.Location = new System.Drawing.Point(22, 254);
            this.dtpThoiGianBatDau.Name = "dtpThoiGianBatDau";
            this.dtpThoiGianBatDau.Size = new System.Drawing.Size(194, 20);
            this.dtpThoiGianBatDau.TabIndex = 22;
            // 
            // txtTenDuAn
            // 
            this.txtTenDuAn.Location = new System.Drawing.Point(21, 107);
            this.txtTenDuAn.Name = "txtTenDuAn";
            this.txtTenDuAn.Size = new System.Drawing.Size(195, 20);
            this.txtTenDuAn.TabIndex = 21;
            // 
            // txtMaSoDuAn
            // 
            this.txtMaSoDuAn.Location = new System.Drawing.Point(21, 37);
            this.txtMaSoDuAn.Name = "txtMaSoDuAn";
            this.txtMaSoDuAn.ReadOnly = true;
            this.txtMaSoDuAn.Size = new System.Drawing.Size(195, 20);
            this.txtMaSoDuAn.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(21, 299);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(195, 15);
            this.textBox4.TabIndex = 20;
            this.textBox4.Text = "Thời gian dự kiến hoàn thành";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(21, 216);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(195, 15);
            this.textBox3.TabIndex = 19;
            this.textBox3.Text = "Thời gian bắt đầu";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(20, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(195, 15);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = "Tên dự án";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(21, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(195, 15);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "Mã số dự án";
            // 
            // txtChuDA
            // 
            this.txtChuDA.Location = new System.Drawing.Point(21, 172);
            this.txtChuDA.Name = "txtChuDA";
            this.txtChuDA.Size = new System.Drawing.Size(195, 20);
            this.txtChuDA.TabIndex = 24;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(21, 151);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(195, 15);
            this.textBox6.TabIndex = 25;
            this.textBox6.Text = "Mã số nhân viên chủ dự án";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(84, 402);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 36);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmFixProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(259, 450);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtChuDA);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.dtpThoiGianKetThuc);
            this.Controls.Add(this.dtpThoiGianBatDau);
            this.Controls.Add(this.txtTenDuAn);
            this.Controls.Add(this.txtMaSoDuAn);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFixProject";
            this.Text = "Sửa dự án";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpThoiGianKetThuc;
        private System.Windows.Forms.DateTimePicker dtpThoiGianBatDau;
        private System.Windows.Forms.TextBox txtTenDuAn;
        private System.Windows.Forms.TextBox txtMaSoDuAn;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtChuDA;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}