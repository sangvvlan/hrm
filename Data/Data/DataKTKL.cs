
using System.Data;
using ParentData;
using DataObject;


namespace Data
{
    public class DataKTKL : ParentDataKTKL
    {
        public int DataInsertKTKL(KTKL ObjKTKL)
        {
            return PDInsertKTKL(ObjKTKL.ktklid, ObjKTKL.soqd, ObjKTKL.ngayqd, ObjKTKL.manv, ObjKTKL.loaikt, ObjKTKL.hinhthuc, ObjKTKL.sotien, ObjKTKL.noidung, ObjKTKL.ngaycn);
        }

        public int DataDeleteKTKL(KTKL ObjKTKL)
        {
            return PDDeleteKTKL(ObjKTKL.ktklid);
        }


        public DataTable DataDetailsKTKL(KTKL ObjKTKL)
        {
            return PDDetailsKTKL(ObjKTKL.ktklid);
        }

        public int DataUpdateKTKL(KTKL ObjKTKL)
        {
            return PDUpdateKTKL(ObjKTKL.ktklid, ObjKTKL.soqd, ObjKTKL.ngayqd, ObjKTKL.manv, ObjKTKL.loaikt, ObjKTKL.hinhthuc, ObjKTKL.sotien, ObjKTKL.noidung, ObjKTKL.ngaycn);
        }

        public DataTable DataGetListKTKL()
        {
            return PDGetListKTKL();
        }

        public DataTable DataDetailsByFieldKTKL(string FieldName, string value)
        {
            return PDDetailsByFieldKTKL(FieldName, value);
        }

    }// End Class
}
