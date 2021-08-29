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
    public class D_Autobuses
    {
        //Conexion base de datos
        SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ConnectionString);

        //Codigo Buscar
        public List<E_Autobuses> ListarAutobuses(string buscar) //Error
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCARAUTOBUSES", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            LeerFilas = cmd.ExecuteReader();

            List<E_Autobuses> Listar = new List<E_Autobuses>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_Autobuses
                {
                    IdAutobuses = LeerFilas.GetInt32(0),
                    CodigoAutobuses = LeerFilas.GetString(1),
                    Marca = LeerFilas.GetString(2),
                    Modelo = LeerFilas.GetString(3),
                    Placa = LeerFilas.GetString(4),
                    Color = LeerFilas.GetString(5),
                    Año = LeerFilas.GetString(6)
                });
            }

            Conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        //Codigo Insertar
        public void InsertarAutobuses(E_Autobuses Autobuse)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARAUTOBUSES", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@MARCA", Autobuse.Marca);
            cmd.Parameters.AddWithValue("@MODELO", Autobuse.Modelo);
            cmd.Parameters.AddWithValue("@PLACA", Autobuse.Placa);
            cmd.Parameters.AddWithValue("@COLOR", Autobuse.Color);
            cmd.Parameters.AddWithValue("@AÑO", Autobuse.Año);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        //Codigo Editar
        public void EditarAutobuses(E_Autobuses Autobuse)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARAUTOBUSES", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@IDAUTOBUSES", Autobuse.IdAutobuses);
            cmd.Parameters.AddWithValue("@MARCA", Autobuse.Marca);
            cmd.Parameters.AddWithValue("@MODELO", Autobuse.Modelo);
            cmd.Parameters.AddWithValue("@PLACA", Autobuse.Placa);
            cmd.Parameters.AddWithValue("@COLOR", Autobuse.Color);
            cmd.Parameters.AddWithValue("@AÑO", Autobuse.Año);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        //Codigo Eliminar
        public void EliminarAutobuses(E_Autobuses Autobuse)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARCHOFERES", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@IDCHOFERES", Autobuse.IdAutobuses);
            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

    }
}
