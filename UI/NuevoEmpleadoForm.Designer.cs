namespace UI
{
    partial class NuevoEmpleadoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_titulo_empleado = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.txt_department = new System.Windows.Forms.TextBox();
            this.lbl_department = new System.Windows.Forms.Label();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.dtp_dob = new System.Windows.Forms.DateTimePicker();
            this.lbl_salary = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo_empleado
            // 
            this.lbl_titulo_empleado.AutoSize = true;
            this.lbl_titulo_empleado.Location = new System.Drawing.Point(12, 21);
            this.lbl_titulo_empleado.Name = "lbl_titulo_empleado";
            this.lbl_titulo_empleado.Size = new System.Drawing.Size(92, 13);
            this.lbl_titulo_empleado.TabIndex = 0;
            this.lbl_titulo_empleado.Text = "Nuevo Empleado:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(129, 44);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(71, 47);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(52, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Nombres:";
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(129, 71);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(100, 20);
            this.txt_lastname.TabIndex = 1;
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Location = new System.Drawing.Point(71, 74);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(52, 13);
            this.lbl_lastname.TabIndex = 0;
            this.lbl_lastname.Text = "Apellidos:";
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Location = new System.Drawing.Point(12, 103);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(114, 13);
            this.lbl_dob.TabIndex = 0;
            this.lbl_dob.Text = "Fecha de Nacimiento: ";
            // 
            // txt_department
            // 
            this.txt_department.Location = new System.Drawing.Point(129, 126);
            this.txt_department.Name = "txt_department";
            this.txt_department.Size = new System.Drawing.Size(100, 20);
            this.txt_department.TabIndex = 1;
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Location = new System.Drawing.Point(49, 129);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(77, 13);
            this.lbl_department.TabIndex = 0;
            this.lbl_department.Text = "Departamento:";
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(129, 154);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(100, 20);
            this.txt_salary.TabIndex = 1;
            // 
            // dtp_dob
            // 
            this.dtp_dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dob.Location = new System.Drawing.Point(129, 99);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(100, 20);
            this.dtp_dob.TabIndex = 2;
            // 
            // lbl_salary
            // 
            this.lbl_salary.AutoSize = true;
            this.lbl_salary.Location = new System.Drawing.Point(84, 157);
            this.lbl_salary.Name = "lbl_salary";
            this.lbl_salary.Size = new System.Drawing.Size(42, 13);
            this.lbl_salary.TabIndex = 0;
            this.lbl_salary.Text = "Salario:";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(52, 194);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(177, 23);
            this.btn_agregar.TabIndex = 3;
            this.btn_agregar.Text = "Agregar Empleado";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // NuevoEmpleadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 242);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.dtp_dob);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.txt_department);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.lbl_salary);
            this.Controls.Add(this.lbl_department);
            this.Controls.Add(this.lbl_dob);
            this.Controls.Add(this.lbl_lastname);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_titulo_empleado);
            this.Name = "NuevoEmpleadoForm";
            this.Text = "NuevoEmpleadoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo_empleado;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.TextBox txt_department;
        private System.Windows.Forms.Label lbl_department;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.DateTimePicker dtp_dob;
        private System.Windows.Forms.Label lbl_salary;
        private System.Windows.Forms.Button btn_agregar;
    }
}