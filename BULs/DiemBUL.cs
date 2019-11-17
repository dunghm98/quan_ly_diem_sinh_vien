using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALs;
using DTOs;

namespace BULs
{
    public class DiemBUL
    {
        DiemDAL diemdal = new DiemDAL();

        public List<DiemDTO> LayDiemTheoLop(string malop)
        {
            try
            {
                return diemdal.LayDiemTheoLop(malop);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<DiemDTO> LayDiemTheoSinhVien(string masv)
        {
            try
            {
                return diemdal.LayDiemTheoSinhVien(masv);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<DiemDTO> LayDiemTheoMonHoc(string mamon)
        {
            try
            {
                return diemdal.LayDiemTheoMonHoc(mamon);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<DiemDTO> LayDiem()
        {
            try
            {
                return diemdal.LayDiem();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean XoaDiem(string maSV, string maMon)
        {
            try
            {
                return diemdal.XoaDiem(maSV, maMon);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean SuaDiem(DiemDTO diem)
        {
            try
            {
                return diemdal.SuaDiem(diem);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Boolean ThemDiem(DiemDTO diem)
        {
            try
            {
                return diemdal.ThemDiem(diem);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
