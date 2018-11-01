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
    public partial class DatosDeUsuarios : Form
    {
        public DatosDeUsuarios()
        {
            InitializeComponent();
            dgvDatosUsuarios.DataSource = DbAgendamiento.BuscarReservas();
        }

        // Boton BUSCAR PERSONA
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Boton CERRAR SESION ADMINISTRADOR
        private void btnCerrarSesionAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Boton BUSCAR EMPRESA
        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
