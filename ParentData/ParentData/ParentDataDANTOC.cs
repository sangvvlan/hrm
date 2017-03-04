using System.Data;
using System.Data.SqlClient;
using Connection;

namespace ParentData
{
    public class ParentDataDANTOC
    {

        protected int PDInsertDANTOC(decimal dantocid, string madt, string tendt)
        {
            try
            {
                SqlCon Scon = new SqlCon();
                SqlCommand Sqlcom = new SqlCommand();
                Sqlcom.CommandType = CommandType.StoredProcedure;
                Sqlcom.CommandText = "spInsertDANTOC";
                Sqlcom.Parameters.AddWithValue("@dantocid", dantocid);
                Sqlcom.Parameters.AddWithValue("@madt", madt);
                Sqlcom.Parameters.AddWithValue("@tendt", tendt);
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

        protected int PDDeleteDANTOC(decimal dantocid)
        {
            try
            {
                SqlCon Scon = new SqlCon();
                SqlCommand Sqlcom = new SqlCommand();
                Sqlcom.CommandType = CommandType.StoredProcedure;
                Sqlcom.CommandText = "spDeleteDANTOC";
                Sqlcom.Parameters.AddWithValue("@dantocid", dantocid);
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

        protected int PDUpdateDANTOC(decimal dantocid, string madt, string tendt)
        {
            try
            {
                SqlCon Scon = new SqlCon();
                SqlCommand Sqlcom = new SqlCommand();
                Sqlcom.CommandType = CommandType.StoredProcedure;
                Sqlcom.CommandText = "spUpdateDANTOC";
                Sqlcom.Parameters.AddWithValue("@dantocid", dantocid);
                Sqlcom.Parameters.AddWithValue("@madt", madt);
                Sqlcom.Parameters.AddWithValue("@tendt", tendt);
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

        protected DataTable PDGetListDANTOC()
        {
            SqlCon Scon = new SqlCon();
            SqlDataAdapter Sqlda = new SqlDataAdapter("spGetListDANTOC", Scon.OpenCon());
            DataTable DTable = new DataTable();
            Sqlda.Fill(DTable);
            Scon.CloseCon();
            return DTable;
        }

        protected DataTable PDDetailsDANTOC(decimal dantocid)
        {
            SqlCon Scon = new SqlCon();
            SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsDANTOC", Scon.OpenCon());
            Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable DTable = new DataTable();
            Sqlda.SelectCommand.Parameters.AddWithValue("@dantocid", dantocid);
            Sqlda.Fill(DTable);
            Scon.CloseCon();
            return DTable;
        }

        protected DataTable PDDetailsByFieldDANTOC(string FieldName, string value)
        {
            SqlCon Scon = new SqlCon();
            SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsByFieldDANTOC", Scon.OpenCon());
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
