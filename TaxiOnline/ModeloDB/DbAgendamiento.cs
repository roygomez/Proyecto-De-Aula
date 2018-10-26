using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiOnline.DbClases;

namespace TaxiOnline.ModeloDB
{
    class DbAgendamiento
    {
        // Agregar reservas
        public static int NuevaReserva(Clases.Agendamiento A1)
        {
            int Retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("INSERT into agendamientopersonal (ciudad_Destino, hora_viaje, numero_ocupantes, fecha_viaje, id_persona) values ('{0}','{1}','{2}', '{3}', '{4}')",
                A1.Ciudad_Destino,A1.Hora_viaje,A1.Numero_ocupantes,A1.Fecha_viaje,A1.Id_persona), DbConexion.ObtenerConexion());

            Retorno = comando.ExecuteNonQuery();

            return Retorno;
        }

        public static List<Clases.Agendamiento> BuscarReservas(string id_persona)
        {
            List<Clases.Agendamiento> _lista = new List<Clases.Agendamiento>();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT * FROM agendamientopersonal WHERE id_persona='"+id_persona+"'"), DbConexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Clases.Agendamiento A1 = new Clases.Agendamiento();
                A1.Id = _reader.GetInt32(0);
                A1.Fecha_viaje = _reader.GetString("fecha_viaje");
                A1.Hora_viaje = _reader.GetString("hora_viaje");
                A1.Numero_ocupantes = _reader.GetString("numero_ocupantes");
                A1.Ciudad_Destino = _reader.GetString("ciudad_Destino");


                _lista.Add(A1);
            }

            return _lista;
        }

    }
}
