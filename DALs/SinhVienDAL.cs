using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using DTOs;
using System.Data.SqlClient;

namespace DALs
{
    public class SinhVienDAL
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
        public List<SinhVienDTO> LayThongTinSinhVien()
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            List<SinhVienDTO> dsSinhVien = new List<SinhVienDTO>();
            //conn.Open();
            setConnection();
            SqlCommand cmd = new SqlCommand("SELECT MaSinhVien,TenSinhVien,NgaySinh,(case GioiTinh when 1 then 'Nam' else N'Nữ' end) as 'GioiTinh',DiaChi,Sdt,Email,TenLop,TenKhoa FROM SinhVien s, Khoa k, Lop l WHERE s.MaLop = l.MaLop AND s.MaKhoa = k.MaKhoa", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            // đọc từng dòng và đưa vào list
            while (dr.Read())
            {
                SinhVienDTO aSV = new SinhVienDTO(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
            
                 
                dsSinhVien.Add(aSV);
            }
            //conn.Close();
            setDisconnection();
            return dsSinhVien;
        }
        public void ThemSinhVien(SinhVienDTO svMoi)
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            //conn.Open();
            setConnection();
            string sqlINSERT = "INSERT INTO SinhVien VALUES(@masv,@tensv,@ngSinh,@gioiTinh,@diaChi,@maLop,@maKhoa,@sdt,@email)";
            SqlCommand cmd = new SqlCommand(sqlINSERT, conn);

            cmd.Parameters.AddWithValue("masv", svMoi.MaSinhVien);
            cmd.Parameters.AddWithValue("tensv", svMoi.TenSinhVien);
            cmd.Parameters.AddWithValue("ngSinh", svMoi.NgaySinh);
            cmd.Parameters.AddWithValue("gioiTinh", check(svMoi.GioiTinh));
            cmd.Parameters.AddWithValue("diaChi", svMoi.DiaChi);
            cmd.Parameters.AddWithValue("maLop", svMoi.MaLop);
            cmd.Parameters.AddWithValue("maKhoa", svMoi.MaKhoa);
            cmd.Parameters.AddWithValue("sdt", svMoi.Sdt);
            cmd.Parameters.AddWithValue("email", svMoi.Email);
         
           
            cmd.ExecuteNonQuery();
            //conn.Close();
            setDisconnection();
        }
        public int check(String ma)
        {
            if (ma.Equals("Nam"))
            {
                return 1;
            }
            return 0;
        }
        public void SuaSinhVien(SinhVienDTO svSua)
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            //conn.Open();
            setConnection();
            string sqlUPDATE = "UPDATE SinhVien SET TenSinhVien=@ten,NgaySinh=@ngSinh,GioiTinh=@gt,DiaChi=@dc,MaLop=@lop,MaKhoa=@khoa,Sdt=@sdt,Email=@email where MaSinhVien=@ma";
            SqlCommand cmd = new SqlCommand(sqlUPDATE, conn);

