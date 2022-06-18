using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class DataBase
    {
        private SqlConnection conn;
        public SqlConnection ConectaDb()
        {
            try
            {
                string cadenaconexion = "Data Source=LAPTOP-254UCORC\\SQLEXPRESS1;Initial Catalog=dbTrabajoF;Integrated Security=True";
                conn = new SqlConnection(cadenaconexion);
                conn.Open();
                return conn;
            }
            catch (SqlException e)
            {
                if (conn != null)
                {
                    DesconectaDb();
                }
                return null;
            }
        }
        public void DesconectaDb()
        {
            conn.Close();
        }
    }
}
