using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BE;

namespace MPP
{
    public class MPPJugador: Mapper
    {
        public void InsertarJugador(BE_Jugador jugador)
        {
            conexion.Conectar();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion.Conectar();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "InsertarJugador";
            cmd.Parameters.AddWithValue("@nombre", jugador.Nombre);
            cmd.Parameters.AddWithValue("@apellido", jugador.Apellido);
            cmd.Parameters.AddWithValue("@fechaNacimiento", jugador.FechaNacimiento);
            cmd.Parameters.AddWithValue("@usuario", jugador.Usuario);
            cmd.Parameters.AddWithValue("@id", jugador.ID);
            cmd.ExecuteNonQuery();
            conexion.Desconectar();
        }
        public void ModificarJugador(BE_Jugador jugador)
        {
            conexion.Conectar();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion.Conectar();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "ModificarJugador";
            cmd.Parameters.AddWithValue("@nombre", jugador.Nombre);
            cmd.Parameters.AddWithValue("@apellido", jugador.Apellido);
            cmd.Parameters.AddWithValue("@fechaNacimiento", jugador.FechaNacimiento);
            cmd.Parameters.AddWithValue("@usuario", jugador.Usuario);
            cmd.Parameters.AddWithValue("@id", jugador.ID);
            cmd.ExecuteNonQuery();
            conexion.Desconectar();
        }
        public void EliminarJugador(BE_Jugador jugador)
        {
            conexion.Conectar();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion.Conectar();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "EliminarJugador";
            cmd.Parameters.AddWithValue("@id", jugador.ID);
            cmd.ExecuteNonQuery();
            conexion.Desconectar();
        }
        public List<BE_Jugador> ListarJugadores()
        {
            conexion.Conectar();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion.Conectar();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "ListarJugador";
            SqlDataReader dr = cmd.ExecuteReader();
            List<BE_Jugador> listaJugadores = new List<BE_Jugador>();
            while (dr.Read())
            {
                BE_Jugador jugador = new BE_Jugador();
                jugador.ID = Convert.ToInt32(dr["id"]);
                jugador.Nombre = dr["nombre"].ToString();
                jugador.Apellido = dr["apellido"].ToString();
                jugador.FechaNacimiento = Convert.ToDateTime(dr["fechaNacimiento"]);
                jugador.Usuario = dr["usuario"].ToString();
                listaJugadores.Add(jugador);
            }
            conexion.Desconectar();
            return listaJugadores;
        }

        public void InssertarScoreJugador(BE_Jugador jugador,BE_Videojuego juego)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion.Conectar();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "InsertarScore";
            cmd.Parameters.AddWithValue("@id_jugador", jugador.ID);
            cmd.Parameters.AddWithValue("@id_juego", juego.ID);
            cmd.Parameters.AddWithValue("@score", jugador.Score);
            cmd.ExecuteNonQuery();
            conexion.Desconectar();
        }

        public List<BE_Jugador> ListarJugadoresPorScore(BE_Videojuego juego)
        {
            conexion.Conectar();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion.Conectar();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "Top3Jugadores";
            cmd.Parameters.AddWithValue("@id_juego", juego.ID);
            SqlDataReader dr = cmd.ExecuteReader();
            List<BE_Jugador> listaJugadores = new List<BE_Jugador>();
            while (dr.Read())
            {
                BE_Jugador jugador = new BE_Jugador();
                jugador.ID = Convert.ToInt32(dr["id_jugador"]);
                jugador.Score = Convert.ToInt32(dr["score"]);
                listaJugadores.Add(jugador);
            }
            conexion.Desconectar();
            return listaJugadores;
        }
    }
}
