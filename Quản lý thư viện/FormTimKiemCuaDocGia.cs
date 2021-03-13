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
    public partial class TimKiemCuaDocGia : Form
    {
        private string Tendocgia;
        public TimKiemCuaDocGia(string thongTinTiemKiem,string ten)
        {
            Tendocgia = ten;
            InitializeComponent();
            SqlConnection con = new SqlConnection("Server=DESKTOP-UF8FEQE\\SQLEXPRESS;uid=sa;pwd=nhan;Database=QLTV");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from Sach";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if(thongTinTiemKiem == dr.GetString(0) || thongTinTiemKiem == dr.GetString(1)){
                    NameBook.Text = dr.GetString(0);
                    NameNXB.Text = dr.GetString(5);
                    TG.Text = dr.GetString(2);
                    MaSach.Text = dr.GetString(3);
                    NoiDung.Text = dr.GetString(4);
                }
            }
        }

        private void QuanLyThongTin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MuonSach_Click(object sender, EventArgs e)
        {
            SqlConnection newCon = new SqlConnection("Server=DESKTOP-UF8FEQE\\SQLEXPRESS;uid=sa;pwd=nhan;Database=QLTV");
            newCon.Open();
            string lenh = "insert into MuonSach (MaSach,TenDocGia,SoLuongMuon) values('" + MaSach.Text + "','" + Tendocgia + "'," + Convert.ToString(1) + ");";
            SqlCommand com = newCon.CreateCommand();
            com.CommandText = lenh;
            com.ExecuteNonQuery();
            MessageBox.Show("Đăng ký mượn sách thành công! Vui lòng đến quầy thủ thư để lấy sách.", "Thông báo");
        }
    }
}
