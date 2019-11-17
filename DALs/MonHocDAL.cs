using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using DTOs;
namespace DALs
{
    public class MonHocDAL
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
        public List<MonHocDTO> LayDanhSachMonHoc()
        {
            List<MonHocDTO> dsMonHoc = new List<MonHocDTO>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM MonHoc", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                MonHocDTO mon = new MonHocDTO(dr[0].ToString(), dr["TenMonHoc"].ToString());
                dsMonHoc.Add(mon);
            }
            conn.Close();
            return dsMonHoc;
        }
    }
}
