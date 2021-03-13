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
    public partial class GiaoDienThemSach : Form
    {
        public GiaoDienThemSach()
        {
            InitializeComponent();
        }

        //ham kiem tra nhap lieu
        Boolean Check()
        {
            Boolean found = false;
            if (NhapMaSach.Text != "")
                if (NhapNhaXuatBan.Text != "")
                    if (NhapNhaXuatBan.Text != "")
                        if (NhapSoLuong.Text != "")
                            if (NhapTenSach.Text != "")
                                if (NhapTheLoai.Text != "")
                                    if (NhapTacGia.Text != "")
                                        found = true;
            return found;
        }

        //ham check du lieu
        Boolean CheckData()
        {
            Boolean found = true;
            SqlConnection con1 = new SqlConnection("Server=DESKTOP-UF8FEQE\\SQLEXPRESS;uid=sa;pwd=nhan;Database=QLTV");
            con1.Open();
            SqlCommand cmd1 = con1.CreateCommand();
            cmd1.CommandText = "select * from Sach";
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                if (dr.GetString(1) == NhapMaSach.Text)
                {
                    found = false;
                    MessageBox.Show("Dữ liệu bạn vừa nhập đã tồn tại trong hệ thống", "Thông báo");
                    break;
                }
            }
            con1.Close();
            return found;
        }

        private void ThemSach_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                if (CheckData())
                {
                    SqlConnection con1 = new SqlConnection("Server=DESKTOP-UF8FEQE\\SQLEXPRESS;uid=sa;pwd=nhan;Database=QLTV");
                    con1.Open();
                    SqlCommand cmd1 = con1.CreateCommand();
                    string command="insert into Sach (TenSach,MaSach,TacGia,TheLoai,TomTacNoiDung,NXB,SoLuong)"+
                        " values ('"+NhapTenSach.Text+"','"+NhapMaSach.Text+"','"+NhapTacGia.Text+"','"+NhapTheLoai.Text+"','"+
                        NhapTomTacNoiDung.Text+"','"+NhapNhaXuatBan.Text+"',"+NhapSoLuong.Text+");";
                    cmd1.CommandText = command;
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Thêm sách thành công", "Thông báo");
                }
            }
        }
    }
}
