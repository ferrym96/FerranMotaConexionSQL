namespace FerranMotaConexionSQL
{
    partial class Form1
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
            this.buttonConectar = new System.Windows.Forms.Button();
            this.buttonDesconectar = new System.Windows.Forms.Button();
            this.labelEstadoConexion = new System.Windows.Forms.Label();
            this.buttonCrearEmpleado = new System.Windows.Forms.Button();
            this.labelCrearEmpleado = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.labelFechaIncor = new System.Windows.Forms.Label();
            this.dateTimeIncor = new System.Windows.Forms.DateTimePicker();
            this.labelPuesto = new System.Windows.Forms.Label();
            this.comboPuesto = new System.Windows.Forms.ComboBox();
            this.labelSueldo = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.comboManager = new System.Windows.Forms.ComboBox();
            this.labelManager = new System.Windows.Forms.Label();
            this.comboDept = new System.Windows.Forms.ComboBox();
            this.labelDept = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConectar
            // 
            this.buttonConectar.Location = new System.Drawing.Point(32, 70);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(103, 35);
            this.buttonConectar.TabIndex = 0;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.UseVisualStyleBackColor = true;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // buttonDesconectar
            // 
            this.buttonDesconectar.Location = new System.Drawing.Point(305, 70);
            this.buttonDesconectar.Name = "buttonDesconectar";
            this.buttonDesconectar.Size = new System.Drawing.Size(103, 35);
            this.buttonDesconectar.TabIndex = 1;
            this.buttonDesconectar.Text = "Desconectar";
            this.buttonDesconectar.UseVisualStyleBackColor = true;
            this.buttonDesconectar.Click += new System.EventHandler(this.buttonDesconectar_Click);
            // 
            // labelEstadoConexion
            // 
            this.labelEstadoConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadoConexion.Location = new System.Drawing.Point(32, 9);
            this.labelEstadoConexion.Name = "labelEstadoConexion";
            this.labelEstadoConexion.Size = new System.Drawing.Size(376, 40);
            this.labelEstadoConexion.TabIndex = 2;
            this.labelEstadoConexion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCrearEmpleado
            // 
            this.buttonCrearEmpleado.Location = new System.Drawing.Point(295, 529);
            this.buttonCrearEmpleado.Name = "buttonCrearEmpleado";
            this.buttonCrearEmpleado.Size = new System.Drawing.Size(108, 50);
            this.buttonCrearEmpleado.TabIndex = 3;
            this.buttonCrearEmpleado.Text = "Crear empleado";
            this.buttonCrearEmpleado.UseVisualStyleBackColor = true;
            this.buttonCrearEmpleado.Click += new System.EventHandler(this.buttonCrearEmpleado_Click);
            // 
            // labelCrearEmpleado
            // 
            this.labelCrearEmpleado.AutoSize = true;
            this.labelCrearEmpleado.Location = new System.Drawing.Point(30, 132);
            this.labelCrearEmpleado.Name = "labelCrearEmpleado";
            this.labelCrearEmpleado.Size = new System.Drawing.Size(105, 16);
            this.labelCrearEmpleado.TabIndex = 5;
            this.labelCrearEmpleado.Text = "Crear empleado";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(30, 169);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(56, 16);
            this.labelNombre.TabIndex = 6;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Location = new System.Drawing.Point(236, 169);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(64, 16);
            this.labelApellidos.TabIndex = 7;
            this.labelApellidos.Text = "Apellidos";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(33, 188);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(164, 22);
            this.txtNombre.TabIndex = 8;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(239, 188);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(164, 22);
            this.txtApellidos.TabIndex = 10;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(30, 236);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 16);
            this.labelEmail.TabIndex = 11;
            this.labelEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(33, 255);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(164, 22);
            this.txtEmail.TabIndex = 12;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(236, 236);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(79, 16);
            this.labelTelefono.TabIndex = 13;
            this.labelTelefono.Text = "Nº Teléfono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(239, 255);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(164, 22);
            this.txtTelefono.TabIndex = 14;
            // 
            // labelFechaIncor
            // 
            this.labelFechaIncor.AutoSize = true;
            this.labelFechaIncor.Location = new System.Drawing.Point(30, 306);
            this.labelFechaIncor.Name = "labelFechaIncor";
            this.labelFechaIncor.Size = new System.Drawing.Size(149, 16);
            this.labelFechaIncor.TabIndex = 15;
            this.labelFechaIncor.Text = "Fecha de incorporación";
            // 
            // dateTimeIncor
            // 
            this.dateTimeIncor.Location = new System.Drawing.Point(33, 325);
            this.dateTimeIncor.Name = "dateTimeIncor";
            this.dateTimeIncor.Size = new System.Drawing.Size(164, 22);
            this.dateTimeIncor.TabIndex = 16;
            // 
            // labelPuesto
            // 
            this.labelPuesto.AutoSize = true;
            this.labelPuesto.Location = new System.Drawing.Point(236, 306);
            this.labelPuesto.Name = "labelPuesto";
            this.labelPuesto.Size = new System.Drawing.Size(121, 16);
            this.labelPuesto.TabIndex = 17;
            this.labelPuesto.Text = "Puesto de trabajao";
            // 
            // comboPuesto
            // 
            this.comboPuesto.FormattingEnabled = true;
            this.comboPuesto.Items.AddRange(new object[] {
            "Public Accountant",
            "Accounting Manager",
            "Administration Assistant",
            "President",
            "Administration Vice President",
            "Accountant",
            "Finance Manager",
            "Human Resources Representative",
            "Programmer",
            "Marketing Manager",
            "Marketing Representative",
            "Public Relations Representative",
            "Purchasing Clerk",
            "Purchasing Manager",
            "Sales Manager",
            "Sales Representative",
            "Shipping Clerk",
            "Stock Clerk",
            "Stock Manager"});
            this.comboPuesto.Location = new System.Drawing.Point(239, 325);
            this.comboPuesto.Name = "comboPuesto";
            this.comboPuesto.Size = new System.Drawing.Size(164, 24);
            this.comboPuesto.TabIndex = 19;
            // 
            // labelSueldo
            // 
            this.labelSueldo.AutoSize = true;
            this.labelSueldo.Location = new System.Drawing.Point(30, 369);
            this.labelSueldo.Name = "labelSueldo";
            this.labelSueldo.Size = new System.Drawing.Size(50, 16);
            this.labelSueldo.TabIndex = 20;
            this.labelSueldo.Text = "Sueldo";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(33, 388);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(164, 22);
            this.txtSueldo.TabIndex = 21;
            // 
            // comboManager
            // 
            this.comboManager.FormattingEnabled = true;
            this.comboManager.Items.AddRange(new object[] {
            "Steven King",
            "Neena Kochhar",
            "Lex De Haan",
            "Alexander Hunold",
            "Nancy Greenberg",
            "Den Raphaely",
            "Matthew Weiss",
            "Shanta Vollman",
            "Michael Hartstein",
            "Shelley Higgins"});
            this.comboManager.Location = new System.Drawing.Point(239, 388);
            this.comboManager.Name = "comboManager";
            this.comboManager.Size = new System.Drawing.Size(164, 24);
            this.comboManager.TabIndex = 23;
            // 
            // labelManager
            // 
            this.labelManager.AutoSize = true;
            this.labelManager.Location = new System.Drawing.Point(236, 369);
            this.labelManager.Name = "labelManager";
            this.labelManager.Size = new System.Drawing.Size(61, 16);
            this.labelManager.TabIndex = 22;
            this.labelManager.Text = "Manager";
            // 
            // comboDept
            // 
            this.comboDept.FormattingEnabled = true;
            this.comboDept.Items.AddRange(new object[] {
            "Administration",
            "Marketing",
            "Purchasing",
            "Human Resources",
            "Shipping",
            "IT",
            "Public Relations",
            "Sales",
            "Executive",
            "Finance",
            "Accounting"});
            this.comboDept.Location = new System.Drawing.Point(33, 461);
            this.comboDept.Name = "comboDept";
            this.comboDept.Size = new System.Drawing.Size(164, 24);
            this.comboDept.TabIndex = 25;
            // 
            // labelDept
            // 
            this.labelDept.AutoSize = true;
            this.labelDept.Location = new System.Drawing.Point(30, 442);
            this.labelDept.Name = "labelDept";
            this.labelDept.Size = new System.Drawing.Size(93, 16);
            this.labelDept.TabIndex = 24;
            this.labelDept.Text = "Departamento";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(32, 529);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(108, 50);
            this.buttonCancelar.TabIndex = 26;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 600);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.comboDept);
            this.Controls.Add(this.labelDept);
            this.Controls.Add(this.comboManager);
            this.Controls.Add(this.labelManager);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.labelSueldo);
            this.Controls.Add(this.comboPuesto);
            this.Controls.Add(this.labelPuesto);
            this.Controls.Add(this.dateTimeIncor);
            this.Controls.Add(this.labelFechaIncor);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelCrearEmpleado);
            this.Controls.Add(this.buttonCrearEmpleado);
            this.Controls.Add(this.labelEstadoConexion);
            this.Controls.Add(this.buttonDesconectar);
            this.Controls.Add(this.buttonConectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.Button buttonDesconectar;
        private System.Windows.Forms.Label labelEstadoConexion;
        private System.Windows.Forms.Button buttonCrearEmpleado;
        private System.Windows.Forms.Label labelCrearEmpleado;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label labelFechaIncor;
        private System.Windows.Forms.DateTimePicker dateTimeIncor;
        private System.Windows.Forms.Label labelPuesto;
        private System.Windows.Forms.ComboBox comboPuesto;
        private System.Windows.Forms.Label labelSueldo;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.ComboBox comboManager;
        private System.Windows.Forms.Label labelManager;
        private System.Windows.Forms.ComboBox comboDept;
        private System.Windows.Forms.Label labelDept;
        private System.Windows.Forms.Button buttonCancelar;
    }
}

