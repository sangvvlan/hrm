
using System.Data;
using ParentData;
using DataObject;

namespace Data
{
    public class DataMUCLUONG : ParentDataMUCLUONG
    {
        public int DataInsertMUCLUONG(MUCLUONG ObjMUCLUONG)
        {
            return PDInsertMUCLUONG(ObjMUCLUONG.bacluong, ObjMUCLUONG.luongcb);
        }

        public int DataDeleteMUCLUONG(MUCLUONG ObjMUCLUONG)
        {
            return PDDeleteMUCLUONG(ObjMUCLUONG.bacluong);
        }


        public DataTable DataDetailsMUCLUONG(MUCLUONG ObjMUCLUONG)
        {
            return PDDetailsMUCLUONG(ObjMUCLUONG.bacluong);
        }

        public int DataUpdateMUCLUONG(MUCLUONG ObjMUCLUONG)
        {
            return PDUpdateMUCLUONG(ObjMUCLUONG.bacluong, ObjMUCLUONG.luongcb);
        }

        public DataTable DataGetListMUCLUONG()
        {
            return PDGetListMUCLUONG();
        }

        public DataTable DataDetailsByFieldMUCLUONG(string FieldName, string value)
        {
            return PDDetailsByFieldMUCLUONG(FieldName, value);
        }

    }// End Class
}
