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

namespace ConvenienceStore.NhanVienThuKho
{
    public partial class NhanVienThuKhoMain : Form
    {
        private string maNVTK;

        NhanVienThuKhoMainService sv = new NhanVienThuKhoMainService();

        private Form currentChildForm;

        public NhanVienThuKhoMain(string maNVTK)
        {
            InitializeComponent();
            this.maNVTK = maNVTK;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            timeLbl.Text = dt.ToString("dddd dd/MM/yyyy HH:mm:ss");
        }

        private void NhanVienThuKhoMain_Load(object sender, EventArgs e)
        {
            userLbl.Text = sv.getName(maNVTK);
        }

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

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new Login().Show();
        }

        private void NhanVienThuKhoMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            BtnLogout_Click(sender, e);
        }

        private void BtnQuanLyKho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyKho());
        }
    }
}
