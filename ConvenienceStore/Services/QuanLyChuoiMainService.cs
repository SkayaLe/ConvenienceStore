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

        public string getName(string maQLChuoi)
        {
            return ModelEntity.db.Nguoi.Single(x => x.userID == maQLChuoi).hoTen;
        }

        public List<Model.QuanLy> getAllNVBH()
        {
            return ModelEntity.db.QuanLy.ToList();
        }
    }
}
