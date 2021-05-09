using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabManager.Models;
using System.Data.Entity.Migrations;
namespace LabManager.Controllers
{
    public class ProjectController
    {
        public static void capNhatCongViec(ProjectMember congViec)
        {
            using(var _context=new DBLabManagerEntities())
            {
                _context.ProjectMembers.AddOrUpdate(congViec);
                _context.SaveChanges();
            }
        }
        public static ProjectMember layCongViec(string maDA, string maNV)
        {
            using(var _context = new DBLabManagerEntities())
            {
                var CongViec = (from pm in _context.ProjectMembers
                                        where string.Compare(pm.IDProject.Trim(), maDA, false) == 0
                                        && string.Compare(pm.IDMember.Trim(), maNV, false) == 0
                                        select pm).SingleOrDefault();
                return CongViec;
            }
        }
        public static List<Project> layDanhSachDuAn()
        {
            using (var _context=new DBLabManagerEntities())
            {
                var danhSachDuAn = (from p in _context.Projects
                                    select p);
                return danhSachDuAn.ToList();
            }
        }
        public static List<Project> layDanhSachDuAnTheoTen(string kyTu)
        {
            using (var _context = new DBLabManagerEntities())
            {
                var danhSachDuAn = (from p in _context.Projects
                                    where p.Name.Contains(kyTu)
                                    select p);
                return danhSachDuAn.ToList();
            }
        }
        public static List<Project> layDanhSachDuAnTheoChuDuAn(string kyTu)
        {
            using (var _context = new DBLabManagerEntities())
            {
                var danhSachDuAn = (from p in _context.Projects
                                    where p.IDAdmin.Contains(kyTu)
                                    select p);
                return danhSachDuAn.ToList();
            }
        }
        public static List<Project> layDanhSachDuAnTheoMaDuAn(string kyTu)
        {
            using (var _context = new DBLabManagerEntities())
            {
                var danhSachDuAn = (from p in _context.Projects
                                    where p.ID.Contains(kyTu)
                                    select p);
                return danhSachDuAn.ToList();
            }
        }
        public static List<ProjectMember> layDanhSachCongViec(string maDA)
        {
            using (var _context = new DBLabManagerEntities())
            {
                var danhSachCongViec = (from pm in _context.ProjectMembers
                                        where string.Compare(pm.IDProject.Trim(), maDA, false) == 0
                                        select pm);
                return danhSachCongViec.ToList();
            }
        }
        public static bool themCongViec(string maDA, string maNV, string congViec)
        {
            using (var _context = new DBLabManagerEntities())
            {
                var CongViec = layCongViec(maDA, maNV);
                if(CongViec==null)
                {
                    ProjectMember CongViecMoi = new ProjectMember();
                    CongViecMoi.IDProject = maDA;
                    CongViecMoi.IDMember = maNV;
                    CongViecMoi.Works = congViec;
                    CongViecMoi.LinkCheckProgress = "";
                    CongViecMoi.Progress = false;
                    _context.ProjectMembers.Add(CongViecMoi);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        public static void xoaDuAn(string maDA)
        {
            using(var _context=new DBLabManagerEntities())
            {
                Project DuAn = (from p in _context.Projects
                                where string.Compare(p.ID.Trim(), maDA, false) == 0
                                select p).SingleOrDefault();
                List<ProjectMember> dSCongViec = (from pm in _context.ProjectMembers
                                                where string.Compare(pm.IDProject.Trim(), maDA, false) == 0
                                                select pm).ToList();
                foreach(ProjectMember CongViec in dSCongViec)
                {
                    _context.ProjectMembers.Remove(CongViec);
                }
                _context.Projects.Remove(DuAn);
                _context.SaveChanges();
            }
        }
        public static Project layDuAn(string maDA)
        {
            using (var _context=new DBLabManagerEntities())
            {
                Project DuAn = (from p in _context.Projects
                                where string.Compare(p.ID.Trim(), maDA, false) == 0
                                select p).SingleOrDefault();
                return DuAn;
            }
        }
        public static void capNhatDuAn(Project DuAn)
        {
            using (var _context=new DBLabManagerEntities())
            {
                _context.Projects.AddOrUpdate(DuAn);
                _context.SaveChanges();
            }
        }
        public static bool kiemTraDuAnDaTonTai(string maDA)
        {
            using(var _context = new DBLabManagerEntities())
            {
                if (layDuAn(maDA) == null)
                    return false;
                return true;
            }
        }
        public static void themDuAn(Project DuAn)
        {
            using(var _context = new DBLabManagerEntities())
            {
                _context.Projects.Add(DuAn);
                _context.SaveChanges();
            }
        }
        public static List<ProjectMember> layDSNhungCongViecChuaLamCuaNhanVien(string maNV)
        {
            using(var _context= new DBLabManagerEntities())
            {
                var dsCongViec = (from pm in _context.ProjectMembers
                                  where string.Compare(pm.IDMember.Trim(), maNV, false) == 0
                                  && pm.Progress == false
                                  select pm).ToList();
                return dsCongViec;
            }
        }
        public static List<ProjectMember> layDSNhungCongViecChuaLam()
        {
            using(var _context = new DBLabManagerEntities())
            {
                var dsCongViec = (from pm in _context.ProjectMembers
                                  where pm.Progress == false
                                  select pm).ToList();
                return dsCongViec;
            }
        }
        
    }
    
}
