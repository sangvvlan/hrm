
using System.Data;
using DataObject;
using Data;

namespace Business
{
    public class NHANVIENBusiness
    {

        public int Insert(NHANVIEN ObjNHANVIEN)
        {
            DataNHANVIEN objData = new DataNHANVIEN();
            return objData.DataInsertNHANVIEN(ObjNHANVIEN);
        }

        public int Update(NHANVIEN ObjNHANVIEN)
        {
            DataNHANVIEN objData = new DataNHANVIEN();
            return objData.DataUpdateNHANVIEN(ObjNHANVIEN);
        }

        public int Update_hinh(Hinh_NHANVIEN ObjNHANVIEN)
        {
            DataNHANVIEN objData = new DataNHANVIEN();
            return objData.DataUpdateHinhNHANVIEN(ObjNHANVIEN);
            
        }

        public int Delete(NHANVIEN ObjNHANVIEN)
        {
            DataNHANVIEN objData = new DataNHANVIEN();
            return objData.DataDeleteNHANVIEN(ObjNHANVIEN);
        }

        public DataTable GetList()
        {
            DataNHANVIEN objData = new DataNHANVIEN();
            return objData.DataGetListNHANVIEN();
        }

        public DataTable Details(NHANVIEN ObjNHANVIEN)
        {
            DataNHANVIEN objData = new DataNHANVIEN();
            return objData.DataDetailsNHANVIEN(ObjNHANVIEN);
        }

        public DataTable DetailsByField(string FieldName, string value)
        {
            DataNHANVIEN objData = new DataNHANVIEN();
            return objData.DataDetailsByFieldNHANVIEN(FieldName, value);
        }


    }// End Class
}
