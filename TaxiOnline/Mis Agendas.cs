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
    public partial class Mis_Agendas : Form
    {
        public string id_persona;

        public Mis_Agendas()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DbAgendamiento.BuscarReservas(id_persona);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Mis_Agendas_Load(object sender, EventArgs e)
        {

        }
    }
}
