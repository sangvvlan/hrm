
using System.Data;
using DataObject;
using Data;

namespace Business
{
    public class CHUYENMONBusiness
    {

        public int Insert(CHUYENMON ObjCHUYENMON)
        {
            DataCHUYENMON objData = new DataCHUYENMON();
            return objData.DataInsertCHUYENMON(ObjCHUYENMON);
        }

        public int Update(CHUYENMON ObjCHUYENMON)
        {
            DataCHUYENMON objData = new DataCHUYENMON();
            return objData.DataUpdateCHUYENMON(ObjCHUYENMON);
        }

        public int Delete(CHUYENMON ObjCHUYENMON)
        {
            DataCHUYENMON objData = new DataCHUYENMON();
            return objData.DataDeleteCHUYENMON(ObjCHUYENMON);
        }

        public DataTable GetList()
        {
            DataCHUYENMON objData = new DataCHUYENMON();
            return objData.DataGetListCHUYENMON();
        }

        public DataTable Details(CHUYENMON ObjCHUYENMON)
        {
            DataCHUYENMON objData = new DataCHUYENMON();
            return objData.DataDetailsCHUYENMON(ObjCHUYENMON);
        }

        public DataTable DetailsByField(string FieldName, string value)
        {
            DataCHUYENMON objData = new DataCHUYENMON();
            return objData.DataDetailsByFieldCHUYENMON(FieldName, value);
        }

    }// End Class
}
