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

namespace ConvenienceStore.QuanLyChuoi
{
    public partial class QuanLyChuoiMain : Form
    {
        // Biến mã quản lý chuỗi để truyền cho service
        internal string maQLChuoi;

        // Khởi tạo service xử lý
        QuanLyChuoiMainService sv = new QuanLyChuoiMainService();

        // Biến chứa form con hiện tại khi chọn các nút bên thanh sidebar
        private Form currentChildForm;

        // Khởi tạo form xử lý chính với ID nhận từ form login
        // và bắt đầu timer
        public QuanLyChuoiMain(string maQLChuoi)
        {
            InitializeComponent();
            this.maQLChuoi = maQLChuoi;
            timer.Start();
        }

        // Cập nhật thời gian mỗi 100 ms
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTime.Text = dt.ToString("dddd dd/MM/yyyy HH:mm:ss");
        }

        // Cập nhật tên quản lý mỗi khi mở form
        private void QuanLyChuoiMain_Load(object sender, EventArgs e)
        {
            lblUser.Text = sv.getName(maQLChuoi);
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
            //pnlUseCase.Tag = childForm;
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
        private void QuanLyChuoiMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            BtnLogout_Click(sender, e);
        }

        private void BtnQuanLySanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLySanPham(this));
        }

        private void pnlUseCase_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
