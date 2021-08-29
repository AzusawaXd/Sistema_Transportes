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
    public class D_Choferes
    {
        //Conexion base de datos
        SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ConnectionString);

        //Codigo Buscar
        public List<E_Choferes> ListarChoferes(string buscar) //Error
        {
            SqlDataReader LeerFilas;
            SqlCommand cmd = new SqlCommand("SP_BUSCARCHOFERES", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", buscar);
            LeerFilas = cmd.ExecuteReader();

            List<E_Choferes> Listar = new List<E_Choferes>();
            while (LeerFilas.Read())
            {
                Listar.Add(new E_Choferes
                {
                    IdChoferes = LeerFilas.GetInt32(0),
                    CodigoChoferes = LeerFilas.GetString(1),
                    Nombre = LeerFilas.GetString(2),
                    Apellido = LeerFilas.GetString(3),
                    FechaNacimiento = LeerFilas.GetString(4),
                    Cedula = LeerFilas.GetString(5)
                });
            }

            Conexion.Close();
            LeerFilas.Close();
            return Listar;
        }

        //Codigo Insertar
        public void InsertarChoferes(E_Choferes Chofere)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARCHOFERES", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@NOMBRE", Chofere.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", Chofere.Apellido);
            cmd.Parameters.AddWithValue("@FECHANACIMIENTO", Chofere.FechaNacimiento);
            cmd.Parameters.AddWithValue("@CEDULA", Chofere.Cedula);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        //Codigo Editar
        public void EditarChoferes(E_Choferes Chofere)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARCHOFERES", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@IDCHOFERES", Chofere.IdChoferes);
            cmd.Parameters.AddWithValue("@NOMBRE", Chofere.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", Chofere.Apellido);
            cmd.Parameters.AddWithValue("@FECHANACIMIENTO", Chofere.FechaNacimiento);
            cmd.Parameters.AddWithValue("@CEDULA", Chofere.Cedula);

            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        //Codigo Eliminar
        public void EliminarChoferesa(E_Choferes Chofere)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARCHOFERES", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();

            cmd.Parameters.AddWithValue("@IDCHOFERES", Chofere.IdChoferes);
            cmd.ExecuteNonQuery();
            Conexion.Close();
        }

        //Totales agregados
        public void Totals(E_Choferes Chofere)
        {
            //SqlCommand cmd = new SqlCommand("Acumulacion", Conexion);
            //cmd.CommandType = CommandType.StoredProcedure;

            //SqlParameter Total_Choferes = new SqlParameter("@Total_Choferes", 0);
            //Total_Choferes.Direction = ParameterDirection.Output;

            //cmd.Parameters.Add(Total_Choferes);
            //Conexion.Open();

            //Chofere.Total_Choferes = cmd.Parameters["@Total_Choferes"].Value.ToString();
            //cmd.ExecuteNonQuery();
            //Conexion.Close();
        }
    }
}
