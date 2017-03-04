using System.Data;
using ParentData;
using DataObject;

namespace Data
{
    public class DataDONVI : ParentDataDONVI
    {

        public int DataInsertDONVI(DONVI ObjDONVI)
        {
            return PDInsertDONVI(ObjDONVI.donviid, ObjDONVI.tendonvi);
        }

        public int DataDeleteDONVI(DONVI ObjDONVI)
        {
            return PDDeleteDONVI(ObjDONVI.donviid);
        }


        public DataTable DataDetailsDONVI(DONVI ObjDONVI)
        {
            return PDDetailsDONVI(ObjDONVI.donviid);
        }

        public int DataUpdateDONVI(DONVI ObjDONVI)
        {
            return PDUpdateDONVI(ObjDONVI.donviid, ObjDONVI.tendonvi);
        }

        public DataTable DataGetListDONVI()
        {
            return PDGetListDONVI();
        }

        public DataTable DataDetailsByFieldDONVI(string FieldName, string value)
        {
            return PDDetailsByFieldDONVI(FieldName, value);
        }


    }
}
