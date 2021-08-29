using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class E_Rutas
    {
        private int _IdRutas;
        private string _CodigoRutas;
        private string _Ruta;
        private string _CodigoPostal;
        private string _Ciudad;

        public int IdRutas { get => _IdRutas; set => _IdRutas = value; }
        public string CodigoRutas { get => _CodigoRutas; set => _CodigoRutas = value; }
        public string Ruta { get => _Ruta; set => _Ruta = value; }
        public string CodigoPostal { get => _CodigoPostal; set => _CodigoPostal = value; }
        public string Ciudad { get => _Ciudad; set => _Ciudad = value; }
    }
}
