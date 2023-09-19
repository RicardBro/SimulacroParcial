using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DAL
{
    public class Conexion
    {
        public Conexion()
        {

        }

        private SqlConnection conexion;

        public SqlConnection Conectar()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=(Local);Initial Catalog=SimuParcial;Integrated Security=True";
            conexion.Open();
            return conexion;
        }
        
        public void Desconectar()
        {
            conexion.Close();
            conexion.Dispose();
            conexion=null;
            GC.Collect();
           
        }



    }
}
