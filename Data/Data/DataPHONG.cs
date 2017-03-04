
using System.Data;
using DataObject;
using ParentData;

namespace Data
{
    public class DataPHONG : ParentDataPHONG
    {
        public int DataInsertPHONG(PHONG ObjPHONG)
        {
            return PDInsertPHONG(ObjPHONG.phongid, ObjPHONG.maphong, ObjPHONG.tenphong, ObjPHONG.Dienthoai);
        }

        public int DataDeletePHONG(PHONG ObjPHONG)
        {
            return PDDeletePHONG(ObjPHONG.phongid);
        }


        public DataTable DataDetailsPHONG(PHONG ObjPHONG)
        {
            return PDDetailsPHONG(ObjPHONG.phongid);
        }

        public int DataUpdatePHONG(PHONG ObjPHONG)
        {
            return PDUpdatePHONG(ObjPHONG.phongid, ObjPHONG.maphong, ObjPHONG.tenphong, ObjPHONG.Dienthoai);
        }

        public DataTable DataGetListPHONG()
        {
            return PDGetListPHONG();
        }

        public DataTable DataDetailsByFieldPHONG(string FieldName, string value)
        {
            return PDDetailsByFieldPHONG(FieldName, value);
        }

    }// End Class
}
