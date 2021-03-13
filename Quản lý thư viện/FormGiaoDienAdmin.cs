using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quản_lý_thư_viện
{
    public partial class GiaoDienAdmin : Form
    {
        public GiaoDienAdmin()
        {
            InitializeComponent();
        }

        private void TimKiem_Click(object sender, EventArgs e)
        {
            TimKiemCuaAdmin GDTK = new TimKiemCuaAdmin(NhapDeTimKiem.Text);
            GDTK.Show();
        }

        //kiem tra thong tin tao tai khoan
        Boolean Check()
        {
            Boolean found = false;
            if(NhapHoTen.Text!="")
                if(NhapTenNguoiDung.Text!="")
                    if(NhapMatKhau.Text!="")
                        if (NhapSoCMND.Text != "")
                        {
                            found = true;
                        }
            if (!found)
                MessageBox.Show("Xin vui lòng nhập đầy đủ thông tin đăng nhập", "Thông báo");
            return found;
        }

        private void ThemNguoiDung_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                SqlConnection con = new SqlConnection("Server=DESKTOP-UF8FEQE\\SQLEXPRESS;uid=sa;pwd=nhan;Database=QLTV");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                string command;
                string NhanDang = NhapTenNguoiDung.Text.Substring(0, 2);
                if (NhanDang == "AD")
                {
                    command = "insert into AD (Ten,TenDangNhap,MatKhau,SoCmnd) values ('" + NhapHoTen.Text + "','" + NhapTenNguoiDung.Text +
                        "','" + NhapMatKhau.Text + "','" + NhapSoCMND.Text + "');";
                    cmd.CommandText = command;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm tài khoảng admin thành công", "Thông báo");
                }
                else
                {
                    if (NhanDang == "TT")
                    {
                        command = "insert into ThuThu (Ten,TenDangNhap,MatKhau,SoCmnd) values ('" + NhapHoTen.Text + "','" + NhapTenNguoiDung.Text +
                            "','" + NhapMatKhau.Text + "','" + NhapSoCMND.Text + "');";
                        cmd.CommandText = command;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm tài khoảng thủ thư thành công", "Thông báo");
                    }
                    else
                    {
                        if (NhanDang == "DG")
                        {
                            command = "insert into DocGia (Ten,TenDangNhap,MatKhau,SoCmnd) values ('" + NhapHoTen.Text + "','" + NhapTenNguoiDung.Text +
                                "','" + NhapMatKhau.Text + "','" + NhapSoCMND.Text + "');";
                            cmd.CommandText = command;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Thêm tài khoảng độc giả thành công", "Thông báo");
                        }
                        else
                            MessageBox.Show("Nhập định dạng tên đăng nhập không đúng", "Thông báo");
                    }
                }
            }
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            NhapDeTimKiem.Text = "";
            NhapHoTen.Text = "";
            NhapSoCMND.Text = "";
            NhapTenNguoiDung.Text = "";
            NhapMatKhau.Text = "";
            NhapTenTaiKhoanCanXoa.Text = "";
        }

        private void XoaTaiKhoan_Click(object sender, EventArgs e)
        {
            if (NhapTenTaiKhoanCanXoa.Text != "")
            {
                SqlConnection con = new SqlConnection("Server=DESKTOP-UF8FEQE\\SQLEXPRESS;uid=sa;pwd=nhan;Database=QLTV");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                string command;
                string NhanDang = NhapTenTaiKhoanCanXoa.Text.Substring(0, 2);
                if (NhanDang == "AD")
                {
                    command = "delete from AD where TenDangNhap = '"+NhapTenTaiKhoanCanXoa.Text+"';";
                    cmd.CommandText = command;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa tài khoảng admin thành công", "Thông báo");
                }
                else
                {
                    if (NhanDang == "TT")
                    {
                        command = "delete from ThuThu where TenDangNhap = '" + NhapTenTaiKhoanCanXoa.Text + "';";
                        cmd.CommandText = command;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa tài khoảng thủ thư thành công", "Thông báo");
                    }
                    else
                    {
                        if (NhanDang == "DG")
                        {
                            command = "delete from DocGia where TenDangNhap = '" + NhapTenTaiKhoanCanXoa.Text + "';";
                            cmd.CommandText = command;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Xóa tài khoảng độc giả thành công", "Thông báo");
                        }
                        else
                            MessageBox.Show("Nhập định dạng tên đăng nhập không đúng", "Thông báo");
                    }
                }
            }
        }
    }
}
