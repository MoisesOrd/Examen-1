using GestionDal.DAL;
using GestionModelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDal
{
    public class EmpleadoDal
    {
        public class EmpleadoDAL
        {
            public DataTable ListarEmpleadoDal()
            {
                string consulta = "select * from empleado";
                DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
                return Lista;
            }
            public void InsertarEmpleadoDal(Empleado empleado)
            {
                string consulta = "INSERT INTO EMPLEADO VALUES (" + empleado.IdPersona + " , " +
                                                                " '" + empleado.Puesto + "' , " +
                                                                " '" + empleado.Salario + "' , " +
                                                                " '" + empleado.FechaContratacion + "')";
                conexion.Ejecutar(consulta);
            }
            public Empleado ObtenerEmpleadoIdDal(int id)
            {
                string consulta = "select * from empleado where idempleado=" + id;
                DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
                Empleado u = new Empleado();
                if (tabla.Rows.Count > 0)
                {
                    u.IdEmpleado = Convert.ToInt32(tabla.Rows[0]["idempleado"]);
                    u.Puesto = tabla.Rows[0]["puesto"].ToString();
                    u.Salario = Convert.ToInt32(tabla.Rows[0]["salario"]);
                    u.FechaContratacion = Convert.ToDateTime(tabla.Rows[0]["fechacontratacion"]);
                }
                return u;

            }
            public void EditarEmpleadoDal(Empleado usuario)
            {
                string consulta = "update empleado set idpersona=" + usuario.IdPersona + "," +
                                                                       "puesto='" + usuario.Puesto + "'," +
                                                                       "salario='" + usuario.Salario + "'," +
                                                                       "fechacontratacion='" + usuario.FechaContratacion + "' " +
                                                               "where idempleado=" + usuario.IdEmpleado;
                conexion.Ejecutar(consulta);
            }

            public void EliminarEmpleadoDal(int id)
            {
                string consulta = "delete from empleado where idempleado=" + id;
                conexion.Ejecutar(consulta);
            }

        }


    }
}
