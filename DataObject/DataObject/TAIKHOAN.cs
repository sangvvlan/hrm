using System;

namespace DataObject
{
    public class TAIKHOAN
    {

        private string _Taikhoan;
        private string _matkhau;
        private string _quyen;
        private DateTime _ngaylap;



        public string Taikhoan
        {
            get { return _Taikhoan; }
            set { _Taikhoan = value; }
        }


        public string matkhau
        {
            get { return _matkhau; }
            set { _matkhau = value; }
        }


        public string quyen
        {
            get { return _quyen; }
            set { _quyen = value; }
        }


        public DateTime ngaylap
        {
            get { return _ngaylap; }
            set { _ngaylap = value; }
        }


    }// End Class
}
