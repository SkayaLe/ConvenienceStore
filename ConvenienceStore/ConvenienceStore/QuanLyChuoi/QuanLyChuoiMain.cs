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
        private string user;

        public QuanLyChuoiMain(string user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void QuanLyChuoiMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            //new Login().Show();
            Application.Exit();
        }

        private void QuanLyChuoiMain_Load(object sender, EventArgs e)
        {
            userLbl.Text = user;
        }
    }
}
