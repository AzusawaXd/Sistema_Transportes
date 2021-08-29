using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class E_DashBoard
    {
        private int _IdRutas;
        private string _CodigoRutas;
        private string _Ruta;
        private string _Ciudad;
        private string _Fecha;
        private int _IdChoferes;
        private int _IdAutobuses;
        private string search;

        private string total_choferes;
        private string total_autobuses;
        private string total_rutas;

        public int IdRutas { get => _IdRutas; set => _IdRutas = value; }
        public string CodigoRutas { get => _CodigoRutas; set => _CodigoRutas = value; }
        public string Ruta { get => _Ruta; set => _Ruta = value; }
        public string Ciudad { get => _Ciudad; set => _Ciudad = value; }
        public string Fecha { get => _Fecha; set => _Fecha = value; }
        public int IdChoferes { get => _IdChoferes; set => _IdChoferes = value; }
        public int IdAutobuses { get => _IdAutobuses; set => _IdAutobuses = value; }
        public string Search { get => search; set => search = value; }

        public string Total_choferes { get => total_choferes; set => total_choferes = value; }
        public string Total_autobuses { get => total_autobuses; set => total_autobuses = value; }
        public string Total_rutas { get => total_rutas; set => total_rutas = value; }
    }
}
