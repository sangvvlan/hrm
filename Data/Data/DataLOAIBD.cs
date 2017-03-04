
using System.Data;
using ParentData;
using DataObject;


namespace Data
{
    public class DataLOAIBD : ParentDataLOAIBD
    {
        public int DataInsertLOAIBD(LOAIBD ObjLOAIBD)
        {
            return PDInsertLOAIBD(ObjLOAIBD.bdid, ObjLOAIBD.loaibd, ObjLOAIBD.ngayps);
        }

        public int DataDeleteLOAIBD(LOAIBD ObjLOAIBD)
        {
            return PDDeleteLOAIBD(ObjLOAIBD.bdid);
        }


        public DataTable DataDetailsLOAIBD(LOAIBD ObjLOAIBD)
        {
            return PDDetailsLOAIBD(ObjLOAIBD.bdid);
        }

        public int DataUpdateLOAIBD(LOAIBD ObjLOAIBD)
        {
            return PDUpdateLOAIBD(ObjLOAIBD.bdid, ObjLOAIBD.loaibd, ObjLOAIBD.ngayps);
        }

        public DataTable DataGetListLOAIBD()
        {
            return PDGetListLOAIBD();
        }

        public DataTable DataDetailsByFieldLOAIBD(string FieldName, string value)
        {
            return PDDetailsByFieldLOAIBD(FieldName, value);
        }

    }// End Class

}