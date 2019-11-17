using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTOs;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace DALs
{
    public class DiemDAL
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());

        public List<DiemDTO> LayDiemTheoLop(string malop)
        {
            List<DiemDTO> list = new List<DiemDTO>();
            conn.Open();
            string sql = "select Diem.* from Diem,SinhVien where Diem.MaSinhVien=SinhVien.MaSinhVien and SinhVien.MaLop='" + malop + "'";
            SqlCommand sqlComm = new SqlCommand(sql, conn);
            SqlDataReader sqlDr = sqlComm.ExecuteReader();
            while (sqlDr.Read())
            {
                DiemDTO diem = new DiemDTO(sqlDr.GetString(0), sqlDr.GetString(1),
                    float.Parse(sqlDr["DiemTB"].ToString()), float.Parse(sqlDr["DiemThiLan1"].ToString()), float.Parse(sqlDr["DiemTongKet"].ToString()));
                list.Add(diem);
            }
            sqlDr.Close();
            conn.Close();
            return list;
        }

        public List<DiemDTO> LayDiemTheoSinhVien(string masv)
        {
            List<DiemDTO> list = new List<DiemDTO>();
            conn.Open();
            string sql = "select * from Diem where MaSinhVien='" + masv + "'";
            SqlCommand sqlComm = new SqlCommand(sql, conn);
            SqlDataReader sqlDr = sqlComm.ExecuteReader();
            while (sqlDr.Read())
            {
                DiemDTO diem = new DiemDTO(sqlDr.GetString(0), sqlDr.GetString(1),
                    float.Parse(sqlDr["DiemTB"].ToString()), float.Parse(sqlDr["DiemThiLan1"].ToString()), float.Parse(sqlDr["DiemTongKet"].ToString()));
                list.Add(diem);
            }
            sqlDr.Close();
            conn.Close();
            return list;
        }

        public List<DiemDTO> LayDiemTheoMonHoc(string mamon)
        {
            List<DiemDTO> list = new List<DiemDTO>();
            conn.Open();
            string sql = "select * from Diem where MaMonHoc='" + mamon + "'";
            SqlCommand sqlComm = new SqlCommand(sql, conn);
            SqlDataReader sqlDr = sqlComm.ExecuteReader();
            while (sqlDr.Read())
            {
                DiemDTO diem = new DiemDTO(sqlDr.GetString(0), sqlDr.GetString(1),
                    float.Parse(sqlDr["DiemTB"].ToString()), float.Parse(sqlDr["DiemThiLan1"].ToString()), float.Parse(sqlDr["DiemTongKet"].ToString()));
                list.Add(diem);
            }
            sqlDr.Close();
            conn.Close();
            return list;
        }

        public List<DiemDTO> LayDiem()
        {
            List<DiemDTO> list = new List<DiemDTO>();
            conn.Open();
            string sql = "select * from Diem";
            SqlCommand sqlComm = new SqlCommand(sql, conn);
            SqlDataReader sqlDr = sqlComm.ExecuteReader();
            while (sqlDr.Read())
            {
                DiemDTO diem = new DiemDTO(sqlDr.GetString(0), sqlDr.GetString(1),
                    float.Parse(sqlDr["DiemTB"].ToString()), float.Parse(sqlDr["DiemThiLan1"].ToString()), float.Parse(sqlDr["DiemTongKet"].ToString()));
                list.Add(diem);
            }
            sqlDr.Close();
            conn.Close();
            return list;
        }
        public Boolean XoaDiem(string maSV, string maMon)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "delete Diem where MaSinhVien=@masv and MaMonHoc=@mamon";
            SqlCommand sqlComm = new SqlCommand(sql, conn);
            sqlComm.Parameters.Add(new SqlParameter("@masv", SqlDbType.NChar)).Value = maSV;
            sqlComm.Parameters.Add(new SqlParameter("@mamon", SqlDbType.NChar)).Value = maMon;
            int kq = sqlComm.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;

            return false;
        }

        public Boolean SuaDiem(DiemDTO diem)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "update Diem set DiemTB=@diemtb,DiemThiLan1=@diemthilan1,DiemTongKet=@diemtk where MaSinhVien=@masv and MaMonHoc=@mamon";
            SqlCommand sqlComm = new SqlCommand(sql, conn);
            sqlComm.Parameters.Add(new SqlParameter("@masv", SqlDbType.NChar)).Value = diem.maSV;
            sqlComm.Parameters.Add(new SqlParameter("@mamon", SqlDbType.NChar)).Value = diem.maMon;
            sqlComm.Parameters.Add(new SqlParameter("@diemtb", SqlDbType.Float)).Value = diem.DiemTB;
            sqlComm.Parameters.Add(new SqlParameter("@diemthilan1", SqlDbType.Float)).Value = diem.DiemThiLan1;
            sqlComm.Parameters.Add(new SqlParameter("@diemtk", SqlDbType.Float)).Value = diem.DiemTongKet;
            int kq = sqlComm.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;

            return false;
        }

        public Boolean ThemDiem(DiemDTO diem)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sql = "insert into Diem values(@masv,@mamon,@diemtb,@diemthilan1,@diemtk)";
            SqlCommand sqlComm = new SqlCommand(sql, conn);
            sqlComm.Parameters.Add(new SqlParameter("@masv", SqlDbType.NChar)).Value = diem.maSV;
            sqlComm.Parameters.Add(new SqlParameter("@mamon", SqlDbType.NChar)).Value = diem.maMon;
            sqlComm.Parameters.Add(new SqlParameter("@diemtb", SqlDbType.Float)).Value = diem.DiemTB;
            sqlComm.Parameters.Add(new SqlParameter("@diemthilan1", SqlDbType.Float)).Value = diem.DiemThiLan1;
            sqlComm.Parameters.Add(new SqlParameter("@diemtk", SqlDbType.Float)).Value = diem.DiemTongKet;
            int kq = sqlComm.ExecuteNonQuery();
            conn.Close();
            if (kq > 0)
                return true;

            return false;
        }
    }
}
