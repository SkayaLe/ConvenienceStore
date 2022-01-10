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
    public partial class QuanLySanPham : Form
    {
        private Form parentForm;

        private QuanLySanPhamService sv = new QuanLySanPhamService();

        string maQLChuoi;

        public QuanLySanPham(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.maQLChuoi = ((QuanLyChuoiMain)parentForm).maQLChuoi;
        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void Load_Data()
        {

        }
    }
}
