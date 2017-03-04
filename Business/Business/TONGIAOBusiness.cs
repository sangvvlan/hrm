
using System.Data;
using DataObject;
using Data;

namespace Business
{
    public class TONGIAOBusiness
    {

        public int Insert(TONGIAO ObjTONGIAO)
        {
            DataTONGIAO objData = new DataTONGIAO();
            return objData.DataInsertTONGIAO(ObjTONGIAO);
        }

        public int Update(TONGIAO ObjTONGIAO)
        {
            DataTONGIAO objData = new DataTONGIAO();
            return objData.DataUpdateTONGIAO(ObjTONGIAO);
        }

        public int Delete(TONGIAO ObjTONGIAO)
        {
            DataTONGIAO objData = new DataTONGIAO();
            return objData.DataDeleteTONGIAO(ObjTONGIAO);
        }

        public DataTable GetList()
        {
            DataTONGIAO objData = new DataTONGIAO();
            return objData.DataGetListTONGIAO();
        }

        public DataTable Details(TONGIAO ObjTONGIAO)
        {
            DataTONGIAO objData = new DataTONGIAO();
            return objData.DataDetailsTONGIAO(ObjTONGIAO);
        }

        public DataTable DetailsByField(string FieldName, string value)
        {
            DataTONGIAO objData = new DataTONGIAO();
            return objData.DataDetailsByFieldTONGIAO(FieldName, value);
        }

    }// End Class
}
