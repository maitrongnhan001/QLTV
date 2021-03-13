namespace Quản_lý_thư_viện
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.NhapTenDangNhap = new System.Windows.Forms.TextBox();
            this.NhapMatKhau = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NhapTenDangNhap
            // 
            this.NhapTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NhapTenDangNhap.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapTenDangNhap.Location = new System.Drawing.Point(270, 126);
            this.NhapTenDangNhap.Name = "NhapTenDangNhap";
            this.NhapTenDangNhap.Size = new System.Drawing.Size(383, 35);
            this.NhapTenDangNhap.TabIndex = 0;
            // 
            // NhapMatKhau
            // 
            this.NhapMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NhapMatKhau.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapMatKhau.Location = new System.Drawing.Point(268, 227);
            this.NhapMatKhau.Name = "NhapMatKhau";
            this.NhapMatKhau.PasswordChar = '*';
            this.NhapMatKhau.Size = new System.Drawing.Size(384, 35);
            this.NhapMatKhau.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Adobe Caslon Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(221, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(337, 75);
            this.button1.TabIndex = 2;
            this.button1.Text = "ĐĂNG NHẬP";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quản_lý_thư_viện.Properties.Resources.Giao_diện_đăng__nhập;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(771, 438);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NhapMatKhau);
            this.Controls.Add(this.NhapTenDangNhap);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DangNhap";
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NhapTenDangNhap;
        private System.Windows.Forms.TextBox NhapMatKhau;
        private System.Windows.Forms.Button button1;
    }
}

