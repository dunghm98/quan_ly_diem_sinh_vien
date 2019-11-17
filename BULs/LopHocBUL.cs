using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALs;
using DTOs;

namespace BULs
{
    public class LopHocBUL
    {
        LopHocDAL myLopdal = new LopHocDAL();
        public List<LopHocDTO> LayDanhSachLop()
        {
            LopHocDAL myLop = new LopHocDAL();
            return myLop.DocBangLopHoc();
        }
        public string countLop() {
            LopHocDAL lop = new LopHocDAL();
            return lop.countLop();
        }
        public string countGv() {
            LopHocDAL gv = new LopHocDAL();
            return gv.countGv();
        }
        public void themmotLop(LopHocDTO a)
            {
                myLopdal.themLop(a);
            }
            public void suamotLop(LopHocDTO a)
            {
                myLopdal.suaLop(a);
            }
            public void xoamotLop(String a)
            {
                myLopdal.xoaLop(a);
            }
            public List<LopHocDTO> timmotLop(String ma)
            {
                return myLopdal.TimLop(ma);
            }
            public List<LopHocDTO> LayDanhSachLopHocTheoKhoa(string tenKhoa)
            {
                try
                {
                    return myLopdal.getDanhSachLopHocTheoKhoa(tenKhoa);
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
    }
}
