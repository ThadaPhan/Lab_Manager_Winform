using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabManager.Models;
using LabManager.Controllers;
using System.Security.Cryptography;

namespace LabManager.Views
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void btnAccAccount_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string xacNhanMatKhau = txtXacNhanMatKhau.Text.Trim();
            string maSoNhanVien = txtMSNV.Text.Trim();
            if(tenDangNhap=="")
            {
                errorProvider1.SetError(txtTenDangNhap, "Tên dăng nhập không được để trống");
                return;
            }
            else if (maSoNhanVien == "")
            {
                errorProvider1.SetError(txtMSNV, "Mã số nhân viên không được để trống");
                return;
            }
            else if(matKhau=="")
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu không được để trống");
                return;
            }
            else if (xacNhanMatKhau == "")
            {
                errorProvider1.SetError(txtXacNhanMatKhau, "Xác nhận mật khẩu không được để trống");
                return;
            }
            else if(MemberController.kiemTraTenDangNhap(tenDangNhap))
            {
                errorProvider1.SetError(txtTenDangNhap, "Tên dăng nhập đã bị trùng");
                return;
            }
            else if (MemberController.kiemTraMaSoNhanVien(maSoNhanVien))
            {
                errorProvider1.SetError(txtMSNV, "Mã số nhân viên không hợp lệ");
                return;
            }
            else if (MemberController.kiemTraMaSoNhanVien(maSoNhanVien))
            {
                errorProvider1.SetError(txtMSNV, "Nhân viên này đã có tài khoản");
                return;
            }
            else if(matKhau != xacNhanMatKhau)
            {
                errorProvider1.SetError(txtXacNhanMatKhau, "Xác nhận mật khẩu không khớp với mật khẩu");
                return;
            }
            SignIn SignIn = new SignIn();
            SignIn.UserName = tenDangNhap;
            SignIn.IDMember = maSoNhanVien;
            SignIn.PassWord = Hash(matKhau);
            MemberController.themTaiKhoan(SignIn);
            MessageBox.Show("Đăng ký thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }
        static string Hash(string input)
        {
            var hash = new SHA1Managed().ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Concat(hash.Select(b => b.ToString("x2")));
            //Source:https://www.it-swarm.dev/vi/c%23/bam-voi-thuat-toan-sha1-trong-c/1072926302/
        }
    }
}
