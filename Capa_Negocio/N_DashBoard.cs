using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using Capa_Datos;
using System.Data;

namespace Capa_Negocio
{
    public class N_DashBoard
    {
        D_DashBoard objDato = new D_DashBoard();
        E_DashBoard objEntidad = new E_DashBoard();

        public DataTable ListingRutas() 
        {
            return objDato.ListRutas();
        }

        public DataTable SearchingRutas(string search)
        {
            objEntidad.Search = search;
            return objDato.BuscarRutas(objEntidad);
        }
        public void InsertarRutas(E_DashBoard Ruta)
        {
            objDato.InsertarRutas(Ruta);
        }

        public void EditarRutas(E_DashBoard Ruta)
        {
            objDato.EditarRutas(Ruta);
        }

        public void EliminarRutas(int id)
        {
            objDato.EliminarRutas(id);
        }

        public void ACUMULACIONES(E_DashBoard Ruta) 
        {
            objDato.MostrarConteo(Ruta);
        }

    }
}
