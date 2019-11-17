using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALs;
using DTOs;
using System.Data.SqlClient;


namespace BULs
{
    public class SinhVienBUL
    {
        SinhVienDAL mySvDAL = new SinhVienDAL();
        public List<SinhVienDTO> LayDsSv() {
            return mySvDAL.LayThongTinSinhVien();
        }
        public void ThemMoiSinhVien(SinhVienDTO sv) {
            try
            {
                mySvDAL.ThemSinhVien(sv);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void SuaThongTinSinhVien(SinhVienDTO sv) {
            mySvDAL.SuaSinhVien(sv);
        }
        public void XoaSV(string ma) {
            mySvDAL.XoaSinhVien(ma);
        }
        public string countSv() {
            return mySvDAL.countSv();
        }
        public List<SinhVienDTO> TimSinhVienTheoMa(string ma) {
            return mySvDAL.TimSVTheoMa(ma);
        }
        public List<string> LayDsIDSv()
        {
            return mySvDAL.LayIDSinhVien();
        }
        public string tangMa()
        {
            return mySvDAL.TangMa();
        }
        public List<SinhVienDTO> LayThongTinSinhVienTheoLop(string tenLop)
        {
            try
            {
                return mySvDAL.getThongTinSinhVienTheoLop(tenLop);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
