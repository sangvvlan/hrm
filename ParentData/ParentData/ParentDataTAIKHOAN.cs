using System;
using System.Data;
using System.Data.SqlClient;
using Connection;


namespace ParentData
{
    public class ParentDataTAIKHOAN
    {

        protected int PDInsertTAIKHOAN(string Taikhoan, string matkhau, string quyen, DateTime ngaylap)
        {
            try
            {
                SqlCon Scon = new SqlCon();
                SqlCommand Sqlcom = new SqlCommand();
                Sqlcom.CommandType = CommandType.StoredProcedure;
                Sqlcom.CommandText = "spInsertTAIKHOAN";
                Sqlcom.Parameters.AddWithValue("@Taikhoan", Taikhoan);
                Sqlcom.Parameters.AddWithValue("@matkhau", matkhau);
                Sqlcom.Parameters.AddWithValue("@quyen", quyen);
                Sqlcom.Parameters.AddWithValue("@ngaylap", ngaylap);
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

        protected int PDDeleteTAIKHOAN(string Taikhoan)
        {
            try
            {
                SqlCon Scon = new SqlCon();
                SqlCommand Sqlcom = new SqlCommand();
                Sqlcom.CommandType = CommandType.StoredProcedure;
                Sqlcom.CommandText = "spDeleteTAIKHOAN";
                Sqlcom.Parameters.AddWithValue("@Taikhoan", Taikhoan);
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

        protected int PDUpdateTAIKHOAN(string Taikhoan, string matkhau, string quyen, DateTime ngaylap)
        {
            try
            {
                SqlCon Scon = new SqlCon();
                SqlCommand Sqlcom = new SqlCommand();
                Sqlcom.CommandType = CommandType.StoredProcedure;
                Sqlcom.CommandText = "spUpdateTAIKHOAN";
                Sqlcom.Parameters.AddWithValue("@Taikhoan", Taikhoan);
                Sqlcom.Parameters.AddWithValue("@matkhau", matkhau);
                Sqlcom.Parameters.AddWithValue("@quyen", quyen);
                Sqlcom.Parameters.AddWithValue("@ngaylap", ngaylap);
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

        protected DataTable PDGetListTAIKHOAN()
        {
            SqlCon Scon = new SqlCon();
            SqlDataAdapter Sqlda = new SqlDataAdapter("spGetListTAIKHOAN", Scon.OpenCon());
            DataTable DTable = new DataTable();
            Sqlda.Fill(DTable);
            Scon.CloseCon();
            return DTable;
        }

        protected DataTable PDDetailsTAIKHOAN(string Taikhoan)
        {
            SqlCon Scon = new SqlCon();
            SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsTAIKHOAN", Scon.OpenCon());
            Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable DTable = new DataTable();
            Sqlda.SelectCommand.Parameters.AddWithValue("@Taikhoan", Taikhoan);
            Sqlda.Fill(DTable);
            Scon.CloseCon();
            return DTable;
        }

        protected DataTable PDDetailsByFieldTAIKHOAN(string FieldName, string value)
        {
            SqlCon Scon = new SqlCon();
            SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsByFieldTAIKHOAN", Scon.OpenCon());
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
