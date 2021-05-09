namespace LabManager.Views
{
    partial class frmFixLink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFixLink));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtLinkMoi = new System.Windows.Forms.TextBox();
            this.btnCapNhatLink = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(187, 15);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Link mới cho công việc";
            // 
            // txtLinkMoi
            // 
            this.txtLinkMoi.Location = new System.Drawing.Point(24, 34);
            this.txtLinkMoi.Name = "txtLinkMoi";
            this.txtLinkMoi.Size = new System.Drawing.Size(638, 20);
            this.txtLinkMoi.TabIndex = 6;
            // 
            // btnCapNhatLink
            // 
            this.btnCapNhatLink.Location = new System.Drawing.Point(295, 69);
            this.btnCapNhatLink.Name = "btnCapNhatLink";
            this.btnCapNhatLink.Size = new System.Drawing.Size(103, 23);
            this.btnCapNhatLink.TabIndex = 0;
            this.btnCapNhatLink.Text = "Cập nhật link";
            this.btnCapNhatLink.UseVisualStyleBackColor = true;
            this.btnCapNhatLink.Click += new System.EventHandler(this.btnCapNhatLink_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmFixLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(700, 104);
            this.Controls.Add(this.btnCapNhatLink);
            this.Controls.Add(this.txtLinkMoi);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFixLink";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa link";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtLinkMoi;
        private System.Windows.Forms.Button btnCapNhatLink;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}