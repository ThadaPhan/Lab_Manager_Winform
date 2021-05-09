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
using LabManager.Views;
using LabManager.Controllers;
namespace LabManager
{
    public partial class FormMain : Form
    {
        public string TenNVDangNhap;
        public string MaNVDangNhap;
        public FormMain()
        {
            InitializeComponent();

        }
        public FormMain(string TenNV,string MaNV)
        {
            InitializeComponent();
            this.TenNVDangNhap = TenNV;
            this.MaNVDangNhap = MaNV;
            this.txtTenNhanVien.Text = "Tên đăng nhập: "+ this.TenNVDangNhap;
            capNhatDanhSachCongViecChuaLam();
            capNhatDanhSachNhungDuAnChuaLam();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
              
        }

        private void danhSáchDựÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListProject frmListProject = new frmListProject(this.MaNVDangNhap);
            frmListProject.ShowDialog();
            capNhatDanhSachCongViecChuaLam();
            capNhatDanhSachNhungDuAnChuaLam();
        }

        private void thêmDựÁnToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAddProject frmAddProject = new frmAddProject(this.MaNVDangNhap);
            frmAddProject.ShowDialog();
            capNhatDanhSachCongViecChuaLam();
            capNhatDanhSachNhungDuAnChuaLam();
        }

        private void danhSáchThànhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListMember frmListMember = new frmListMember(this.MaNVDangNhap);
            frmListMember.Show();
        }

        private void thêmThànhViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddMember frmAddMember = new frmAddMember();
            frmAddMember.Show();
        }
        private void capNhatDanhSachCongViecChuaLam()
        {
            this.dgrDsCongViecChuaHoanThanh.Rows.Clear();
            List<ProjectMember> dSCongViec = ProjectController.layDSNhungCongViecChuaLamCuaNhanVien(MaNVDangNhap);
            foreach(ProjectMember congViec in dSCongViec)
            {
                Project duAn = ProjectController.layDuAn(congViec.IDProject.Trim());
                this.dgrDsCongViecChuaHoanThanh.Rows.Add();
                int hang = this.dgrDsCongViecChuaHoanThanh.Rows.Count-1;
                this.dgrDsCongViecChuaHoanThanh.Rows[hang].Cells[0].Value = hang+1;
                this.dgrDsCongViecChuaHoanThanh.Rows[hang].Cells[1].Value = congViec.Works.Trim();
                this.dgrDsCongViecChuaHoanThanh.Rows[hang].Cells[2].Value = duAn.Name.Trim();
                this.dgrDsCongViecChuaHoanThanh.Rows[hang].Cells[3].Value = duAn.TimeExpectedEnd;
                this.dgrDsCongViecChuaHoanThanh.Rows[hang].Cells[4].Value = duAn.IDAdmin.Trim();
            }
        }
        private void capNhatDanhSachNhungDuAnChuaLam()
        {
            this.dgrDsDuAnChuaLam.Rows.Clear();
            List<ProjectMember> dsCongViec = ProjectController.layDSNhungCongViecChuaLam();
            List<string> danhSachMaSoDuAn = new List<string>();
            List<string> danhSachCongViecChuaLam = new List<string>();
            foreach(ProjectMember congViec in dsCongViec)
            {
                bool kiemTra = true;
                for(int i=0;i<danhSachMaSoDuAn.Count;i++)
                    if(congViec.IDProject.Trim()==danhSachMaSoDuAn[i])
                    {
                        kiemTra = false;
                        break;
                    }
                if (kiemTra)
                    danhSachMaSoDuAn.Add(congViec.IDProject.Trim());
            }
            for(int i=0;i<danhSachMaSoDuAn.Count;i++)
            {
                string cv = "";
                foreach (ProjectMember congViec in dsCongViec)
                {
                    if (congViec.IDProject.Trim() == danhSachMaSoDuAn[i])
                        if(!cv.Contains(congViec.Works.Trim()))
                    {    
                        if (cv == "")
                            cv += congViec.Works.Trim();
                        else
                            cv += "; " + congViec.Works.Trim();
                    }
                }
                danhSachCongViecChuaLam.Add(cv);
            }
            for(int i=0;i<danhSachMaSoDuAn.Count;i++)
            {
                this.dgrDsDuAnChuaLam.Rows.Add();
                Project duAn = ProjectController.layDuAn(danhSachMaSoDuAn[i]);
                int hang = this.dgrDsDuAnChuaLam.Rows.Count - 1;
                this.dgrDsDuAnChuaLam.Rows[hang].Cells[0].Value = hang+1;
                this.dgrDsDuAnChuaLam.Rows[hang].Cells[1].Value = duAn.Name.Trim();
                this.dgrDsDuAnChuaLam.Rows[hang].Cells[2].Value = duAn.TimeExpectedEnd;
                this.dgrDsDuAnChuaLam.Rows[hang].Cells[3].Value = danhSachCongViecChuaLam[i];
                this.dgrDsDuAnChuaLam.Rows[hang].Cells[4].Value = duAn.IDAdmin.Trim();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
