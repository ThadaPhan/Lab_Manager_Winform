using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabManager.Controllers;
using LabManager.Models;
namespace LabManager.Views
{
    public partial class frmFixProject : Form
    {
        Project DuAn;
        public frmFixProject()
        {
            InitializeComponent();
        }
        public frmFixProject(Project duAn)
        {
            InitializeComponent();
            this.txtMaSoDuAn.Text = duAn.ID.Trim();
            this.txtTenDuAn.Text = duAn.Name.Trim();
            this.txtChuDA.Text = duAn.IDAdmin.Trim();
            this.dtpThoiGianBatDau.Value = duAn.TimeStart.Value;
            this.dtpThoiGianKetThuc.Value = duAn.TimeExpectedEnd.Value;
            DuAn = duAn;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string tenDuAn = this.txtTenDuAn.Text.ToString().Trim();
            string chuDa = this.txtChuDA.Text.ToString().Trim();
            DateTime thoiGianBatDau = this.dtpThoiGianBatDau.Value;
            DateTime thoiGianKetThuc = this.dtpThoiGianKetThuc.Value;
            if(tenDuAn=="")
            {
                errorProvider1.SetError(this.txtTenDuAn, "Hãy điền tên dự án");
                return;
            }
            else if(chuDa=="")
            {
                errorProvider1.SetError(this.txtChuDA, "Hãy điền chủ dự án");
                return;
            }
            else if(!MemberController.kiemTraMaSoNhanVien(chuDa))
            {
                errorProvider1.SetError(this.txtChuDA, "Mã số nhân viên không tồn tại");
                return;
            }
            else if(thoiGianBatDau>=thoiGianKetThuc)
            {
                errorProvider1.SetError(this.dtpThoiGianKetThuc, "Thời gian kết thúc không được nhỏ hơn thời gian bắt đầu");
                return;
            }
            DuAn.Name = tenDuAn;
            DuAn.IDAdmin = chuDa;
            DuAn.TimeStart = thoiGianBatDau;
            DuAn.TimeExpectedEnd = thoiGianKetThuc;
            ProjectController.capNhatDuAn(DuAn);
            MessageBox.Show("Sửa dự án thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
