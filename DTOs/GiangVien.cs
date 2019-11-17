using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTOs
{
    public class GiangVien
    {
        private String magiangvien;

        public String Magiangvien
        {
            get { return magiangvien; }
            set { magiangvien = value; }
        }
        private String tengiangvien;

        public String Tengiangvien
        {
            get { return tengiangvien; }
            set { tengiangvien = value; }
        }
        private String gioitinh;

        public String Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        private String dienthoai;

        public String Dienthoai
        {
            get { return dienthoai; }
            set { dienthoai = value; }
        }
        private String email;

        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        private String phanloaigiaovien;

        public String Phanloaigiaovien
        {
            get { return phanloaigiaovien; }
            set { phanloaigiaovien = value; }
        }
        private String makhoa;

        public String Makhoa
        {
            get { return makhoa; }
            set { makhoa = value; }
        }
        public GiangVien(String magiangvien, String tengiangvien, String gioitinh, String dienthoai, String email, String phanloaigiaovien, String makhoa)
        {
            this.Dienthoai = dienthoai;
            this.Email = email;
            this.Tengiangvien = tengiangvien;
            this.Magiangvien = magiangvien;
            this.Phanloaigiaovien = phanloaigiaovien;
            this.Gioitinh = gioitinh;
            this.Makhoa = makhoa;
        }
        public GiangVien()

        { }
    }
}
