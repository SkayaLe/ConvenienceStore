﻿
namespace ConvenienceStore.NhanVienBanHang
{
    partial class NhanVienBanHangMain
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
            this.components = new System.ComponentModel.Container();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.userLbl = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timeLbl = new System.Windows.Forms.Label();
            this.btnXemHoaDon = new System.Windows.Forms.Button();
            this.btnTongKetCa = new System.Windows.Forms.Button();
            this.pnlUseCase = new System.Windows.Forms.Panel();
            this.pnlSideBar.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBanHang
            // 
            this.btnBanHang.Location = new System.Drawing.Point(0, 0);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(117, 29);
            this.btnBanHang.TabIndex = 0;
            this.btnBanHang.Text = "Bán Hàng";
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new System.EventHandler(this.BtnBanHang_Click);
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSideBar.Controls.Add(this.btnTongKetCa);
            this.pnlSideBar.Controls.Add(this.btnXemHoaDon);
            this.pnlSideBar.Controls.Add(this.btnBanHang);
            this.pnlSideBar.Location = new System.Drawing.Point(1, 36);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(117, 437);
            this.pnlSideBar.TabIndex = 1;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTitle.Controls.Add(this.timeLbl);
            this.pnlTitle.Controls.Add(this.btnLogout);
            this.pnlTitle.Location = new System.Drawing.Point(118, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(799, 38);
            this.pnlTitle.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.Location = new System.Drawing.Point(739, 9);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(50, 21);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // userLbl
            // 
            this.userLbl.Location = new System.Drawing.Point(1, 0);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(117, 33);
            this.userLbl.TabIndex = 1;
            this.userLbl.Text = "User";
            this.userLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // timeLbl
            // 
            this.timeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLbl.Location = new System.Drawing.Point(251, 9);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(304, 23);
            this.timeLbl.TabIndex = 1;
            this.timeLbl.Text = "Time";
            this.timeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnXemHoaDon
            // 
            this.btnXemHoaDon.Location = new System.Drawing.Point(-1, 35);
            this.btnXemHoaDon.Name = "btnXemHoaDon";
            this.btnXemHoaDon.Size = new System.Drawing.Size(117, 29);
            this.btnXemHoaDon.TabIndex = 0;
            this.btnXemHoaDon.Text = "Xem Hóa Đơn";
            this.btnXemHoaDon.UseVisualStyleBackColor = true;
            this.btnXemHoaDon.Click += new System.EventHandler(this.BtnXemHoaDon_Click);
            // 
            // btnTongKetCa
            // 
            this.btnTongKetCa.Location = new System.Drawing.Point(-1, 70);
            this.btnTongKetCa.Name = "btnTongKetCa";
            this.btnTongKetCa.Size = new System.Drawing.Size(117, 29);
            this.btnTongKetCa.TabIndex = 0;
            this.btnTongKetCa.Text = "Tổng Kết Ca";
            this.btnTongKetCa.UseVisualStyleBackColor = true;
            this.btnTongKetCa.Click += new System.EventHandler(this.BtnTongKetCa_Click);
            // 
            // pnlUseCase
            // 
            this.pnlUseCase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUseCase.Location = new System.Drawing.Point(118, 36);
            this.pnlUseCase.Name = "pnlUseCase";
            this.pnlUseCase.Size = new System.Drawing.Size(798, 436);
            this.pnlUseCase.TabIndex = 3;
            // 
            // NhanVienBanHangMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 473);
            this.Controls.Add(this.pnlUseCase);
            this.Controls.Add(this.userLbl);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlSideBar);
            this.Name = "NhanVienBanHangMain";
            this.Text = "NhanVienBanHangMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NhanVienBanHangMain_FormClosed);
            this.Load += new System.EventHandler(this.NhanVienBanHangMain_Load);
            this.pnlSideBar.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Button btnTongKetCa;
        private System.Windows.Forms.Button btnXemHoaDon;
        private System.Windows.Forms.Panel pnlUseCase;
    }
}