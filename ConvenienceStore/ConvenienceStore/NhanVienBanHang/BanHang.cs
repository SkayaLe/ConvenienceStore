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
        private Form parentForm;
        
        private BanHangService sv = new BanHangService();

        private string maNVBH;
        private string maHD;

        public BanHang(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.maNVBH = ((NhanVienBanHangMain)parentForm).maNVBH;
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            AutoCreateNewHoaDon();
        }

        private void AutoCreateNewHoaDon()
        {
            maHD = sv.AutoCreateNewHoaDon(maNVBH);
            txtMaHD.Text = maHD;
            //((NhanVienBanHangMain)parentForm).lblUser.Text = "From child form";
        }

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
