using Microsoft.IdentityModel.Protocols;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie
{
    public static class DBTest
    {
        public static string GetDefaultLanguage()
        {
            string cs = "Data Source=DESKTOP-QJLP9GV\\LAURENSSQL;Initial Catalog=RudyCommCProef;Persist Security Info=True;User ID=C-proef;Password=cproef";

            using (SqlConnection con = new SqlConnection(cs))
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select language_name from language where is_default=1";
                cmd.Connection = con;
                con.Open();
                var dr = cmd.ExecuteReader();
                dr.Read();
                var d = dr[0].ToString();
                return d;
            }
        }
    }
}
