using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;

namespace MPP
{
    public abstract class Mapper
    {
        internal DAL.Conexion conexion;
        public Mapper()
        {
            conexion = new DAL.Conexion();
        }



    }
}
