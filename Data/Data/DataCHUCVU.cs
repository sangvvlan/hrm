
using System.Data;
using ParentData;
using DataObject;

namespace Data
{
    public class DataCHUCVU : ParentDataCHUCVU
    {
        public int DataInsertCHUCVU(CHUCVU ObjCHUCVU)
        {
            return PDInsertCHUCVU(ObjCHUCVU.cvid, ObjCHUCVU.macv, ObjCHUCVU.tencv);
        }

        public int DataDeleteCHUCVU(CHUCVU ObjCHUCVU)
        {
            return PDDeleteCHUCVU(ObjCHUCVU.cvid);
        }


        public DataTable DataDetailsCHUCVU(CHUCVU ObjCHUCVU)
        {
            return PDDetailsCHUCVU(ObjCHUCVU.cvid);
        }

        public int DataUpdateCHUCVU(CHUCVU ObjCHUCVU)
        {
            return PDUpdateCHUCVU(ObjCHUCVU.cvid, ObjCHUCVU.macv, ObjCHUCVU.tencv);
        }

        public DataTable DataGetListCHUCVU()
        {
            return PDGetListCHUCVU();
        }

        public DataTable DataDetailsByFieldCHUCVU(string FieldName, string value)
        {
            return PDDetailsByFieldCHUCVU(FieldName, value);
        }

    }// End Class
}
