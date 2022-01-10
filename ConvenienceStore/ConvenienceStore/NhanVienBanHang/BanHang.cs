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
    public partial class BanHang : Form
    {
        // Biến chứa form cha
        private Form parentForm;

        // Khởi tạo service
        private BanHangService sv = new BanHangService();

        // Biến chứa nhân viên bán hàng và hóa đơn
        private string maNVBH;
        private string maHD;


        // Khởi tạo form con bán hàng từ form cha
        // gán mã nhân viên bán hàng tương ứng
        public BanHang(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.maNVBH = ((NhanVienBanHangMain)parentForm).maNVBH;
        }

        // Tạo ID hóa đơn khi load
        private void BanHang_Load(object sender, EventArgs e)
        {
            AutoCreateNewHoaDon();
        }

        // Gọi service tạo ID
        // hiển thị lên textbox
        private void AutoCreateNewHoaDon()
        {
            maHD = sv.AutoCreateNewHoaDon(maNVBH);
            txtMaHD.Text = maHD;
        }

        // Hủy đơn hàng hiện tại
        private void BtnHuy_Click(object sender, EventArgs e)
        {
            sv.HuyHoaDon(txtMaHD.Text);
        }

        private void BanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            BtnHuy_Click(sender, e);
        }
    }
}
