namespace Quản_lý_thư_viện
{
    partial class GiaoDienXoaSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDienXoaSach));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NhapMaSach = new System.Windows.Forms.TextBox();
            this.XoaSach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhâp đầy đủ thông tin trước khi xóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập mã sách cần xóa:";
            // 
            // NhapMaSach
            // 
            this.NhapMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapMaSach.Location = new System.Drawing.Point(338, 132);
            this.NhapMaSach.Name = "NhapMaSach";
            this.NhapMaSach.Size = new System.Drawing.Size(294, 34);
            this.NhapMaSach.TabIndex = 4;
            // 
            // XoaSach
            // 
            this.XoaSach.BackColor = System.Drawing.Color.MediumPurple;
            this.XoaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaSach.Location = new System.Drawing.Point(237, 220);
            this.XoaSach.Name = "XoaSach";
            this.XoaSach.Size = new System.Drawing.Size(262, 85);
            this.XoaSach.TabIndex = 5;
            this.XoaSach.Text = "XÓA SÁCH";
            this.XoaSach.UseVisualStyleBackColor = false;
            this.XoaSach.Click += new System.EventHandler(this.XoaSach_Click);
            // 
            // GiaoDienXoaSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(724, 354);
            this.Controls.Add(this.XoaSach);
            this.Controls.Add(this.NhapMaSach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GiaoDienXoaSach";
            this.Text = "Xóa Sách";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NhapMaSach;
        private System.Windows.Forms.Button XoaSach;
    }
}