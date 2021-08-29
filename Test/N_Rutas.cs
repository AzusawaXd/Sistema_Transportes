using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Datos;

namespace Capa_Negocio
{
    public class N_Rutas
    {
        D_Rutas objDato = new D_Rutas();
        public List<E_Rutas> ListarRutas(string buscar)
        {
            return objDato.ListarRutas(buscar);
        }
        public void InsertarRutas(E_Rutas Ruta)
        {
            objDato.InsertarRutas(Ruta);
        }

        public void EditarRutas(E_Rutas Ruta)
        {
            objDato.EditarRutas(Ruta);
        }

        public void EliminarRutas(E_Rutas Ruta)
        {
            objDato.EliminarRutas(Ruta);
        }
    }
}
