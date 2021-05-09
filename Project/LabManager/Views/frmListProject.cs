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
using QRCoder;

namespace LabManager.Views
{
    public partial class frmListProject : Form
    {
        public string MSNVDangNhap;
        public frmListProject()
        {
            InitializeComponent();
            this.clmMSDuAn.DataPropertyName = nameof(Project.ID);
            this.clmTenDuAn.DataPropertyName = nameof(Project.Name);
            this.clmNgayBatDau.DataPropertyName = nameof(Project.TimeStart);
            this.clmNgayDuKienHoanThanh.DataPropertyName = nameof(Project.TimeExpectedEnd);
            this.clmChuDuAn.DataPropertyName = nameof(Project.IDAdmin);
            capNhatDanhSachDuAn();
        }
        public frmListProject(string MSNV)
        {
            InitializeComponent();
            this.MSNVDangNhap = MSNV;

            this.clmMSDuAn.DataPropertyName = nameof(Project.ID);
            this.clmTenDuAn.DataPropertyName = nameof(Project.Name);
            this.clmNgayBatDau.DataPropertyName = nameof(Project.TimeStart);
            this.clmNgayDuKienHoanThanh.DataPropertyName = nameof(Project.TimeExpectedEnd);
            this.clmChuDuAn.DataPropertyName = nameof(Project.IDAdmin);
            capNhatDanhSachDuAn();
        }
        public void capNhatDanhSachDuAn()
        {
            BindingSource source = new BindingSource();
            source.DataSource = ProjectController.layDanhSachDuAn();
            this.dgrDanhSachDuAn.DataSource = source;
            this.dgrDanhSachDuAn.Columns[5].Visible = false;
            this.dgrDanhSachDuAn.Columns[6].Visible = false;
        }

        private void dgrDanhSachDuAn_Click(object sender, EventArgs e)
        {
            if(this.dgrDanhSachDuAn.Rows.Count >= 1)
            {
                if (this.dgrDanhSachDuAn.CurrentRow.Index > -1)
                {
                    this.btnLinkCongViec.Visible = false;
                    this.dgrDanhSachCongViec.Rows.Clear();
                    string chuDA = this.dgrDanhSachDuAn.CurrentRow.Cells[4].Value.ToString().Trim();
                    if (chuDA == MSNVDangNhap)
                    {
                        this.dgrDanhSachCongViec.Columns[4].ReadOnly = false;
                        this.btnThemCongViec.Visible = true;
                    }
                    else
                    {
                        this.dgrDanhSachCongViec.Columns[4].ReadOnly = true;
                        this.btnThemCongViec.Visible = false;
                    }
                    string maDA = this.dgrDanhSachDuAn.CurrentRow.Cells[0].Value.ToString().Trim();
                    List<ProjectMember> danhSachCongViec = ProjectController.layDanhSachCongViec(maDA);
                    foreach (ProjectMember pm in danhSachCongViec)
                    {
                        this.dgrDanhSachCongViec.Rows.Add();
                        int soHang = this.dgrDanhSachCongViec.RowCount;
                        this.dgrDanhSachCongViec.Rows[soHang - 1].Cells[0].Value = soHang;
                        this.dgrDanhSachCongViec.Rows[soHang - 1].Cells[1].Value = pm.Works;
                        this.dgrDanhSachCongViec.Rows[soHang - 1].Cells[2].Value = pm.IDMember;
                        this.dgrDanhSachCongViec.Rows[soHang - 1].Cells[3].Value = pm.LinkCheckProgress;
                        if (pm.Progress == true)
                            this.dgrDanhSachCongViec.Rows[soHang - 1].Cells[4].Value = true;
                        else
                            this.dgrDanhSachCongViec.Rows[soHang - 1].Cells[4].Value = false;
                    }
                }
            }
            
        }

