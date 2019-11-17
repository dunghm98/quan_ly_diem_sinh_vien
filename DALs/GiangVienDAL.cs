using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using DTOs;
using System.Configuration;

namespace DALs
{
    public class GiangVienDAL
    {
        //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        SqlConnection conn;
        private void setConnection()
        {
            string conString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            try
            {
                conn = new SqlConnection(conString);
                conn.Open();
            }
            catch (SqlException)
            {
                throw new Exception("Không thể kết nối csdl");
            }
        }
        private void setDisconnection()
        {
            conn.Close();
            conn.Dispose();
        }
        public List<GiangVien> LayThongTinGiangVien()
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            List<GiangVien> ds = new List<GiangVien>();
            setConnection();
            String sqlselect = "select MaGiangVien,TenGiangVien,GioiTinh,DienThoai,Email,TenPhanLoai,TenKhoa from GiangVien,Khoa,LoaiGiangVien where GiangVien.MaKhoa=Khoa.MaKhoa and GiangVien.MaPhanLoaiGV=LoaiGiangVien.MaPhanLoaiGV";
            SqlCommand cmd = new SqlCommand(sqlselect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                GiangVien a = new GiangVien(dr["MaGiangVien"].ToString(), dr["TenGiangVien"].ToString(), dr["GioiTinh"].ToString(), dr["DienThoai"].ToString(), dr["Email"].ToString(), dr["TenPhanLoai"].ToString(), dr["TenKhoa"].ToString());
                ds.Add(a);
            }
            setDisconnection();
            return ds;
        }
        public void themGiangVien(GiangVien GiangVienmoi)
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            setConnection();
            String sqlthem = "insert into GiangVien values(@ma,@ten,@gt,@dt,@email,@phanloai,@mk) ";
            SqlCommand cmd = new SqlCommand(sqlthem, conn);
            cmd.Parameters.AddWithValue("ma", GiangVienmoi.Magiangvien);
            cmd.Parameters.AddWithValue("ten", GiangVienmoi.Tengiangvien);
            cmd.Parameters.AddWithValue("gt", GiangVienmoi.Gioitinh);
            cmd.Parameters.AddWithValue("dt", GiangVienmoi.Dienthoai);
            cmd.Parameters.AddWithValue("email", GiangVienmoi.Email);
            cmd.Parameters.AddWithValue("phanloai", GiangVienmoi.Phanloaigiaovien);
            cmd.Parameters.AddWithValue("mk", GiangVienmoi.Makhoa);
            cmd.ExecuteNonQuery();
            setDisconnection();

        }
        public void suaGiangVien(GiangVien GiangViensua)
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            setConnection();
            String sqlsua = "update GiangVien set TenGiangVien=@ten,GioiTinh=@gt,DienThoai=@dt,Email=@email,MaPhanLoaiGV=@phanloai,MaKhoa=@mk where MaGiangVien=@ma ";
            SqlCommand cmd = new SqlCommand(sqlsua, conn);
            cmd.Parameters.AddWithValue("ma", GiangViensua.Magiangvien);
            cmd.Parameters.AddWithValue("ten", GiangViensua.Tengiangvien);
            cmd.Parameters.AddWithValue("gt", GiangViensua.Gioitinh);
            cmd.Parameters.AddWithValue("dt", GiangViensua.Dienthoai);
            cmd.Parameters.AddWithValue("email", GiangViensua.Email);
            cmd.Parameters.AddWithValue("phanloai", GiangViensua.Phanloaigiaovien);
            cmd.Parameters.AddWithValue("mk", GiangViensua.Makhoa);
            cmd.ExecuteNonQuery();
            setDisconnection();
        }
        public void xoaGiangVien(String ma)
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            setConnection();
            String sqlxoa = "delete from GiangVien where MaGiangVien=@ma";
            SqlCommand cmd = new SqlCommand(sqlxoa, conn);
            cmd.Parameters.AddWithValue("ma", ma);
            cmd.ExecuteNonQuery();
            setDisconnection();
        }
        public List<GiangVien> TimGiangVien(String ma)
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            setConnection();
            String sqltim = "select * from GiangVien where MaGiangVien=@ma";
            SqlCommand cmd = new SqlCommand(sqltim, conn);
            cmd.Parameters.AddWithValue("ma", ma);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            GiangVien a = new GiangVien(dr["MaGiangVien"].ToString(), dr["TenGiangVien"].ToString(), dr["GioiTinh"].ToString(), dr["DienThoai"].ToString(), dr["Email"].ToString(), dr["MaPhanLoaiGV"].ToString(), dr["MaKhoa"].ToString());
            setDisconnection();
            List<GiangVien> ds = new List<GiangVien>();
            ds.Add(a);
            return ds;

        }
    }
}
