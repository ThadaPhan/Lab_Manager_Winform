using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabManager.Controllers;
namespace LabManager.Views
{
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }
        

        private void frmLogin_Load(object sender, EventArgs e)
        {
            loadDuLieuTenTaiKhoan();
        }
        private void loadDuLieuTenTaiKhoan()
        {
            this.cbbTenDangNhap.Items.Clear();
            foreach (string item in MemberController.layDanhSachTenDangNhap())
                this.cbbTenDangNhap.Items.Add(item.Trim());
        }
        private void btnAccAccount_Click(object sender, EventArgs e)
        {
            frmSignUp frmSignUp = new frmSignUp();
            frmSignUp.ShowDialog();
            loadDuLieuTenTaiKhoan();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string tenDangNhap = this.cbbTenDangNhap.Text.Trim();
            string matKhau = this.txtMatKhau.Text.Trim();
            if(tenDangNhap=="")
            {
                errorProvider1.SetError(this.cbbTenDangNhap, "Hãy nhập tên đăng nhập");
                return;
            }
            else if(matKhau=="")
            {
                errorProvider1.SetError(this.txtMatKhau, "Hãy nhập mật khẩu");
                return;
            }
            else if(!MemberController.kiemTraTenDangNhap(tenDangNhap))
            {
                errorProvider1.SetError(this.cbbTenDangNhap, "Tên đăng nhập không tồn tại");
                return;
            }
            else if(!MemberController.kiemTraMatKhau(Hash(matKhau),tenDangNhap))
            {
                errorProvider1.SetError(this.txtMatKhau, "Mật khẩu không đúng");
                return;
            }
            this.Hide();
            FormMain FormMain = new FormMain(this.cbbTenDangNhap.Text.Trim(),MemberController.layIDNVTuTenDangNhap(tenDangNhap));
            FormMain.ShowDialog();
            if (FormMain.DialogResult == DialogResult.OK)
            {
                this.Show();
                this.txtMatKhau.Text = "";
                this.cbbTenDangNhap.Text="";
            }
            else
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
