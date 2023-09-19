using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Videojuego
    {
		private int id;

		public int ID
		{	
			get { return id; }
			set { id = value; }
		}

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private string estudio;

		public string Estudio
		{
			get { return estudio; }
			set { estudio = value; }
		}

		private string genero;

		public string Genero
		{
			get { return genero; }
			set { genero = value; }
		}



	}
}
