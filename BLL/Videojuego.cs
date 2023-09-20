using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Videojuego
    {
        public void IngresarVideojuego(BE_Videojuego videojuego)
        {
            MPPVideojuego mPPVideojuego = new MPPVideojuego();
            mPPVideojuego.InsertarVideojuego(videojuego);
        }

        public void ModificarVideojuego(BE_Videojuego videojuego)
        {
            MPPVideojuego mPPVideojuego = new MPPVideojuego();
            mPPVideojuego.ModificarVideojuego(videojuego);

        }

        public void EliminarVideojuego(BE_Videojuego videojuego)
        {
            MPPVideojuego mPPVideojuego = new MPPVideojuego();
            mPPVideojuego.EliminarVideojuego(videojuego);
        }

        public List<BE_Videojuego> ListarVideojuegos()
        {
            return new MPPVideojuego().ListarVideojuegos();
        }


    }
}
