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
namespace LabManager.Views
{
    public partial class frmAddWork : Form
    {
        public string MaDA;
        public ProjectMember CongViec = new ProjectMember();
        public frmAddWork()
        {
            InitializeComponent();
        }
        //public frmAddWork(string maDA)
        //{
        //    InitializeComponent();
        //    this.MaDA = maDA;
        //}
        public frmAddWork(string maDA,List<string> dsMaNV)
        {
            InitializeComponent();
            this.MaDA = maDA;
            loadDuLieuMaNV(dsMaNV);
        }

        private void loadDuLieuMaNV(List<string> dsMaNV)
        {
            this.cbbMaNV.Items.Clear();
            foreach (string item in MemberController.layDanhSachMaNV())
            {
                bool kiemTra = true;
                foreach(string congViec in dsMaNV)
                {
                    if(string.Compare(congViec.Trim(),item.Trim(),false)==0)
                    {
                        kiemTra = false;
                        break;
                    }
                }
                if(kiemTra)
                    this.cbbMaNV.Items.Add(item.Trim());
            }
                
        }
        private void btnThemCongViec_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            //string maNV = txtMaNV.Text.ToString().Trim();
            string maNV = this.cbbMaNV.Text.Trim();
            string congViec = this.txtCongViec.Text.ToString().Trim();
            if(maNV=="")
            {
                errorProvider1.SetError(cbbMaNV, "Hãy điền mã nhân viên");
                return;
            }
            else if(congViec=="")
            {
                errorProvider1.SetError(txtCongViec, "Hãy điền công việc");
                return;
            }
            else if(!MemberController.kiemTraMaSoNhanVien(maNV))
            {
                errorProvider1.SetError(cbbMaNV, "Mã nhân viên không tồn tại");
                return;
            }
            try
            {
                if (ProjectController.themCongViec(this.MaDA, maNV, congViec))
                {
                    CongViec.IDMember = maNV;
                    CongViec.IDProject = MaDA;
                    CongViec.Works = congViec;
                    MessageBox.Show("Thêm công việc thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    errorProvider1.SetError(cbbMaNV, "Nhân viên này đã có công việc trong dự án này");
                    return;
                }
            }
            catch
            {
                CongViec.IDMember = maNV;
                CongViec.IDProject = MaDA;
                CongViec.Works = congViec;
                this.DialogResult = DialogResult.OK;
                //MessageBox.Show("Thêm công việc thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            
            
            
            //else
            //{
            //    errorProvider1.SetError(txtMaNV, "Nhân viên này đã có công việc trong dự án này");
            //    return;
            //}
        }
    }
}
