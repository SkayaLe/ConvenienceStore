using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvenienceStore.QuanLyChiNhanh
{
    public partial class QuanLyChiNhanhMain : Form
    {
        private string user;

        public QuanLyChiNhanhMain(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void QuanLyChiNhanhMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            //new Login().Show();
            Application.Exit();
        }

        private void QuanLyChiNhanhMain_Load(object sender, EventArgs e)
        {
            userLbl.Text = user;
        }
    }
}
