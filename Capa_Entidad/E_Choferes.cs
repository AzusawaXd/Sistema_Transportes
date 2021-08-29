using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class E_Choferes
    {
        private int _IdChoferes;
        private string _CodigoChoferes;
        private string _Nombre;
        private string _Apellido;
        private string _FechaNacimiento;
        private string _Cedula;

        public int IdChoferes { get => _IdChoferes; set => _IdChoferes = value; }
        public string CodigoChoferes { get => _CodigoChoferes; set => _CodigoChoferes = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string FechaNacimiento { get => _FechaNacimiento; set => _FechaNacimiento = value; }
        public string Cedula { get => _Cedula; set => _Cedula = value; }
    }
}
