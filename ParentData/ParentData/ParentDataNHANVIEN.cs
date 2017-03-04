using System;
using System.Data;
using System.Data.SqlClient;
using Connection;

namespace ParentData
{
    public class ParentDataNHANVIEN
    {

        protected int PDInsertNHANVIEN(string manv, string honv, string tennv, decimal gioitinh, string noisinh, DateTime ngaysinh, string noiohientai, string socmnd, string hinh, string sodt, string email, decimal dantoc, decimal tongiao, decimal giadinh, string sohd, decimal loaihd, DateTime ngayhd, DateTime ngayct, DateTime ngaybd, decimal donviid, decimal phongid, decimal tdid, decimal cmid, decimal cvid, float bacluong, string bhxh, DateTime ngaykt, decimal trangthai)
        {
            try
            {
                SqlCon Scon = new SqlCon();
                SqlCommand Sqlcom = new SqlCommand();
                Sqlcom.CommandType = CommandType.StoredProcedure;
                Sqlcom.CommandText = "spInsertNHANVIEN";
                Sqlcom.Parameters.AddWithValue("@manv", manv);
                Sqlcom.Parameters.AddWithValue("@honv", honv);
                Sqlcom.Parameters.AddWithValue("@tennv", tennv);
                Sqlcom.Parameters.AddWithValue("@gioitinh", gioitinh);
                Sqlcom.Parameters.AddWithValue("@noisinh", noisinh);
                Sqlcom.Parameters.AddWithValue("@ngaysinh", ngaysinh);
                Sqlcom.Parameters.AddWithValue("@noiohientai", noiohientai);
                Sqlcom.Parameters.AddWithValue("@socmnd", socmnd);
                Sqlcom.Parameters.AddWithValue("@hinh", hinh);
                Sqlcom.Parameters.AddWithValue("@sodt", sodt);
                Sqlcom.Parameters.AddWithValue("@email", email);
                Sqlcom.Parameters.AddWithValue("@dantoc", dantoc);
                Sqlcom.Parameters.AddWithValue("@tongiao", tongiao);
                Sqlcom.Parameters.AddWithValue("@giadinh", giadinh);
                Sqlcom.Parameters.AddWithValue("@sohd", sohd);
                Sqlcom.Parameters.AddWithValue("@loaihd", loaihd);
                Sqlcom.Parameters.AddWithValue("@ngayhd", ngayhd);
                Sqlcom.Parameters.AddWithValue("@ngayct", ngayct);
                Sqlcom.Parameters.AddWithValue("@ngaybd", ngaybd);
                Sqlcom.Parameters.AddWithValue("@donviid", donviid);
                Sqlcom.Parameters.AddWithValue("@phongid", phongid);
                Sqlcom.Parameters.AddWithValue("@tdid", tdid);
                Sqlcom.Parameters.AddWithValue("@cmid", cmid);
                Sqlcom.Parameters.AddWithValue("@cvid", cvid);
                Sqlcom.Parameters.AddWithValue("@bacluong", bacluong);
                Sqlcom.Parameters.AddWithValue("@bhxh", bhxh);
                Sqlcom.Parameters.AddWithValue("@ngaykt", ngaykt);
                Sqlcom.Parameters.AddWithValue("@trangthai", trangthai);
                Sqlcom.Connection = Scon.OpenCon();
                int R = 0;
                R = Sqlcom.ExecuteNonQuery();
                Scon.CloseCon();
                return R;
            }
            catch
            {
                return 0;
            }
        }

        protected int PDDeleteNHANVIEN(string manv)
        {
            try
            {
                SqlCon Scon = new SqlCon();
                SqlCommand Sqlcom = new SqlCommand();
                Sqlcom.CommandType = CommandType.StoredProcedure;
                Sqlcom.CommandText = "spDeleteNHANVIEN";
                Sqlcom.Parameters.AddWithValue("@manv", manv);
                Sqlcom.Connection = Scon.OpenCon();
                int R = Sqlcom.ExecuteNonQuery();
                Scon.CloseCon();
                return R;
            }
            catch
            {
                return 0;
            }
        }

