using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class QuanLyChuoiMainService
    {
        public QuanLyChuoiMainService()
        {

        }

        // Lấy tên quản lý từ table Nguoi
        public string getName(string maQLChuoi)
        {
            return ModelEntity.db.Nguoi.Single(x => x.userID == maQLChuoi).hoTen;
        }
    }
}
