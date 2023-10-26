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

        public EmpleadosApp()
        {
            InitializeComponent();
            empleadoBLL= new EmpleadoBLL();
        }

        public void CargarEmpleados()
        {
            this.dtgv_empleados.Rows.Clear();
            List<Empleado> empleados = empleadoBLL.ObtenerEmpleados();
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

        private void btn_llamar_empleados_Click(object sender, EventArgs e)
        {
            this.CargarEmpleados();
        }

        private void btn_nuevo_empleado_Click(object sender, EventArgs e)
        {
            formularioEmpleado = new NuevoEmpleadoForm();
            if (formularioEmpleado.ShowDialog() == DialogResult.OK)
            {
                this.CargarEmpleados();
            }
        }
    }
}
