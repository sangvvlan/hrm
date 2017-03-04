
using System.Data;
using DataObject;
using ParentData;

namespace Data
{

    public class DataTAIKHOAN : ParentDataTAIKHOAN
    {
        public int DataInsertTAIKHOAN(TAIKHOAN ObjTAIKHOAN)
        {
            return PDInsertTAIKHOAN(ObjTAIKHOAN.Taikhoan, ObjTAIKHOAN.matkhau, ObjTAIKHOAN.quyen, ObjTAIKHOAN.ngaylap);
        }

        public int DataDeleteTAIKHOAN(TAIKHOAN ObjTAIKHOAN)
        {
            return PDDeleteTAIKHOAN(ObjTAIKHOAN.Taikhoan);
        }


        public DataTable DataDetailsTAIKHOAN(TAIKHOAN ObjTAIKHOAN)
        {
            return PDDetailsTAIKHOAN(ObjTAIKHOAN.Taikhoan);
        }

        public int DataUpdateTAIKHOAN(TAIKHOAN ObjTAIKHOAN)
        {
            return PDUpdateTAIKHOAN(ObjTAIKHOAN.Taikhoan, ObjTAIKHOAN.matkhau, ObjTAIKHOAN.quyen, ObjTAIKHOAN.ngaylap);
        }

        public DataTable DataGetListTAIKHOAN()
        {
            return PDGetListTAIKHOAN();
        }

        public DataTable DataDetailsByFieldTAIKHOAN(string FieldName, string value)
        {
            return PDDetailsByFieldTAIKHOAN(FieldName, value);
        }

    }// End Class
}
