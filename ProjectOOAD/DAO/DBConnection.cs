using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class DBConnection
    {
        protected SqlConnection conn = new SqlConnection();
        public DBConnection()
        {
            try
            {
                //conn.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\SQL_OOAD.mdf;Integrated Security=True";
                conn.ConnectionString = @"Data Source=DINHTHIEN;Initial Catalog=SQL_OOAD;Integrated Security=True";
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
