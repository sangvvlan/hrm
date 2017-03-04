
using System.Data;
using ParentData;
using DataObject;

namespace Data
{
    public class DataLOAIHOPDONG : ParentDataLOAIHOPDONG
    {
        public int DataInsertLOAIHOPDONG(LOAIHOPDONG ObjLOAIHOPDONG)
        {
            return PDInsertLOAIHOPDONG(ObjLOAIHOPDONG.loaihdid, ObjLOAIHOPDONG.mahd, ObjLOAIHOPDONG.tenhd);
        }

        public int DataDeleteLOAIHOPDONG(LOAIHOPDONG ObjLOAIHOPDONG)
        {
            return PDDeleteLOAIHOPDONG(ObjLOAIHOPDONG.loaihdid);
        }


        public DataTable DataDetailsLOAIHOPDONG(LOAIHOPDONG ObjLOAIHOPDONG)
        {
            return PDDetailsLOAIHOPDONG(ObjLOAIHOPDONG.loaihdid);
        }

        public int DataUpdateLOAIHOPDONG(LOAIHOPDONG ObjLOAIHOPDONG)
        {
            return PDUpdateLOAIHOPDONG(ObjLOAIHOPDONG.loaihdid, ObjLOAIHOPDONG.mahd, ObjLOAIHOPDONG.tenhd);
        }

        public DataTable DataGetListLOAIHOPDONG()
        {
            return PDGetListLOAIHOPDONG();
        }

        public DataTable DataDetailsByFieldLOAIHOPDONG(string FieldName, string value)
        {
            return PDDetailsByFieldLOAIHOPDONG(FieldName, value);
        }

    }// End Class
}
