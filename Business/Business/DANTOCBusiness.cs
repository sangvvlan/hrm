
using System.Data;
using DataObject;
using Data;

namespace Business
{
    public class DANTOCBusiness
    {

        public int Insert(DANTOC ObjDANTOC)
        {
            DataDANTOC objData = new DataDANTOC();
            return objData.DataInsertDANTOC(ObjDANTOC);
        }

        public int Update(DANTOC ObjDANTOC)
        {
            DataDANTOC objData = new DataDANTOC();
            return objData.DataUpdateDANTOC(ObjDANTOC);
        }

        public int Delete(DANTOC ObjDANTOC)
        {
            DataDANTOC objData = new DataDANTOC();
            return objData.DataDeleteDANTOC(ObjDANTOC);
        }

        public DataTable GetList()
        {
            DataDANTOC objData = new DataDANTOC();
            return objData.DataGetListDANTOC();
        }

        public DataTable Details(DANTOC ObjDANTOC)
        {
            DataDANTOC objData = new DataDANTOC();
            return objData.DataDetailsDANTOC(ObjDANTOC);
        }

        public DataTable DetailsByField(string FieldName, string value)
        {
            DataDANTOC objData = new DataDANTOC();
            return objData.DataDetailsByFieldDANTOC(FieldName, value);
        }

    }// End Class
}
