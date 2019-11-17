using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTOs;
using DALs;

namespace BULs
{
    public class GiangVienBUL
    {
        GiangVienDAL myGiangViendal = new GiangVienDAL();
        public List<GiangVien> laydsGiangVien()
        {
            return myGiangViendal.LayThongTinGiangVien();
        }
        public void themmotGiangVien(GiangVien a)
        {
            myGiangViendal.themGiangVien(a);
        }
        public void suamotGiangVien(GiangVien a)
        {
            myGiangViendal.suaGiangVien(a);
        }
        public void xoamotGiangVien(String a)
        {
            myGiangViendal.xoaGiangVien(a);
        }
        public List<GiangVien> timmotGiangVien(String ma)
        {
            return myGiangViendal.TimGiangVien(ma);
        }

    }
}
