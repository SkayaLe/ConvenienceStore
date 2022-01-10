using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvenienceStore.NhanVienBanHang
{
    public partial class NhanVienBanHangMain : Form
    {
        private string maNVBH;
        private Model.NhanVienBanHang nvbh;

        private Form currentChildForm;

        public NhanVienBanHangMain(string maNVBH)
        {
            InitializeComponent();
            this.maNVBH = maNVBH;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            timeLbl.Text = dt.ToString("dddd dd/MM/yyyy HH:mm:ss");
        }

        private void NhanVienBanHangMain_Load(object sender, EventArgs e)
        {
            nvbh = Model.ModelEntity.db.NhanVienBanHangs.Single(x => x.maNVBH == maNVBH);
            userLbl.Text = nvbh.Nguoi.hoTen;
        }

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
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

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new Login().Show();
        }

        private void NhanVienBanHangMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            BtnLogout_Click(sender, e);
        }

        private void BtnBanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BanHang());
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
