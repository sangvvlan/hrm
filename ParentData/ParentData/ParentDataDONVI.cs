using System;
using System.Data;
using System.Data.SqlClient;
using Connection;

namespace ParentData
{
    public class ParentDataDONVI
    {
        protected int PDInsertDONVI(decimal donviid, string tendonvi)
        {
            try
            {
                SqlCon Scon = new SqlCon();
                SqlCommand Sqlcom = new SqlCommand();
                Sqlcom.CommandType = CommandType.StoredProcedure;
                Sqlcom.CommandText = "spInsertDONVI";
                Sqlcom.Parameters.AddWithValue("@donviid", donviid);
                Sqlcom.Parameters.AddWithValue("@tendonvi", tendonvi);
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

        protected int PDDeleteDONVI(decimal donviid)
        {
            try
            {
                SqlCon Scon = new SqlCon();
                SqlCommand Sqlcom = new SqlCommand();
                Sqlcom.CommandType = CommandType.StoredProcedure;
                Sqlcom.CommandText = "spDeleteDONVI";
                Sqlcom.Parameters.AddWithValue("@donviid", donviid);
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

        protected int PDUpdateDONVI(decimal donviid, string tendonvi)
        {
            try
            {
                SqlCon Scon = new SqlCon();
                SqlCommand Sqlcom = new SqlCommand();
                Sqlcom.CommandType = CommandType.StoredProcedure;
                Sqlcom.CommandText = "spUpdateDONVI";
                Sqlcom.Parameters.AddWithValue("@donviid", donviid);
                Sqlcom.Parameters.AddWithValue("@tendonvi", tendonvi);
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

        protected DataTable PDGetListDONVI()
        {
            SqlCon Scon = new SqlCon();
            SqlDataAdapter Sqlda = new SqlDataAdapter("spGetListDONVI", Scon.OpenCon());
            DataTable DTable = new DataTable();
            Sqlda.Fill(DTable);
            Scon.CloseCon();
            return DTable;
        }

        protected DataTable PDDetailsDONVI(decimal donviid)
        {
            SqlCon Scon = new SqlCon();
            SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsDONVI", Scon.OpenCon());
            Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable DTable = new DataTable();
            Sqlda.SelectCommand.Parameters.AddWithValue("@donviid", donviid);
            Sqlda.Fill(DTable);
            Scon.CloseCon();
            return DTable;
        }

        protected DataTable PDDetailsByFieldDONVI(string FieldName, string value)
        {
            SqlCon Scon = new SqlCon();
            SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsByFieldDONVI", Scon.OpenCon());
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
