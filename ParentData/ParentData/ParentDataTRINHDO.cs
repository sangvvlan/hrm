using System.Data;
using System.Data.SqlClient;
using Connection;


namespace ParentData
{
    public class ParentDataTRINHDO
    {

        protected int PDInsertTRINHDO(decimal tdid, string matd, string tentd)
        {
            try
            {
                SqlCon Scon = new SqlCon();
                SqlCommand Sqlcom = new SqlCommand();
                Sqlcom.CommandType = CommandType.StoredProcedure;
                Sqlcom.CommandText = "spInsertTRINHDO";
                Sqlcom.Parameters.AddWithValue("@tdid", tdid);
                Sqlcom.Parameters.AddWithValue("@matd", matd);
                Sqlcom.Parameters.AddWithValue("@tentd", tentd);
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

        protected int PDDeleteTRINHDO(decimal tdid)
        {
            try
            {
                SqlCon Scon = new SqlCon();
                SqlCommand Sqlcom = new SqlCommand();
                Sqlcom.CommandType = CommandType.StoredProcedure;
                Sqlcom.CommandText = "spDeleteTRINHDO";
                Sqlcom.Parameters.AddWithValue("@tdid", tdid);
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

        protected int PDUpdateTRINHDO(decimal tdid, string matd, string tentd)
        {
            try
            {
                SqlCon Scon = new SqlCon();
                SqlCommand Sqlcom = new SqlCommand();
                Sqlcom.CommandType = CommandType.StoredProcedure;
                Sqlcom.CommandText = "spUpdateTRINHDO";
                Sqlcom.Parameters.AddWithValue("@tdid", tdid);
                Sqlcom.Parameters.AddWithValue("@matd", matd);
                Sqlcom.Parameters.AddWithValue("@tentd", tentd);
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

        protected DataTable PDGetListTRINHDO()
        {
            SqlCon Scon = new SqlCon();
            SqlDataAdapter Sqlda = new SqlDataAdapter("spGetListTRINHDO", Scon.OpenCon());
            DataTable DTable = new DataTable();
            Sqlda.Fill(DTable);
            Scon.CloseCon();
            return DTable;
        }

        protected DataTable PDDetailsTRINHDO(decimal tdid)
        {
            SqlCon Scon = new SqlCon();
            SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsTRINHDO", Scon.OpenCon());
            Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable DTable = new DataTable();
            Sqlda.SelectCommand.Parameters.AddWithValue("@tdid", tdid);
            Sqlda.Fill(DTable);
            Scon.CloseCon();
            return DTable;
        }

        protected DataTable PDDetailsByFieldTRINHDO(string FieldName, string value)
        {
            SqlCon Scon = new SqlCon();
            SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsByFieldTRINHDO", Scon.OpenCon());
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
