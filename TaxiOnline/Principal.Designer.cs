namespace TaxiOnline
{
    partial class Principal
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRecuperarUsuario = new System.Windows.Forms.Button();
            this.bntClear = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtContraseñaPersonal = new System.Windows.Forms.TextBox();
            this.txtUsuarioPersonal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtResidencia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.btnfemenino = new System.Windows.Forms.RadioButton();
            this.btnmasculino = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtContraseñaEmp = new System.Windows.Forms.TextBox();
            this.txtUsuarioEmp = new System.Windows.Forms.TextBox();
            this.InContraseñaEmp = new System.Windows.Forms.Label();
            this.InUsuarioEmp = new System.Windows.Forms.Label();
            this.InCiudadEmp = new System.Windows.Forms.Label();
            this.InEmpresa = new System.Windows.Forms.Label();
            this.InCorreoEmp = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.InTelefonoEmp = new System.Windows.Forms.Label();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.InDireccionEmp = new System.Windows.Forms.Label();
            this.txtDireccionEmp = new System.Windows.Forms.TextBox();
            this.InNit = new System.Windows.Forms.Label();
            this.txtTelefonoEmp = new System.Windows.Forms.TextBox();
            this.txtCorreoEmp = new System.Windows.Forms.TextBox();
            this.btnLimpiarEmp = new System.Windows.Forms.Button();
            this.txtCiudadEmp = new System.Windows.Forms.TextBox();
            this.btnRegistrarEmp = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnInicioSesionAdmin = new System.Windows.Forms.Button();
            this.btnLimpiarAdmin = new System.Windows.Forms.Button();
            this.txtContraseñaAdmin = new System.Windows.Forms.TextBox();
            this.txtUsuarioAdmin = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(738, 644);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.btnRecuperarUsuario);
            this.tabPage1.Controls.Add(this.bntClear);
            this.tabPage1.Controls.Add(this.btnIngresar);
            this.tabPage1.Controls.Add(this.txtContraseña);
            this.tabPage1.Controls.Add(this.txtUsuario);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(730, 618);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Iniciar sesion";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnRecuperarUsuario
            // 
            this.btnRecuperarUsuario.Location = new System.Drawing.Point(294, 237);
            this.btnRecuperarUsuario.Name = "btnRecuperarUsuario";
            this.btnRecuperarUsuario.Size = new System.Drawing.Size(209, 23);
            this.btnRecuperarUsuario.TabIndex = 5;
            this.btnRecuperarUsuario.Text = "¿Olvido Su Usuario y/o Contraseña?";
            this.btnRecuperarUsuario.UseVisualStyleBackColor = true;
            this.btnRecuperarUsuario.Click += new System.EventHandler(this.btnRecuperarUsuario_Click);
            // 
            // bntClear
            // 
            this.bntClear.Location = new System.Drawing.Point(294, 172);
            this.bntClear.Name = "bntClear";
            this.bntClear.Size = new System.Drawing.Size(75, 23);
            this.bntClear.TabIndex = 4;
            this.bntClear.Text = "Limpiar";
            this.bntClear.UseVisualStyleBackColor = true;
            this.bntClear.Click += new System.EventHandler(this.bntClear_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(428, 172);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(294, 134);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '+';
            this.txtContraseña.Size = new System.Drawing.Size(209, 20);
            this.txtContraseña.TabIndex = 2;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(294, 78);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(209, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(156, 134);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 20);
            this.label17.TabIndex = 1;
            this.label17.Text = "Contraseña:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(156, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "Usuario:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.txtNacimiento);
            this.tabPage2.Controls.Add(this.txtContraseñaPersonal);
            this.tabPage2.Controls.Add(this.txtUsuarioPersonal);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnLimpiar);
            this.tabPage2.Controls.Add(this.btnRegistrar);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txtNombre);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txtApellidos);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtCc);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtTelefono);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtResidencia);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtCiudad);
            this.tabPage2.Controls.Add(this.txtCorreo);
            this.tabPage2.Controls.Add(this.btnfemenino);
            this.tabPage2.Controls.Add(this.btnmasculino);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(730, 618);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registro Personal";
            // 
            // txtNacimiento
            // 
            this.txtNacimiento.Location = new System.Drawing.Point(307, 215);
            this.txtNacimiento.Name = "txtNacimiento";
            this.txtNacimiento.Size = new System.Drawing.Size(264, 20);
            this.txtNacimiento.TabIndex = 43;
            this.txtNacimiento.Value = new System.DateTime(2018, 10, 16, 0, 0, 0, 0);
            // 
            // txtContraseñaPersonal
            // 
            this.txtContraseñaPersonal.Location = new System.Drawing.Point(307, 531);
            this.txtContraseñaPersonal.Name = "txtContraseñaPersonal";
            this.txtContraseñaPersonal.Size = new System.Drawing.Size(264, 20);
            this.txtContraseñaPersonal.TabIndex = 42;
            // 
            // txtUsuarioPersonal
            // 
            this.txtUsuarioPersonal.Location = new System.Drawing.Point(307, 487);
            this.txtUsuarioPersonal.Name = "txtUsuarioPersonal";
            this.txtUsuarioPersonal.Size = new System.Drawing.Size(264, 20);
            this.txtUsuarioPersonal.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 538);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Usuario:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(307, 589);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(496, 589);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(115, 435);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "Sexo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Nombre:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(115, 389);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Correo Electronico";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(307, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(264, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(115, 347);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Ciudad de Residencia:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(307, 123);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(264, 20);
            this.txtApellidos.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(115, 308);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Direccion DondeLo Recogeremos:";
            // 
            // txtCc
            // 
            this.txtCc.Location = new System.Drawing.Point(307, 167);
            this.txtCc.Name = "txtCc";
            this.txtCc.Size = new System.Drawing.Size(264, 20);
            this.txtCc.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(115, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Telefono:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(115, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Fecha de Nacimiento:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(307, 258);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(264, 20);
            this.txtTelefono.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "CC:";
            // 
            // txtResidencia
            // 
            this.txtResidencia.Location = new System.Drawing.Point(307, 301);
            this.txtResidencia.Name = "txtResidencia";
            this.txtResidencia.Size = new System.Drawing.Size(264, 20);
            this.txtResidencia.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Apellidos:";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(307, 340);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(264, 20);
            this.txtCiudad.TabIndex = 7;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(307, 382);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(264, 20);
            this.txtCorreo.TabIndex = 8;
            // 
            // btnfemenino
            // 
            this.btnfemenino.AutoSize = true;
            this.btnfemenino.Location = new System.Drawing.Point(399, 435);
            this.btnfemenino.Name = "btnfemenino";
            this.btnfemenino.Size = new System.Drawing.Size(71, 17);
            this.btnfemenino.TabIndex = 10;
            this.btnfemenino.TabStop = true;
            this.btnfemenino.Text = "Femenino";
            this.btnfemenino.UseVisualStyleBackColor = true;
            // 
            // btnmasculino
            // 
            this.btnmasculino.AutoSize = true;
            this.btnmasculino.Location = new System.Drawing.Point(307, 435);
            this.btnmasculino.Name = "btnmasculino";
            this.btnmasculino.Size = new System.Drawing.Size(73, 17);
            this.btnmasculino.TabIndex = 9;
            this.btnmasculino.TabStop = true;
            this.btnmasculino.Text = "Masculino";
            this.btnmasculino.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.txtContraseñaEmp);
            this.tabPage3.Controls.Add(this.txtUsuarioEmp);
            this.tabPage3.Controls.Add(this.InContraseñaEmp);
            this.tabPage3.Controls.Add(this.InUsuarioEmp);
            this.tabPage3.Controls.Add(this.InCiudadEmp);
            this.tabPage3.Controls.Add(this.InEmpresa);
            this.tabPage3.Controls.Add(this.InCorreoEmp);
            this.tabPage3.Controls.Add(this.txtEmpresa);
            this.tabPage3.Controls.Add(this.InTelefonoEmp);
            this.tabPage3.Controls.Add(this.txtNit);
            this.tabPage3.Controls.Add(this.InDireccionEmp);
            this.tabPage3.Controls.Add(this.txtDireccionEmp);
            this.tabPage3.Controls.Add(this.InNit);
            this.tabPage3.Controls.Add(this.txtTelefonoEmp);
            this.tabPage3.Controls.Add(this.txtCorreoEmp);
            this.tabPage3.Controls.Add(this.btnLimpiarEmp);
            this.tabPage3.Controls.Add(this.txtCiudadEmp);
            this.tabPage3.Controls.Add(this.btnRegistrarEmp);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(730, 618);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Registro Empresarial";
            // 
            // txtContraseñaEmp
            // 
            this.txtContraseñaEmp.Location = new System.Drawing.Point(325, 378);
            this.txtContraseñaEmp.Name = "txtContraseñaEmp";
            this.txtContraseñaEmp.Size = new System.Drawing.Size(288, 20);
            this.txtContraseñaEmp.TabIndex = 49;
            // 
            // txtUsuarioEmp
            // 
            this.txtUsuarioEmp.Location = new System.Drawing.Point(328, 339);
            this.txtUsuarioEmp.Name = "txtUsuarioEmp";
            this.txtUsuarioEmp.Size = new System.Drawing.Size(288, 20);
            this.txtUsuarioEmp.TabIndex = 47;
            // 
            // InContraseñaEmp
            // 
            this.InContraseñaEmp.AutoSize = true;
            this.InContraseñaEmp.Location = new System.Drawing.Point(151, 385);
            this.InContraseñaEmp.Name = "InContraseñaEmp";
            this.InContraseñaEmp.Size = new System.Drawing.Size(64, 13);
            this.InContraseñaEmp.TabIndex = 45;
            this.InContraseñaEmp.Text = "Contraseña:";
            // 
            // InUsuarioEmp
            // 
            this.InUsuarioEmp.AutoSize = true;
            this.InUsuarioEmp.Location = new System.Drawing.Point(151, 346);
            this.InUsuarioEmp.Name = "InUsuarioEmp";
            this.InUsuarioEmp.Size = new System.Drawing.Size(46, 13);
            this.InUsuarioEmp.TabIndex = 43;
            this.InUsuarioEmp.Text = "Usuario:";
            // 
            // InCiudadEmp
            // 
            this.InCiudadEmp.AutoSize = true;
            this.InCiudadEmp.Location = new System.Drawing.Point(148, 304);
            this.InCiudadEmp.Name = "InCiudadEmp";
            this.InCiudadEmp.Size = new System.Drawing.Size(43, 13);
            this.InCiudadEmp.TabIndex = 42;
            this.InCiudadEmp.Text = "Ciudad:";
            // 
            // InEmpresa
            // 
            this.InEmpresa.AutoSize = true;
            this.InEmpresa.Location = new System.Drawing.Point(148, 102);
            this.InEmpresa.Name = "InEmpresa";
            this.InEmpresa.Size = new System.Drawing.Size(117, 13);
            this.InEmpresa.TabIndex = 37;
            this.InEmpresa.Text = "Nombre de la Empresa:";
            // 
            // InCorreoEmp
            // 
            this.InCorreoEmp.AutoSize = true;
            this.InCorreoEmp.Location = new System.Drawing.Point(148, 262);
            this.InCorreoEmp.Name = "InCorreoEmp";
            this.InCorreoEmp.Size = new System.Drawing.Size(96, 13);
            this.InCorreoEmp.TabIndex = 41;
            this.InCorreoEmp.Text = "Correo electronico:";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(328, 102);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(288, 20);
            this.txtEmpresa.TabIndex = 29;
            this.txtEmpresa.TextChanged += new System.EventHandler(this.txtEmpresa_TextChanged);
            // 
            // InTelefonoEmp
            // 
            this.InTelefonoEmp.AutoSize = true;
            this.InTelefonoEmp.Location = new System.Drawing.Point(148, 216);
            this.InTelefonoEmp.Name = "InTelefonoEmp";
            this.InTelefonoEmp.Size = new System.Drawing.Size(52, 13);
            this.InTelefonoEmp.TabIndex = 40;
            this.InTelefonoEmp.Text = "Telefono:";
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(328, 140);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(288, 20);
            this.txtNit.TabIndex = 30;
            // 
            // InDireccionEmp
            // 
            this.InDireccionEmp.AutoSize = true;
            this.InDireccionEmp.Location = new System.Drawing.Point(148, 182);
            this.InDireccionEmp.Name = "InDireccionEmp";
            this.InDireccionEmp.Size = new System.Drawing.Size(174, 13);
            this.InDireccionEmp.TabIndex = 39;
            this.InDireccionEmp.Text = "Direccion Donde Lo Recogeremos:";
            // 
            // txtDireccionEmp
            // 
            this.txtDireccionEmp.Location = new System.Drawing.Point(328, 175);
            this.txtDireccionEmp.Name = "txtDireccionEmp";
            this.txtDireccionEmp.Size = new System.Drawing.Size(288, 20);
            this.txtDireccionEmp.TabIndex = 31;
            // 
            // InNit
            // 
            this.InNit.AutoSize = true;
            this.InNit.Location = new System.Drawing.Point(148, 140);
            this.InNit.Name = "InNit";
            this.InNit.Size = new System.Drawing.Size(58, 13);
            this.InNit.TabIndex = 38;
            this.InNit.Text = "No. de Nit:";
            // 
            // txtTelefonoEmp
            // 
            this.txtTelefonoEmp.Location = new System.Drawing.Point(328, 216);
            this.txtTelefonoEmp.Name = "txtTelefonoEmp";
            this.txtTelefonoEmp.Size = new System.Drawing.Size(288, 20);
            this.txtTelefonoEmp.TabIndex = 32;
            // 
            // txtCorreoEmp
            // 
            this.txtCorreoEmp.Location = new System.Drawing.Point(328, 262);
            this.txtCorreoEmp.Name = "txtCorreoEmp";
            this.txtCorreoEmp.Size = new System.Drawing.Size(288, 20);
            this.txtCorreoEmp.TabIndex = 33;
            // 
            // btnLimpiarEmp
            // 
            this.btnLimpiarEmp.Location = new System.Drawing.Point(298, 471);
            this.btnLimpiarEmp.Name = "btnLimpiarEmp";
            this.btnLimpiarEmp.Size = new System.Drawing.Size(125, 31);
            this.btnLimpiarEmp.TabIndex = 36;
            this.btnLimpiarEmp.Text = "Limpiar";
            this.btnLimpiarEmp.UseVisualStyleBackColor = true;
            // 
            // txtCiudadEmp
            // 
            this.txtCiudadEmp.Location = new System.Drawing.Point(328, 304);
            this.txtCiudadEmp.Name = "txtCiudadEmp";
            this.txtCiudadEmp.Size = new System.Drawing.Size(288, 20);
            this.txtCiudadEmp.TabIndex = 34;
            // 
            // btnRegistrarEmp
            // 
            this.btnRegistrarEmp.Location = new System.Drawing.Point(461, 471);
            this.btnRegistrarEmp.Name = "btnRegistrarEmp";
            this.btnRegistrarEmp.Size = new System.Drawing.Size(125, 31);
            this.btnRegistrarEmp.TabIndex = 35;
            this.btnRegistrarEmp.Text = "Registrar";
            this.btnRegistrarEmp.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnInicioSesionAdmin);
            this.tabPage4.Controls.Add(this.btnLimpiarAdmin);
            this.tabPage4.Controls.Add(this.txtContraseñaAdmin);
            this.tabPage4.Controls.Add(this.txtUsuarioAdmin);
            this.tabPage4.Controls.Add(this.label23);
            this.tabPage4.Controls.Add(this.label22);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(730, 618);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Administrador";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnInicioSesionAdmin
            // 
            this.btnInicioSesionAdmin.Location = new System.Drawing.Point(437, 213);
            this.btnInicioSesionAdmin.Name = "btnInicioSesionAdmin";
            this.btnInicioSesionAdmin.Size = new System.Drawing.Size(84, 23);
            this.btnInicioSesionAdmin.TabIndex = 7;
            this.btnInicioSesionAdmin.Text = "Iniciar Sesion";
            this.btnInicioSesionAdmin.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarAdmin
            // 
            this.btnLimpiarAdmin.Location = new System.Drawing.Point(293, 213);
            this.btnLimpiarAdmin.Name = "btnLimpiarAdmin";
            this.btnLimpiarAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarAdmin.TabIndex = 6;
            this.btnLimpiarAdmin.Text = "Limpiar";
            this.btnLimpiarAdmin.UseVisualStyleBackColor = true;
            this.btnLimpiarAdmin.Click += new System.EventHandler(this.btnLimpiarAdmin_Click);
            // 
            // txtContraseñaAdmin
            // 
            this.txtContraseñaAdmin.Location = new System.Drawing.Point(293, 144);
            this.txtContraseñaAdmin.Name = "txtContraseñaAdmin";
            this.txtContraseñaAdmin.PasswordChar = '°';
            this.txtContraseñaAdmin.Size = new System.Drawing.Size(228, 20);
            this.txtContraseñaAdmin.TabIndex = 5;
            // 
            // txtUsuarioAdmin
            // 
            this.txtUsuarioAdmin.Location = new System.Drawing.Point(293, 101);
            this.txtUsuarioAdmin.Name = "txtUsuarioAdmin";
            this.txtUsuarioAdmin.Size = new System.Drawing.Size(228, 20);
            this.txtUsuarioAdmin.TabIndex = 4;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(205, 147);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "Contraseña:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(205, 104);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "Administrador:";
            // 
            // Principal
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 749);
            this.Controls.Add(this.tabControl1);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:Pagina Principal:.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button bntClear;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtResidencia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.RadioButton btnfemenino;
        private System.Windows.Forms.RadioButton btnmasculino;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label InCiudadEmp;
        private System.Windows.Forms.Label InEmpresa;
        private System.Windows.Forms.Label InCorreoEmp;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label InTelefonoEmp;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label InDireccionEmp;
        private System.Windows.Forms.TextBox txtDireccionEmp;
        private System.Windows.Forms.Label InNit;
        private System.Windows.Forms.TextBox txtTelefonoEmp;
        private System.Windows.Forms.TextBox txtCorreoEmp;
        private System.Windows.Forms.Button btnLimpiarEmp;
        private System.Windows.Forms.TextBox txtCiudadEmp;
        private System.Windows.Forms.Button btnRegistrarEmp;
        private System.Windows.Forms.TextBox txtContraseñaEmp;
        private System.Windows.Forms.TextBox txtUsuarioEmp;
        private System.Windows.Forms.Label InContraseñaEmp;
        private System.Windows.Forms.Label InUsuarioEmp;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtContraseñaAdmin;
        private System.Windows.Forms.TextBox txtUsuarioAdmin;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtContraseñaPersonal;
        private System.Windows.Forms.TextBox txtUsuarioPersonal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiarAdmin;
        private System.Windows.Forms.Button btnInicioSesionAdmin;
        private System.Windows.Forms.Button btnRecuperarUsuario;
        private System.Windows.Forms.DateTimePicker txtNacimiento;
    }
}

