using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace ProductionStockCardSystem
{
    class SqlConnectionClass
    {
        public SqlConnection sqlConn()
        {
            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["PasmyDB"].ConnectionString);

            return cnn;
        }


    }
}
