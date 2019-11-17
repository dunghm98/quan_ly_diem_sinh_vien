using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTOs;
using System.Configuration;
using System.Data.SqlClient;

namespace DALs
{
    public class KhoaDAL
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
        public List<KhoaDTO> DocBangKhoa()
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            List<KhoaDTO> dsKhoa = new List<KhoaDTO>();
            //conn.Open();
            setConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Khoa", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                KhoaDTO aKhoa = new KhoaDTO(dr[0].ToString(), dr["TenKhoa"].ToString());
                dsKhoa.Add(aKhoa);
            }
            //conn.Close();
            setDisconnection();
            return dsKhoa;
        }
        public void themKhoa(KhoaDTO khoamoi)
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            //conn.Open();
            setConnection();
            String sqlthem = "insert into Khoa values(@ma,@ten) ";
            SqlCommand cmd = new SqlCommand(sqlthem, conn);
            cmd.Parameters.AddWithValue("ma", khoamoi.MaKhoa);
            cmd.Parameters.AddWithValue("ten", khoamoi.TenKhoa);
            cmd.ExecuteNonQuery();
            //conn.Close();
            setDisconnection();

        }
        public void suaKhoa(KhoaDTO khoasua)
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            //conn.Open();
            setConnection();
            String sqlsua = "update Khoa set TenKhoa=@ten where MaKhoa=@ma ";
            SqlCommand cmd = new SqlCommand(sqlsua, conn);
            cmd.Parameters.AddWithValue("ma", khoasua.MaKhoa);
            cmd.Parameters.AddWithValue("ten", khoasua.TenKhoa);
            cmd.ExecuteNonQuery();
            //conn.Close();
            setDisconnection();
        }
        public void xoakhoa(String ma)
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            //conn.Open();
            setConnection();
            String sqlxoa = "delete from khoa where MaKhoa=@ma";
            SqlCommand cmd = new SqlCommand(sqlxoa, conn);
            cmd.Parameters.AddWithValue("ma", ma);
            cmd.ExecuteNonQuery();
            //conn.Close();
            setDisconnection();
        }
        public List<KhoaDTO> TimKhoa(String ma)
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            //conn.Open();
            setConnection();
            String sqltim = "select * from khoa where MaKhoa=@ma";
            SqlCommand cmd = new SqlCommand(sqltim, conn);
            cmd.Parameters.AddWithValue("ma", ma);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            KhoaDTO a = new KhoaDTO(dr["MaKhoa"].ToString(), dr["TenKhoa"].ToString());
            //conn.Close();
            setDisconnection();
            List<KhoaDTO> ds = new List<KhoaDTO>();
            ds.Add(a);
            return ds;

        }
    }
}
