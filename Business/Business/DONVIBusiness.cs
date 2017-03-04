
using System.Data;
using DataObject;
using Data;


namespace Business
{
    public class DONVIBusiness
    {
        public int Insert(DONVI ObjDONVI)
        {
            DataDONVI objData = new DataDONVI();
            return objData.DataInsertDONVI(ObjDONVI);
        }

        public int Update(DONVI ObjDONVI)
        {
            DataDONVI objData = new DataDONVI();
            return objData.DataUpdateDONVI(ObjDONVI);
        }

        public int Delete(DONVI ObjDONVI)
        {
            DataDONVI objData = new DataDONVI();
            return objData.DataDeleteDONVI(ObjDONVI);
        }

        public DataTable GetList()
        {
            DataDONVI objData = new DataDONVI();
            return objData.DataGetListDONVI();
        }

        public DataTable Details(DONVI ObjDONVI)
        {
            DataDONVI objData = new DataDONVI();
            return objData.DataDetailsDONVI(ObjDONVI);
        }

        public DataTable DetailsByField(string FieldName, string value)
        {
            DataDONVI objData = new DataDONVI();
            return objData.DataDetailsByFieldDONVI(FieldName, value);
        }




    }
}
