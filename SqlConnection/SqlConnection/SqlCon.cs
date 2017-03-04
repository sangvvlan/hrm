
using System;
using System.Data;
using System.Data.SqlClient;

namespace Connection
{
    public class SqlCon
    {

        public String StrCon;
        public SqlConnection Con;


        public SqlConnection OpenCon()
        {

            //StrCon =System.Configuration.ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

            StrCon = "Data Source=VTLAL-SANGVV;Initial Catalog=qlns;User Id = sa;Password = sa12345678";
            Con = new SqlConnection(StrCon);
            Con.Open();
            return Con;
        }

        public void CloseCon()
        {

            if (Con != null)
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }
    }
}
