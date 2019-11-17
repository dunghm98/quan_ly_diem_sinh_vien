using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTOs
{
    public class MonHocDTO
    {
        public string maMon { get; set; }
        public string tenMon { get; set; }

        public MonHocDTO() { }
        public MonHocDTO(string maMon, string tenMon)
        {
            this.maMon = maMon;
            this.tenMon = tenMon;
        }
    }
}
