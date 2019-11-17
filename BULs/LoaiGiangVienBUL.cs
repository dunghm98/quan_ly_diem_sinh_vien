using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTOs;
using DALs;

namespace BULs
{
    public class LoaiGiangVienBUL
    {
        LoaiGiangVienDAL gvDal = new LoaiGiangVienDAL();
        public List<LoaiGiangVienDTO> LayDanhSachLoai()
        {
            
            return gvDal.DocBangLoai();
        }
        
    }
}
