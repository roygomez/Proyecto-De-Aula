using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiOnline.Clases
{
    class Agendamiento

    {
        private int id;
        private string ciudad_Destino;
        private string hora_viaje;
        private string numero_ocupantes;
        private string fecha_viaje;
        private int id_persona;

        public int Id { get => id; set => id = value; }
        public string Ciudad_Destino { get => ciudad_Destino; set => ciudad_Destino = value; }
        public string Hora_viaje { get => hora_viaje; set => hora_viaje = value; }
        public string Numero_ocupantes { get => numero_ocupantes; set => numero_ocupantes = value; }
        public string Fecha_viaje { get => fecha_viaje; set => fecha_viaje = value; }
        public int Id_persona { get => id_persona; set => id_persona = value; }
    }
}
