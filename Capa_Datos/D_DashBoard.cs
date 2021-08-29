using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Capa_Entidad;

namespace Capa_Datos
{
    public class D_DashBoard
    {
        //Conexion base de datos
        SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ConnectionString);


        public DataTable ListRutas()
        {
            DataTable table = new DataTable();
            SqlDataReader readRows;
            SqlCommand cmd = new SqlCommand("SP_LISTRUTAS", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            readRows = cmd.ExecuteReader();
            table.Load(readRows);

            readRows.Close();
            Conexion.Close();

            return table;
        }

        public DataTable BuscarRutas(E_DashBoard Ruta)
        {
            DataTable Table = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_BUSCARRUTAS", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", Ruta.Search);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(Table);

            Conexion.Close();
            return Table;
        }

        public void EliminarRutas(int id)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARRUTAS", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@IDRUTAS", id);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void InsertarRutas(E_DashBoard Ruta)
        {

            SqlCommand cmd = new SqlCommand("SP_INSERTARRUTAS", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@RUTA", Ruta.Ruta);
            cmd.Parameters.AddWithValue("@CIUDAD", Ruta.Ciudad);
            cmd.Parameters.AddWithValue("@FECHA", Ruta.Fecha);
            cmd.Parameters.AddWithValue("@IDCHOFERES", Ruta.IdChoferes);
            cmd.Parameters.AddWithValue("@IDAUTOBUSES", Ruta.IdAutobuses);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void EditarRutas(E_DashBoard Ruta)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARRUTAS", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@RUTA", Ruta.Ruta);
            cmd.Parameters.AddWithValue("@CIUDAD", Ruta.Ciudad);
            cmd.Parameters.AddWithValue("@FECHA", Ruta.Fecha);
            cmd.Parameters.AddWithValue("@IDCHOFERES", Ruta.IdChoferes);
            cmd.Parameters.AddWithValue("@IDAUTOBUSES", Ruta.IdAutobuses);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        public void MostrarConteo(E_DashBoard Ruta) 
        {
            SqlCommand cmd = new SqlCommand("ACUMULACION", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter total_choferes = new SqlParameter("@TOTAL_CHOFERES", 0);
            total_choferes.Direction = ParameterDirection.Output;

            SqlParameter total_autobuses = new SqlParameter("@TOTAL_AUTOBUSES", 0);
            total_autobuses.Direction = ParameterDirection.Output;

            SqlParameter total_rutas = new SqlParameter("@TOTAL_RUTAS", 0);
            total_rutas.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(total_choferes);
            cmd.Parameters.Add(total_autobuses);
            cmd.Parameters.Add(total_rutas);
            Conexion.Open();

            cmd.ExecuteNonQuery();

            Ruta.Total_choferes = cmd.Parameters["@TOTAL_CHOFERES"].Value.ToString();
            Ruta.Total_autobuses = cmd.Parameters["@TOTAL_AUTOBUSES"].Value.ToString();
            Ruta.Total_rutas = cmd.Parameters["@TOTAL_RUTAS"].Value.ToString();

            Conexion.Close();
        }
    }
}
