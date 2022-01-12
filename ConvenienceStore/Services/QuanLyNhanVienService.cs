using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class QuanLyNhanVienService
    {
        public QuanLyNhanVienService()
        {

        }

        public List<dynamic> GetAllNhanVien()
        {
            var query = ModelEntity.db.Nguoi.Join
                (
                    ModelEntity.db.NhanVienBanHang,
                    nguoi => nguoi.userID,
                    nvbh => nvbh.maNVBH,
                    (nguoi, nvbh) => new
                    {
                        maNVBH = nvbh.maNVBH,
                        hoTen = nguoi.hoTen,
                        ngaySinh = nguoi.ngaySinh,
                        gioiTinh = nguoi.gioiTinh,
                        cmnd = nguoi.cmnd,
                        sdt = nguoi.sdt,
                        email = nguoi.email,
                        diaChi = nguoi.diaChi,
                        soGioLam = nvbh.soGioLam,
                        danhGia = nvbh.danhgia,
                        luong = nvbh.luong
                    }
                ).ToList();

            List<dynamic> list = new List<dynamic>();

            foreach (var item in query)
                list.Add(item);

            return list;
        }

        public bool ThemNhanVien(string hoTen, DateTime ngaySinh, bool gioiTinh, string cmnd, string sdt, string diaChi, double soGioLam, int danhGia, double luong, string maQL)
        {
            string maNVBH = AutoCreateNewMaNhanVien();

            ModelEntity.db.Nguoi.Add(new Model.Nguoi
            {
                userID = maNVBH,
                passwd = "123",
                hoTen = hoTen,
                ngaySinh = ngaySinh,
                gioiTinh = gioiTinh,
                cmnd = cmnd,
                sdt = sdt,
                email = maNVBH.ToLower() + "@convstore.com",
                diaChi = diaChi
            });

            ModelEntity.db.NhanVienBanHang.Add(new Model.NhanVienBanHang
            {
                maNVBH = maNVBH,
                maCN = ModelEntity.db.ChiNhanh.Where(x => x.maQL == maQL).Single().maCN,
                soGioLam = soGioLam,
                danhgia = danhGia,
                luong = luong
            });

            ModelEntity.db.SaveChanges();

            return true;
        }

        public bool SuaNhanVien(string maNVBH, string hoTen, DateTime ngaySinh, bool gioiTinh, string cmnd, string sdt, string diaChi, double soGioLam, int danhGia, double luong, string maQL)
        {
            var nguoi = ModelEntity.db.Nguoi.Where(x => x.userID == maNVBH).Single();

            nguoi.hoTen = hoTen;
            nguoi.ngaySinh = ngaySinh;
            nguoi.gioiTinh = gioiTinh;
            nguoi.cmnd = cmnd;
            nguoi.sdt = sdt;
            nguoi.diaChi = diaChi;

            var nvbh = ModelEntity.db.NhanVienBanHang.Where(x => x.maNVBH == maNVBH).Single();

            nvbh.soGioLam = soGioLam;
            nvbh.danhgia = danhGia;
            nvbh.luong = luong;

            ModelEntity.db.SaveChanges();

            return true;
        }

        public bool XoaNhanVien(string maNVBH)
        {
            ModelEntity.db.Nguoi.Remove(ModelEntity.db.Nguoi.Where(x => x.userID == maNVBH).Single());
            ModelEntity.db.NhanVienBanHang.Remove(ModelEntity.db.NhanVienBanHang.Where(x => x.maNVBH == maNVBH).Single());

            ModelEntity.db.SaveChanges();

            return true;
        }

        public string AutoCreateNewMaNhanVien()
        {
            int count = ModelEntity.db.NhanVienBanHang.Count();
            count++;
            return  "BH" + count.ToString().PadLeft(6, '0');
        }
    }
}
