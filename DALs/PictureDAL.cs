using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTOs;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Configuration;

namespace DALs
{
    public class PictureDAL
    {
        SqlConnection conn;
        SqlCommand cmd = new SqlCommand();
        //SqlDataReader dr = new SqlDataReader();
       
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
        public List<PictureDTO> LayThongTinImg()
        {
            List<PictureDTO> danhSachImg = new List<PictureDTO>();
            setConnection();
            SqlCommand cmd = new SqlCommand("Select ID, TenFile from Pic",conn);
            //cmd.CommandText = "Select ID, FileName from Pic";
            //cmd.Connection = conn;
            SqlDataReader dr = cmd.ExecuteReader();


            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    PictureDTO apic = new PictureDTO();
                    apic.ID = Int32.Parse(dr[0].ToString());
                    apic.FileName = dr[1].ToString();
                    danhSachImg.Add(apic);

                }
            }
            dr.Close();
            setDisconnection();
            return danhSachImg;
        }

        public MemoryStream LayDsImage(string ma)
        {
            //List<PictureDTO> dsImg = new List<PictureDTO>();
            setConnection();
            cmd.CommandText = "select DuLieu from Pic where Msv = @ma";
            cmd.Parameters.AddWithValue("@ma", ma);
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder cbd = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            setDisconnection();
            byte[] ap = (byte[])(ds.Tables[0].Rows[0]["DuLieu"]);
            MemoryStream ms = new MemoryStream(ap);
            //pictureBox1.Image = Image.FromStream(ms);
            return ms;
            //ms.Close();

        }
        public void SaveImg(byte[] apic, string name, string msv)
        {
            setConnection();
            SqlParameter picture = new SqlParameter("@picture", SqlDbType.Image);
            
            //cmd.CommandText = "insert into Pic (FileName,Data,ID) values(@ten,@picture,@ma)";
            SqlCommand cmd = new SqlCommand("insert into Pic (DuLieu, TenFile,Msv) values(@picture, @ten,@ma)", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@picture", apic);
            cmd.Parameters.AddWithValue("@ma", msv);
            cmd.Parameters.AddWithValue("@ten", name);
            //cmd.Connection = conn;
            
            cmd.ExecuteNonQuery();
            setDisconnection();
        }
        public void UpdateImg(byte[] apic, string name, string msv)
        {
            setConnection();
            SqlParameter picture = new SqlParameter("@picture", SqlDbType.Image);

            //cmd.CommandText = "insert into Pic (FileName,Data,ID) values(@ten,@picture,@ma)";
            SqlCommand cmd = new SqlCommand("Update Pic set DuLieu = @picture, TenFile =  @ten where Msv = @ma", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ma", msv);
            cmd.Parameters.AddWithValue("@picture", apic);
            cmd.Parameters.AddWithValue("@ten", name);
            //cmd.Connection = conn;

            cmd.ExecuteNonQuery();
            setDisconnection();
        }

    }
}
