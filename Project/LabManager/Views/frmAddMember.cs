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
    public partial class frmAddMember : Form
    {
        public frmAddMember()
        {
            InitializeComponent();
            this.nudGioLam.Value = 7;
            this.nudGioNghi.Value = 17;
            this.nudPhutLam.Value = 0;
            this.nudPhutNghi.Value = 0;
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {

            errorProvider1.Clear();
            string MSNV = this.txtMSNV.Text.ToString().Trim();
            string TenNV = this.txtTenNhanVien.Text.ToString().Trim();
            string SDT = this.txtSoDienThoai.Text.ToString().Trim();
            string Email = this.txtEmail.Text.ToString().Trim();
            DateTime NgaySinh = this.dtNgaySinh.Value;
            string Luong = this.txtLuong.Text.ToString().Trim();
            string DiaChi = this.txtDiaChi.Text.ToString().Trim();
            DateTime ThoiGianBatDauLamViec = this.dtThoiGianBatDauLamViec.Value;
            DateTime GioLam = DateTime.MinValue;
            DateTime GioNghi = DateTime.MinValue;

            GioLam = new DateTime(1, 1, 1, int.Parse(this.nudGioLam.Value.ToString()), int.Parse(this.nudPhutLam.Value.ToString()), 0);
            GioNghi = new DateTime(1, 1, 1, int.Parse(this.nudGioNghi.Value.ToString()), int.Parse(this.nudPhutNghi.Value.ToString()), 0);


            if (MSNV=="")
            {
                errorProvider1.SetError(txtMSNV, "Hãy điền Mã nhân viên");
                return;
            }
            else if(TenNV=="")
            {
                errorProvider1.SetError(txtTenNhanVien, "Hãy điền tên nhân viên");
                return;
            }
            else if(SDT=="")
            {
                errorProvider1.SetError(txtSoDienThoai, "Hãy điền số điện thoại");
                return;
            }
            else if(Email=="")
            {
                errorProvider1.SetError(txtEmail, "Hãy điền email");
                return;
            }
            else if(NgaySinh==null)
            {
                errorProvider1.SetError(dtNgaySinh, "Hãy điền ngày sinh");
                return;
            }
            else if(Luong == "")
            {
                errorProvider1.SetError(txtLuong, "Hãy điền lương cho nhân viên");
                return;
            }
            else if(DiaChi=="")
            {
                errorProvider1.SetError(txtDiaChi, "Hãy điền địa chỉ cho nhân viên");
                return;
            }
            else if(ThoiGianBatDauLamViec == null)
            {
                errorProvider1.SetError(dtThoiGianBatDauLamViec, "Hãy điền thời gian bắt đầu làm việc cho nhân viên");
                return;
            }
            else if (GioLam == DateTime.MinValue)
            {
                errorProvider1.SetError(nudPhutLam, "Hãy điền giờ bắt đầu làm cho nhân viên");
                return;
            }
            else if (GioNghi == DateTime.MinValue)
            {
                errorProvider1.SetError(nudPhutNghi, "Hãy điền giờ nghỉ cho nhân viên");
                return;
            }
            else if(MemberController.kiemTraMaSoNhanVien(MSNV))
            {
                errorProvider1.SetError(txtMSNV, "Mã số nhân viên đã tồn tại");
                return;
            }
            else if(!kiemTraSoDienThoaiHopLe(SDT))
            {
                errorProvider1.SetError(txtSoDienThoai, "Số điện thoại không hợp lệ");
                return;
            }
            else if(!kiemTraEmail(Email))
            {
                errorProvider1.SetError(txtEmail, "Email không hợp lệ");
                return;
            }
            else if(NgaySinh.AddYears(16).Date>DateTime.Today.Date)
            {
                errorProvider1.SetError(dtNgaySinh, "Nhân viên quá nhỏ tuổi");
                return;
            }
            else if(!int.TryParse(Luong,out int a) || a<0)
            {
                errorProvider1.SetError(txtLuong, "Lương không hợp lệ");
                return;
            }
            else if(ThoiGianBatDauLamViec.Date>DateTime.Today)
            {
                errorProvider1.SetError(dtThoiGianBatDauLamViec, "Thời gian bắt đầu làm việc không thể lớn hơn ngày hiện tại");
                return;
            }
            else if (int.Parse(this.nudGioLam.Value.ToString())> int.Parse(this.nudGioNghi.Value.ToString()))
            {
                errorProvider1.SetError(nudPhutNghi, "Giờ nghỉ phải giờ bắt đầu làm");
                return;
            }
            else if (int.Parse(this.nudGioLam.Value.ToString()) == int.Parse(this.nudGioNghi.Value.ToString()))
            {
                if (int.Parse(this.nudPhutLam.Value.ToString()) >= int.Parse(this.nudPhutNghi.Value.ToString()))
                    errorProvider1.SetError(nudPhutNghi, "Giờ nghỉ phải giờ bắt đầu làm");
                return;
            }
            Member nhanvien = new Member();
            nhanvien.ID = MSNV;
            nhanvien.FullName = TenNV;
            nhanvien.Phone = SDT;
            nhanvien.Email = Email;
            nhanvien.BirthDay = NgaySinh;
            nhanvien.Salary = int.Parse(Luong);
            nhanvien.Address = DiaChi;
            nhanvien.TimeStartWork = ThoiGianBatDauLamViec;
            nhanvien.TimeBegin = GioLam.TimeOfDay;
            nhanvien.TimeEnd = GioNghi.TimeOfDay;
            MemberController.themNhanVien(nhanvien);
            MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.txtMSNV.Clear();
            this.txtTenNhanVien.Clear();
            this.txtSoDienThoai.Clear();
            this.txtEmail.Clear();
            this.dtNgaySinh.Value = DateTime.Now;
            this.txtLuong.Clear();
            this.txtDiaChi.Clear();
            this.dtThoiGianBatDauLamViec.Value = DateTime.Now;
            this.nudGioLam.Value = 7;
            this.nudGioNghi.Value = 17;
            this.nudPhutLam.Value = 0;
            this.nudPhutNghi.Value = 0;
        }
        public bool kiemTraSoDienThoaiHopLe(string soDienThoai)
        {
            if (soDienThoai.Length != 10 || soDienThoai[0] != '0')
                return false;
            else
            {

                bool check = int.TryParse(soDienThoai, out int values);
                if (!check)
                    return false;
            }
            return true;
        }
        public bool kiemTraEmail(string email)
        {
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i < email.Length; i++)
            {
                if (i == 0)
                {
                    if (email[i] == '@'|| email[i]=='.')
                        return false;
                }
                else
                {
                    if (email[i] == '@')
                        count1++;
                    if (email[i] == '.')
                        count2++;
                }

            }
            if (count1 != 1)
                return false;
            if (count2 < 1)
                return false;
            return true;
        }
    }
}
