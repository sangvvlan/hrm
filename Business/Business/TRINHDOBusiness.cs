
using System.Data;
using DataObject;
using Data;

namespace Business
{
    public class TRINHDOBusiness
    {

        public int Insert(TRINHDO ObjTRINHDO)
        {
            DataTRINHDO objData = new DataTRINHDO();
            return objData.DataInsertTRINHDO(ObjTRINHDO);
        }

        public int Update(TRINHDO ObjTRINHDO)
        {
            DataTRINHDO objData = new DataTRINHDO();
            return objData.DataUpdateTRINHDO(ObjTRINHDO);
        }

        public int Delete(TRINHDO ObjTRINHDO)
        {
            DataTRINHDO objData = new DataTRINHDO();
            return objData.DataDeleteTRINHDO(ObjTRINHDO);
        }

        public DataTable GetList()
        {
            DataTRINHDO objData = new DataTRINHDO();
            return objData.DataGetListTRINHDO();
        }

        public DataTable Details(TRINHDO ObjTRINHDO)
        {
            DataTRINHDO objData = new DataTRINHDO();
            return objData.DataDetailsTRINHDO(ObjTRINHDO);
        }

        public DataTable DetailsByField(string FieldName, string value)
        {
            DataTRINHDO objData = new DataTRINHDO();
            return objData.DataDetailsByFieldTRINHDO(FieldName, value);
        }

    }// End Class
}
