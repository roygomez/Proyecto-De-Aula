using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxiOnline.ModeloDB;

namespace TaxiOnline
{
    public partial class Agendamiento : Form
    {
        public Agendamiento()
        {
            InitializeComponent();
        }

        public int id_persona;

        private void label1_Click(object sender, EventArgs e)
        {

        }


        //Boton AGENDAR Reservas
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Clases.Agendamiento A1 = new Clases.Agendamiento();

                A1.Ciudad_Destino = cmbDestino.Text;
                A1.Fecha_viaje = dtmFechaViaje.Text;
                A1.Hora_viaje = txtHoraViaje.Text;
                A1.Numero_ocupantes = txtOcupantes.Text;
                A1.Id_persona = id_persona;


                int Resultado = DbAgendamiento.NuevaReserva(A1);

                if (Resultado > 0)
                {
                    MessageBox.Show("Su Viaje ha sido agendado con exito", "Exito", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error al agendar");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            txtHoraViaje.Clear();
            txtOcupantes.Clear();
            cmbDestino.Text = "Seleccione";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        // Boton LIMPIAR Datos Ventana de Agendamiento
        private void button2_Click(object sender, EventArgs e)
        {
            txtHoraViaje.Clear();
            txtOcupantes.Clear();
            cmbDestino.Text = "Seleccione";
            
        }

        private void Agendamiento_Load(object sender, EventArgs e)
        {

        }


        // Boton Mostrar EL NUMERO DE AGENDAS DE UN USUSRIO
        private void btnMisAgendas_Click(object sender, EventArgs e)
        {
            Mis_Agendas Agendas = new Mis_Agendas();
            Agendas.id_persona = lblid_persona.Text;
            
            Agendas.dataGridView1.DataSource = DbAgendamiento.BuscarReservas(Agendas.id_persona);
            Agendas.dataGridView1.Columns["id"].Visible = true;
            Agendas.dataGridView1.Columns["id_persona"].Visible = false;
            this.Hide();
            Agendas.ShowDialog();
            this.Show();
        }


        //Boton CERRAR SESION Usuarios
        private void btnCerrarSesionUsu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHoraViaje_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
