using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTOs
{
    public class LoaiQuyenDTO
    {
        private string _MaQuyen;

        public string MaQuyen
        {
            get { return _MaQuyen; }
            set { _MaQuyen = value; }
        }
        private string _Quyen;

        public string Quyen
        {
            get { return _Quyen; }
            set { _Quyen = value; }
        }
        public LoaiQuyenDTO() { }
        public LoaiQuyenDTO(string id, string quyen) {
            this.MaQuyen = id;
            this.Quyen = quyen;
        }
    }
}