        private void dgrDanhSachCongViec_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==3)
            {
                try
                {
                    System.Diagnostics.Process.Start(this.dgrDanhSachCongViec.CurrentCell.Value.ToString());
                }
                catch
                {
                    MessageBox.Show("Link này không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgrDanhSachCongViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.dgrDanhSachCongViec.Rows.Count>=1)
            {
                if (e.ColumnIndex == 4)
                {
                    this.btnLinkCongViec.Visible = false;
                    string maDA = this.dgrDanhSachDuAn.CurrentRow.Cells[0].Value.ToString().Trim();
                    string maNV = this.dgrDanhSachCongViec.CurrentRow.Cells[2].Value.ToString().Trim();
                    ProjectMember congViec = ProjectController.layCongViec(maDA, maNV);
                    if (congViec == null)
                        return;
                    if (string.Compare(this.dgrDanhSachDuAn.CurrentRow.Cells[4].Value.ToString().Trim(),MSNVDangNhap)==0)
                        if(congViec.Progress==true)
                            congViec.Progress = false;
                        else
                            congViec.Progress = true;
                    ProjectController.capNhatCongViec(congViec);
                }
                else if (e.ColumnIndex == 3)
                {
                    QRCodeGenerator qr = new QRCodeGenerator();
                    string ND;
                    if (this.dgrDanhSachCongViec.CurrentRow.Cells[3].Value.ToString().Trim()=="")
                        ND = "Không có link để truy cập";
                    else
                        ND = this.dgrDanhSachCongViec.CurrentRow.Cells[3].Value.ToString();
                    QRCodeData data = qr.CreateQrCode(ND, QRCodeGenerator.ECCLevel.Q);
                    QRCode code = new QRCode(data);
                    pictureBox1.Image = code.GetGraphic(10);
                    string maNV = this.dgrDanhSachCongViec.CurrentRow.Cells[2].Value.ToString().Trim();
                    if (string.Compare(maNV, MSNVDangNhap, false) == 0)
                        this.btnLinkCongViec.Visible = true;
                    else
                        this.btnLinkCongViec.Visible = false;
                }
            }
            
        }

        private void btnThemCongViec_Click(object sender, EventArgs e)
        {
            List<string> dsMaNV = new List<string>();
            for(int i=0;i<this.dgrDanhSachCongViec.Rows.Count;i++)
            {
                dsMaNV.Add(this.dgrDanhSachCongViec.Rows[i].Cells[2].Value.ToString().Trim());
            }
            frmAddWork frmAddWork = new frmAddWork(this.dgrDanhSachDuAn.CurrentRow.Cells[0].Value.ToString().Trim(),dsMaNV);
            frmAddWork.ShowDialog();
            capNhatDanhSachCongViec();
        }

        private void dgrDanhSachCongViec_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnLinkCongViec_Click(object sender, EventArgs e)
        {
            if(this.dgrDanhSachCongViec.CurrentRow.Index>-1)
            {
                string maNV = this.dgrDanhSachCongViec.CurrentRow.Cells[2].Value.ToString().Trim();
                string maDA = this.dgrDanhSachDuAn.CurrentRow.Cells[0].Value.ToString().Trim();
                frmFixLink frmFixLink = new frmFixLink(maDA, maNV);
                frmFixLink.ShowDialog();
                capNhatDanhSachCongViec();
            }
            
        }
        private void capNhatDanhSachCongViec()
        {
            this.dgrDanhSachCongViec.Rows.Clear();
            string chuDA = this.dgrDanhSachDuAn.CurrentRow.Cells[4].Value.ToString().Trim();
            if (chuDA == MSNVDangNhap)
                this.dgrDanhSachCongViec.Columns[4].ReadOnly = false;
            else
                this.dgrDanhSachCongViec.Columns[4].ReadOnly = true;
            string maDA = this.dgrDanhSachDuAn.CurrentRow.Cells[0].Value.ToString().Trim();
            List<ProjectMember> danhSachCongViec = ProjectController.layDanhSachCongViec(maDA);
            foreach (ProjectMember pm in danhSachCongViec)
            {
                this.dgrDanhSachCongViec.Rows.Add();
                int soHang = this.dgrDanhSachCongViec.RowCount;
                this.dgrDanhSachCongViec.Rows[soHang - 1].Cells[0].Value = soHang;
                this.dgrDanhSachCongViec.Rows[soHang - 1].Cells[1].Value = pm.Works;
                this.dgrDanhSachCongViec.Rows[soHang - 1].Cells[2].Value = pm.IDMember;
                this.dgrDanhSachCongViec.Rows[soHang - 1].Cells[3].Value = pm.LinkCheckProgress;
                if (pm.Progress == true)
                    this.dgrDanhSachCongViec.Rows[soHang - 1].Cells[4].Value = true;
                else
                    this.dgrDanhSachCongViec.Rows[soHang - 1].Cells[4].Value = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.dgrDanhSachDuAn.Rows.Count>=1)
            {
                if (this.dgrDanhSachDuAn.CurrentRow.Index > -1)
                {
                    string maDA = this.dgrDanhSachDuAn.CurrentRow.Cells[0].Value.ToString().Trim();
                    ProjectController.xoaDuAn(maDA);
                    capNhatDanhSachDuAn();
                }
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(this.dgrDanhSachDuAn.Rows.Count >= 1)
            {
                if (this.dgrDanhSachDuAn.CurrentRow.Index > -1)
                {
                    string maDA = this.dgrDanhSachDuAn.CurrentRow.Cells[0].Value.ToString().Trim();
                    Project duAn = ProjectController.layDuAn(maDA);
                    frmFixProject suaDA = new frmFixProject(duAn);
                    suaDA.ShowDialog();
                    capNhatDanhSachDuAn();
                }
            }
            
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(this.cbbTimKiemTheo.Text.Trim()=="Tên dự án")
            {
                BindingSource source = new BindingSource();
                source.DataSource = ProjectController.layDanhSachDuAnTheoTen(this.txtTimKiem.Text.Trim());
                this.dgrDanhSachDuAn.DataSource = source;
                this.dgrDanhSachDuAn.Columns[5].Visible = false;
                this.dgrDanhSachDuAn.Columns[6].Visible = false;
            }
            else if(this.cbbTimKiemTheo.Text.Trim() == "Chủ dự án")
            {
                BindingSource source = new BindingSource();
                source.DataSource = ProjectController.layDanhSachDuAnTheoChuDuAn(this.txtTimKiem.Text.Trim());
                this.dgrDanhSachDuAn.DataSource = source;
                this.dgrDanhSachDuAn.Columns[5].Visible = false;
                this.dgrDanhSachDuAn.Columns[6].Visible = false;
            }
            else if (this.cbbTimKiemTheo.Text.Trim() == "Mã dự án")
            {
                BindingSource source = new BindingSource();
                source.DataSource = ProjectController.layDanhSachDuAnTheoMaDuAn(this.txtTimKiem.Text.Trim());
                this.dgrDanhSachDuAn.DataSource = source;
                this.dgrDanhSachDuAn.Columns[5].Visible = false;
                this.dgrDanhSachDuAn.Columns[6].Visible = false;
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtTimKiem.Clear();
            capNhatDanhSachDuAn();
        }
    }
}
