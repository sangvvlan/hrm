
using System.Data;
using ParentData;
using DataObject;

namespace Data
{
    public class DataGIOITINH : ParentDataGIOITINH
    {
        public int DataInsertGIOITINH(GIOITINH ObjGIOITINH)
        {
            return PDInsertGIOITINH(ObjGIOITINH.gioitinhid, ObjGIOITINH.gioitinh);
        }

        public int DataDeleteGIOITINH(GIOITINH ObjGIOITINH)
        {
            return PDDeleteGIOITINH(ObjGIOITINH.gioitinhid);
        }


        public DataTable DataDetailsGIOITINH(GIOITINH ObjGIOITINH)
        {
            return PDDetailsGIOITINH(ObjGIOITINH.gioitinhid);
        }

        public int DataUpdateGIOITINH(GIOITINH ObjGIOITINH)
        {
            return PDUpdateGIOITINH(ObjGIOITINH.gioitinhid, ObjGIOITINH.gioitinh);
        }

        public DataTable DataGetListGIOITINH()
        {
            return PDGetListGIOITINH();
        }

        public DataTable DataDetailsByFieldGIOITINH(string FieldName, string value)
        {
            return PDDetailsByFieldGIOITINH(FieldName, value);
        }

    }// End Class
}
