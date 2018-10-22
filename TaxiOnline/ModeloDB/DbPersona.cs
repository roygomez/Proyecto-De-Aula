using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiOnline.Clases;

namespace TaxiOnline.DbClases
{
    class DbPersona
    {
        //Agregando Persona
        public static int Agregar(Persona p1)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into datos (nombre, apellidos, cc, fecha_nacimineto, telefono, direccion_residencia, ciudad_residencia, usuario, contraseña, correo_electronico, sexo) values ('{0}','{1}','{2}', '{3}', '{4}','{5}','{6}','{7}','{8}', '{9}', '{10}')",
               p1.Nombre, p1.Apellidos, p1.CC, p1.Fecha_Nacimiento, p1.Telefono, p1.Direccion_Residencia, p1.Ciudad_Residencia, p1.Usuario, p1.Contraseña, p1.Correo_electronico, p1.Sexo), DbConexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
