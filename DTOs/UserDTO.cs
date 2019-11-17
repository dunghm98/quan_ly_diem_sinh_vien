using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTOs
{
    public class UserDTO
    {
        private string _TenDangNhap;

        public string TenDangNhap
        {
            get { return _TenDangNhap; }
            set { _TenDangNhap = value; }
        }
        private string _MatKhau;

        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }
        private string _MaQuyen;

        public string MaQuyen
        {
            get { return _MaQuyen; }
            set { _MaQuyen = value; }
        }
        private string _HoTen;

        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }
        public UserDTO() { }
        public UserDTO(string username, string mk, string quyen, string hoTen) {
            this.TenDangNhap = username;
            this.MatKhau = mk;
            this.MaQuyen = quyen;
            this.HoTen = hoTen;
        }
    }
}
