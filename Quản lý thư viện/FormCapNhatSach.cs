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
    public partial class GiaoDienCapNhat : Form
    {
        public GiaoDienCapNhat()
        {
            InitializeComponent();
        }
        //kiem tra thong tin sach can cap nhat
        Boolean CheckBook()
        {
            Boolean found = false;
            SqlConnection con = new SqlConnection("Server=DESKTOP-UF8FEQE\\SQLEXPRESS;uid=sa;pwd=nhan;Database=QLTV");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Sach";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                if (dr.GetString(1) == NhapMaSach.Text)
                {
                    found = true;
                    break;
                }
            if (!found)
                MessageBox.Show("Sách không tồn tại", "Thông báo");
            con.Close();
            return found;
        }
        //cap nhat ten sach
        void CapNhatTen()
        {
            if (NhapTenSach.Text != "")
            {
                SqlConnection con = new SqlConnection("Server=DESKTOP-UF8FEQE\\SQLEXPRESS;uid=sa;pwd=nhan;Database=QLTV");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                string lenh = "update Sach set TenSach = '" + NhapTenSach.Text + "' where MaSach = '" + NhapMaSach.Text + "';";
                cmd.CommandText = lenh;
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        //cap nhat the loai
        void CapNhatTheLoai()
        {
            if (NhapTheLoai.Text != "")
            {
                SqlConnection con = new SqlConnection("Server=DESKTOP-UF8FEQE\\SQLEXPRESS;uid=sa;pwd=nhan;Database=QLTV");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                string lenh = "update Sach set TheLoai = '" + NhapTheLoai.Text + "' where MaSach = '" + NhapMaSach.Text + "';";
                cmd.CommandText = lenh;
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        //cap nhat so luong
        void CapNhatSoLuong()
        {
            if (NhapSoLuong.Text != "" && NhapSoLuong.Text != "0") 
            {
                SqlConnection con = new SqlConnection("Server=DESKTOP-UF8FEQE\\SQLEXPRESS;uid=sa;pwd=nhan;Database=QLTV");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                string lenh = "update Sach set SoLuong = " + NhapSoLuong.Text + " where MaSach = '" + NhapMaSach.Text + "';";
                cmd.CommandText = lenh;
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        //cap nhat tom tac noi dung
        void CapNhatTomTacNoiDung()
        {
            if (NhapTomTacNoiDung.Text != "")
            {
                SqlConnection con = new SqlConnection("Server=DESKTOP-UF8FEQE\\SQLEXPRESS;uid=sa;pwd=nhan;Database=QLTV");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                string lenh = "update Sach set TomTacNoiDung = '" + NhapTomTacNoiDung.Text + "' where MaSach = '" + NhapMaSach.Text + "';";
                cmd.CommandText = lenh;
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        private void CapNhat_Click(object sender, EventArgs e)
        {
            if (CheckBook())
            {
                CapNhatTen();
                CapNhatTheLoai();
                CapNhatSoLuong();
                CapNhatTomTacNoiDung();
                MessageBox.Show("Câp nhật thông tin sách thành công", "Thông báo");
            }
        }
    }
}
