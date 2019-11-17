using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTOs;
using System.Configuration;
using System.Data.SqlClient;
namespace DALs
{
    public class LoaiQuyenDAL
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
        public List<LoaiQuyenDTO> DocBangLoaiQuyen()
        {
            //conn = new SqlConnection(@"Data Source=DESKTOP-QSF19BO\SQLEXPRESS;Initial Catalog=QuanLySinhVienExport;Integrated Security=True");
            List<LoaiQuyenDTO> dsQuyen = new List<LoaiQuyenDTO>();
            //conn.Open();
            setConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM LoaiQuyen", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LoaiQuyenDTO aQuyen = new LoaiQuyenDTO(dr[0].ToString(), dr["Quyen"].ToString());
                dsQuyen.Add(aQuyen);
            }
            //conn.Close();
            setDisconnection();
            return dsQuyen;
        }
    }
}
