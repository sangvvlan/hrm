
using System.Data;
using DataObject;
using Data;

namespace Business
{
    public class GIOITINHBusiness
    {

        public int Insert(GIOITINH ObjGIOITINH)
        {
            DataGIOITINH objData = new DataGIOITINH();
            return objData.DataInsertGIOITINH(ObjGIOITINH);
        }

        public int Update(GIOITINH ObjGIOITINH)
        {
            DataGIOITINH objData = new DataGIOITINH();
            return objData.DataUpdateGIOITINH(ObjGIOITINH);
        }

        public int Delete(GIOITINH ObjGIOITINH)
        {
            DataGIOITINH objData = new DataGIOITINH();
            return objData.DataDeleteGIOITINH(ObjGIOITINH);
        }

        public DataTable GetList()
        {
            DataGIOITINH objData = new DataGIOITINH();
            return objData.DataGetListGIOITINH();
        }

        public DataTable Details(GIOITINH ObjGIOITINH)
        {
            DataGIOITINH objData = new DataGIOITINH();
            return objData.DataDetailsGIOITINH(ObjGIOITINH);
        }

        public DataTable DetailsByField(string FieldName, string value)
        {
            DataGIOITINH objData = new DataGIOITINH();
            return objData.DataDetailsByFieldGIOITINH(FieldName, value);
        }

    }// End Class
}
