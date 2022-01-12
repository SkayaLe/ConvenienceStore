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

namespace ConvenienceStore.QuanLyChiNhanh
{
    public partial class QuanLyNhanVien : Form
    {
        // Biến chứa form cha
        private Form parentForm;

        // Khởi tạo service
        private QuanLyNhanVienService sv = new QuanLyNhanVienService();

        // Biến chứa mã quản lý chi nhánh
        private string maQLChiNhanh;

        public QuanLyNhanVien(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.maQLChiNhanh = ((QuanLyChiNhanhMain)parentForm).maQLChiNhanh;
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            dataGridNhanVien.Columns[0].HeaderText = "Mã NV";
            dataGridNhanVien.Columns[1].HeaderText = "Họ tên";
            dataGridNhanVien.Columns[2].HeaderText = "Ngày sinh";
            dataGridNhanVien.Columns[3].HeaderText = "Giới tính";
            dataGridNhanVien.Columns[4].HeaderText = "CMND";
            dataGridNhanVien.Columns[5].HeaderText = "Số ĐT";
            dataGridNhanVien.Columns[6].HeaderText = "Email";
            dataGridNhanVien.Columns[7].HeaderText = "Địa chỉ";
            dataGridNhanVien.Columns[8].HeaderText = "Số giờ làm";
            dataGridNhanVien.Columns[9].HeaderText = "Đánh giá";
            dataGridNhanVien.Columns[10].HeaderText ="Lương";
        }

        private void LoadData()
        {
            dataGridNhanVien.DataSource = sv.GetAllNhanVien();
        }

        private void SetEditingMode(bool enable)
        {
            if (!enable)
            {
                dataGridNhanVien.ClearSelection();
            }
            btnThem.Enabled = !enable;
            btnCapNhat.Enabled = true;
            btnClear.Enabled = enable;
            btnXoa.Enabled = enable;
        }

        private void DataGridNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= dataGridNhanVien.RowCount)
            {
                return;
            }

            DataGridViewRow row = dataGridNhanVien.Rows[index];
            txtHoTen.Text = Convert.ToString(row.Cells[1].Value);
            dtpNgaySinh.Value = Convert.ToDateTime(row.Cells[2].Value);
            rbNam.Checked = Convert.ToBoolean(row.Cells[3].Value);
            rbNu.Checked = !rbNam.Checked;
            txtCmnd.Text = Convert.ToString(row.Cells[4].Value);
            txtSdt.Text = Convert.ToString(row.Cells[5].Value);
            txtDiaChi.Text = Convert.ToString(row.Cells[7].Value);
            txtSoGioLam.Text = Convert.ToString(row.Cells[8].Value);
            cbDanhGia.SelectedItem = Convert.ToString(row.Cells[9].Value);
            txtLuong.Text = Convert.ToString(row.Cells[10].Value);

            SetEditingMode(true);
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (CheckEmpty())
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }

            if (dtpNgaySinh.Value >= DateTime.Now)
            {
                MessageBox.Show("Ngày sinh phải bé hơn ngày hiện tại");
                return;
            }

            if (sv.ThemNhanVien(txtHoTen.Text, dtpNgaySinh.Value, rbNam.Checked, txtCmnd.Text, txtSdt.Text, txtDiaChi.Text, double.Parse(txtSoGioLam.Text), int.Parse(cbDanhGia.SelectedItem.ToString()), double.Parse(txtLuong.Text), maQLChiNhanh))
            {
                dataGridNhanVien.ClearSelection();
                LoadData();
                BtnClear_Click(null, null);
                SetEditingMode(false);
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            if (dataGridNhanVien.SelectedCells.Count == 0)
            {
                MessageBox.Show("Xin chọn một nhân viên trước");
                return;
            }

            int index = dataGridNhanVien.SelectedCells[0].RowIndex;

            if (index < 0 || index >= dataGridNhanVien.RowCount)
            {
                MessageBox.Show("Xin chọn một nhân viên trước");
                return;
            }

            if (CheckEmpty())
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            }

            if (dtpNgaySinh.Value >= DateTime.Now)
            {
                MessageBox.Show("Ngày sinh phải bé hơn ngày hiện tại");
                return;
            }

            DataGridViewRow row = dataGridNhanVien.Rows[index];

            DialogResult result = MessageBox.Show("Cập nhật nhân viên " + row.Cells[1].Value.ToString() + "?", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            if (sv.SuaNhanVien(row.Cells[0].Value.ToString(), txtHoTen.Text, dtpNgaySinh.Value, rbNam.Checked, txtCmnd.Text, txtSdt.Text, txtDiaChi.Text, double.Parse(txtSoGioLam.Text), int.Parse(cbDanhGia.SelectedItem.ToString()), double.Parse(txtLuong.Text), maQLChiNhanh))
            {
                dataGridNhanVien.ClearSelection();
                LoadData();
                BtnClear_Click(null, null);
                SetEditingMode(false);
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công");
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            rbNam.Checked = false;
            rbNu.Checked = false;
            txtCmnd.Text = "";
            txtSdt.Text = "";
            txtDiaChi.Text = "";
            txtSoGioLam.Text = "";
            cbDanhGia.SelectedItem = null;
            txtLuong.Text = "";

            SetEditingMode(false);
            txtHoTen.Focus();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridNhanVien.SelectedCells.Count == 0)
            {
                MessageBox.Show("Xin chọn một nhân viên trước");
                return;
            }

            int index = dataGridNhanVien.SelectedCells[0].RowIndex;

            if (index < 0 || index >= dataGridNhanVien.RowCount)
            {
                MessageBox.Show("Xin chọn một nhân viên trước");
                return;
            }

            DataGridViewRow row = dataGridNhanVien.Rows[index];

            DialogResult result = MessageBox.Show("Xóa nhân viên " + row.Cells[1].Value.ToString() + "?", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            if (sv.XoaNhanVien(row.Cells[0].Value.ToString()))
            {
                dataGridNhanVien.ClearSelection();
                LoadData();
                BtnClear_Click(null, null);
                SetEditingMode(false);
            }
            else
            {
                MessageBox.Show("Xóa không thành công");
            }

        }

        private bool CheckEmpty()
        {
            return (
                string.IsNullOrEmpty(txtHoTen.Text) ||
                !(rbNam.Checked ^ rbNu.Checked) ||
                string.IsNullOrEmpty(txtCmnd.Text) ||
                string.IsNullOrEmpty(txtSdt.Text) ||
                string.IsNullOrEmpty(txtDiaChi.Text) ||
                string.IsNullOrEmpty(txtSoGioLam.Text) ||
                string.IsNullOrEmpty(cbDanhGia.SelectedItem.ToString()) ||
                string.IsNullOrEmpty(txtLuong.Text)
                );
        }
    }
}
