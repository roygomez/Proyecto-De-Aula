using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiOnline.Clases
{
    class Persona
    {
        private string id;
        private string nombre;
        private string apellidos;
        private string cC;
        private string fecha_Nacimiento;
        private string telefono;
        private string direccion_Residencia;
        private string ciudad_Residencia;
        private string usuario;
        private string contraseña;
        private string correo_electronico;
        private string sexo;

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string CC { get => cC; set => cC = value; }
        public string Fecha_Nacimiento { get => fecha_Nacimiento; set => fecha_Nacimiento = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion_Residencia { get => direccion_Residencia; set => direccion_Residencia = value; }
        public string Ciudad_Residencia { get => ciudad_Residencia; set => ciudad_Residencia = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Correo_electronico { get => correo_electronico; set => correo_electronico = value; }
        public string Sexo { get => sexo; set => sexo = value; }
    }
}
