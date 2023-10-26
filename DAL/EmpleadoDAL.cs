using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmpleadoDAL
    {
        public bool GuardarEmpleado(Empleado empleado)
        {
            string fecharFormateada = empleado.DoB.ToString("yyyy-MM-dd");
            string query = $"" +
                $"INSERT INTO Empleados(Nombre, Apellido, FechaNacimiento, Departamento, Salario) " +
                $"VALUES('{empleado.Name}', '{empleado.Lastname}', '{fecharFormateada}', '{empleado.Department}', {empleado.Salary})";
            int rows = DatabaseHelper.Instance.ExecuteNonQuery(query);
            if (rows == 0)
            {
                return false;
            }
            return true;
        }

        public List<Empleado> ObtenerEmpleados()
        {
            string query = "SELECT * FROM Empleados";
            DataTable dt = DatabaseHelper.Instance.ExecuteQuery(query);
            List<Empleado> empleados = new List<Empleado>();
            foreach (DataRow row in dt.Rows)
            {
                Empleado e = new Empleado();
                e.Id = int.Parse(row["ID"].ToString());
                e.Name = row["Nombre"].ToString().TrimEnd();
                e.Lastname = row["Apellido"].ToString().TrimEnd();
                e.Department = row["Departamento"].ToString().TrimEnd();
                e.Salary = Math.Round(Double.Parse(row["Salario"].ToString()),2);

                if (DateTime.TryParse(row["FechaNacimiento"].ToString(), out DateTime fechaNacimiento))
                {
                    e.DoB = fechaNacimiento;
                }
                empleados.Add(e);
            }
            return empleados;

        }
    }
}
