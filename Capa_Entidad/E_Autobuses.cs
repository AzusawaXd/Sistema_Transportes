using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class E_Autobuses
    {
        private int _IdAutobuses;
        private string _CodigoAutobuses;
        private string _Marca;
        private string _Modelo;
        private string _Placa;
        private string _Color;
        private string _Año;

        public int IdAutobuses { get => _IdAutobuses; set => _IdAutobuses = value; }
        public string CodigoAutobuses { get => _CodigoAutobuses; set => _CodigoAutobuses = value; }
        public string Marca { get => _Marca; set => _Marca = value; }
        public string Modelo { get => _Modelo; set => _Modelo = value; }
        public string Placa { get => _Placa; set => _Placa = value; }
        public string Color { get => _Color; set => _Color = value; }
        public string Año { get => _Año; set => _Año = value; }
    }
}
