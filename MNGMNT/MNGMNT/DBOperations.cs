using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNGMNT
{
    public class DBOperations
    {
        SqlConnection connection = new SqlConnection("server= localhost; database=C_sharp_SCMS; integrated security=true; trusted_connection=true;");

        public int Update_DB(string sql)
        {
            int n = 0;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                n = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return n;
        }

        public SqlDataReader executeQuery(string sql)
        {
            SqlDataReader reader;
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return reader;
        }

        public SqlDataAdapter findQuery(string sql)
        {
            SqlDataAdapter d;
            try
            {
                d = new SqlDataAdapter(sql, connection);
                connection.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return d;
        }
    }
}
