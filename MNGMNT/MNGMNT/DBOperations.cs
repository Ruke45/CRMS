using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace MNGMNT
{
    public class DBOperations
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MNGMNT.Properties.Settings.CRMSConnectionString"].ToString());

        public int Add_Update(string sql)
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
