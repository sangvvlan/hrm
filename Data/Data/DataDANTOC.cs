
using System.Data;
using ParentData;
using DataObject;

namespace Data
{
    public class DataDANTOC : ParentDataDANTOC
    {
        public int DataInsertDANTOC(DANTOC ObjDANTOC)
        {
            return PDInsertDANTOC(ObjDANTOC.dantocid, ObjDANTOC.madt, ObjDANTOC.tendt);
        }

        public int DataDeleteDANTOC(DANTOC ObjDANTOC)
        {
            return PDDeleteDANTOC(ObjDANTOC.dantocid);
        }


        public DataTable DataDetailsDANTOC(DANTOC ObjDANTOC)
        {
            return PDDetailsDANTOC(ObjDANTOC.dantocid);
        }

        public int DataUpdateDANTOC(DANTOC ObjDANTOC)
        {
            return PDUpdateDANTOC(ObjDANTOC.dantocid, ObjDANTOC.madt, ObjDANTOC.tendt);
        }

        public DataTable DataGetListDANTOC()
        {
            return PDGetListDANTOC();
        }

        public DataTable DataDetailsByFieldDANTOC(string FieldName, string value)
        {
            return PDDetailsByFieldDANTOC(FieldName, value);
        }

    }// End Class
}
