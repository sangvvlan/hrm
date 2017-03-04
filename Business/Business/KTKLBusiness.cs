
using System.Data;
using DataObject;
using Data;

namespace Business
{
    public class KTKLBusiness
    {

        public int Insert(KTKL ObjKTKL)
        {
            DataKTKL objData = new DataKTKL();
            return objData.DataInsertKTKL(ObjKTKL);
        }

        public int Update(KTKL ObjKTKL)
        {
            DataKTKL objData = new DataKTKL();
            return objData.DataUpdateKTKL(ObjKTKL);
        }

        public int Delete(KTKL ObjKTKL)
        {
            DataKTKL objData = new DataKTKL();
            return objData.DataDeleteKTKL(ObjKTKL);
        }

        public DataTable GetList()
        {
            DataKTKL objData = new DataKTKL();
            return objData.DataGetListKTKL();
        }

        public DataTable Details(KTKL ObjKTKL)
        {
            DataKTKL objData = new DataKTKL();
            return objData.DataDetailsKTKL(ObjKTKL);
        }

        public DataTable DetailsByField(string FieldName, string value)
        {
            DataKTKL objData = new DataKTKL();
            return objData.DataDetailsByFieldKTKL(FieldName, value);
        }

    }// End Class

}