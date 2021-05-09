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
    public partial class frmFixLink : Form
    {
        public string MaDA, MaNV;
        public frmFixLink()
        {
            InitializeComponent();
        }

        private void btnCapNhatLink_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string linkMoi = this.txtLinkMoi.Text.ToString().Trim();
            if(linkMoi=="")
            {
                errorProvider1.SetError(txtLinkMoi, "Hãy điền link mới");
                return;
            }
            ProjectMember congViec = ProjectController.layCongViec(MaDA, MaNV);
            congViec.LinkCheckProgress = linkMoi;
            ProjectController.capNhatCongViec(congViec);
            this.Close();
        }

        public frmFixLink(string maDA,string maNV)
        {
            InitializeComponent();
            this.MaDA = maDA;
            this.MaNV = maNV;
        }
    }
}
