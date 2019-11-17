using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTOs;
using DALs;
namespace BULs
{
    public class LoaiQuyenBUL
    {
        public List<LoaiQuyenDTO> LayDanhSachQuyen()
        {
            LoaiQuyenDAL myQuyen = new LoaiQuyenDAL();
            return myQuyen.DocBangLoaiQuyen();
        }
    }
}
