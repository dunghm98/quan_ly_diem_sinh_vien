using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALs;
using DTOs;

namespace BULs
{
    public class KhoaBUL
    {
        public List<KhoaDTO> LayDanhSachKhoa() { 
            KhoaDAL myKhoa = new KhoaDAL();
            return myKhoa.DocBangKhoa();
        }
        KhoaDAL mykhoadal = new KhoaDAL();
        public List<KhoaDTO> laydskhoa()
        {
            return mykhoadal.DocBangKhoa();
        }
        public void themmotkhoa(KhoaDTO a)
        {
            mykhoadal.themKhoa(a);
        }
        public void suamotkhoa(KhoaDTO a)
        {
            mykhoadal.suaKhoa(a);
        }
        public void xoamotkhoa(String a)
        {
            mykhoadal.xoakhoa(a);
        }
        public List<KhoaDTO> timmotkhoa(String ma)
        {
            return mykhoadal.TimKhoa(ma);
        }
            
    }
}
