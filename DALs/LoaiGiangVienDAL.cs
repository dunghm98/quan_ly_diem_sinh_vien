using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTOs;
using System.Configuration;
using System.Data.SqlClient;

namespace DALs
{
    public class LoaiGiangVienDAL
    {
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
        public List<LoaiGiangVienDTO> DocBangLoai()
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            try
            {
                List<LoaiGiangVienDTO> ds = new List<LoaiGiangVienDTO>();
                //conn.Open();
                setConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM LoaiGiangVien", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LoaiGiangVienDTO a = new LoaiGiangVienDTO();
                    a.MaLoai1 = dr["MaPhanLoaiGV"].ToString();
                    a.TenLoai1 = dr["TenPhanLoai"].ToString();
                    ds.Add(a);
                }
                //conn.Close();
                return ds;
            }
            catch (Exception e)
            {
                throw new Exception("lỖI" + e);
            }
            finally
            {
                setDisconnection();
            }
        }
    }

}
