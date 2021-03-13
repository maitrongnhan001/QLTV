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
    public partial class GiaoDienXoaSach : Form
    {
        public GiaoDienXoaSach()
        {
            InitializeComponent();
        }

        //kiem tra sach co ton tai trong co so du lieu khong
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

        private void XoaSach_Click(object sender, EventArgs e)
        {
            if (CheckBook())
            {
                SqlConnection con = new SqlConnection("Server=DESKTOP-UF8FEQE\\SQLEXPRESS;uid=sa;pwd=nhan;Database=QLTV");
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                string commmand = "delete from Sach where MaSach = '" + NhapMaSach.Text + "';";
                cmd.CommandText = commmand;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa sách thành công", "Thông báo");
            }
        }
    }
}
