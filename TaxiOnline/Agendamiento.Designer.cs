namespace TaxiOnline
{
    partial class Agendamiento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.dtmFechaViaje = new System.Windows.Forms.DateTimePicker();
            this.txtHoraViaje = new System.Windows.Forms.TextBox();
            this.txtOcupantes = new System.Windows.Forms.TextBox();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            this.btnMisAgendas = new System.Windows.Forms.Button();
            this.btnCerrarSesionUsu = new System.Windows.Forms.Button();
            this.lblid_persona = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(141, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(613, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido A Transporte Caribe !!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Del Viaje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora Del viaje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ciudad Destino:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numero De Ocupantes:";
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Items.AddRange(new object[] {
            "Barranquilla",
            "Carmen De Bolivar",
            "Cordoba",
            "Monteria",
            "La Guajira",
            "Santa Marta",
            "Sincelejo"});
            this.cmbDestino.Location = new System.Drawing.Point(188, 130);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(200, 21);
            this.cmbDestino.TabIndex = 5;
            this.cmbDestino.Text = "Seleccione...";
            this.cmbDestino.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtmFechaViaje
            // 
            this.dtmFechaViaje.Checked = false;
            this.dtmFechaViaje.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFechaViaje.Location = new System.Drawing.Point(188, 190);
            this.dtmFechaViaje.Name = "dtmFechaViaje";
            this.dtmFechaViaje.Size = new System.Drawing.Size(200, 20);
            this.dtmFechaViaje.TabIndex = 6;
            // 
            // txtHoraViaje
            // 
            this.txtHoraViaje.Location = new System.Drawing.Point(188, 244);
            this.txtHoraViaje.Name = "txtHoraViaje";
            this.txtHoraViaje.Size = new System.Drawing.Size(200, 20);
            this.txtHoraViaje.TabIndex = 7;
            this.txtHoraViaje.TextChanged += new System.EventHandler(this.txtHoraViaje_TextChanged);
            // 
            // txtOcupantes
            // 
            this.txtOcupantes.Location = new System.Drawing.Point(188, 292);
            this.txtOcupantes.Name = "txtOcupantes";
            this.txtOcupantes.Size = new System.Drawing.Size(200, 20);
            this.txtOcupantes.TabIndex = 8;
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(327, 373);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(75, 23);
            this.btnAgendar.TabIndex = 9;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.Location = new System.Drawing.Point(188, 373);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarDatos.TabIndex = 10;
            this.btnLimpiarDatos.Text = "Limpiar";
            this.btnLimpiarDatos.UseVisualStyleBackColor = true;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMisAgendas
            // 
            this.btnMisAgendas.Location = new System.Drawing.Point(480, 373);
            this.btnMisAgendas.Name = "btnMisAgendas";
            this.btnMisAgendas.Size = new System.Drawing.Size(86, 23);
            this.btnMisAgendas.TabIndex = 12;
            this.btnMisAgendas.Text = "Mis Agendas";
            this.btnMisAgendas.UseVisualStyleBackColor = true;
            this.btnMisAgendas.Click += new System.EventHandler(this.btnMisAgendas_Click);
            // 
            // btnCerrarSesionUsu
            // 
            this.btnCerrarSesionUsu.Location = new System.Drawing.Point(665, 22);
            this.btnCerrarSesionUsu.Name = "btnCerrarSesionUsu";
            this.btnCerrarSesionUsu.Size = new System.Drawing.Size(78, 23);
            this.btnCerrarSesionUsu.TabIndex = 13;
            this.btnCerrarSesionUsu.Text = "Cerrar Sesion";
            this.btnCerrarSesionUsu.UseVisualStyleBackColor = true;
            this.btnCerrarSesionUsu.Click += new System.EventHandler(this.btnCerrarSesionUsu_Click);
            // 
            // lblid_persona
            // 
            this.lblid_persona.AutoSize = true;
            this.lblid_persona.Location = new System.Drawing.Point(13, 31);
            this.lblid_persona.Name = "lblid_persona";
            this.lblid_persona.Size = new System.Drawing.Size(35, 13);
            this.lblid_persona.TabIndex = 14;
            this.lblid_persona.Text = "label6";
            this.lblid_persona.Visible = false;
            // 
            // Agendamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblid_persona);
            this.Controls.Add(this.btnCerrarSesionUsu);
            this.Controls.Add(this.btnMisAgendas);
            this.Controls.Add(this.btnLimpiarDatos);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.txtOcupantes);
            this.Controls.Add(this.txtHoraViaje);
            this.Controls.Add(this.dtmFechaViaje);
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Agendamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamiento";
            this.Load += new System.EventHandler(this.Agendamiento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.DateTimePicker dtmFechaViaje;
        private System.Windows.Forms.TextBox txtHoraViaje;
        private System.Windows.Forms.TextBox txtOcupantes;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Button btnLimpiarDatos;
        private System.Windows.Forms.Button btnMisAgendas;
        private System.Windows.Forms.Button btnCerrarSesionUsu;
        public System.Windows.Forms.Label lblid_persona;
    }
}