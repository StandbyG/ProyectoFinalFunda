using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
namespace Datos
{
    public class dSector
    {
        DataBase db = new DataBase();
        public string InsertarSector(eSector sector)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string insert = string.Format("insert into Sector(Nombre_sector,Ubicacion_planta) values('{0}','{1}')", sector.nombreSector, sector.ubicacion_Planta);
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
