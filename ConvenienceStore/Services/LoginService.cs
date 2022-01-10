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

        public bool CheckQuanLyChuoi(string username)
        {
            return ModelEntity.db.QuanLy.Single(x => x.maQL == username).isQLChuoi.Value;
        }
    }
}
