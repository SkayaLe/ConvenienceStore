using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;

namespace ConvenienceStore
{
    public partial class Login : Form
    {
        // Create login service
        LoginService sv = new LoginService();
        
        public Login()
        {
            InitializeComponent();
        }

        // Kiểm tra tên đăng nhập và mật khẩu
        public bool CheckTaiKhoan(string username, string passwd)
        {
            return sv.CheckTaiKhoan(username, passwd);
        }

        // Kiểm tra có phải bit quản lý chuỗi
        public bool CheckQuanLyChuoi(string username)
        {
            return sv.CheckQuanLyChuoi(username);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (CheckTaiKhoan(txtUsername.Text, txtPasswd.Text))
            {
                // Xem hai ký tự đầu trong userID để điều hướng form màn hình chính
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

        // Kết thúc chương trình khi đóng form login
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();        
        }
    }
}
