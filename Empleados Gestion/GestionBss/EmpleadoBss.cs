using GestionDal;
using GestionModelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestionDal.EmpleadoDal;

namespace GestionBss
{
    public class EmpleadoBss
    {
        public class EmpleadoBSS
        {
            EmpleadoDAL dal = new EmpleadoDAL();
            public DataTable ListarEmpleadoBss()
            {
                return dal.ListarEmpleadoDal();
            }

            public void InsertarEmpleadoBss(Empleado empleado)
            {
                dal.InsertarEmpleadoDal(empleado);
            }

            public Empleado ObtenerEmpleadoIdBss(int id)
            {
                return dal.ObtenerEmpleadoIdDal(id);
            }

            public void EditarEmpleadoBss(Empleado e)
            {
                dal.EditarEmpleadoDal(e);
            }

            public void EliminarEmpleadoBss(int id)
            {
                dal.EliminarEmpleadoDal(id);
            }

        }
    }
}
