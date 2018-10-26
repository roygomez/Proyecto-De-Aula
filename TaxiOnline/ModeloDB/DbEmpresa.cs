using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiOnline.ModeloDB;
using TaxiOnline.Clases;
using TaxiOnline.DbClases;

namespace TaxiOnline.ModeloDB
{
    class DbEmpresa
    {
        //Agregando Empresa
        public static int AgregarEmp(Empresa E1)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into datosempresa (Empresa, Nit, Direccion, Telefono, Correo, Ciudad, usuario, contraseña) values ('{0}','{1}','{2}', '{3}', '{4}','{5}','{6}','{7}')",
               E1.Nombre_Empresa1, E1.Nit1, E1.Direccion_Emp1, E1.Telefono_Emp1, E1.Correo_Emp1, E1.Ciudad_Emp1, E1.Usuario_Emp1, E1.Contraseña_Emp1), DbConexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
