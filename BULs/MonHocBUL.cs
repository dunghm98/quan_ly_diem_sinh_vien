using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALs;
using DTOs;
namespace BULs
{
    public class MonHocBUL
    {

        MonHocDAL myMonHoc = new MonHocDAL();
        public List<MonHocDTO> LayDanhSachMonHoc()
        {
            try
            {
                return myMonHoc.LayDanhSachMonHoc();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
