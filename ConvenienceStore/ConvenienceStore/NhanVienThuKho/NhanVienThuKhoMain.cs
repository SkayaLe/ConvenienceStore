using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvenienceStore.NhanVienThuKho
{
    public partial class NhanVienThuKhoMain : Form
    {
        private string user;

        public NhanVienThuKhoMain(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void NhanVienThuKhoMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            //new Login().Show();
            Application.Exit();
        }

        private void NhanVienThuKhoMain_Load(object sender, EventArgs e)
        {
            userLbl.Text = user;
        }
    }
}
