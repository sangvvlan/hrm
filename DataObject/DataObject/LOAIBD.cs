using System;
namespace DataObject
{
    public class LOAIBD
    {

        private decimal _bdid;
        private string _loaibd;
        private DateTime _ngayps;



        public decimal bdid
        {
            get { return _bdid; }
            set { _bdid = value; }
        }


        public string loaibd
        {
            get { return _loaibd; }
            set { _loaibd = value; }
        }


        public DateTime ngayps
        {
            get { return _ngayps; }
            set { _ngayps = value; }
        }


    }// End Class
}
