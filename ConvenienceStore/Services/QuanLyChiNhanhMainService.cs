using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class QuanLyChiNhanhMainService
    {
        public QuanLyChiNhanhMainService()
        {

        }

        // Lấy tên nhân viên bán hàng từ bảng người
        public string getName(string maQLChiNhanh)
        {
            return ModelEntity.db.Nguoi.Single(x => x.userID == maQLChiNhanh).hoTen;
        }
    }
}
