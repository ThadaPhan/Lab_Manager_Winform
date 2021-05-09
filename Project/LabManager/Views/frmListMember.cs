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
using PagedList;
using DGVPrinterHelper;

namespace LabManager.Views
{
    public partial class frmListMember : Form
    {
        public string MaNVDangNhap;
        public frmListMember()
        {
            InitializeComponent();
        }
        public frmListMember(string maNV)
        {
            InitializeComponent();
            this.clmMaSoNhanVien.DataPropertyName = nameof(Member.ID);
            this.clmTenNhanVien.DataPropertyName = nameof(Member.FullName);
            this.clmSDT.DataPropertyName = nameof(Member.Phone);
            this.clmEmail.DataPropertyName = nameof(Member.Email);
            this.clmNgaySinh.DataPropertyName = nameof(Member.BirthDay);
            this.clmLuong.DataPropertyName = nameof(Member.Salary);
            this.clmDiaChi.DataPropertyName = nameof(Member.Address);
            this.clmThoiGianBatDauLamViec.DataPropertyName = nameof(Member.TimeStartWork);
            this.clmGioBatDauLam.DataPropertyName = nameof(Member.TimeBegin);
            this.clmGioNghi.DataPropertyName = nameof(Member.TimeEnd);
            this.MaNVDangNhap = maNV;
            this.btnSua.Visible = false;
            this.btnXoa.Visible = false;
            CapNhatDanhSach();
        }
        public void CapNhatDanhSach()
        {
            BindingSource source = new BindingSource();
            source.DataSource = MemberController.layDanhSachThanhVien();
            this.dgrDanhSachThanhVien.DataSource = source;
            this.dgrDanhSachThanhVien.Columns[10].Visible = false;
            this.dgrDanhSachThanhVien.Columns[11].Visible = false;
            this.dgrDanhSachThanhVien.Columns[12].Visible = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(this.dgrDanhSachThanhVien.Rows.Count>=1)
            {
                if (this.dgrDanhSachThanhVien.CurrentRow.Index != -1)
                {

                    string MSNV = this.dgrDanhSachThanhVien.CurrentRow.Cells[0].Value.ToString().Trim();
                    Member thanhVien = MemberController.layNhanVienTuMaNV(MSNV);
                    frmFixMember frmFixMember = new frmFixMember(thanhVien);
                    frmFixMember.ShowDialog();
                    CapNhatDanhSach();
                }
            }
            
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(this.dgrDanhSachThanhVien.Rows.Count>=1)
            {
                if (this.dgrDanhSachThanhVien.CurrentRow.Index >= -1)
                {
                    string MSNV = this.dgrDanhSachThanhVien.CurrentRow.Cells[0].Value.ToString().Trim();
                    List<Project> danhSachDuAn = ProjectController.layDanhSachDuAn();
                    foreach (Project project in danhSachDuAn)
                    {
                        if (project.IDAdmin.Trim() == MSNV)
                        {
                            MessageBox.Show("Nhân viên này đang là chủ của dự án " + project.Name + ", bạn không thể xóa nhân viên này, nếu bạn vẫn" +
                                " xóa nhân viên này thì mời bạn thay đổi chủ của dự án này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    Member thanhVien = MemberController.layNhanVienTuMaNV(MSNV);
                    MemberController.xoaNhanVien(thanhVien);
                    CapNhatDanhSach();
                }
            }
            
        }

        private void dgrDanhSachThanhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.dgrDanhSachThanhVien.Rows.Count>=1)
                if(this.dgrDanhSachThanhVien.CurrentRow.Index>-1)
                {
                    string maNV = this.dgrDanhSachThanhVien.CurrentRow.Cells[0].Value.ToString().Trim();
                    if(string.Compare(maNV,MaNVDangNhap,false)==0)
                    {
                        this.btnSua.Visible = true;
                        this.btnXoa.Visible = true;
                    }
                    else
                    {
                        this.btnSua.Visible = false;
                        this.btnXoa.Visible = false;
                    }
                }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Danh sách Nhân viên";
            print.SubTitle = "Ngày in: " + DateTime.Now.ToShortDateString();
            
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Tài liệu lưu hành nội bộ";
            print.FooterSpacing = 15;
            print.PrintDataGridView(this.dgrDanhSachThanhVien);
        }

        private void cbbTimKiemTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtTimKiem.Clear();
            CapNhatDanhSach();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (this.cbbTimKiemTheo.Text.Trim() == "Tên nhân viên")
            {

                BindingSource source = new BindingSource();
                source.DataSource = MemberController.layDanhSachThanhVien(this.txtTimKiem.Text.Trim());
                this.dgrDanhSachThanhVien.DataSource = source;
                this.dgrDanhSachThanhVien.Columns[10].Visible = false;
                this.dgrDanhSachThanhVien.Columns[11].Visible = false;
                this.dgrDanhSachThanhVien.Columns[12].Visible = false;
            }
            else if (this.cbbTimKiemTheo.Text.Trim() == "Mã nhân viên")
            {
                BindingSource source = new BindingSource();
                source.DataSource = MemberController.layDanhSachThanhVienTheoMaNV(this.txtTimKiem.Text.Trim());
                this.dgrDanhSachThanhVien.DataSource = source;
                this.dgrDanhSachThanhVien.Columns[10].Visible = false;
                this.dgrDanhSachThanhVien.Columns[11].Visible = false;
                this.dgrDanhSachThanhVien.Columns[12].Visible = false;
            }
        }

        private void dgrDanhSachThanhVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgrDanhSachThanhVien.Rows.Count >= 1)
                if (this.dgrDanhSachThanhVien.CurrentRow.Index > -1)
                {

                }
        }
    }
}
