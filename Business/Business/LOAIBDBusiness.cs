
using System.Data;
using DataObject;
using Data;

namespace Business
{
    public class LOAIBDBusiness
    {

        public int Insert(LOAIBD ObjLOAIBD)
        {
            DataLOAIBD objData = new DataLOAIBD();
            return objData.DataInsertLOAIBD(ObjLOAIBD);
        }

        public int Update(LOAIBD ObjLOAIBD)
        {
            DataLOAIBD objData = new DataLOAIBD();
            return objData.DataUpdateLOAIBD(ObjLOAIBD);
        }

        public int Delete(LOAIBD ObjLOAIBD)
        {
            DataLOAIBD objData = new DataLOAIBD();
            return objData.DataDeleteLOAIBD(ObjLOAIBD);
        }

        public DataTable GetList()
        {
            DataLOAIBD objData = new DataLOAIBD();
            return objData.DataGetListLOAIBD();
        }

        public DataTable Details(LOAIBD ObjLOAIBD)
        {
            DataLOAIBD objData = new DataLOAIBD();
            return objData.DataDetailsLOAIBD(ObjLOAIBD);
        }

        public DataTable DetailsByField(string FieldName, string value)
        {
            DataLOAIBD objData = new DataLOAIBD();
            return objData.DataDetailsByFieldLOAIBD(FieldName, value);
        }

    }// End Class
}
