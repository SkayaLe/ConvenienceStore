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

namespace ConvenienceStore.NhanVienBanHang
{
    public partial class NhanVienBanHangMain : Form
    {
        // Biến mã NVBH để truyền cho service
        internal string maNVBH;

        // Khởi tạo service xử lý
        private NhanVienBanHangMainService sv = new NhanVienBanHangMainService();

        // Biến chứa form con hiện tại khi chọn các nút bên thanh sidebar
        private Form currentChildForm;

        // Khởi tạo form xử lý chính với ID nhận từ form login
        // và bắt đầu timer
        public NhanVienBanHangMain(string maNVBH)
        {
            InitializeComponent();
            this.maNVBH = maNVBH;
            timer.Start();
        }

        // Cập nhật thời gian mỗi 100 ms
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTime.Text = dt.ToString("dddd dd/MM/yyyy HH:mm:ss");
        }

        // Cập nhật tên nhân viên mỗi khi mở form
        private void NhanVienBanHangMain_Load(object sender, EventArgs e)
        {
            lblUser.Text = sv.getName(maNVBH);
        }

        // Hàm mở form con trong panel use case
        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //childForm.MdiParent = this;
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
        private void NhanVienBanHangMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            BtnLogout_Click(sender, e);
        }

        private void BtnBanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BanHang(this));
        }

        private void BtnXemHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new XemHoaDon());
        }

        private void BtnTongKetCa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TongKetCa());
        }
    }
}
