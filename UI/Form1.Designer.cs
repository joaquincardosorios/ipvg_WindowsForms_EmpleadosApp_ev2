namespace UI
{
    partial class EmpleadosApp
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgv_empleados = new System.Windows.Forms.DataGridView();
            this.btn_llamar_empleados = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_nuevo_empleado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_empleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_empleados
            // 
            this.dtgv_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_empleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellido,
            this.FechaNacimiento,
            this.Departamento,
            this.Salario});
            this.dtgv_empleados.Location = new System.Drawing.Point(25, 33);
            this.dtgv_empleados.Name = "dtgv_empleados";
            this.dtgv_empleados.Size = new System.Drawing.Size(644, 309);
            this.dtgv_empleados.TabIndex = 0;
            // 
            // btn_llamar_empleados
            // 
            this.btn_llamar_empleados.Location = new System.Drawing.Point(536, 363);
            this.btn_llamar_empleados.Name = "btn_llamar_empleados";
            this.btn_llamar_empleados.Size = new System.Drawing.Size(133, 23);
            this.btn_llamar_empleados.TabIndex = 1;
            this.btn_llamar_empleados.Text = "Obtener Empleados";
            this.btn_llamar_empleados.UseVisualStyleBackColor = true;
            this.btn_llamar_empleados.Click += new System.EventHandler(this.btn_llamar_empleados_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombres";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellidos";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            // 
            // Departamento
            // 
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            // 
            // Salario
            // 
            this.Salario.HeaderText = "Salario";
            this.Salario.Name = "Salario";
            this.Salario.ReadOnly = true;
            // 
            // btn_nuevo_empleado
            // 
            this.btn_nuevo_empleado.Location = new System.Drawing.Point(25, 363);
            this.btn_nuevo_empleado.Name = "btn_nuevo_empleado";
            this.btn_nuevo_empleado.Size = new System.Drawing.Size(122, 23);
            this.btn_nuevo_empleado.TabIndex = 2;
            this.btn_nuevo_empleado.Text = "Agregar Empleado";
            this.btn_nuevo_empleado.UseVisualStyleBackColor = true;
            this.btn_nuevo_empleado.Click += new System.EventHandler(this.btn_nuevo_empleado_Click);
            // 
            // EmpleadosApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 415);
            this.Controls.Add(this.btn_nuevo_empleado);
            this.Controls.Add(this.btn_llamar_empleados);
            this.Controls.Add(this.dtgv_empleados);
            this.Name = "EmpleadosApp";
            this.Text = "EmpleadosApp";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_empleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_empleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.Button btn_llamar_empleados;
        private System.Windows.Forms.Button btn_nuevo_empleado;
    }
}

