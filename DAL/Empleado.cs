using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Empleado
    {
        // Creacion de Clase Empleado con sus getters y setters
        public Empleado() { }

        public Empleado(int id,string name, string lastname, DateTime dob, string department, double salary ) 
        {
            this.Id= id;
            this.Name= name;
            this.Lastname= lastname;
            this.DoB= dob;
            this.Department= department;
            this.Salary= salary;
        }

        public Empleado(string name, string lastname, DateTime dob, string department, double salary)
        {
            this.Name = name;
            this.Lastname = lastname;
            this.DoB = dob;
            this.Department = department;
            this.Salary = salary;
        }

        public int Id { get; set}
        public string Name { get; set}
        public string Lastname { get; set; }
        public DateTime DoB { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
    }
}
