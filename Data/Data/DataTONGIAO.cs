
using System.Data;
using ParentData;
using DataObject;

namespace Data
{
    public class DataTONGIAO : ParentDataTONGIAO
    {
        public int DataInsertTONGIAO(TONGIAO ObjTONGIAO)
        {
            return PDInsertTONGIAO(ObjTONGIAO.tgid, ObjTONGIAO.matg, ObjTONGIAO.tentg);
        }

        public int DataDeleteTONGIAO(TONGIAO ObjTONGIAO)
        {
            return PDDeleteTONGIAO(ObjTONGIAO.tgid);
        }


        public DataTable DataDetailsTONGIAO(TONGIAO ObjTONGIAO)
        {
            return PDDetailsTONGIAO(ObjTONGIAO.tgid);
        }

        public int DataUpdateTONGIAO(TONGIAO ObjTONGIAO)
        {
            return PDUpdateTONGIAO(ObjTONGIAO.tgid, ObjTONGIAO.matg, ObjTONGIAO.tentg);
        }

        public DataTable DataGetListTONGIAO()
        {
            return PDGetListTONGIAO();
        }

        public DataTable DataDetailsByFieldTONGIAO(string FieldName, string value)
        {
            return PDDetailsByFieldTONGIAO(FieldName, value);
        }

    }// End Class

}
