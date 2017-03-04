
using System.Data;
using Data;
using DataObject;

namespace Business
{
    public class TAIKHOANBusiness
    {

        public int Insert(TAIKHOAN ObjTAIKHOAN)
        {
            DataTAIKHOAN objData = new DataTAIKHOAN();
            return objData.DataInsertTAIKHOAN(ObjTAIKHOAN);
        }

        public int Update(TAIKHOAN ObjTAIKHOAN)
        {
            DataTAIKHOAN objData = new DataTAIKHOAN();
            return objData.DataUpdateTAIKHOAN(ObjTAIKHOAN);
        }

        public int Delete(TAIKHOAN ObjTAIKHOAN)
        {
            DataTAIKHOAN objData = new DataTAIKHOAN();
            return objData.DataDeleteTAIKHOAN(ObjTAIKHOAN);
        }

        public DataTable GetList()
        {
            DataTAIKHOAN objData = new DataTAIKHOAN();
            return objData.DataGetListTAIKHOAN();
        }

        public DataTable Details(TAIKHOAN ObjTAIKHOAN)
        {
            DataTAIKHOAN objData = new DataTAIKHOAN();
            return objData.DataDetailsTAIKHOAN(ObjTAIKHOAN);
        }

        public DataTable DetailsByField(string FieldName, string value)
        {
            DataTAIKHOAN objData = new DataTAIKHOAN();
            return objData.DataDetailsByFieldTAIKHOAN(FieldName, value);
        }

    }// End Class

}