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
    public partial class TimKiemCuaThuThu : Form
    {
        Boolean KiemTra;
        string TenDangNhap;
        public TimKiemCuaThuThu(string thongTinTimKiem,Boolean found,string tenDocGia)
        {
            KiemTra = found;
            TenDangNhap = tenDocGia;
            InitializeComponent();
            if (!found)
                ChoMuon.Text = "TRẢ SÁCH";
            SqlConnection con = new SqlConnection("Server=DESKTOP-UF8FEQE\\SQLEXPRESS;uid=sa;pwd=nhan;Database=QLTV");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Sach";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (thongTinTimKiem == dr.GetString(0) || thongTinTimKiem == dr.GetString(1))
                {
                    NameBook.Text = dr.GetString(0);
                    NameNXB.Text = dr.GetString(5);
                    TG.Text = dr.GetString(2);
                    MaSach.Text = dr.GetString(1);
                }
            }
        }

        private void MuonSach_Click(object sender, EventArgs e)
        {
            Boolean found1 = false ;
            SqlConnection con = new SqlConnection("Server=DESKTOP-UF8FEQE\\SQLEXPRESS;uid=sa;pwd=nhan;Database=QLTV");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select *from DocGia";
            SqlDataReader dr1 = cmd.ExecuteReader();
            while (dr1.Read())
                if (dr1.GetString(1) == TenDangNhap)
                {
                    found1 = true;
                    break;
                }           
            if (found1)
            {
                if (KiemTra)
                {
                    SqlConnection conDGD = new SqlConnection("Server=DESKTOP-UF8FEQE\\SQLEXPRESS;uid=sa;pwd=nhan;Database=QLTV");
                    conDGD.Open();
                    SqlCommand cmd1 = conDGD.CreateCommand();
                    string lenh = "insert into MuonSach (MaSach,TenDocGia,SoLuongMuon) values ('" + MaSach.Text + "','" + TenDangNhap + "'," + Convert.ToString(1) + ");";
                    cmd1.CommandText = lenh;
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Cho độc giả mượn thành công!", "Thông báo");
                }
                else
                {
                    SqlConnection con1 = new SqlConnection("Server=DESKTOP-UF8FEQE\\SQLEXPRESS;uid=sa;pwd=nhan;Database=QLTV");
                    con1.Open();
                    SqlCommand cmd2 = con1.CreateCommand();
                    string lenh = "delete from MuonSach where MaSach = '" + MaSach.Text + "' and TenDocGia = '" + TenDangNhap + "';";
                    cmd2.CommandText = lenh;
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Độc giả trả sách thành công", "Thông báo");
                }
            }
            else
                MessageBox.Show("Thất bại do nhập không đúng tên đăng nhập độc giả", "Thông báo");
        }
    }
}
