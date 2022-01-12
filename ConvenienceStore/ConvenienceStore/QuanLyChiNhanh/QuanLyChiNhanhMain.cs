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

namespace ConvenienceStore.QuanLyChiNhanh
{
    public partial class QuanLyChiNhanhMain : Form
    {
        // Biến mã QLChiNhanh để truyền cho service
        internal string maQLChiNhanh;

        // Khởi tạo service xử lý
        QuanLyChiNhanhMainService sv = new QuanLyChiNhanhMainService();

        // Biến chứa form con hiện tại khi chọn các nút bên thanh sidebar
        private Form currentChildForm;

        // Khởi tạo form xử lý chính với ID nhận từ form login
        // và bắt đầu timer
        public QuanLyChiNhanhMain(string maQLChiNhanh)
        {
            InitializeComponent();
            this.maQLChiNhanh = maQLChiNhanh;
            timer.Start();
        }

        // Cập nhật thời gian mỗi 100 ms
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTime.Text = dt.ToString("dddd dd/MM/yyyy HH:mm:ss");
        }

        // Cập nhật tên nhân viên mỗi khi mở form
        private void QuanLyChiNhanhMain_Load(object sender, EventArgs e)
        {
            lblUser.Text = sv.getName(maQLChiNhanh);
        }

        // Hàm mở form con trong panel use case
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Dispose();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlUseCase.Controls.Add(childForm);
            pnlUseCase.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // Logout
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new Login().Show();
        }

        // Logout khi đóng form
        private void QuanLyChiNhanhMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            BtnLogout_Click(sender, e);
        }

        private void BtnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyNhanVien(this));
        }

        private void BtnXepCaLam_Click(object sender, EventArgs e)
        {
            OpenChildForm(new XepCaLam());
        }

        private void BtnKiemTraHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KiemTraHoaDon());
        }
    }
}
