namespace Quản_lý_thư_viện
{
    partial class GiaoDienThuThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDienThuThu));
            this.NhapThongTinDeTimKiem = new System.Windows.Forms.TextBox();
            this.TimKiem = new System.Windows.Forms.Button();
            this.btMuonSach = new System.Windows.Forms.Button();
            this.btThemSach = new System.Windows.Forms.Button();
            this.btXoaSach = new System.Windows.Forms.Button();
            this.btCapNhatSach = new System.Windows.Forms.Button();
            this.PhieuMuon = new System.Windows.Forms.Panel();
            this.CheckTraSach = new System.Windows.Forms.CheckBox();
            this.NhapTenDocGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NhapMaSach = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.DangXuat = new System.Windows.Forms.Button();
            this.PhieuMuon.SuspendLayout();
            this.SuspendLayout();
            // 
            // NhapThongTinDeTimKiem
            // 
            this.NhapThongTinDeTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NhapThongTinDeTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapThongTinDeTimKiem.Location = new System.Drawing.Point(30, 22);
            this.NhapThongTinDeTimKiem.Multiline = true;
            this.NhapThongTinDeTimKiem.Name = "NhapThongTinDeTimKiem";
            this.NhapThongTinDeTimKiem.Size = new System.Drawing.Size(430, 41);
            this.NhapThongTinDeTimKiem.TabIndex = 0;
            // 
            // TimKiem
            // 
            this.TimKiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TimKiem.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimKiem.Image = global::Quản_lý_thư_viện.Properties.Resources.EasyFind;
            this.TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TimKiem.Location = new System.Drawing.Point(50, 87);
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.Size = new System.Drawing.Size(185, 47);
            this.TimKiem.TabIndex = 1;
            this.TimKiem.Text = "Tìm kiếm";
            this.TimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TimKiem.UseVisualStyleBackColor = false;
            this.TimKiem.Click += new System.EventHandler(this.TimKiem_Click);
            // 
            // btMuonSach
            // 
            this.btMuonSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btMuonSach.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMuonSach.Location = new System.Drawing.Point(50, 284);
            this.btMuonSach.Name = "btMuonSach";
            this.btMuonSach.Size = new System.Drawing.Size(197, 77);
            this.btMuonSach.TabIndex = 2;
            this.btMuonSach.Text = "MƯỢN SÁCH";
            this.btMuonSach.UseVisualStyleBackColor = false;
            this.btMuonSach.Click += new System.EventHandler(this.btMuonSach_Click);
            // 
            // btThemSach
            // 
            this.btThemSach.BackgroundImage = global::Quản_lý_thư_viện.Properties.Resources.icon_thẻm_sách;
            this.btThemSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btThemSach.Location = new System.Drawing.Point(408, 226);
            this.btThemSach.Name = "btThemSach";
            this.btThemSach.Size = new System.Drawing.Size(126, 104);
            this.btThemSach.TabIndex = 3;
            this.btThemSach.UseVisualStyleBackColor = true;
            this.btThemSach.Click += new System.EventHandler(this.btThemSach_Click);
            // 
            // btXoaSach
            // 
            this.btXoaSach.BackgroundImage = global::Quản_lý_thư_viện.Properties.Resources.icon_xóa_sách;
            this.btXoaSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btXoaSach.Location = new System.Drawing.Point(521, 64);
            this.btXoaSach.Name = "btXoaSach";
            this.btXoaSach.Size = new System.Drawing.Size(98, 82);
            this.btXoaSach.TabIndex = 4;
            this.btXoaSach.UseVisualStyleBackColor = true;
            this.btXoaSach.Click += new System.EventHandler(this.btXoaSach_Click);
            // 
            // btCapNhatSach
            // 
            this.btCapNhatSach.BackgroundImage = global::Quản_lý_thư_viện.Properties.Resources.icon_cập_nhật_sách;
            this.btCapNhatSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCapNhatSach.Location = new System.Drawing.Point(694, 147);
            this.btCapNhatSach.Name = "btCapNhatSach";
            this.btCapNhatSach.Size = new System.Drawing.Size(142, 121);
            this.btCapNhatSach.TabIndex = 5;
            this.btCapNhatSach.UseVisualStyleBackColor = true;
            this.btCapNhatSach.Click += new System.EventHandler(this.btCapNhatSach_Click);
            // 
            // PhieuMuon
            // 
            this.PhieuMuon.BackColor = System.Drawing.Color.White;
            this.PhieuMuon.Controls.Add(this.CheckTraSach);
            this.PhieuMuon.Controls.Add(this.NhapTenDocGia);
            this.PhieuMuon.Controls.Add(this.label2);
            this.PhieuMuon.Controls.Add(this.label1);
            this.PhieuMuon.Controls.Add(this.NhapMaSach);
            this.PhieuMuon.Location = new System.Drawing.Point(30, 396);
            this.PhieuMuon.Name = "PhieuMuon";
            this.PhieuMuon.Size = new System.Drawing.Size(885, 178);
            this.PhieuMuon.TabIndex = 6;
            // 
            // CheckTraSach
            // 
            this.CheckTraSach.AutoSize = true;
            this.CheckTraSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckTraSach.Location = new System.Drawing.Point(378, 117);
            this.CheckTraSach.Name = "CheckTraSach";
            this.CheckTraSach.Size = new System.Drawing.Size(102, 26);
            this.CheckTraSach.TabIndex = 6;
            this.CheckTraSach.Text = "Trả Sách";
            this.CheckTraSach.UseVisualStyleBackColor = true;
            this.CheckTraSach.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // NhapTenDocGia
            // 
            this.NhapTenDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapTenDocGia.Location = new System.Drawing.Point(516, 55);
            this.NhapTenDocGia.Multiline = true;
            this.NhapTenDocGia.Name = "NhapTenDocGia";
            this.NhapTenDocGia.Size = new System.Drawing.Size(241, 37);
            this.NhapTenDocGia.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(486, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập tên đăng nhập của độc giả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhâp mã sách:";
            // 
            // NhapMaSach
            // 
            this.NhapMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapMaSach.Location = new System.Drawing.Point(200, 55);
            this.NhapMaSach.Multiline = true;
            this.NhapMaSach.Name = "NhapMaSach";
            this.NhapMaSach.Size = new System.Drawing.Size(197, 37);
            this.NhapMaSach.TabIndex = 0;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Clear.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(374, 597);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(184, 48);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "CLEAR";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // DangXuat
            // 
            this.DangXuat.BackgroundImage = global::Quản_lý_thư_viện.Properties.Resources.pngtree_logout__icon_in_trendy_style_isolated_background_png_image_1566043;
            this.DangXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DangXuat.Location = new System.Drawing.Point(840, 637);
            this.DangXuat.Name = "DangXuat";
            this.DangXuat.Size = new System.Drawing.Size(75, 73);
            this.DangXuat.TabIndex = 7;
            this.DangXuat.UseVisualStyleBackColor = true;
            // 
            // GiaoDienThuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quản_lý_thư_viện.Properties.Resources.Giao_diện_thủ_thư;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 722);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.DangXuat);
            this.Controls.Add(this.PhieuMuon);
            this.Controls.Add(this.btCapNhatSach);
            this.Controls.Add(this.btXoaSach);
            this.Controls.Add(this.btThemSach);
            this.Controls.Add(this.btMuonSach);
            this.Controls.Add(this.TimKiem);
            this.Controls.Add(this.NhapThongTinDeTimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GiaoDienThuThu";
            this.Text = "Thủ Thư";
            this.PhieuMuon.ResumeLayout(false);
            this.PhieuMuon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NhapThongTinDeTimKiem;
        private System.Windows.Forms.Button TimKiem;
        private System.Windows.Forms.Button btMuonSach;
        private System.Windows.Forms.Button btThemSach;
        private System.Windows.Forms.Button btXoaSach;
        private System.Windows.Forms.Button btCapNhatSach;
        private System.Windows.Forms.Panel PhieuMuon;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox NhapTenDocGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NhapMaSach;
        private System.Windows.Forms.Button DangXuat;
        private System.Windows.Forms.CheckBox CheckTraSach;
    }
}