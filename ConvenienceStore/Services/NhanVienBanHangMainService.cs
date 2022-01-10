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

        public string getName(string maNVBH)
        {
            return ModelEntity.db.Nguoi.Single(x => x.userID == maNVBH).hoTen;
        }

        public List<Model.NhanVienBanHang> getAllNVBH()
        {
            return ModelEntity.db.NhanVienBanHang.ToList();
        }
    }
}
