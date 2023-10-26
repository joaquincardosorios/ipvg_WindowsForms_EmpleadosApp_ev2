using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class EmpleadoBLL
    {
        private EmpleadoDAL empleadoDAL;
        public EmpleadoBLL()
        {
            empleadoDAL= new EmpleadoDAL();
        }

        public void AgregarEmpleado(Empleado empleado)
        {
            empleado.Name = empleado.Name.Trim();
            empleado.Lastname= empleado.Lastname.Trim();
            empleado.Department = empleado.Department.Trim();

            if (string.IsNullOrEmpty(empleado.Name)) throw new Exception("El nombre no puede ir vacio");
            if(empleado.Name.Length > 50) throw new Exception("El nombre no puede tener mas de 50 caracteres");
            if (string.IsNullOrEmpty(empleado.Lastname)) throw new Exception("El apellido no puede ser vacio");
            if (empleado.Lastname.Length > 50) throw new Exception("El apellido no puede tener mas de 50 caracteres");
            if (string.IsNullOrEmpty(empleado.Department)) throw new Exception("El departamento no puede estar vacio");
            if (empleado.Department.Length > 50) throw new Exception("El departamento no puede tener mas de 50 caracteres");
            if (empleado.Salary <= 0) throw new Exception("El salario no puede ser igual o inferior a 0");


            Empleado empleadoExiste = empleadoDAL.ObtenerEmpleados().Where( e => e.Name.Equals(empleado.Name) && e.Lastname.Equals(empleado.Lastname)).FirstOrDefault();
            if (empleadoExiste != null) throw new Exception("El empleado ya existe");
            if (!empleadoDAL.GuardarEmpleado(empleado)) throw new Exception("No se pudo realizar el guardado");
        }

        public List<Empleado> ObtenerEmpleados()
        {
            return empleadoDAL.ObtenerEmpleados();
        }
    }
}
