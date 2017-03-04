
using System.Data;
using DataObject;
using ParentData;

namespace Data
{
    public class DataNHANVIEN : ParentDataNHANVIEN
    {
        public int DataInsertNHANVIEN(NHANVIEN ObjNHANVIEN)
        {
            return PDInsertNHANVIEN(ObjNHANVIEN.manv, ObjNHANVIEN.honv, ObjNHANVIEN.tennv, ObjNHANVIEN.gioitinh, ObjNHANVIEN.noisinh, ObjNHANVIEN.ngaysinh, ObjNHANVIEN.noiohientai, ObjNHANVIEN.socmnd, ObjNHANVIEN.hinh, ObjNHANVIEN.sodt, ObjNHANVIEN.email, ObjNHANVIEN.dantoc, ObjNHANVIEN.tongiao, ObjNHANVIEN.giadinh, ObjNHANVIEN.sohd, ObjNHANVIEN.loaihd, ObjNHANVIEN.ngayhd, ObjNHANVIEN.ngayct, ObjNHANVIEN.ngaybd, ObjNHANVIEN.donviid, ObjNHANVIEN.phongid, ObjNHANVIEN.tdid, ObjNHANVIEN.cmid, ObjNHANVIEN.cvid, ObjNHANVIEN.bacluong, ObjNHANVIEN.bhxh, ObjNHANVIEN.ngaykt, ObjNHANVIEN.trangthai);
        }

        public int DataDeleteNHANVIEN(NHANVIEN ObjNHANVIEN)
        {
            return PDDeleteNHANVIEN(ObjNHANVIEN.manv);
        }


        public DataTable DataDetailsNHANVIEN(NHANVIEN ObjNHANVIEN)
        {
            return PDDetailsNHANVIEN(ObjNHANVIEN.manv);
        }

        public int DataUpdateNHANVIEN(NHANVIEN ObjNHANVIEN)
        {
            return PDUpdateNHANVIEN(ObjNHANVIEN.manv, ObjNHANVIEN.honv, ObjNHANVIEN.tennv, ObjNHANVIEN.gioitinh, ObjNHANVIEN.noisinh, ObjNHANVIEN.ngaysinh, ObjNHANVIEN.noiohientai, ObjNHANVIEN.socmnd, ObjNHANVIEN.hinh, ObjNHANVIEN.sodt, ObjNHANVIEN.email, ObjNHANVIEN.dantoc, ObjNHANVIEN.tongiao, ObjNHANVIEN.giadinh, ObjNHANVIEN.sohd, ObjNHANVIEN.loaihd, ObjNHANVIEN.ngayhd, ObjNHANVIEN.ngayct, ObjNHANVIEN.ngaybd, ObjNHANVIEN.donviid, ObjNHANVIEN.phongid, ObjNHANVIEN.tdid, ObjNHANVIEN.cmid, ObjNHANVIEN.cvid, ObjNHANVIEN.bacluong, ObjNHANVIEN.bhxh, ObjNHANVIEN.ngaykt, ObjNHANVIEN.trangthai);
        }

        public int DataUpdateHinhNHANVIEN(Hinh_NHANVIEN ObjNHANVIEN)
        {
            return PDUpdate_hinh_NHANVIEN(ObjNHANVIEN.manv, ObjNHANVIEN.hinh);
        }

        public DataTable DataGetListNHANVIEN()
        {
            return PDGetListNHANVIEN();
        }

        public DataTable DataDetailsByFieldNHANVIEN(string FieldName, string value)
        {
            return PDDetailsByFieldNHANVIEN(FieldName, value);
        }

    }// End Class

}