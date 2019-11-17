using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTOs
{
    public class LoaiGiangVienDTO
    {
        private String MaLoai;

        public String MaLoai1
        {
            get { return MaLoai; }
            set { MaLoai = value; }
        }
        private String TenLoai;

        public String TenLoai1
        {
            get { return TenLoai; }
            set { TenLoai = value; }
        }
        public LoaiGiangVienDTO() { }
        public LoaiGiangVienDTO(String maloai, String tenloai)
        {
            this.MaLoai1 = maloai;
            this.TenLoai1 = tenloai;
        }


    }
}
