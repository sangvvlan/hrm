
using System.Data;
using DataObject;
using Data;

namespace Business
{
    public class MUCLUONGBusiness
    {

        public int Insert(MUCLUONG ObjMUCLUONG)
        {
            DataMUCLUONG objData = new DataMUCLUONG();
            return objData.DataInsertMUCLUONG(ObjMUCLUONG);
        }

        public int Update(MUCLUONG ObjMUCLUONG)
        {
            DataMUCLUONG objData = new DataMUCLUONG();
            return objData.DataUpdateMUCLUONG(ObjMUCLUONG);
        }

        public int Delete(MUCLUONG ObjMUCLUONG)
        {
            DataMUCLUONG objData = new DataMUCLUONG();
            return objData.DataDeleteMUCLUONG(ObjMUCLUONG);
        }

        public DataTable GetList()
        {
            DataMUCLUONG objData = new DataMUCLUONG();
            return objData.DataGetListMUCLUONG();
        }

        public DataTable Details(MUCLUONG ObjMUCLUONG)
        {
            DataMUCLUONG objData = new DataMUCLUONG();
            return objData.DataDetailsMUCLUONG(ObjMUCLUONG);
        }

        public DataTable DetailsByField(string FieldName, string value)
        {
            DataMUCLUONG objData = new DataMUCLUONG();
            return objData.DataDetailsByFieldMUCLUONG(FieldName, value);
        }

    }// End Class
}
