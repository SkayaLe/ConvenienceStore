using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class NhanVienThuKhoMainService
    {
        public NhanVienThuKhoMainService()
        {

        }

        public string getName(string maNVTK)
        {
            return ModelEntity.db.Nguoi.Single(x => x.userID == maNVTK).hoTen;
        }

        public List<Model.NhanVienThuKho> getAllNVBH()
        {
            return ModelEntity.db.NhanVienThuKho.ToList();
        }
    }
}
