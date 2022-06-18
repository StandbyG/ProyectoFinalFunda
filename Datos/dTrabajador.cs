using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
namespace Datos
{
    public class dTrabajador
    {
        DataBase db = new DataBase();
        public string InsertarEmpleado(eTrabajador empleado)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string insert = string.Format("insert into Trabajador(Nombres,Apellido_paterno,Apellido_materno,DNI,Fecha_nacimiento,Salario,Telefono,Direccion,Años_en_la_empresa,id_cargo,id_sector) values('{0}','{1}','{2}',{3},{4},{5},{6},'{7}',{8},{9},{10},{11})",empleado.nombres,empleado.apellidoPaterno,empleado.apellidoMaterno,empleado.Dni,empleado.fechaNacimiento,empleado.salario,empleado.telefono,empleado.direccion,empleado.ageEnLaEmpresa,empleado.idCargo,empleado.idSector,empleado.asistencias);
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
        public string modificarEmpleado(eTrabajador empleado)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string update = string.Format("update Trabajador set nombres='{0}',apellidoPaterno='{1}',apellidoMaterno='{2}',dni = {3},fecha_Nacimiento = {4}, salario={5}, tefelono= {6}, direccion = '{7}',añosempresa= {8}, where idEmpleado={9}",empleado.nombres, empleado.apellidoPaterno,empleado.apellidoMaterno,empleado.Dni,empleado.fechaNacimiento,empleado.salario,empleado.telefono,empleado.direccion,empleado.ageEnLaEmpresa, empleado.idEmpleado);
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                return "Modifico";
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
        public string eliminarEmpleado(int id)
        {
            try
            {
                SqlConnection con = db.ConectaDb();
                string delete = string.Format("delete from Trabajador where idEmpleado={0}", id);
                SqlCommand cmd = new SqlCommand(delete, con);
                cmd.ExecuteNonQuery();
                return "Elimino";
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
