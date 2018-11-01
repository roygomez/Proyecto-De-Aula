using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiOnline.DbClases;

namespace TaxiOnline
{
    public partial class RecupersacionUsuarioContraseña : Form
    {
        public RecupersacionUsuarioContraseña()
        {
            InitializeComponent();
        }

        private void RecupersacionUsuarioContraseña_Load(object sender, EventArgs e)
        {

        }

        // Boton VOLVER De La Ventana Recuperar Contraseña
        private void button2_Click(object sender, EventArgs e)
        {
 
            this.Close();
        }

        // BotonEnviar Para recuperar contraseña y/o Usuario
        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM datos WHERE cc='" + txtValidacion.Text + "' "), DbConexion.ObtenerConexion());
                MySqlDataReader _reader = _comando.ExecuteReader();
                if (_reader.Read())
                {
                    string servidor = "smtp.gmail.com";
                    MailMessage mensaje = new MailMessage
                        (
                            "caribetransporte11@gmail.com", //Correo de donde se enviara
                            _reader.GetString("correo_electronico"), //Correo a quien se le va a enviar
                            "Recuperacion de contraseña", //Asusnto del correo
                            "Estimado usuario (" + _reader.GetString("nombre") +" "+ _reader.GetString("apellidos") + "),\n\nSu usuario es: " + _reader.GetString("usuario") + " \n" +
                            "y su contraseña es: " + _reader.GetString(9) + "\n\nPor favor no sea tan olvidadiz@... Gracias! " //Contenido del correo
                        );
                    
                    //Envía el mensaje.
                    SmtpClient cliente = new SmtpClient(servidor);

                    cliente.UseDefaultCredentials = false;
                    cliente.Credentials = new System.Net.NetworkCredential("caribetransporte11@gmail.com", "proyectodeaula");
                    cliente.Port = 587;
                    cliente.Host = "smtp.gmail.com";
                    cliente.EnableSsl = true;

                    cliente.Send(mensaje);
                    MessageBox.Show("Su contraseña y usuario ha sido enviado a su correo", "Recuperacion de contraseña", MessageBoxButtons.OK);
                }

                else
                {
                    MessageBox.Show("No se encontro registro de ese numero de cc.", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtValidacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
