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

        // Lấy tên nhân viên thủ kho từ table Nguoi
        public string getName(string maNVTK)
        {
            return ModelEntity.db.Nguoi.Single(x => x.userID == maNVTK).hoTen;
        }
    }
}