        protected int PDUpdateNHANVIEN(string manv, string honv, string tennv, decimal gioitinh, string noisinh, DateTime ngaysinh, string noiohientai, string socmnd, string hinh, string sodt, string email, decimal dantoc, decimal tongiao, decimal giadinh, string sohd, decimal loaihd, DateTime ngayhd, DateTime ngayct, DateTime ngaybd, decimal donviid, decimal phongid, decimal tdid, decimal cmid, decimal cvid, float bacluong, string bhxh, DateTime ngaykt, decimal trangthai)
        {
            try
            {
                SqlCon Scon = new SqlCon();
                SqlCommand Sqlcom = new SqlCommand();
                Sqlcom.CommandType = CommandType.StoredProcedure;
                Sqlcom.CommandText = "spUpdateNHANVIEN";
                Sqlcom.Parameters.AddWithValue("@manv", manv);
                Sqlcom.Parameters.AddWithValue("@honv", honv);
                Sqlcom.Parameters.AddWithValue("@tennv", tennv);
                Sqlcom.Parameters.AddWithValue("@gioitinh", gioitinh);
                Sqlcom.Parameters.AddWithValue("@noisinh", noisinh);
                Sqlcom.Parameters.AddWithValue("@ngaysinh", ngaysinh);
                Sqlcom.Parameters.AddWithValue("@noiohientai", noiohientai);
                Sqlcom.Parameters.AddWithValue("@socmnd", socmnd);
                Sqlcom.Parameters.AddWithValue("@hinh", hinh);
                Sqlcom.Parameters.AddWithValue("@sodt", sodt);
                Sqlcom.Parameters.AddWithValue("@email", email);
                Sqlcom.Parameters.AddWithValue("@dantoc", dantoc);
                Sqlcom.Parameters.AddWithValue("@tongiao", tongiao);
                Sqlcom.Parameters.AddWithValue("@giadinh", giadinh);
                Sqlcom.Parameters.AddWithValue("@sohd", sohd);
                Sqlcom.Parameters.AddWithValue("@loaihd", loaihd);
                Sqlcom.Parameters.AddWithValue("@ngayhd", ngayhd);
                Sqlcom.Parameters.AddWithValue("@ngayct", ngayct);
                Sqlcom.Parameters.AddWithValue("@ngaybd", ngaybd);
                Sqlcom.Parameters.AddWithValue("@donviid", donviid);
                Sqlcom.Parameters.AddWithValue("@phongid", phongid);
                Sqlcom.Parameters.AddWithValue("@tdid", tdid);
                Sqlcom.Parameters.AddWithValue("@cmid", cmid);
                Sqlcom.Parameters.AddWithValue("@cvid", cvid);
                Sqlcom.Parameters.AddWithValue("@bacluong", bacluong);
                Sqlcom.Parameters.AddWithValue("@bhxh", bhxh);
                Sqlcom.Parameters.AddWithValue("@ngaykt", ngaykt);
                Sqlcom.Parameters.AddWithValue("@trangthai", trangthai);
                Sqlcom.Connection = Scon.OpenCon();
                int R = Sqlcom.ExecuteNonQuery();
                Scon.CloseCon();
                return R;
            }
            catch
            {
                return 0;
            }
        }

        protected int PDUpdate_hinh_NHANVIEN(string manv, string hinh)
        {
            try
            {
                SqlCon Scon = new SqlCon();
                SqlCommand Sqlcom = new SqlCommand();
                Sqlcom.CommandType = CommandType.StoredProcedure;
                Sqlcom.CommandText = "spUpdate_hinh_NHANVIEN";
                Sqlcom.Parameters.AddWithValue("@manv", manv);
                Sqlcom.Parameters.AddWithValue("@hinh", hinh);
                Sqlcom.Connection = Scon.OpenCon();
                int R = Sqlcom.ExecuteNonQuery();
                Scon.CloseCon();
                return R;
            }
            catch
            {
                return 0;
            }
        }
  
        protected DataTable PDGetListNHANVIEN()
        {
            SqlCon Scon = new SqlCon();
            SqlDataAdapter Sqlda = new SqlDataAdapter("spGetListNHANVIEN", Scon.OpenCon());
            DataTable DTable = new DataTable();
            Sqlda.Fill(DTable);
            Scon.CloseCon();
            return DTable;
        }

        protected DataTable PDDetailsNHANVIEN(string manv)
        {
            SqlCon Scon = new SqlCon();
            SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsNHANVIEN", Scon.OpenCon());
            Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable DTable = new DataTable();
            Sqlda.SelectCommand.Parameters.AddWithValue("@manv", manv);
            Sqlda.Fill(DTable);
            Scon.CloseCon();
            return DTable;
        }

        protected DataTable PDDetailsByFieldNHANVIEN(string FieldName, string value)
        {
            SqlCon Scon = new SqlCon();
            SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsByFieldNHANVIEN", Scon.OpenCon());
            Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            Sqlda.SelectCommand.Parameters.AddWithValue("@FieldName", FieldName);
            Sqlda.SelectCommand.Parameters.AddWithValue("@Value", value);
            DataTable DTable = new DataTable();
            Sqlda.Fill(DTable);
            Scon.CloseCon();
            return DTable;
        }


    }
}
