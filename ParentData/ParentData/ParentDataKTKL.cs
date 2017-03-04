using System;
using System.Data;
using System.Data.SqlClient;
using Connection;

namespace ParentData
{
    public class ParentDataKTKL
    {

        protected int PDInsertKTKL(decimal ktklid, string soqd, DateTime ngayqd, decimal manv, decimal loaikt, decimal hinhthuc, float sotien, string noidung, DateTime ngaycn)
        {
            try
            {
                SqlCon Scon = new SqlCon();
                SqlCommand Sqlcom = new SqlCommand();
                Sqlcom.CommandType = CommandType.StoredProcedure;
                Sqlcom.CommandText = "spInsertKTKL";
                Sqlcom.Parameters.AddWithValue("@ktklid", ktklid);
                Sqlcom.Parameters.AddWithValue("@soqd", soqd);
                Sqlcom.Parameters.AddWithValue("@ngayqd", ngayqd);
                Sqlcom.Parameters.AddWithValue("@manv", manv);
                Sqlcom.Parameters.AddWithValue("@loaikt", loaikt);
                Sqlcom.Parameters.AddWithValue("@hinhthuc", hinhthuc);
                Sqlcom.Parameters.AddWithValue("@sotien", sotien);
                Sqlcom.Parameters.AddWithValue("@noidung", noidung);
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

        protected int PDDeleteKTKL(decimal ktklid)
        {
            try
            {
                SqlCon Scon = new SqlCon();
                SqlCommand Sqlcom = new SqlCommand();
                Sqlcom.CommandType = CommandType.StoredProcedure;
                Sqlcom.CommandText = "spDeleteKTKL";
                Sqlcom.Parameters.AddWithValue("@ktklid", ktklid);
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

        protected int PDUpdateKTKL(decimal ktklid, string soqd, DateTime ngayqd, decimal manv, decimal loaikt, decimal hinhthuc, float sotien, string noidung, DateTime ngaycn)
        {
            try
            {
                SqlCon Scon = new SqlCon();
                SqlCommand Sqlcom = new SqlCommand();
                Sqlcom.CommandType = CommandType.StoredProcedure;
                Sqlcom.CommandText = "spUpdateKTKL";
                Sqlcom.Parameters.AddWithValue("@ktklid", ktklid);
                Sqlcom.Parameters.AddWithValue("@soqd", soqd);
                Sqlcom.Parameters.AddWithValue("@ngayqd", ngayqd);
                Sqlcom.Parameters.AddWithValue("@manv", manv);
                Sqlcom.Parameters.AddWithValue("@loaikt", loaikt);
                Sqlcom.Parameters.AddWithValue("@hinhthuc", hinhthuc);
                Sqlcom.Parameters.AddWithValue("@sotien", sotien);
                Sqlcom.Parameters.AddWithValue("@noidung", noidung);
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

        protected DataTable PDGetListKTKL()
        {
            SqlCon Scon = new SqlCon();
            SqlDataAdapter Sqlda = new SqlDataAdapter("spGetListKTKL", Scon.OpenCon());
            DataTable DTable = new DataTable();
            Sqlda.Fill(DTable);
            Scon.CloseCon();
            return DTable;
        }

        protected DataTable PDDetailsKTKL(decimal ktklid)
        {
            SqlCon Scon = new SqlCon();
            SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsKTKL", Scon.OpenCon());
            Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable DTable = new DataTable();
            Sqlda.SelectCommand.Parameters.AddWithValue("@ktklid", ktklid);
            Sqlda.Fill(DTable);
            Scon.CloseCon();
            return DTable;
        }

        protected DataTable PDDetailsByFieldKTKL(string FieldName, string value)
        {
            SqlCon Scon = new SqlCon();
            SqlDataAdapter Sqlda = new SqlDataAdapter("spDetailsByFieldKTKL", Scon.OpenCon());
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
