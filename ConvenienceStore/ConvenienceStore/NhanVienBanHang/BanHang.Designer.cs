
namespace ConvenienceStore.NhanVienBanHang
{
    partial class BanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridSP = new System.Windows.Forms.DataGridView();
            this.cbTenSP = new System.Windows.Forms.ComboBox();
            this.cbMaSP = new System.Windows.Forms.ComboBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.cbSoLuong = new System.Windows.Forms.ComboBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.txtTongCong = new System.Windows.Forms.TextBox();
            this.lblTongCong = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSP)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSP
            // 
            this.dataGridSP.AllowUserToAddRows = false;
            this.dataGridSP.AllowUserToDeleteRows = false;
            this.dataGridSP.AllowUserToResizeRows = false;
            this.dataGridSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSP.Location = new System.Drawing.Point(12, 12);
            this.dataGridSP.MultiSelect = false;
            this.dataGridSP.Name = "dataGridSP";
            this.dataGridSP.ReadOnly = true;
            this.dataGridSP.RowHeadersVisible = false;
            this.dataGridSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSP.ShowEditingIcon = false;
            this.dataGridSP.Size = new System.Drawing.Size(492, 307);
            this.dataGridSP.TabIndex = 0;
            // 
            // cbTenSP
            // 
            this.cbTenSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTenSP.FormattingEnabled = true;
            this.cbTenSP.Location = new System.Drawing.Point(594, 72);
            this.cbTenSP.Name = "cbTenSP";
            this.cbTenSP.Size = new System.Drawing.Size(194, 21);
            this.cbTenSP.TabIndex = 1;
            // 
            // cbMaSP
            // 
            this.cbMaSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMaSP.FormattingEnabled = true;
            this.cbMaSP.Location = new System.Drawing.Point(594, 109);
            this.cbMaSP.Name = "cbMaSP";
            this.cbMaSP.Size = new System.Drawing.Size(194, 21);
            this.cbMaSP.TabIndex = 2;
            // 
            // lblTenSP
            // 
            this.lblTenSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(510, 75);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(78, 13);
            this.lblTenSP.TabIndex = 3;
            this.lblTenSP.Text = "Tên Sản Phẩm";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(510, 112);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(74, 13);
            this.lblMaSP.TabIndex = 3;
            this.lblMaSP.Text = "Mã Sản Phẩm";
            // 
            // cbSoLuong
            // 
            this.cbSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSoLuong.FormattingEnabled = true;
            this.cbSoLuong.Location = new System.Drawing.Point(594, 144);
            this.cbSoLuong.Name = "cbSoLuong";
            this.cbSoLuong.Size = new System.Drawing.Size(121, 21);
            this.cbSoLuong.TabIndex = 4;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(510, 147);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(53, 13);
            this.lblSoLuong.TabIndex = 3;
            this.lblSoLuong.Text = "Số Lượng";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonGia.Location = new System.Drawing.Point(594, 178);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(100, 20);
            this.txtDonGia.TabIndex = 5;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThanhTien.Location = new System.Drawing.Point(594, 210);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(100, 20);
            this.txtThanhTien.TabIndex = 5;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(510, 181);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(44, 13);
            this.lblDonGia.TabIndex = 3;
            this.lblDonGia.Text = "Đơn giá";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new System.Drawing.Point(510, 213);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(62, 13);
            this.lblThanhTien.TabIndex = 3;
            this.lblThanhTien.Text = "Thành Tiền";
            // 
            // txtTongCong
            // 
            this.txtTongCong.Location = new System.Drawing.Point(92, 340);
            this.txtTongCong.Name = "txtTongCong";
            this.txtTongCong.ReadOnly = true;
            this.txtTongCong.Size = new System.Drawing.Size(100, 20);
            this.txtTongCong.TabIndex = 6;
            // 
            // lblTongCong
            // 
            this.lblTongCong.AutoSize = true;
            this.lblTongCong.Location = new System.Drawing.Point(12, 343);
            this.lblTongCong.Name = "lblTongCong";
            this.lblTongCong.Size = new System.Drawing.Size(60, 13);
            this.lblTongCong.TabIndex = 3;
            this.lblTongCong.Text = "Tổng Cộng";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaHD.Location = new System.Drawing.Point(688, 12);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(100, 20);
            this.txtMaHD.TabIndex = 5;
            // 
            // lblMaHD
            // 
            this.lblMaHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(614, 15);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(68, 13);
            this.lblMaHD.TabIndex = 3;
            this.lblMaHD.Text = "Mã Hóa Đơn";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(513, 244);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 30);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(584, 244);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(65, 30);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(655, 244);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 30);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(726, 244);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(65, 30);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(513, 284);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(278, 35);
            this.btnThanhToan.TabIndex = 8;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTongCong);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.cbSoLuong);
            this.Controls.Add(this.lblTongCong);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.lblMaHD);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.cbMaSP);
            this.Controls.Add(this.cbTenSP);
            this.Controls.Add(this.dataGridSP);
            this.Name = "BanHang";
            this.Text = "BanHang";
            this.Load += new System.EventHandler(this.BanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSP;
        private System.Windows.Forms.ComboBox cbTenSP;
        private System.Windows.Forms.ComboBox cbMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.ComboBox cbSoLuong;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.TextBox txtTongCong;
        private System.Windows.Forms.Label lblTongCong;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnThanhToan;
    }
}