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
    public partial class TimKiemCuaAdmin : Form
    {
        public TimKiemCuaAdmin(string thongTinTimKiem)
        {
            InitializeComponent();
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

    }
}
