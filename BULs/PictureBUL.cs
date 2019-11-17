using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using DALs;
using DTOs;

namespace BULs
{
    public class PictureBUL
    {
        PictureDAL mypicDal = new PictureDAL();
        PictureDTO myDTO = new PictureDTO();
        public MemoryStream LayImage(string ma)
        {
            return mypicDal.LayDsImage(ma);
        }
        public List<PictureDTO> getDsImg()
        {
            return mypicDal.LayThongTinImg();
        }
        public void SaveToImg(byte[] a, string n, string m)
        {
            try
            {
                mypicDal.SaveImg(a, n, m);
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateImage(byte[] a, string n, string m) {
            try
            {
                mypicDal.UpdateImg(a, n, m);
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
            
        }
    }
}
