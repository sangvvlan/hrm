
using System.Data;
using Data;
using DataObject;

namespace Business
{
    public class PHONGBusiness
    {

        public int Insert(PHONG ObjPHONG)
        {
            DataPHONG objData = new DataPHONG();
            return objData.DataInsertPHONG(ObjPHONG);
        }

        public int Update(PHONG ObjPHONG)
        {
            DataPHONG objData = new DataPHONG();
            return objData.DataUpdatePHONG(ObjPHONG);
        }

        public int Delete(PHONG ObjPHONG)
        {
            DataPHONG objData = new DataPHONG();
            return objData.DataDeletePHONG(ObjPHONG);
        }

        public DataTable GetList()
        {
            DataPHONG objData = new DataPHONG();
            return objData.DataGetListPHONG();
        }

        public DataTable Details(PHONG ObjPHONG)
        {
            DataPHONG objData = new DataPHONG();
            return objData.DataDetailsPHONG(ObjPHONG);
        }

        public DataTable DetailsByField(string FieldName, string value)
        {
            DataPHONG objData = new DataPHONG();
            return objData.DataDetailsByFieldPHONG(FieldName, value);
        }

    }// End Class
}