            cmd.Parameters.AddWithValue("ma", svSua.MaSinhVien);
            cmd.Parameters.AddWithValue("ten", svSua.TenSinhVien);
            cmd.Parameters.AddWithValue("ngSinh", svSua.NgaySinh);
            cmd.Parameters.AddWithValue("gt", check(svSua.GioiTinh));
            cmd.Parameters.AddWithValue("dc", svSua.DiaChi);
            cmd.Parameters.AddWithValue("lop", svSua.MaLop);
            cmd.Parameters.AddWithValue("khoa", svSua.MaKhoa);
            cmd.Parameters.AddWithValue("sdt", svSua.Sdt);
            cmd.Parameters.AddWithValue("email", svSua.Email);
            cmd.ExecuteNonQuery();
            //conn.Close();
            setDisconnection();
        }
        public void XoaSinhVien(string ma)
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            //conn.Open();
            setConnection();
            string sqlDEL = "DELETE from SinhVien WHERE MaSinhVien=@ma";
            SqlCommand cmd = new SqlCommand(sqlDEL, conn);

            cmd.Parameters.AddWithValue("ma", ma);
            cmd.ExecuteNonQuery();
            //conn.Close();
            setDisconnection();
        }
        public string countSv()
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            //conn.Open();
            setConnection();
            string sqlCount = "select Count(MaSinhVien) as 'SoLuong' from SinhVien ";
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
        public List<SinhVienDTO> TimSVTheoMa(string ma)
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            //conn.Open();
            setConnection();
            string sqlSELECCT = "SELECT MaSinhVien,TenSinhVien,NgaySinh,(case GioiTinh when 1 then 'Nam' else N'Nữ' end) as 'GioiTinh',DiaChi,Sdt,Email,TenLop,TenKhoa FROM SinhVien s, Khoa k, Lop l WHERE s.MaLop = l.MaLop AND s.MaKhoa = k.MaKhoa AND MaSinhVien = @ma";
            SqlCommand cmd = new SqlCommand(sqlSELECCT, conn);
            cmd.Parameters.AddWithValue("ma", ma);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            SinhVienDTO aSV = new SinhVienDTO(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
            //conn.Close();
            setDisconnection();
            List<SinhVienDTO> ds = new List<SinhVienDTO>();
            ds.Add(aSV);
            return ds;
        }
        public List<string> LayIDSinhVien()
        {
            List<string> dsIDSinhVien = new List<string>();
            setConnection();
            SqlCommand cmd = new SqlCommand("SELECT MaSinhVien FROM SinhVien", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            // đọc từng dòng và đưa vào list
            while (dr.Read())
            {

                dsIDSinhVien.Add(dr["MaSinhVien"].ToString());
            }
            setDisconnection();
            return dsIDSinhVien;
        }
        public string TangMa()
        {
            string msv;
            setConnection();

            string sql = "select top(1) CAST(RIGHT(MaSinhVien,2) AS int) + 1  as 'ma' from SinhVien order by MaSinhVien DESC";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
          
            string vt = "00" + dr[0].ToString();
            vt = vt.Substring(vt.Length - 3, 3);
            msv = vt;

            setDisconnection();
            return msv;

        }
       
        public List<SinhVienDTO> getThongTinSinhVienTheoLop(string tenLop)
        {
            List<SinhVienDTO> dsSinhVien = new List<SinhVienDTO>();
            //conn.Open();
            setConnection();
            SqlCommand cmd = new SqlCommand("SELECT MaSinhVien,TenSinhVien,NgaySinh,(case GioiTinh when 1 then 'Nam' else N'Nữ' end) as 'GioiTinh',DiaChi,Sdt,Email,TenLop,TenKhoa FROM SinhVien s, Khoa k, Lop l WHERE s.MaLop = l.MaLop AND s.MaKhoa = k.MaKhoa AND l.TenLop=N'" + tenLop + "'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            // đọc từng dòng và đưa vào list
            while (dr.Read())
            {
                SinhVienDTO aSV = new SinhVienDTO(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
                dsSinhVien.Add(aSV);
            }
            dr.Close();
            //conn.Close();
            setDisconnection();
            return dsSinhVien;
        }
        public List<SinhVienDTO> LayThongTinSinhVienTheoLop(string tenLop)
        {
            List<SinhVienDTO> dsSinhVien = new List<SinhVienDTO>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT MaSinhVien,TenSinhVien,NgaySinh,(case GioiTinh when 1 then 'Nam' else N'Nữ' end) as 'GioiTinh',DiaChi,Sdt,Email,TenLop,TenKhoa FROM SinhVien s, Khoa k, Lop l WHERE s.MaLop = l.MaLop AND s.MaKhoa = k.MaKhoa AND l.TenLop=N'" + tenLop + "'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            // đọc từng dòng và đưa vào list
            while (dr.Read())
            {
                SinhVienDTO aSV = new SinhVienDTO(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());
                dsSinhVien.Add(aSV);
            }
            dr.Close();
            conn.Close();
            return dsSinhVien;
        }
    }
}