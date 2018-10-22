using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiOnline.DbClases
{
    class DbConexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("SslMode=none; server=127.0.0.1; database=taxionline; Uid=root; pwd=;");

            conectar.Open();
            return conectar;
        }
    }
}
