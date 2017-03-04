
using System.Data;
using ParentData;
using DataObject;

namespace Data
{
    public class DataTRINHDO : ParentDataTRINHDO
    {
        public int DataInsertTRINHDO(TRINHDO ObjTRINHDO)
        {
            return PDInsertTRINHDO(ObjTRINHDO.tdid, ObjTRINHDO.matd, ObjTRINHDO.tentd);
        }

        public int DataDeleteTRINHDO(TRINHDO ObjTRINHDO)
        {
            return PDDeleteTRINHDO(ObjTRINHDO.tdid);
        }


        public DataTable DataDetailsTRINHDO(TRINHDO ObjTRINHDO)
        {
            return PDDetailsTRINHDO(ObjTRINHDO.tdid);
        }

        public int DataUpdateTRINHDO(TRINHDO ObjTRINHDO)
        {
            return PDUpdateTRINHDO(ObjTRINHDO.tdid, ObjTRINHDO.matd, ObjTRINHDO.tentd);
        }

        public DataTable DataGetListTRINHDO()
        {
            return PDGetListTRINHDO();
        }

        public DataTable DataDetailsByFieldTRINHDO(string FieldName, string value)
        {
            return PDDetailsByFieldTRINHDO(FieldName, value);
        }

    }// End Class

}