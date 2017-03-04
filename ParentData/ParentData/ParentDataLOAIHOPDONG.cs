using System.Data;
using System.Data.SqlClient;
using Connection;

namespace ParentData
{
    public class ParentDataLOAIHOPDONG
    {

        protected int PDInsertLOAIHOPDONG(decimal loaihdid, string mahd, string tenhd)
        {
            try
            {
                SqlCon Scon = new SqlCon();
                SqlCommand Sqlcom = new SqlCommand();
                Sqlcom.CommandType = CommandType.StoredProcedure;
                Sqlcom.CommandText = "spInsertLOAIHOPDONG";
                Sqlcom.Parameters.AddWithValue("@loaihdid", loaihdid);
                Sqlcom.Parameters.AddWithValue("@mahd", mahd);
                Sqlcom.Parameters.AddWithValue("@tenhd", tenhd);
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

        protected int PDDeleteLOAIHOPDONG(decimal loaihdid)
        {
            try
            {
                SqlCon Scon = new SqlCon();
                SqlCommand Sqlcom = new SqlCommand();
                Sqlcom.CommandType = CommandType.StoredProcedure;
                Sqlcom.CommandText = "spDeleteLOAIHOPDONG";
                Sqlcom.Parameters.AddWithValue("@loaihdid", loaihdid);
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

        protected int PDUpdateLOAIHOPDONG(decimal loaihdid, string mahd, string tenhd)
        {
            try
            {
                SqlCon Scon = new SqlCon();
                SqlCommand Sqlcom = new SqlCommand();
                Sqlcom.CommandType = CommandType.StoredProcedure;
                Sqlcom.CommandText = "spUpdateLOAIHOPDONG";
                Sqlcom.Parameters.AddWithValue("@loaihdid", loaihdid);
                Sqlcom.Parameters.AddWithValue("@mahd", mahd);
                Sqlcom.Parameters.AddWithValue("@tenhd", tenhd);
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

        protected DataTable PDGetListLOAIHOPDONG()
        {
            SqlCon Scon = new SqlCon();
            SqlDataAdapter Sqlda = new SqlDataAdapter("spGetListLOAIHOPDONG", Scon.OpenCon());
            DataTable DTable = new DataTable();
            Sqlda.Fill(DTable);
            Scon.CloseCon();
            return DTable;
        }

        protected DataTable PDDetailsLOAIHOPDONG(decimal loaihdid)
        {
            SqlCon Scon = new SqlCon();
            SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsLOAIHOPDONG", Scon.OpenCon());
            Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable DTable = new DataTable();
            Sqlda.SelectCommand.Parameters.AddWithValue("@loaihdid", loaihdid);
            Sqlda.Fill(DTable);
            Scon.CloseCon();
            return DTable;
        }

        protected DataTable PDDetailsByFieldLOAIHOPDONG(string FieldName, string value)
        {
            SqlCon Scon = new SqlCon();
            SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsByFieldLOAIHOPDONG", Scon.OpenCon());
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