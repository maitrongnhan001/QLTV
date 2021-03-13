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
    public partial class GiaoDienThuThu : Form
    {
        private string TenDocgia;
        private Boolean found = true;
        public GiaoDienThuThu()
        {
            InitializeComponent();
        }

        private void TimKiem_Click(object sender, EventArgs e)
        {
            TenDocgia=NhapTenDocGia.Text;
            string thongTinTiepKiem;
            thongTinTiepKiem = NhapThongTinDeTimKiem.Text;
            TimKiemCuaThuThu GDTK = new TimKiemCuaThuThu(thongTinTiepKiem,found,TenDocgia);
            GDTK.Show();
        }

        private void btThemSach_Click(object sender, EventArgs e)
        {
            GiaoDienThemSach GDTS = new GiaoDienThemSach();
            GDTS.Show();
        }

        private void btXoaSach_Click(object sender, EventArgs e)
        {
            GiaoDienXoaSach GDXS = new GiaoDienXoaSach();
            GDXS.Show();
        }

        private void btCapNhatSach_Click(object sender, EventArgs e)
        {
            GiaoDienCapNhat GDCN = new GiaoDienCapNhat();
            GDCN.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckTraSach.CheckState == CheckState.Checked)
            {
                btMuonSach.Text = "TRẢ SÁCH";
                found = false;
            }
            if (CheckTraSach.CheckState == CheckState.Unchecked)
            {
                btMuonSach.Text = "MƯỢN SÁCH";
                found = false;
            }
        }
        private void btMuonSach_Click(object sender, EventArgs e)
        {
            Boolean found1 = false, found2 = false;
            SqlConnection con = new SqlConnection("Server=DESKTOP-UF8FEQE\\SQLEXPRESS;uid=sa;pwd=nhan;Database=QLTV");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select *from DocGia";
            SqlDataReader dr1 = cmd.ExecuteReader();
            while(dr1.Read())
                if(dr1.GetString(1) == NhapTenDocGia.Text)
                {
                    found1 = true;
                    break;
                }
            SqlConnection con2 = new SqlConnection("Server=DESKTOP-UF8FEQE\\SQLEXPRESS;uid=sa;pwd=nhan;Database=QLTV");
            con2.Open();
            SqlCommand cmd3 = con2.CreateCommand();
            cmd3.CommandText = "select *from Sach";
            SqlDataReader dr2 = cmd3.ExecuteReader();
            while(dr2.Read())
                if (dr2.GetString(1) == NhapMaSach.Text)
                {
                    found2 = true;
                    break;
                }
            if (found1 && found2)
            {
                if (found)
                {
                    TenDocgia = NhapTenDocGia.Text;
                    SqlConnection conDGD = new SqlConnection("Server=DESKTOP-UF8FEQE\\SQLEXPRESS;uid=sa;pwd=nhan;Database=QLTV");
                    conDGD.Open();
                    SqlCommand cmd1 = conDGD.CreateCommand();
                    string lenh = "insert into MuonSach (MaSach,TenDocGia,SoLuongMuon) values ('" + NhapMaSach.Text + "','" + TenDocgia + "'," + Convert.ToString(1) + ");";
                    cmd1.CommandText = lenh;
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Cho độc giả mượn thành công!", "Thông báo");
                }
                else
                {
                    TenDocgia = NhapTenDocGia.Text;
                    SqlConnection con1 = new SqlConnection("Server=DESKTOP-UF8FEQE\\SQLEXPRESS;uid=sa;pwd=nhan;Database=QLTV");
                    con1.Open();
                    SqlCommand cmd2 = con1.CreateCommand();
                    string lenh = "delete from MuonSach where MaSach = '" + NhapMaSach.Text + "' and TenDocGia = '" + TenDocgia + "';";
                    cmd2.CommandText = lenh;
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Độc giả trả sách thành công", "Thông báo");
                }
            }
            else
                MessageBox.Show("Thất bại do nhập không đúng tên đăng nhập độc giả", "Thông báo");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            NhapMaSach.Text = "";
            NhapTenDocGia.Text = "";
        }
    }
}
