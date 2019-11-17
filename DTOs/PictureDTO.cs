using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTOs
{
    public class PictureDTO
    {
        private byte[] _Img;

        public byte[] Img
        {
            get { return _Img; }
            set { _Img = value; }
        }
        private string _FileName;

        public string FileName
        {
            get { return _FileName; }
            set { _FileName = value; }
        }
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private string _Msv;

        public string Msv
        {
            get { return _Msv; }
            set { _Msv = value; }
        }
        public PictureDTO()
        {

        }
        public PictureDTO(int id, string name, byte[] img, string msv)
        {
            this.ID = id;
            this.FileName = name;
            this.Img = img;
            this.Msv = msv;
        }
    }
}
