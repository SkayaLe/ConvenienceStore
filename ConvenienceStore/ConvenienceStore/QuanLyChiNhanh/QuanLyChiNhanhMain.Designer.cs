﻿
namespace ConvenienceStore.QuanLyChiNhanh
{
    partial class QuanLyChiNhanhMain
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
            this.btnQuanLyNhanVien = new System.Windows.Forms.Button();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.btnKiemTraHoaDon = new System.Windows.Forms.Button();
            this.btnXepCaLam = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlUseCase = new System.Windows.Forms.Panel();
            this.pnlSideBar.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.Location = new System.Drawing.Point(0, 0);
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(117, 29);
            this.btnQuanLyNhanVien.TabIndex = 0;
            this.btnQuanLyNhanVien.Text = "Quản Lý Nhân Viên";
            this.btnQuanLyNhanVien.UseVisualStyleBackColor = true;
            this.btnQuanLyNhanVien.Click += new System.EventHandler(this.BtnQuanLyNhanVien_Click);
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSideBar.Controls.Add(this.btnKiemTraHoaDon);
            this.pnlSideBar.Controls.Add(this.btnXepCaLam);
            this.pnlSideBar.Controls.Add(this.btnQuanLyNhanVien);
            this.pnlSideBar.Location = new System.Drawing.Point(1, 36);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(117, 437);
            this.pnlSideBar.TabIndex = 1;
            // 
            // btnKiemTraHoaDon
            // 
            this.btnKiemTraHoaDon.Location = new System.Drawing.Point(-1, 70);
            this.btnKiemTraHoaDon.Name = "btnKiemTraHoaDon";
            this.btnKiemTraHoaDon.Size = new System.Drawing.Size(117, 29);
            this.btnKiemTraHoaDon.TabIndex = 0;
            this.btnKiemTraHoaDon.Text = "Kiểm Tra Hóa Đơn";
            this.btnKiemTraHoaDon.UseVisualStyleBackColor = true;
            this.btnKiemTraHoaDon.Click += new System.EventHandler(this.BtnKiemTraHoaDon_Click);
            // 
            // btnXepCaLam
            // 
            this.btnXepCaLam.Location = new System.Drawing.Point(-1, 35);
            this.btnXepCaLam.Name = "btnXepCaLam";
            this.btnXepCaLam.Size = new System.Drawing.Size(117, 29);
            this.btnXepCaLam.TabIndex = 0;
            this.btnXepCaLam.Text = "Xếp Ca Làm";
            this.btnXepCaLam.UseVisualStyleBackColor = true;
            this.btnXepCaLam.Click += new System.EventHandler(this.BtnXepCaLam_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTitle.Controls.Add(this.lblTime);
            this.pnlTitle.Controls.Add(this.btnLogout);
            this.pnlTitle.Location = new System.Drawing.Point(118, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(799, 38);
            this.pnlTitle.TabIndex = 2;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.Location = new System.Drawing.Point(251, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(304, 23);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(1, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(117, 33);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "User";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
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
            // QuanLyChiNhanhMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 473);
            this.Controls.Add(this.pnlUseCase);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlSideBar);
            this.Name = "QuanLyChiNhanhMain";
            this.Text = "Quản Lý Chi Nhánh";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuanLyChiNhanhMain_FormClosed);
            this.Load += new System.EventHandler(this.QuanLyChiNhanhMain_Load);
            this.pnlSideBar.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuanLyNhanVien;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnKiemTraHoaDon;
        private System.Windows.Forms.Button btnXepCaLam;
        private System.Windows.Forms.Panel pnlUseCase;
    }
}