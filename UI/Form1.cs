using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace UI
{
    public partial class EmpleadosApp : Form
    {
        private EmpleadoBLL empleadoBLL;
        NuevoEmpleadoForm formularioEmpleado;

        // Constructor de clase, la cual instancia a la clase EmpleadoBLL al iniciarse
        public EmpleadosApp()
        {
            InitializeComponent();
            empleadoBLL= new EmpleadoBLL();
        }

        //Metodo de carga de empleados
        public void CargarEmpleados()
        {
            this.dtgv_empleados.Rows.Clear();

            // Llama empleados desde DB
            List<Empleado> empleados = empleadoBLL.ObtenerEmpleados();

            // Itera sobre cada empleado para incluirlo en el DataGridView
            foreach (Empleado e in empleados)
            {
                int n = dtgv_empleados.Rows.Add();
                dtgv_empleados.Rows[n].Cells[0].Value = e.Id;
                dtgv_empleados.Rows[n].Cells[1].Value = e.Name;
                dtgv_empleados.Rows[n].Cells[2].Value = e.Lastname;
                dtgv_empleados.Rows[n].Cells[3].Value = e.DoB.ToString("dd-MM-yyyy");
                dtgv_empleados.Rows[n].Cells[4].Value = e.Department;
                dtgv_empleados.Rows[n].Cells[5].Value = e.Salary;

            }
        }

        // Llama al metodo de carga de empleados al hacer clic el boton llamar_empleados
        private void btn_llamar_empleados_Click(object sender, EventArgs e)
        {
            this.CargarEmpleados();
        }

        // Abre nuevo Form para ingreso de nuevo usuario
        private void btn_nuevo_empleado_Click(object sender, EventArgs e)
        {
            formularioEmpleado = new NuevoEmpleadoForm();
            // Si la creacion es exitosa se recarga el DataGridView
            if (formularioEmpleado.ShowDialog() == DialogResult.OK)
            {
                this.CargarEmpleados();
            }
        }
    }
}
