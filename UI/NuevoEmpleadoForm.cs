using BLL;
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


namespace UI
{
    public partial class NuevoEmpleadoForm : Form
    {
        private EmpleadoBLL empleadoBLL;

        public NuevoEmpleadoForm()
        {
            InitializeComponent();
            empleadoBLL = new EmpleadoBLL();
        }

        // Se intenta crear u nuevo Empleado al presionar el boton agregar
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Primera capa de validación para verificar que los datos son válidos
                this.ValidarDatos();


                string name = txt_name.Text;
                string lastname = txt_lastname.Text;
                DateTime dob = dtp_dob.Value.Date;
                string department = txt_department.Text;
                double salary = double.Parse(txt_salary.Text);

                // Creacion de instancia de empleado con los datos ya validados
                Empleado empleado = new Empleado(name, lastname, dob,department,salary);

                // Llamado a la capa logica para crear nuevo usuario
                this.empleadoBLL.AgregarEmpleado(empleado);

                // Limpieza de campos
                txt_name.Clear();
                txt_lastname.Clear();
                txt_department.Clear();
                txt_salary.Clear();
                dtp_dob.ResetText();

                // Confirmacion de tarea completada
                this.DialogResult = DialogResult.OK;
                Close();
            } catch(Exception ex)
            {
                // Manejo de errores
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        // Validacion de campos obligatorios
        private void ValidarDatos()
        {
            if (string.IsNullOrEmpty(txt_name.Text.Trim()))
            {
                throw new Exception("El nombre es obligatorio");
            }
            if (string.IsNullOrEmpty(txt_lastname.Text.Trim()))
            {
                throw new Exception("El apellido es obligatorio");
            }
            if (string.IsNullOrEmpty(txt_department.Text.Trim()))
            {
                throw new Exception("El departamento es obligatorio");
            }
            if (!double.TryParse(txt_salary.Text.Trim(), out double salary))
            {
                throw new Exception("La cantidad ingresada no es valida");
            }
        }


    }
}
