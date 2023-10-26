using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Empleado
    {
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

        public int Id;
        public string Name;
        public string Lastname;
        public DateTime DoB;
        public string Department;
        public double Salary;
    }
}
