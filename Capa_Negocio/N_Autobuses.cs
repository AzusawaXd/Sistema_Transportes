using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Datos;

namespace Capa_Negocio
{
    public class N_Autobuses
    {
        D_Autobuses objDato = new D_Autobuses();
        public List<E_Autobuses> ListarAutobuses(string buscar)
        {
            return objDato.ListarAutobuses(buscar);
        }
        public void InsertarAutobuses(E_Autobuses Autobuse)
        {
            objDato.InsertarAutobuses(Autobuse);
        }

        public void EditarAutobuses(E_Autobuses Autobuse)
        {
            objDato.EditarAutobuses(Autobuse);
        }

        public void EliminarAutobuses(E_Autobuses Autobuse)
        {
            objDato.EliminarAutobuses(Autobuse);
        }
    }
}
