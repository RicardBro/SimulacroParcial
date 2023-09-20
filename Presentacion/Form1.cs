using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;


namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CargarUsuario_Click(object sender, EventArgs e)
        {
            BE_Jugador bejugador = new BE_Jugador();
            bejugador.Nombre = TxbNomJug.Text;
            bejugador.Apellido = TxBApellido.Text;
            bejugador.FechaNacimiento = Convert.ToDateTime(TxBFechaNacimiento.Text);
            bejugador.Usuario = TxBUsuario.Text;
            bejugador.ID = int.Parse(TxBIDUsuario.Text);

            Jugador jugador = new Jugador();
            jugador.IngresarJuador(bejugador);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void ModUser_Click(object sender, EventArgs e)
        {
            BE_Jugador bejugador = new BE_Jugador();
            bejugador.Nombre = TxbNomJug.Text;
            bejugador.Apellido = TxBApellido.Text;
            bejugador.FechaNacimiento = Convert.ToDateTime(TxBFechaNacimiento.Text);
            bejugador.Usuario = TxBUsuario.Text;
            bejugador.ID = int.Parse(TxBIDUsuario.Text);

            Jugador jugador = new Jugador();
            jugador.ModificarJugador(bejugador);
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            BE_Jugador bejugador = new BE_Jugador();
            bejugador.ID = int.Parse(TxBIDUsuario.Text);
            Jugador jugador = new Jugador();
            jugador.EliminarJugador(bejugador);
        }

        private void ListarUsuarios_Click(object sender, EventArgs e)
        {
            Jugador jugador = new Jugador();
            listBoxUser.Items.Clear();
            foreach (BE_Jugador item in jugador.ListarJugadores())
            {
                listBoxUser.Items.Add(item.Nombre + " " + item.Apellido + " " + item.FechaNacimiento + " " + item.Usuario + " " + item.ID);
            }
        }

        private void CargarVideojuego_Click(object sender, EventArgs e)
        {
            BE_Videojuego bE_Videojuego = new BE_Videojuego();
            bE_Videojuego.Nombre = TxBNombreVideojueego.Text;
            bE_Videojuego.Estudio = TxBEstudioVideojueego.Text;
            bE_Videojuego.Genero = TxBGeneroVideojueego.Text;
            bE_Videojuego.ID = int.Parse(TxBIDVideojueego.Text);
            Videojuego videojuego = new Videojuego();
            videojuego.IngresarVideojuego(bE_Videojuego);

        }

        private void ModJuego_Click(object sender, EventArgs e)
        {
            BE_Videojuego bE_Videojuego = new BE_Videojuego();
            bE_Videojuego.Nombre = TxBNombreVideojueego.Text;
            bE_Videojuego.Estudio = TxBEstudioVideojueego.Text;
            bE_Videojuego.Genero = TxBGeneroVideojueego.Text;
            bE_Videojuego.ID = int.Parse(TxBIDVideojueego.Text);
            Videojuego videojuego = new Videojuego();
            videojuego.ModificarVideojuego(bE_Videojuego);
        }

        private void DeleteJuego_Click(object sender, EventArgs e)
        {
            BE_Videojuego bE_Videojuego = new BE_Videojuego();
            bE_Videojuego.ID = int.Parse(TxBIDVideojueego.Text);
            Videojuego videojuego = new Videojuego();
            videojuego.EliminarVideojuego(bE_Videojuego);
        }

        private void ListarVideojuegos_Click(object sender, EventArgs e)
        {
            Videojuego videojuego = new Videojuego();
            listBoxVideojuego.Items.Clear();
            foreach (BE_Videojuego item in videojuego.ListarVideojuegos())
            {
                listBoxVideojuego.Items.Add(item.Nombre + " " + item.Estudio + " " + item.Genero + " " + item.ID);
            }
        }

        private void CargarScore_Click(object sender, EventArgs e)
        {
            BE_Jugador bE_Jugador = new BE_Jugador();
            bE_Jugador.ID = int.Parse(IDJuegadorInsertScore.Text);
            BE_Videojuego bE_Videojuego = new BE_Videojuego();
            bE_Videojuego.ID = int.Parse(IDJuegoInsertScore.Text);
            bE_Jugador.Score = int.Parse(ScoreJugador.Text);
            Jugador jugador = new Jugador();
            jugador.IngresarScore(bE_Jugador, bE_Videojuego);
        }

        private void ListarTopUsers_Click(object sender, EventArgs e)
        {
            Jugador jugador = new Jugador();
            BE_Videojuego bE_Videojuego = new BE_Videojuego();
            bE_Videojuego.ID = int.Parse(IDJuegoInsertScore.Text);
            listBoxTopUsers.Items.Clear();
            foreach (BE_Jugador item in jugador.ListarJugadoresScore(bE_Videojuego))
            {
                listBoxTopUsers.Items.Add(item.ID + "-----" + item.Score);
            }
        }
    }
}
