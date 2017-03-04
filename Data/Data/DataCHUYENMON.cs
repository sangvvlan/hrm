
using System.Data;
using ParentData;
using DataObject;

namespace Data
{
    public class DataCHUYENMON : ParentDataCHUYENMON
    {
        public int DataInsertCHUYENMON(CHUYENMON ObjCHUYENMON)
        {
            return PDInsertCHUYENMON(ObjCHUYENMON.cmid, ObjCHUYENMON.macm, ObjCHUYENMON.tencm);
        }

        public int DataDeleteCHUYENMON(CHUYENMON ObjCHUYENMON)
        {
            return PDDeleteCHUYENMON(ObjCHUYENMON.cmid);
        }


        public DataTable DataDetailsCHUYENMON(CHUYENMON ObjCHUYENMON)
        {
            return PDDetailsCHUYENMON(ObjCHUYENMON.cmid);
        }

        public int DataUpdateCHUYENMON(CHUYENMON ObjCHUYENMON)
        {
            return PDUpdateCHUYENMON(ObjCHUYENMON.cmid, ObjCHUYENMON.macm, ObjCHUYENMON.tencm);
        }

        public DataTable DataGetListCHUYENMON()
        {
            return PDGetListCHUYENMON();
        }

        public DataTable DataDetailsByFieldCHUYENMON(string FieldName, string value)
        {
            return PDDetailsByFieldCHUYENMON(FieldName, value);
        }

    }// End Class
}
