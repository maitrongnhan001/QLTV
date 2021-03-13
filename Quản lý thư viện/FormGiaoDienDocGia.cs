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
    public partial class GiaoDienDocGia : Form
    {
        private string Tendocgia;
        public GiaoDienDocGia(string ten)
        {
            Tendocgia = ten;
            int min = 1000;
            InitializeComponent();
            SqlConnection con = new SqlConnection("Server=DESKTOP-UF8FEQE\\SQLEXPRESS;uid=sa;pwd=nhan;Database=QLTV");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Sach";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (min>dr.GetInt32(6))
                {
                    NameBook.Text = dr.GetString(0);
                    NameNXB.Text = dr.GetString(5);
                    TG.Text = dr.GetString(2);
                    MaSach.Text = dr.GetString(1);
                    NoiDung.Text = dr.GetString(4);
                }
            }
        }

        private void TimKiem_Click(object sender, EventArgs e)
        {
            string thongTinTiepKiem;
            thongTinTiepKiem = NhapThongTinTimKiem.Text;
            TimKiemCuaDocGia GDTK = new TimKiemCuaDocGia(thongTinTiepKiem,Tendocgia);
            GDTK.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MuonSach_Click(object sender, EventArgs e)
        {
            int sl=0;
            SqlConnection con = new SqlConnection("Server=DESKTOP-UF8FEQE\\SQLEXPRESS;uid=sa;pwd=nhan;Database=QLTV");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Sach";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (NameBook.Text == dr.GetString(0))
                {
                    SqlConnection newCon = new SqlConnection("Server=DESKTOP-UF8FEQE\\SQLEXPRESS;uid=sa;pwd=nhan;Database=QLTV");
                    newCon.Open();
                    sl++;
                    string lenh = "insert into MuonSach (MaSach,TenDocGia,SoLuongMuon) values('" + MaSach.Text + "','" + Tendocgia + "'," + Convert.ToString(sl) + ");";
                    SqlCommand com = newCon.CreateCommand();
                    com.CommandText = lenh;
                    com.ExecuteNonQuery();
                    MessageBox.Show("Đăng ký mượn sách thành công! Vui lòng đến quầy thủ thư để lấy sách.", "Thông báo");
                }
            }
        }
    }
}
