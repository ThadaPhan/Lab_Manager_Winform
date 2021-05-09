using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabManager.Models;
using System.Data.Entity.Migrations;
namespace LabManager.Controllers
{
    public class MemberController
    {
        public static string layIDNVTuTenDangNhap(string tenDangNhap)
        {
            using(var _context = new DBLabManagerEntities())
            {
                var NV = (from s in _context.SignIns
                            where s.UserName == tenDangNhap
                            select s).SingleOrDefault();
                if (NV == null)
                    return null;
                if (string.Compare(NV.UserName.Trim(), tenDangNhap, false) == 0)
                    return NV.IDMember.Trim();
                return null;
            }
        }
        public static bool kiemTraTenDangNhap(string tenDangNhap)
        {
            using (var _context = new DBLabManagerEntities())
            {
                var TenDangNhapDB = (from s in _context.SignIns
                                     where s.UserName == tenDangNhap
                                     select s.UserName).SingleOrDefault();
                if (TenDangNhapDB == null)
                    return false;
                if (string.Compare(TenDangNhapDB.Trim(), tenDangNhap, false) == 0)
                    return true;
                return false;
            }
        }
        public static bool kiemTraMaSoNhanVien(string maSoNhanVien)
        {
            using (var _context = new DBLabManagerEntities())
            {
                var MaSoNhanVienDB = (from s in _context.SignIns
                                      where s.IDMember == maSoNhanVien
                                      select s.IDMember).SingleOrDefault();
                if (MaSoNhanVienDB == null)
                    return false;
                if (string.Compare(MaSoNhanVienDB.Trim(), maSoNhanVien, false) == 0)
                    return true;
                return false;
            }
        }
        public static void themTaiKhoan(SignIn signIn)
        {
            using (var _context = new DBLabManagerEntities())
            {
                _context.SignIns.Add(signIn);
                _context.SaveChanges();
            }
        }
        public static void themNhanVien(Member nhanVien)
        {
            using (var _context = new DBLabManagerEntities())
            {
                _context.Members.Add(nhanVien);
                _context.SaveChanges();
            }
        }
        public static bool kiemTraMatKhau(string matKhau,string tenDangNhap)
        {
            using (var _context = new DBLabManagerEntities())
            {
                var DangNhap = (from s in _context.SignIns
                               where s.PassWord == matKhau && s.UserName == tenDangNhap
                               select s.UserName).SingleOrDefault();
                if (DangNhap == null)
                    return false;
                if (string.Compare(DangNhap.Trim(),tenDangNhap,false)==0)
                    return true;
                return false;
            }
        }
        public static List<string> layDanhSachTenDangNhap()
        {
            using (var _context = new DBLabManagerEntities())
            {
                var danhSachTenDangNhap = (from s in _context.SignIns
                                           select s.UserName);
                return danhSachTenDangNhap.ToList();
            }
        }
        public static List<Member> layDanhSachThanhVien()
        {
            using (var _context = new DBLabManagerEntities())
            {
                var danhSachThanhVien = (from m in _context.Members
                                         select m);
                return danhSachThanhVien.ToList();
            }
        }
        public static List<Member> layDanhSachThanhVien(string kyTu)
        {
            using (var _context = new DBLabManagerEntities())
            {
                var danhSachThanhVien = (from m in _context.Members
                                         where m.FullName.Contains(kyTu)
                                         select m);
                return danhSachThanhVien.ToList();
            }
        }
        public static List<Member> layDanhSachThanhVienTheoMaNV(string kyTu)
        {
            using (var _context = new DBLabManagerEntities())
            {
                var danhSachThanhVien = (from m in _context.Members
                                         where m.ID.Contains(kyTu)
                                         select m);
                return danhSachThanhVien.ToList();
            }
        }
        public static void SuaThongTinThanhVien(Member thanhVien)
        {
            using(var _context = new DBLabManagerEntities())
            {
                _context.Members.AddOrUpdate(thanhVien);
                _context.SaveChanges();
            }
        }
        public static Member layNhanVienTuMaNV(string MaNV)
        {
            using (var _context = new DBLabManagerEntities())
            {
                var nhanVien = (from m in _context.Members
                                where string.Compare(m.ID.Trim(), MaNV, false) == 0
                                select m).SingleOrDefault();
                return nhanVien;
            }
        }
        public static void xoaNhanVien(Member thanhVien)
        {
            using (var _context = new DBLabManagerEntities())
            {
                
                var ThanhVien = (from m in _context.Members
                                 where m.ID == thanhVien.ID
                                 select m).SingleOrDefault();
                try
                {
                    var TaiKhoan = (from s in _context.SignIns
                                    where s.IDMember == thanhVien.ID
                                    select s).SingleOrDefault();
                    _context.SignIns.Remove(TaiKhoan);
                }
                catch
                { 

                }
                _context.Members.Remove(ThanhVien);
                _context.SaveChanges();
                
            }
        }
        public static List<string> layDanhSachMaNV()
        {
            using (var _context=new DBLabManagerEntities())
            {
                var dsMaNV = (from m in _context.Members
                              select m.ID).ToList();
                return dsMaNV;
            }
        }

    }
}
