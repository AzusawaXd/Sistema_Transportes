using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Datos;

namespace Capa_Negocio
{
    public class N_Choferes
    {
        D_Choferes objDato = new D_Choferes();
        public List<E_Choferes> ListarChoferes(string buscar)
        {
            return objDato.ListarChoferes(buscar);
        }
        public void InsertarChoferes(E_Choferes Chofere)
        {
            objDato.InsertarChoferes(Chofere);
        }

        public void EditarChoferes(E_Choferes Chofere)
        {
            objDato.EditarChoferes(Chofere);
        }

        public void EliminarChoferesa(E_Choferes Chofere)
        {
            objDato.EliminarChoferesa(Chofere);
        }
    }
}
