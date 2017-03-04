
using System.Data;
using ParentData;
using DataObject;

namespace Data
{
    public class DataCHAMCONG : ParentDataCHAMCONG
    {
        public int DataInsertCHAMCONG(CHAMCONG ObjCHAMCONG)
        {
            return PDInsertCHAMCONG(ObjCHAMCONG.chcongid, ObjCHAMCONG.manv, ObjCHAMCONG.thang, ObjCHAMCONG.nam, ObjCHAMCONG.luongcb, ObjCHAMCONG.bacluong, ObjCHAMCONG.ngaycong, ObjCHAMCONG.thuclinh, ObjCHAMCONG.conlai, ObjCHAMCONG.nghiphep, ObjCHAMCONG.ngungviec, ObjCHAMCONG.tangca, ObjCHAMCONG.phucapkhac, ObjCHAMCONG.luongtangca, ObjCHAMCONG.phucapcv, ObjCHAMCONG.ngaycn);
        }

        public int DataDeleteCHAMCONG(CHAMCONG ObjCHAMCONG)
        {
            return PDDeleteCHAMCONG(ObjCHAMCONG.chcongid);
        }


        public DataTable DataDetailsCHAMCONG(CHAMCONG ObjCHAMCONG)
        {
            return PDDetailsCHAMCONG(ObjCHAMCONG.chcongid);
        }

        public int DataUpdateCHAMCONG(CHAMCONG ObjCHAMCONG)
        {
            return PDUpdateCHAMCONG(ObjCHAMCONG.chcongid, ObjCHAMCONG.manv, ObjCHAMCONG.thang, ObjCHAMCONG.nam, ObjCHAMCONG.luongcb, ObjCHAMCONG.bacluong, ObjCHAMCONG.ngaycong, ObjCHAMCONG.thuclinh, ObjCHAMCONG.conlai, ObjCHAMCONG.nghiphep, ObjCHAMCONG.ngungviec, ObjCHAMCONG.tangca, ObjCHAMCONG.phucapkhac, ObjCHAMCONG.luongtangca, ObjCHAMCONG.phucapcv, ObjCHAMCONG.ngaycn);
        }

        public DataTable DataGetListCHAMCONG()
        {
            return PDGetListCHAMCONG();
        }

        public DataTable DataDetailsByFieldCHAMCONG(string FieldName, string value)
        {
            return PDDetailsByFieldCHAMCONG(FieldName, value);
        }

    }// End Class

}