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
    public partial class frmAddProject : Form
    {
        public string MSNVDangNhap;
        public frmAddProject()
        {
            InitializeComponent();
        }
        public frmAddProject(string MSNV)
        {
            InitializeComponent();
            this.MSNVDangNhap = MSNV;
        }

        private void btnThemCongViec_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (ProjectController.kiemTraDuAnDaTonTai(this.txtMaSoDuAn.Text.ToString().Trim()))
            {
                errorProvider1.SetError(this.txtMaSoDuAn, "Mã dự án đã tồn tại");
                return;
            }
            List<string> dsMaNV = new List<string>();
            for(int i=0;i<this.dgrDanhSachCongViec.Rows.Count;i++)
            {
                dsMaNV.Add(this.dgrDanhSachCongViec.Rows[i].Cells[1].Value.ToString().Trim());
            }
            frmAddWork frmAddWork1 = new frmAddWork(this.txtMaSoDuAn.Text.ToString().Trim(),dsMaNV);
            frmAddWork1.ShowDialog();
            //capNhatDanhSachCongViec();
            if(frmAddWork1.DialogResult==DialogResult.OK)
            {
                this.dgrDanhSachCongViec.Rows.Add();
                int soHang = this.dgrDanhSachCongViec.RowCount;
                this.dgrDanhSachCongViec.Rows[soHang - 1].Cells[0].Value = frmAddWork1.CongViec.Works;
                this.dgrDanhSachCongViec.Rows[soHang - 1].Cells[1].Value = frmAddWork1.CongViec.IDMember;
            }
            
        }
        private void capNhatDanhSachCongViec()
        {
            this.dgrDanhSachCongViec.Rows.Clear();
            string chuDA = MSNVDangNhap;
            if (chuDA == MSNVDangNhap)
                this.dgrDanhSachCongViec.Columns[4].ReadOnly = false;
            else
                this.dgrDanhSachCongViec.Columns[4].ReadOnly = true;
            string maDA = this.txtMaSoDuAn.Text.ToString().Trim();
            List<ProjectMember> danhSachCongViec = ProjectController.layDanhSachCongViec(maDA);
            foreach (ProjectMember pm in danhSachCongViec)
            {
                this.dgrDanhSachCongViec.Rows.Add();
                int soHang = this.dgrDanhSachCongViec.RowCount;
                this.dgrDanhSachCongViec.Rows[soHang - 1].Cells[0].Value = pm.Works;
                this.dgrDanhSachCongViec.Rows[soHang - 1].Cells[1].Value = pm.IDMember;
                if (pm.Progress == true)
                    this.dgrDanhSachCongViec.Rows[soHang - 1].Cells[4].Value = true;
                else
                    this.dgrDanhSachCongViec.Rows[soHang - 1].Cells[4].Value = false;

            }
        }

        private void btnThemDuAn_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string maDA = this.txtMaSoDuAn.Text.ToString().Trim();
            string tenDuAn = this.txtTenDuAn.Text.ToString().Trim();
            string chuDA = MSNVDangNhap;
            DateTime thoiGianBatDau = this.dtpThoiGianBatDau.Value;
            DateTime thoiGianKetThuc = this.dtpThoiGianKetThuc.Value;
            if(maDA=="")
            {
                errorProvider1.SetError(this.txtMaSoDuAn, "Hãy điền mã số dự án");
                return;
            }
            else if (tenDuAn == "")
            {
                errorProvider1.SetError(this.txtTenDuAn, "Hãy điền tên dự án");
                return;
            }
            else if(ProjectController.kiemTraDuAnDaTonTai(maDA))
            {
                errorProvider1.SetError(this.txtMaSoDuAn, "Mã dự án đã tồn tại");
                return;
            }
            else if (!MemberController.kiemTraMaSoNhanVien(chuDA))
            {
                errorProvider1.SetError(this.txtMaSoDuAn, "Mã số nhân viên không tồn tại");
                return;
            }
            else if (thoiGianBatDau >= thoiGianKetThuc)
            {
                errorProvider1.SetError(this.dtpThoiGianKetThuc, "Thời gian kết thúc không được nhỏ hơn thời gian bắt đầu");
                return;
            }
            Project DuAn = new Project();
            DuAn.ID = maDA;
            DuAn.Name = tenDuAn;
            DuAn.IDAdmin = chuDA;
            DuAn.TimeStart = thoiGianBatDau;
            DuAn.TimeExpectedEnd = thoiGianKetThuc;
            ProjectController.themDuAn(DuAn);
            List<string> dSCongViec = new List<string>();
            List<string> dSMaNV = new List<string>();
            
            for(int i=0;i<this.dgrDanhSachCongViec.Rows.Count;i++)
            {
                bool kiemTra = true;
                for (int j=0;j<dSMaNV.Count;j++)
                {
                    if (this.dgrDanhSachCongViec.Rows[i].Cells[1].Value.ToString().Trim() == dSMaNV[j])
                    {
                        kiemTra = false;
                        break;
                    }
                }
                if (kiemTra)
                {
                    dSMaNV.Add(this.dgrDanhSachCongViec.Rows[i].Cells[1].Value.ToString().Trim());
                }
            }
            for(int i=0;i<dSMaNV.Count;i++)
            {
                string cv = "";
                for(int j=0;j<this.dgrDanhSachCongViec.Rows.Count;j++)
                {
                    if (this.dgrDanhSachCongViec.Rows[j].Cells[1].Value.ToString().Trim() == dSMaNV[i])
                        if(cv=="")
                            cv+= this.dgrDanhSachCongViec.Rows[j].Cells[0].Value.ToString().Trim();
                        else
                            cv += ", "+this.dgrDanhSachCongViec.Rows[j].Cells[0].Value.ToString().Trim();
                }
                dSCongViec.Add(cv);
            }
            for (int i = 0; i < dSMaNV.Count; i++)
                ProjectController.themCongViec(maDA, dSMaNV[i], dSCongViec[i]);
            this.Close();
        }
    }
}
