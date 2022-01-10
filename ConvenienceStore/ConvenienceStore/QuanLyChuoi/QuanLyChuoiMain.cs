using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvenienceStore.QuanLyChuoi
{
    public partial class QuanLyChuoiMain : Form
    {
        private string maQLChuoi;
        private Model.QuanLy qlChuoi;

        private Form currentChildForm;

        public QuanLyChuoiMain(string maQLChuoi)
        {
            InitializeComponent();
            this.maQLChuoi = maQLChuoi;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            timeLbl.Text = dt.ToString("dddd dd/MM/yyyy HH:mm:ss");
        }

        private void QuanLyChuoiMain_Load(object sender, EventArgs e)
        {
            qlChuoi = Model.ModelEntity.db.QuanLies.Single(x => x.maQL == maQLChuoi);
            userLbl.Text = qlChuoi.Nguoi.hoTen;
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

        private void QuanLyChuoiMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            BtnLogout_Click(sender, e);
        }

        private void BtnQuanLySanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLySanPham());
        }
    }
}
