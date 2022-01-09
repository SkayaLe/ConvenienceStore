using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvenienceStore
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public bool CheckTaiKhoan(string username, string passwd)
        {
            try
            {
                var nguoi = Model.ModelEntity.db.Nguois.Single(x => x.userID == username && x.passwd == passwd);
            }
            catch (InvalidOperationException)
            {
                return false;
            }
            return true;
        }

        public bool CheckQuanLyChuoi(string username)
        {
            var ql = Model.ModelEntity.db.QuanLies.Single(x => x.maQL == username);
            return ql.isQLChuoi.Value;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (CheckTaiKhoan(txtUsername.Text, txtPasswd.Text))
            {
                switch (txtUsername.Text.Substring(0, 2))
                {
                    case "QL":
                        if (CheckQuanLyChuoi(txtUsername.Text))
                        {
                            new QuanLyChuoi.QuanLyChuoiMain(txtUsername.Text).Show();
                        }
                        else
                        {
                            new QuanLyChiNhanh.QuanLyChiNhanhMain(txtUsername.Text).Show();
                        }
                        break;
                    case "BH":
                        new NhanVienBanHang.NhanVienBanHangMain(txtUsername.Text).Show();
                        break;
                    case "TK":
                        new NhanVienThuKho.NhanVienThuKhoMain(txtUsername.Text).Show();
                        break;
                }
                this.Dispose();
            }    
            else
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();        
        }
    }
}
