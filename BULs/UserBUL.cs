using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALs;
using DTOs;
namespace BULs
{
    public class UserBUL
    {
        UserDAL us = new UserDAL();
        public List<UserDTO> LayDsUser()
        {
            return us.LayThongTinUser();
        }
        public void ThemMoiUser(UserDTO user)
        {
            us.ThemUser(user);
        }
        public void SuaThongTinUser(UserDTO user)
        {
            us.SuaUser(user);
        }
        public void XoaUser(string ten)
        {
            us.XoaUser(ten);
        }
        public string Ktra(UserDTO user) { 
            string str = null;
            str = us.KiemtraTK(user);
            return str;
        }
        public List<UserDTO> TimUserTheoMa(string ma)
        {
            return us.TimUserTheoMa(ma);
        }
        public List<string> LayDsUserName()
        {
            return us.LayUserName();
        }
        public string getTenNgDung(string username)
        {
            string strUserName = "";
            try
            {
                strUserName = us.layTenNgDung(username);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return strUserName;
        }
        public int checkQuyenUser(string user) {
            return us.checkQuyen(user);
        }
    }
}
