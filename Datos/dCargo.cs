using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
namespace Datos
{
    public class dCargo
    {
        DataBase db = new DataBase();
        public string InsertarSector(eCargo cargo)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string insert = string.Format("insert into Cargo(nombre_cargo) values('{0}')",cargo.nombreCargo);
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                return "Inserto";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                db.DesconectaDb();
            }
        }
    }
}
