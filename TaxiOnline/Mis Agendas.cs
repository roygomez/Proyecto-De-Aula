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
using MySql.Data.MySqlClient;

namespace TaxiOnline
{
    public partial class Mis_Agendas : Form
    {
        public string id_persona;

        public Mis_Agendas()
        {
            InitializeComponent();
        }

        BaseDeDatos bd = new BaseDeDatos();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DbAgendamiento.BuscarReservas(id_persona);
        }
        
        private void Mis_Agendas_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrarAgenda_Click(object sender, EventArgs e)
        {
            string CancelarAgenda = "delete from agendamientopersonal where id=" + txtIdAgendas.Text;

            if (bd.executecommand(CancelarAgenda))
            {
                MessageBox.Show(" Agenda Cancelada");
                dataGridView1.DataSource = bd.SelectDataTable("select * from agendamientopersonal where id_persona='"+ id_persona + "'");
            }
            else
            {
                MessageBox.Show("No Se Pudo Cancelar Agenda");
            }
        }
    }
}
