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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            string UserName, PassWord, NhanDang;
            UserName = NhapTenDangNhap.Text;
            PassWord = NhapMatKhau.Text;
            NhanDang = UserName.Substring(0, 2);
            SqlConnection con = new SqlConnection("Server=DESKTOP-UF8FEQE\\SQLEXPRESS;uid=sa;pwd=nhan;Database=QLTV");
            con.Open();
            SqlCommand cmd = con.CreateCommand();            
            if ("AD" == NhanDang)
                {
                    cmd.CommandText = "select * from AD";
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (UserName == dr.GetString(1) && PassWord == dr.GetString(2))
                        {
                            GiaoDienAdmin AD = new GiaoDienAdmin();
                            AD.Show();
                            found = true;
                            break;
                        }
                    }
                }
            else
                {
                    if ("TT" == NhanDang)
                    {
                        cmd.CommandText = "select * from ThuThu";
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            if (UserName == dr.GetString(1) && PassWord == dr.GetString(2))
                            {
                                GiaoDienThuThu TT = new GiaoDienThuThu();
                                TT.Show();
                                found = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        if ("DG" == NhanDang)
                        {
                            cmd.CommandText = "select * from DocGia";
                            SqlDataReader dr = cmd.ExecuteReader();
                            while (dr.Read())
                            {
                                if (UserName == dr.GetString(1) && PassWord == dr.GetString(2))
                                {
                                    GiaoDienDocGia DG = new GiaoDienDocGia(NhapTenDangNhap.Text);
                                    DG.Show();
                                    found = true;
                                    break;
                                }
                            }
                        }
                    }
                }
            if(!found)
                MessageBox.Show("Tài khoảng hoặc mật khẩu không đúng", "Thông báo");
        }
    }
}
