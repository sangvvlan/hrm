using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObject
{
    public class DONVI
    {
        private decimal _donviid;
        private string _tendonvi;



        public decimal donviid
        {
            get { return _donviid; }
            set { _donviid = value; }
        }


        public string tendonvi
        {
            get { return _tendonvi; }
            set { _tendonvi = value; }
        }


    }
}
