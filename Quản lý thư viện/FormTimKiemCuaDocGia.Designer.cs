namespace Quản_lý_thư_viện
{
    partial class TimKiemCuaDocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiemCuaDocGia));
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
            this.QuanLyThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuanLyThongTin.Location = new System.Drawing.Point(0, 0);
            this.QuanLyThongTin.Name = "QuanLyThongTin";
            this.QuanLyThongTin.Size = new System.Drawing.Size(1019, 398);
            this.QuanLyThongTin.TabIndex = 4;
            this.QuanLyThongTin.Paint += new System.Windows.Forms.PaintEventHandler(this.QuanLyThongTin_Paint);
            // 
            // NoiDung
            // 
            this.NoiDung.Location = new System.Drawing.Point(63, 228);
            this.NoiDung.MinimumSize = new System.Drawing.Size(500, 100);
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.Size = new System.Drawing.Size(500, 100);
            this.NoiDung.TabIndex = 6;
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
            this.label1.Size = new System.Drawing.Size(235, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kết quả tìm kiếm";
            // 
            // MaSach
            // 
            this.MaSach.AutoSize = true;
            this.MaSach.Location = new System.Drawing.Point(363, 161);
            this.MaSach.MinimumSize = new System.Drawing.Size(300, 50);
            this.MaSach.Name = "MaSach";
            this.MaSach.Size = new System.Drawing.Size(300, 50);
            this.MaSach.TabIndex = 3;
            // 
            // TG
            // 
            this.TG.AutoSize = true;
            this.TG.Location = new System.Drawing.Point(29, 161);
            this.TG.MinimumSize = new System.Drawing.Size(300, 50);
            this.TG.Name = "TG";
            this.TG.Size = new System.Drawing.Size(300, 50);
            this.TG.TabIndex = 2;
            // 
            // NameNXB
            // 
            this.NameNXB.AutoSize = true;
            this.NameNXB.Location = new System.Drawing.Point(363, 82);
            this.NameNXB.MinimumSize = new System.Drawing.Size(300, 50);
            this.NameNXB.Name = "NameNXB";
            this.NameNXB.Size = new System.Drawing.Size(300, 50);
            this.NameNXB.TabIndex = 1;
            // 
            // NameBook
            // 
            this.NameBook.AutoSize = true;
            this.NameBook.Location = new System.Drawing.Point(29, 82);
            this.NameBook.MinimumSize = new System.Drawing.Size(300, 50);
            this.NameBook.Name = "NameBook";
            this.NameBook.Size = new System.Drawing.Size(300, 50);
            this.NameBook.TabIndex = 0;
            // 
            // TimKiemCuaDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1019, 398);
            this.Controls.Add(this.QuanLyThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimKiemCuaDocGia";
            this.Text = "Tìm Kiếm Sách";
            this.QuanLyThongTin.ResumeLayout(false);
            this.QuanLyThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel QuanLyThongTin;
        private System.Windows.Forms.Label NoiDung;
        private System.Windows.Forms.Button MuonSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MaSach;
        private System.Windows.Forms.Label TG;
        private System.Windows.Forms.Label NameNXB;
        private System.Windows.Forms.Label NameBook;
    }
}