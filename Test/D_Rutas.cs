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
    public class D_Rutas
    {
        //Conexion base de datos
        SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ConnectionString);

        //Codigo Buscar
        public List<E_Rutas> ListarRutas(string buscar) //Error
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCARRUTAS", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            LeerFilas = cmd.ExecuteReader();

            List<E_Rutas> Listar = new List<E_Rutas>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_Rutas
                {
                    IdRutas = LeerFilas.GetInt32(0),
                    CodigoRutas = LeerFilas.GetString(1),
                    Ruta = LeerFilas.GetString(2),
                    CodigoPostal = LeerFilas.GetString(3),
                    Ciudad = LeerFilas.GetString(4)
                });
            }

            Conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        //Codigo Insertar
        public void InsertarRutas(E_Rutas Ruta)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARRUTAS", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@RUTA", Ruta.Ruta);
            cmd.Parameters.AddWithValue("@CODIGOPOSTAL", Ruta.CodigoPostal);
            cmd.Parameters.AddWithValue("@CIUDAD", Ruta.Ciudad);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        //Codigo Editar
        public void EditarRutas(E_Rutas Ruta)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARRUTAS", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@IDRUTAS", Ruta.IdRutas);
            cmd.Parameters.AddWithValue("@RUTA", Ruta.Ruta);
            cmd.Parameters.AddWithValue("@CODIGOPOSTAL", Ruta.CodigoPostal);
            cmd.Parameters.AddWithValue("@CIUDAD", Ruta.Ciudad);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        //Codigo Eliminar
        public void EliminarRutas(E_Rutas Ruta)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARRUTAS", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@IDRUTAS", Ruta.IdRutas);
            cmd.ExecuteNonQuery();
            Conexion.Close();
        }
    }
}
