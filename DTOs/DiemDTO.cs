using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTOs
{
    public class DiemDTO
    {
        public string maSV { get; set; }
        public string maMon { get; set; }
        public float DiemTB { get; set; }
        public float DiemThiLan1 { get; set; }
        public float DiemTongKet { get; set; }

        public DiemDTO() { }
        public DiemDTO(string maSV, string maMon, float DiemTB, float DiemThiLan1, float DiemTongKet)
        {
            this.maMon = maMon;
            this.maSV = maSV;
            this.DiemTB = DiemTB;
            this.DiemThiLan1 = DiemThiLan1;
            this.DiemTongKet = DiemTongKet;
        }
    }
}
