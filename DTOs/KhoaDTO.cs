using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTOs
{
    public class KhoaDTO
    {
        private string _MaKhoa;

        public string MaKhoa
        {
            get { return _MaKhoa; }
            set { _MaKhoa = value; }
        }
        private string _TenKhoa;

        public string TenKhoa
        {
            get { return _TenKhoa; }
            set { _TenKhoa = value; }
        }
        public KhoaDTO() { }
        public KhoaDTO(string ma, string ten) {
            this.MaKhoa = ma;
            this.TenKhoa = ten;
        }
    }
}
