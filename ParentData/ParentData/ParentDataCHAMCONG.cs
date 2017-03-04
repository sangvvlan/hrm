using System;
using System.Data;
using System.Data.SqlClient;
using Connection;

namespace ParentData
{
    public class ParentDataCHAMCONG
    {

        protected int PDInsertCHAMCONG(decimal chcongid, string manv, int thang, int nam, float luongcb, float bacluong, byte ngaycong, float thuclinh, float conlai, byte nghiphep, byte ngungviec, float tangca, float phucapkhac, float luongtangca, float phucapcv, DateTime ngaycn)
        {
            try
            {
                SqlCon Scon = new SqlCon();
                SqlCommand Sqlcom = new SqlCommand();
                Sqlcom.CommandType = CommandType.StoredProcedure;
                Sqlcom.CommandText = "spInsertCHAMCONG";
                Sqlcom.Parameters.AddWithValue("@chcongid", chcongid);
                Sqlcom.Parameters.AddWithValue("@manv", manv);
                Sqlcom.Parameters.AddWithValue("@thang", thang);
                Sqlcom.Parameters.AddWithValue("@nam", nam);
                Sqlcom.Parameters.AddWithValue("@luongcb", luongcb);
                Sqlcom.Parameters.AddWithValue("@bacluong", bacluong);
                Sqlcom.Parameters.AddWithValue("@ngaycong", ngaycong);
                Sqlcom.Parameters.AddWithValue("@thuclinh", thuclinh);
                Sqlcom.Parameters.AddWithValue("@conlai", conlai);
                Sqlcom.Parameters.AddWithValue("@nghiphep", nghiphep);
                Sqlcom.Parameters.AddWithValue("@ngungviec", ngungviec);
                Sqlcom.Parameters.AddWithValue("@tangca", tangca);
                Sqlcom.Parameters.AddWithValue("@phucapkhac", phucapkhac);
                Sqlcom.Parameters.AddWithValue("@luongtangca", luongtangca);
                Sqlcom.Parameters.AddWithValue("@phucapcv", phucapcv);
                Sqlcom.Parameters.AddWithValue("@ngaycn", ngaycn);
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

        protected int PDDeleteCHAMCONG(decimal chcongid)
        {
            try
            {
                SqlCon Scon = new SqlCon();
                SqlCommand Sqlcom = new SqlCommand();
                Sqlcom.CommandType = CommandType.StoredProcedure;
                Sqlcom.CommandText = "spDeleteCHAMCONG";
                Sqlcom.Parameters.AddWithValue("@chcongid", chcongid);
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

        protected int PDUpdateCHAMCONG(decimal chcongid, string manv, int thang, int nam, float luongcb, float bacluong, byte ngaycong, float thuclinh, float conlai, byte nghiphep, byte ngungviec, float tangca, float phucapkhac, float luongtangca, float phucapcv, DateTime ngaycn)
        {
            try
            {
                SqlCon Scon = new SqlCon();
                SqlCommand Sqlcom = new SqlCommand();
                Sqlcom.CommandType = CommandType.StoredProcedure;
                Sqlcom.CommandText = "spUpdateCHAMCONG";
                Sqlcom.Parameters.AddWithValue("@chcongid", chcongid);
                Sqlcom.Parameters.AddWithValue("@manv", manv);
                Sqlcom.Parameters.AddWithValue("@thang", thang);
                Sqlcom.Parameters.AddWithValue("@nam", nam);
                Sqlcom.Parameters.AddWithValue("@luongcb", luongcb);
                Sqlcom.Parameters.AddWithValue("@bacluong", bacluong);
                Sqlcom.Parameters.AddWithValue("@ngaycong", ngaycong);
                Sqlcom.Parameters.AddWithValue("@thuclinh", thuclinh);
                Sqlcom.Parameters.AddWithValue("@conlai", conlai);
                Sqlcom.Parameters.AddWithValue("@nghiphep", nghiphep);
                Sqlcom.Parameters.AddWithValue("@ngungviec", ngungviec);
                Sqlcom.Parameters.AddWithValue("@tangca", tangca);
                Sqlcom.Parameters.AddWithValue("@phucapkhac", phucapkhac);
                Sqlcom.Parameters.AddWithValue("@luongtangca", luongtangca);
                Sqlcom.Parameters.AddWithValue("@phucapcv", phucapcv);
                Sqlcom.Parameters.AddWithValue("@ngaycn", ngaycn);
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

        protected DataTable PDGetListCHAMCONG()
        {
            SqlCon Scon = new SqlCon();
            SqlDataAdapter Sqlda = new SqlDataAdapter("spGetListCHAMCONG", Scon.OpenCon());
            DataTable DTable = new DataTable();
            Sqlda.Fill(DTable);
            Scon.CloseCon();
            return DTable;
        }

        protected DataTable PDDetailsCHAMCONG(decimal chcongid)
        {
            SqlCon Scon = new SqlCon();
            SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsCHAMCONG", Scon.OpenCon());
            Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable DTable = new DataTable();
            Sqlda.SelectCommand.Parameters.AddWithValue("@chcongid", chcongid);
            Sqlda.Fill(DTable);
            Scon.CloseCon();
            return DTable;
        }

        protected DataTable PDDetailsByFieldCHAMCONG(string FieldName, string value)
        {
            SqlCon Scon = new SqlCon();
            SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsByFieldCHAMCONG", Scon.OpenCon());
            Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            Sqlda.SelectCommand.Parameters.AddWithValue("@FieldName", FieldName);
            Sqlda.SelectCommand.Parameters.AddWithValue("@Value", value);
            DataTable DTable = new DataTable();
            Sqlda.Fill(DTable);
            Scon.CloseCon();
            return DTable;
        }
    }// End Class
}
