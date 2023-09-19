using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BE;

namespace MPP
{
    public class MPPVideojuego:Mapper
    {
        public void InsertarVideojuego(BE_Videojuego videojuego)
        {
            conexion.Conectar();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion.Conectar();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "InsertarVideojuego";
            cmd.Parameters.AddWithValue("@id", videojuego.Nombre);
            cmd.Parameters.AddWithValue("@nombre", videojuego.Nombre);
            cmd.Parameters.AddWithValue("@estudio", videojuego.Estudio);
            cmd.Parameters.AddWithValue("@genero", videojuego.Genero);
            cmd.ExecuteNonQuery();
            conexion.Desconectar();
        }
        public void ModificarVideojuego(BE_Videojuego videojuego)
        {
            conexion.Conectar();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection  = conexion.Conectar();
            cmd.CommandType= System.Data.CommandType.StoredProcedure;
            cmd.CommandText  = "ModificarVideojuego";
            cmd.Parameters.AddWithValue("@id", videojuego.Nombre);
        }
        public void EliminarVideojuego(BE_Videojuego videojuego)
        {
            conexion.Conectar() ;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion.Conectar();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "EliminarVideojuego";
            cmd.Parameters.AddWithValue("@id", videojuego.ID);
            cmd.ExecuteNonQuery();
            conexion.Desconectar();
            
        }
        public List<BE_Videojuego> ListarVideojuegos()
        {
            conexion.Conectar();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion.Conectar();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "ListarVideojuego";
            SqlDataReader dr = cmd.ExecuteReader();
            List<BE_Videojuego> listaVideojuegos = new List<BE_Videojuego>();
            while (dr.Read())
            {
                BE_Videojuego videojuego = new BE_Videojuego();
                videojuego.ID = Convert.ToInt32(dr["id"]);
                videojuego.Nombre = dr["nombre"].ToString();
                videojuego.Estudio = dr["estudio"].ToString();
                videojuego.Genero = dr["genero"].ToString();
                listaVideojuegos.Add(videojuego);
            }
            conexion.Desconectar();
            return listaVideojuegos;
        }



    }
}
