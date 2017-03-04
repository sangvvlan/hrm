
using System.Data;
using DataObject;
using Data;

namespace Business
{
    public class LOAIHOPDONGBusiness
    {

        public int Insert(LOAIHOPDONG ObjLOAIHOPDONG)
        {
            DataLOAIHOPDONG objData = new DataLOAIHOPDONG();
            return objData.DataInsertLOAIHOPDONG(ObjLOAIHOPDONG);
        }

        public int Update(LOAIHOPDONG ObjLOAIHOPDONG)
        {
            DataLOAIHOPDONG objData = new DataLOAIHOPDONG();
            return objData.DataUpdateLOAIHOPDONG(ObjLOAIHOPDONG);
        }

        public int Delete(LOAIHOPDONG ObjLOAIHOPDONG)
        {
            DataLOAIHOPDONG objData = new DataLOAIHOPDONG();
            return objData.DataDeleteLOAIHOPDONG(ObjLOAIHOPDONG);
        }

        public DataTable GetList()
        {
            DataLOAIHOPDONG objData = new DataLOAIHOPDONG();
            return objData.DataGetListLOAIHOPDONG();
        }

        public DataTable Details(LOAIHOPDONG ObjLOAIHOPDONG)
        {
            DataLOAIHOPDONG objData = new DataLOAIHOPDONG();
            return objData.DataDetailsLOAIHOPDONG(ObjLOAIHOPDONG);
        }

        public DataTable DetailsByField(string FieldName, string value)
        {
            DataLOAIHOPDONG objData = new DataLOAIHOPDONG();
            return objData.DataDetailsByFieldLOAIHOPDONG(FieldName, value);
        }

    }// End Class
}
