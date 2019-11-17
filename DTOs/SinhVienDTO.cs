using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTOs
{
    public class SinhVienDTO
    {
        private string _MaSinhVien;

        public string MaSinhVien
        {
            get { return _MaSinhVien; }
            set { _MaSinhVien = value; }
        }
        private string _TenSinhVien;

        public string TenSinhVien
        {
            get { return _TenSinhVien; }
            set { _TenSinhVien = value; }
        }
        private string _NgaySinh;

        public string NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }
        private string _GioiTinh;

        public string GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }
        private string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        private string _MaLop;

        public string MaLop
        {
            get { return _MaLop; }
            set { _MaLop = value; }
        }
        private string _MaKhoa;

        public string MaKhoa
        {
            get { return _MaKhoa; }
            set { _MaKhoa = value; }
        }
        private string _Sdt;

        public string Sdt
        {
            get { return _Sdt; }
            set { _Sdt = value; }
        }
        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
      
      
        public SinhVienDTO() { }
        public SinhVienDTO(string maSv, string ten, string ngSinh, string gioiTinh, string diaChi, string maLop, string maKhoa, string sdt, string email) {
            this.MaSinhVien = maSv;
            this.TenSinhVien = ten;
            this.NgaySinh = ngSinh;
            this.GioiTinh = gioiTinh;
            this.DiaChi = diaChi;
            this.MaLop = maLop;
            this.MaKhoa = maKhoa;
            this.Sdt = sdt;
            this.Email = email;
        
        
        }
    }
}
