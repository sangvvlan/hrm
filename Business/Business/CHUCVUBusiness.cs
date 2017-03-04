
using System.Data;
using DataObject;
using Data;

namespace Business
{
    public class CHUCVUBusiness
    {

        public int Insert(CHUCVU ObjCHUCVU)
        {
            DataCHUCVU objData = new DataCHUCVU();
            return objData.DataInsertCHUCVU(ObjCHUCVU);
        }

        public int Update(CHUCVU ObjCHUCVU)
        {
            DataCHUCVU objData = new DataCHUCVU();
            return objData.DataUpdateCHUCVU(ObjCHUCVU);
        }

        public int Delete(CHUCVU ObjCHUCVU)
        {
            DataCHUCVU objData = new DataCHUCVU();
            return objData.DataDeleteCHUCVU(ObjCHUCVU);
        }

        public DataTable GetList()
        {
            DataCHUCVU objData = new DataCHUCVU();
            return objData.DataGetListCHUCVU();
        }

        public DataTable Details(CHUCVU ObjCHUCVU)
        {
            DataCHUCVU objData = new DataCHUCVU();
            return objData.DataDetailsCHUCVU(ObjCHUCVU);
        }

        public DataTable DetailsByField(string FieldName, string value)
        {
            DataCHUCVU objData = new DataCHUCVU();
            return objData.DataDetailsByFieldCHUCVU(FieldName, value);
        }

    }// End Class
}
