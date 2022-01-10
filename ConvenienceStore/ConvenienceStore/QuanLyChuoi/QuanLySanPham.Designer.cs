
namespace ConvenienceStore.QuanLyChuoi
{
    partial class QuanLySanPham
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
            this.lblTenMH = new System.Windows.Forms.Label();
            this.lblLoaiMH = new System.Windows.Forms.Label();
            this.lblNCC = new System.Windows.Forms.Label();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.dataGridSanPham = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbLoaiMH = new System.Windows.Forms.ComboBox();
            this.cbNCC = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenMH
            // 
            this.lblTenMH.AutoSize = true;
            this.lblTenMH.Location = new System.Drawing.Point(11, 25);
            this.lblTenMH.Name = "lblTenMH";
            this.lblTenMH.Size = new System.Drawing.Size(76, 13);
            this.lblTenMH.TabIndex = 0;
            this.lblTenMH.Text = "Tên Mặt Hàng";
            // 
            // lblLoaiMH
            // 
            this.lblLoaiMH.AutoSize = true;
            this.lblLoaiMH.Location = new System.Drawing.Point(11, 63);
            this.lblLoaiMH.Name = "lblLoaiMH";
            this.lblLoaiMH.Size = new System.Drawing.Size(77, 13);
            this.lblLoaiMH.TabIndex = 0;
            this.lblLoaiMH.Text = "Loại Mặt Hàng";
            // 
            // lblNCC
            // 
            this.lblNCC.AutoSize = true;
            this.lblNCC.Location = new System.Drawing.Point(12, 101);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(77, 13);
            this.lblNCC.TabIndex = 0;
            this.lblNCC.Text = "Nhà Cung Cấp";
            // 
            // lblDonVi
            // 
            this.lblDonVi.AutoSize = true;
            this.lblDonVi.Location = new System.Drawing.Point(12, 137);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(65, 13);
            this.lblDonVi.TabIndex = 0;
            this.lblDonVi.Text = "Đơn Vị Tính";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(12, 173);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(46, 13);
            this.lblDonGia.TabIndex = 0;
            this.lblDonGia.Text = "Đơn Giá";
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(95, 22);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(156, 20);
            this.txtTenMH.TabIndex = 1;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(95, 134);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(156, 20);
            this.txtDonVi.TabIndex = 1;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(95, 170);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(156, 20);
            this.txtDonGia.TabIndex = 1;
            // 
            // dataGridSanPham
            // 
            this.dataGridSanPham.AllowUserToAddRows = false;
            this.dataGridSanPham.AllowUserToDeleteRows = false;
            this.dataGridSanPham.AllowUserToResizeRows = false;
            this.dataGridSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSanPham.Location = new System.Drawing.Point(275, 18);
            this.dataGridSanPham.MultiSelect = false;
            this.dataGridSanPham.Name = "dataGridSanPham";
            this.dataGridSanPham.ReadOnly = true;
            this.dataGridSanPham.RowHeadersVisible = false;
            this.dataGridSanPham.ShowEditingIcon = false;
            this.dataGridSanPham.Size = new System.Drawing.Size(513, 403);
            this.dataGridSanPham.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(27, 234);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 32);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(142, 234);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(85, 32);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(142, 293);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 32);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(27, 293);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 32);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // cbLoaiMH
            // 
            this.cbLoaiMH.FormattingEnabled = true;
            this.cbLoaiMH.Location = new System.Drawing.Point(95, 60);
            this.cbLoaiMH.Name = "cbLoaiMH";
            this.cbLoaiMH.Size = new System.Drawing.Size(156, 21);
            this.cbLoaiMH.TabIndex = 6;
            // 
            // cbNCC
            // 
            this.cbNCC.FormattingEnabled = true;
            this.cbNCC.Location = new System.Drawing.Point(95, 98);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(156, 21);
            this.cbNCC.TabIndex = 6;
            // 
            // QuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbNCC);
            this.Controls.Add(this.cbLoaiMH);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridSanPham);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtDonVi);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblDonVi);
            this.Controls.Add(this.lblNCC);
            this.Controls.Add(this.lblLoaiMH);
            this.Controls.Add(this.lblTenMH);
            this.Name = "QuanLySanPham";
            this.Text = "QuanLySanPham";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenMH;
        private System.Windows.Forms.Label lblLoaiMH;
        private System.Windows.Forms.Label lblNCC;
        private System.Windows.Forms.Label lblDonVi;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.DataGridView dataGridSanPham;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbLoaiMH;
        private System.Windows.Forms.ComboBox cbNCC;
    }
}