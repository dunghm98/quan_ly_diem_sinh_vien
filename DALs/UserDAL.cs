using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTOs;
using System.Data.SqlClient;
using System.Configuration;
namespace DALs
{
    public class UserDAL
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
                throw new Exception("Khoong theer ket noi csdl");
            }
        }
        private void setDisconnection()
        {
            conn.Close();
            conn.Dispose();
        }

        public List<UserDTO> LayThongTinUser()
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            List<UserDTO> dsUser = new List<UserDTO>();
            //conn.Open();
            setConnection();
            SqlCommand cmd = new SqlCommand("SELECT TenDangNhap, MatKhau, Quyen, HoTen From NguoiDung, LoaiQuyen Where NguoiDung.MaQuyen = LoaiQuyen.MaQuyen", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            // đọc từng dòng và đưa vào list
            while (dr.Read())
            {
                UserDTO aUser = new UserDTO(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
                dsUser.Add(aUser);
            }
            //conn.Close();
            setDisconnection();
            return dsUser;
        }
        public void ThemUser(UserDTO userMoi)
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            //conn.Open();
            setConnection();
            string sqlINSERT = "INSERT INTO NguoiDung VALUES(@user,@mk,@maQuyen,@hoTen)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, conn);

            cmd.Parameters.AddWithValue("user", userMoi.TenDangNhap);
            cmd.Parameters.AddWithValue("mk", userMoi.MatKhau);
            cmd.Parameters.AddWithValue("maQuyen", userMoi.MaQuyen);
            cmd.Parameters.AddWithValue("hoTen", userMoi.HoTen);

            cmd.ExecuteNonQuery();
            //conn.Close();
            setDisconnection();
        }

        public void SuaUser(UserDTO userSua)
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            //conn.Open();
            setConnection();
            string sqlUPDATE = "UPDATE NguoiDung SET MatKhau=@mk,MaQuyen=@mq, HoTen=@hoTen where TenDangNhap=@ten";

            SqlCommand cmd = new SqlCommand(sqlUPDATE, conn);
            cmd.Parameters.AddWithValue("ten", userSua.TenDangNhap);
            cmd.Parameters.AddWithValue("mk", userSua.MatKhau);
            cmd.Parameters.AddWithValue("mq", userSua.MaQuyen);
            cmd.Parameters.AddWithValue("hoTen", userSua.HoTen);

            cmd.ExecuteNonQuery();
            //conn.Close();
            setDisconnection();

        }
        public void XoaUser(string user)
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            //conn.Open();
            setConnection();
            string sqlDEL = "DELETE from NguoiDung WHERE TenDangNhap=@user";
            SqlCommand cmd = new SqlCommand(sqlDEL, conn);

            cmd.Parameters.AddWithValue("user", user);
            cmd.ExecuteNonQuery();
            //conn.Close();
            setDisconnection();
        }
        public string KiemtraTK(UserDTO user)
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            //conn.Open();
            setConnection();
            string sql = null;

            SqlCommand cmd = new SqlCommand("  select  count(*) from nguoidung where tendangnhap='" + user.TenDangNhap + "' and matkhau='" + user.MatKhau + "'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sql = dr[0].ToString();
            }
            //conn.Close();
            setDisconnection();
            return sql;
        }

        public List<UserDTO> TimUserTheoMa(string ma)
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            //conn.Open();
            setConnection();
            string sqlSELECCT = "SELECT TenDangNhap, MatKhau, Quyen, HoTen From NguoiDung, LoaiQuyen Where NguoiDung.MaQuyen = LoaiQuyen.MaQuyen AND TenDangNhap = @ma";
            SqlCommand cmd = new SqlCommand(sqlSELECCT, conn);
            cmd.Parameters.AddWithValue("ma", ma);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            UserDTO aU = new UserDTO(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            //conn.Close();
            setDisconnection();
            List<UserDTO> ds = new List<UserDTO>();
            ds.Add(aU);
            return ds;
        }
        public List<string> LayUserName()
        {
            List<string> dsUserName = new List<string>();
            setConnection();
            SqlCommand cmd = new SqlCommand("SELECT TenDangNhap FROM NguoiDung", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            // đọc từng dòng và đưa vào list
            while (dr.Read())
            {

                dsUserName.Add(dr["TenDangNhap"].ToString());
            }
            setDisconnection();
            return dsUserName;
        }
        public int checkQuyen(string userName) {
            
            setConnection();
            string q = "";
            SqlCommand cmd = new SqlCommand("SELECT MaQuyen FROM NguoiDung where TenDangNhap = @username", conn);
            cmd.Parameters.AddWithValue("@username", userName);
            SqlDataReader dr = cmd.ExecuteReader();
            // đọc từng dòng và đưa vào list
            while (dr.Read())
            {
                q = dr[0].ToString();
            }
            setDisconnection();
            if (q == "Q1")
                return 1;
            else
                return 0;
            
        }

        public string layTenNgDung(string userName)
        {
            string tenNgDung = "";
            try
            {
                setConnection();
                SqlCommand cmd = new SqlCommand("Select HoTen from NguoiDung where TenDangNhap = @userName", conn);
                cmd.Parameters.AddWithValue("userName", userName);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    tenNgDung = r["HoTen"].ToString();
                }

            }
            catch (SqlException)
            {
                throw new Exception("Không thể kết nối đến csdl");
            }
            catch (Exception e)
            {
                throw new Exception("Lỗi : " + e.Message);
            }
            finally
            {
                setDisconnection();
            }
            return tenNgDung;
        }

    }
}
