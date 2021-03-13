namespace Quản_lý_thư_viện
{
    partial class GiaoDienDocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDienDocGia));
            this.NhapThongTinTimKiem = new System.Windows.Forms.TextBox();
            this.TimKiem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.QuanLyThongTin = new System.Windows.Forms.Panel();
            this.NoiDung = new System.Windows.Forms.Label();
            this.MuonSach = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MaSach = new System.Windows.Forms.Label();
            this.TG = new System.Windows.Forms.Label();
            this.NameNXB = new System.Windows.Forms.Label();
            this.NameBook = new System.Windows.Forms.Label();
            this.QuanLyThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // NhapThongTinTimKiem
            // 
            this.NhapThongTinTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NhapThongTinTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapThongTinTimKiem.Location = new System.Drawing.Point(46, 34);
            this.NhapThongTinTimKiem.Name = "NhapThongTinTimKiem";
            this.NhapThongTinTimKiem.Size = new System.Drawing.Size(591, 38);
            this.NhapThongTinTimKiem.TabIndex = 0;
            // 
            // TimKiem
            // 
            this.TimKiem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.TimKiem.BackgroundImage = global::Quản_lý_thư_viện.Properties.Resources.EasyFind;
            this.TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TimKiem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TimKiem.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.TimKiem.Location = new System.Drawing.Point(670, 30);
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.Size = new System.Drawing.Size(68, 61);
            this.TimKiem.TabIndex = 1;
            this.TimKiem.UseVisualStyleBackColor = false;
            this.TimKiem.Click += new System.EventHandler(this.TimKiem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.BackgroundImage = global::Quản_lý_thư_viện.Properties.Resources.pngtree_logout__icon_in_trendy_style_isolated_background_png_image_1566043;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(867, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 79);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuanLyThongTin
            // 
            this.QuanLyThongTin.BackColor = System.Drawing.Color.White;
            this.QuanLyThongTin.Controls.Add(this.NoiDung);
            this.QuanLyThongTin.Controls.Add(this.MuonSach);
            this.QuanLyThongTin.Controls.Add(this.label1);
            this.QuanLyThongTin.Controls.Add(this.MaSach);
            this.QuanLyThongTin.Controls.Add(this.TG);
            this.QuanLyThongTin.Controls.Add(this.NameNXB);
            this.QuanLyThongTin.Controls.Add(this.NameBook);
            this.QuanLyThongTin.Location = new System.Drawing.Point(14, 120);
            this.QuanLyThongTin.Name = "QuanLyThongTin";
            this.QuanLyThongTin.Size = new System.Drawing.Size(981, 343);
            this.QuanLyThongTin.TabIndex = 3;
            // 
            // NoiDung
            // 
            this.NoiDung.AllowDrop = true;
            this.NoiDung.BackColor = System.Drawing.Color.Transparent;
            this.NoiDung.Location = new System.Drawing.Point(54, 231);
            this.NoiDung.MinimumSize = new System.Drawing.Size(700, 100);
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.Size = new System.Drawing.Size(700, 100);
            this.NoiDung.TabIndex = 6;
            this.NoiDung.Text = "NỘI DUNG";
            // 
            // MuonSach
            // 
            this.MuonSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MuonSach.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuonSach.Location = new System.Drawing.Point(817, 82);
            this.MuonSach.Name = "MuonSach";
            this.MuonSach.Size = new System.Drawing.Size(132, 188);
            this.MuonSach.TabIndex = 5;
            this.MuonSach.Text = "MƯỢN SÁCH";
            this.MuonSach.UseVisualStyleBackColor = false;
            this.MuonSach.Click += new System.EventHandler(this.MuonSach_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dưới đây là thòng tin một số sách điển hình";
            // 
            // MaSach
            // 
            this.MaSach.AutoSize = true;
            this.MaSach.Location = new System.Drawing.Point(363, 161);
            this.MaSach.MinimumSize = new System.Drawing.Size(300, 50);
            this.MaSach.Name = "MaSach";
            this.MaSach.Size = new System.Drawing.Size(300, 50);
            this.MaSach.TabIndex = 3;
            this.MaSach.Text = "MÃ SÁCH";
            // 
            // TG
            // 
            this.TG.AutoSize = true;
            this.TG.Location = new System.Drawing.Point(29, 161);
            this.TG.MinimumSize = new System.Drawing.Size(300, 50);
            this.TG.Name = "TG";
            this.TG.Size = new System.Drawing.Size(300, 50);
            this.TG.TabIndex = 2;
            this.TG.Text = "TÁC GIẢ";
            // 
            // NameNXB
            // 
            this.NameNXB.AutoSize = true;
            this.NameNXB.Location = new System.Drawing.Point(363, 82);
            this.NameNXB.MinimumSize = new System.Drawing.Size(300, 50);
            this.NameNXB.Name = "NameNXB";
            this.NameNXB.Size = new System.Drawing.Size(300, 50);
            this.NameNXB.TabIndex = 1;
            this.NameNXB.Text = "NHÀ XUẤT BẢN";
            // 
            // NameBook
            // 
            this.NameBook.AutoSize = true;
            this.NameBook.Location = new System.Drawing.Point(29, 82);
            this.NameBook.MinimumSize = new System.Drawing.Size(300, 50);
            this.NameBook.Name = "NameBook";
            this.NameBook.Size = new System.Drawing.Size(300, 50);
            this.NameBook.TabIndex = 0;
            this.NameBook.Text = "TÊN SÁCH";
            // 
            // GiaoDienDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quản_lý_thư_viện.Properties.Resources.Giao_diện_độc_giả2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.TimKiem;
            this.ClientSize = new System.Drawing.Size(1015, 636);
            this.Controls.Add(this.QuanLyThongTin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TimKiem);
            this.Controls.Add(this.NhapThongTinTimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GiaoDienDocGia";
            this.ShowInTaskbar = false;
            this.Text = "GiaoDienDocGia";
            this.QuanLyThongTin.ResumeLayout(false);
            this.QuanLyThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NhapThongTinTimKiem;
        private System.Windows.Forms.Button TimKiem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel QuanLyThongTin;
        private System.Windows.Forms.Label MaSach;
        private System.Windows.Forms.Label TG;
        private System.Windows.Forms.Label NameNXB;
        private System.Windows.Forms.Label NameBook;
        private System.Windows.Forms.Label NoiDung;
        private System.Windows.Forms.Button MuonSach;
        private System.Windows.Forms.Label label1;
    }
}