using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;

namespace BLL
{
    public class Jugador
    {
        public void IngresarJuador(BE_Jugador jugador)
        {
            MPPJugador mPPJugador = new MPPJugador();
            mPPJugador.InsertarJugador(jugador);
        }

        public void ModificarJugador(BE_Jugador jugador)
        {
            MPPJugador mPPJugador = new MPPJugador();
            mPPJugador.ModificarJugador(jugador);

        }

        public void EliminarJugador(BE_Jugador jugador)
        {
            MPPJugador mPPJugador = new MPPJugador();
            mPPJugador.EliminarJugador(jugador);
        }

        public List<BE_Jugador> ListarJugadores()
        {
            return new MPPJugador().ListarJugadores();
        }

        public void IngresarScore(BE_Jugador jugador, BE_Videojuego videojuego)
        {
            MPPJugador mPPJugador = new MPPJugador();
            mPPJugador.InssertarScoreJugador(jugador,videojuego);
        }

        public List<BE_Jugador> ListarJugadoresScore(BE_Videojuego videojuego)
        {
            MPPJugador mp = new MPPJugador();
            return mp.ListarJugadoresPorScore(videojuego);
        }

    }
}
