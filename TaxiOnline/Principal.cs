using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiOnline.Clases;
using TaxiOnline.DbClases;

namespace TaxiOnline
{
    public partial class Principal : Form
    {
        string sexo;

        public Principal()
        {
            InitializeComponent();
        }

        
        

        private void bntClear_Click(object sender, EventArgs e)
        {
            txtUsuarioPersonal.Clear();
            txtContraseñaPersonal.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txtCc.Clear();
            txtCiudad.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtResidencia.Clear();
            txtCiudad.Clear();
            txtCorreo.Clear();
            btnmasculino.Checked = false;
            btnfemenino.Checked = false;


        }

        private void txtEmpresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        // Boton para ingreso de usuario
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand("SELECT * FROM datos WHERE usuario='" + txtUsuario.Text + "' AND contraseña='" + txtContraseña.Text + "'", DbConexion.ObtenerConexion());
                MySqlDataReader leer = comando.ExecuteReader();

                if (leer.Read())
                {
                    txtUsuario.Clear();
                    txtContraseña.Clear();

                    Agendamiento AgendUsu = new Agendamiento();
                    AgendUsu.id_persona = leer.GetInt32("id");
                    AgendUsu.lblid_persona.Text = AgendUsu.id_persona.ToString();
                    this.Hide();
                    AgendUsu.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o Clave Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        // Boton deLogin administrador
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtUsuarioAdmin.Text == "Admin" && txtContraseñaAdmin.Text == "Admin")
            {
                DatosDeUsuarios datosUsu = new DatosDeUsuarios();
                this.Hide();
                datosUsu.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("Usuario y/o Clave Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // boton de registrar persona
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona p1 = new Persona();
                p1.Nombre = txtNombre.Text;
                p1.Apellidos = txtApellidos.Text;
                p1.CC = txtCc.Text;
                p1.Fecha_Nacimiento = txtNacimiento.Text;
                p1.Telefono = txtTelefono.Text;
                p1.Direccion_Residencia = txtResidencia.Text;
                p1.Ciudad_Residencia = txtCiudad.Text;
                p1.Usuario = txtUsuarioPersonal.Text;
                p1.Fecha_Nacimiento = txtNacimiento.Value.ToString();
                p1.Contraseña = txtContraseñaPersonal.Text;
                p1.Correo_electronico = txtCorreo.Text;
                p1.Sexo = sexo;

                int resultado = DbPersona.Agregar(p1);
                if (resultado > 0)
                {
                    MessageBox.Show("Persona Agregada con exito");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al agregar");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnmasculino_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "masculino";
        }

        private void btnfemenino_CheckedChanged(object sender, EventArgs e)
        {
            sexo = "femenino";
        }

        // boton para la ventana recuperacion de usuario
        private void btnRecuperarUsuario_Click(object sender, EventArgs e)
        {
            RecupersacionUsuarioContraseña r1 = new RecupersacionUsuarioContraseña();
            this.Hide();
            r1.ShowDialog();
            this.Show();
        }

        //  boton de limpiar los cuadros de texto del login administrador
        private void btnLimpiarAdmin_Click(object sender, EventArgs e)
        {
            txtContraseñaAdmin.Clear();
            txtUsuarioAdmin.Clear();
        }
    }
}
