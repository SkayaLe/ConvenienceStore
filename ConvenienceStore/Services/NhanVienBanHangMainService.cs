using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class NhanVienBanHangMainService
    {
        public NhanVienBanHangMainService()
        {

        }

        // Lấy tên nhân viên bán hàng từ bảng người
        public string getName(string maNVBH)
        {
            return ModelEntity.db.Nguoi.Single(x => x.userID == maNVBH).hoTen;
        }

        // Trả về list nhân viên bán hàng
        public List<Model.NhanVienBanHang> getAllNVBH()
        {
            return ModelEntity.db.NhanVienBanHang.ToList();
        }
    }
}
