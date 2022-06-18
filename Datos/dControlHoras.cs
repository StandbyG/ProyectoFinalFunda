using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
namespace Datos
{
    public class dControlHoras
    {
        DataBase db = new DataBase();
        public string InsertarControlHoras(eControlHoras controlHoras)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string insert = string.Format("insert into Sector(id_trabajador,Hora_ingreso,Hora_salida,Fecha_registro) values({0},{1},{3},{4})", controlHoras.trabajador, controlHoras.horaIngreso,controlHoras.horaSalida,controlHoras.fechaRegistro);
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
