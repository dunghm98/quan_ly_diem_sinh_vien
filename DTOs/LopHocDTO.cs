using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTOs
{
    public class LopHocDTO
    {
        private string _MaLop;

        public string MaLop
        {
            get { return _MaLop; }
            set { _MaLop = value; }
        }
        private string _TenLop;

        public string TenLop
        {
            get { return _TenLop; }
            set { _TenLop = value; }
        }
        private string _MaKhoa;

        public string MaKhoa
        {
            get { return _MaKhoa; }
            set { _MaKhoa = value; }
        }
        public LopHocDTO() { }
        public LopHocDTO(string ma, string ten, string maKhoa) {
            this.MaLop = ma;
            this.TenLop = ten;
            this.MaKhoa = maKhoa;
        }
    }
}
