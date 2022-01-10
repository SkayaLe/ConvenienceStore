using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class LoginService
    {
        public LoginService()
        {

        }

        // Lấy user có username và password, nếu tồn tại thì trả về true, ngược lại là false
        public bool CheckTaiKhoan(string username, string passwd)
        {
            try
            {
                var nguoi = ModelEntity.db.Nguoi.Single(x => x.userID == username && x.passwd == passwd);
            }
            catch (InvalidOperationException)
            {
                return false;
            }
            return true;
        }

        // Lấy bit isQLChuoi từ quản lý dựa trên maQL tương ứng
        public bool CheckQuanLyChuoi(string username)
        {
            return ModelEntity.db.QuanLy.Single(x => x.maQL == username).isQLChuoi.Value;
        }
    }
}
