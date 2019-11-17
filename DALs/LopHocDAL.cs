using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using DTOs;
namespace DALs
{
    public class LopHocDAL
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
        public List<LopHocDTO> DocBangLopHoc()
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            List<LopHocDTO> dsLopHoc = new List<LopHocDTO>();
            //conn.Open();
            setConnection();
            SqlCommand cmd = new SqlCommand("SELECT MaLop,TenLop,TenKhoa from Lop,Khoa where Lop.MaKhoa=Khoa.MaKhoa", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LopHocDTO aLop = new LopHocDTO(dr[0].ToString(), dr["TenLop"].ToString(), dr["TenKhoa"].ToString());
                dsLopHoc.Add(aLop);
            }
            //conn.Close();
            setDisconnection();
            return dsLopHoc;
        }
        public string countLop()
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            //conn.Open();
            setConnection();
            string sqlCount = "select Count(MaLop) as 'SoLuong' from Lop ";
            SqlCommand cmd = new SqlCommand(sqlCount, conn);
            SqlDataReader rs = cmd.ExecuteReader();
            String s = null;
            while (rs.Read())
            {
                s = rs["SoLuong"].ToString();
            }
            setDisconnection();
            return s;
        }
        public string countGv()
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            //conn.Open();
            setConnection();
            string sqlCount = "select Count(MaGiangVien) as 'SoLuong' from GiangVien ";
            SqlCommand cmd = new SqlCommand(sqlCount, conn);
            SqlDataReader rs = cmd.ExecuteReader();
            String s = null;
            while (rs.Read())
            {
                s = rs["SoLuong"].ToString();
            }
            setDisconnection();
            return s;
        }
        public string countLop1()
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            //conn.Open();
            setConnection();
            string sqlCount = "select Count(MaLop) as 'SoLuong' from Lop ";
            SqlCommand cmd = new SqlCommand(sqlCount, conn);
            SqlDataReader rs = cmd.ExecuteReader();
            String s = null;
            while (rs.Read())
            {
                s = rs["SoLuong"].ToString();
            }
            setDisconnection();
            return s;
        }
        public string countGv1()
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            //conn.Open();
            setConnection();
            string sqlCount = "select Count(MaGiangVien) as 'SoLuong' from GiangVien ";
            SqlCommand cmd = new SqlCommand(sqlCount, conn);
            SqlDataReader rs = cmd.ExecuteReader();
            String s = null;
            while (rs.Read())
            {
                s = rs["SoLuong"].ToString();
            }
            setDisconnection();
            return s;
        }
        public void themLop(LopHocDTO Lopmoi)
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            //conn.Open();
            setConnection();
            String sqlthem = "insert into Lop values(@ma,@ten,@mk) ";
            SqlCommand cmd = new SqlCommand(sqlthem, conn);
            cmd.Parameters.AddWithValue("ma", Lopmoi.MaLop);
            cmd.Parameters.AddWithValue("ten", Lopmoi.TenLop);
            cmd.Parameters.AddWithValue("mk", Lopmoi.MaKhoa);
            cmd.ExecuteNonQuery();
            //conn.Close();
            setDisconnection();

        }
        public void suaLop(LopHocDTO Lopsua)
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            //conn.Open();
            setConnection();
            String sqlsua = "update Lop set TenLop=@ten, MaKhoa=@mk where MaLop=@ma ";
            SqlCommand cmd = new SqlCommand(sqlsua, conn);
            cmd.Parameters.AddWithValue("ma", Lopsua.MaLop);
            cmd.Parameters.AddWithValue("ten", Lopsua.TenLop);
            cmd.Parameters.AddWithValue("mk", Lopsua.MaKhoa);
            cmd.ExecuteNonQuery();
            //conn.Close();
            setDisconnection();
        }
        public void xoaLop(String ma)
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            //conn.Open();
            setConnection();
            String sqlxoa = "delete from Lop where MaLop=@ma";
            SqlCommand cmd = new SqlCommand(sqlxoa, conn);
            cmd.Parameters.AddWithValue("ma", ma);
            cmd.ExecuteNonQuery();
            //conn.Close();
            setDisconnection();
        }
        public List<LopHocDTO> TimLop(String ma)
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            //conn.Open();
            setConnection();
            String sqltim = "select * from Lop where MaLop=@ma";
            SqlCommand cmd = new SqlCommand(sqltim, conn);
            cmd.Parameters.AddWithValue("ma", ma);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            LopHocDTO a = new LopHocDTO(dr["MaLop"].ToString(), dr["TenLop"].ToString(), dr["MaKhoa"].ToString());
            //conn.Close();
            setDisconnection();
            List<LopHocDTO> ds = new List<LopHocDTO>();
            ds.Add(a);
            return ds;

        }
        public List<LopHocDTO> getDanhSachLopHocTheoKhoa(string tenKhoa)
        {
            List<LopHocDTO> dsLopHoc = new List<LopHocDTO>();
            // conn.Open();
            setConnection();
            SqlCommand cmd = new SqlCommand("SELECT Lop.* FROM lop, khoa where Lop.MaKhoa=Khoa.MaKhoa and Khoa.TenKhoa=N'" + tenKhoa + "'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LopHocDTO aLop = new LopHocDTO(dr[0].ToString(), dr["TenLop"].ToString().Trim(), dr["MaKhoa"].ToString());
                dsLopHoc.Add(aLop);
            }
            //dr.Close();
            //conn.Close();
            setDisconnection();
            return dsLopHoc;
        }
    }
}
