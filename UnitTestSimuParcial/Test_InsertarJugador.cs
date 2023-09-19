using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using MPP;

namespace UnitTestSimuParcial
{

    [TestClass]
    public class Test_InsertarJugador
    {
        /*
        public Test_InsertarJugador()
        {
           
        }

        private TestContext testContextInstance;
 
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        */

        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestInsertarJugador()
        {
            MPPJugador mpp = new MPPJugador();
            BE.BE_Jugador jugador = new BE.BE_Jugador();
            jugador.Nombre = "Gaston";
            jugador.Apellido = "Solis";
            jugador.FechaNacimiento = DateTime.Now;
            jugador.Usuario = "GSolis";
            jugador.ID = 5;

            mpp.InsertarJugador(jugador);
            Assert.IsTrue(true);
       
        }

        [TestMethod]
        public void TestListarJugadores()
        {
            MPPJugador mpp = new MPPJugador();
            List<BE.BE_Jugador> jugadores = new List<BE.BE_Jugador>();
            jugadores = mpp.ListarJugadores();
            Assert.IsTrue(jugadores.Count > 0);
            foreach (BE.BE_Jugador jugador in jugadores)
            {
                Console.WriteLine(jugador.Nombre);
                Console.WriteLine(jugador.Apellido);
                Console.WriteLine(jugador.FechaNacimiento);
                Console.WriteLine(jugador.Usuario);
                Console.WriteLine(jugador.ID);
            }
            
        }

        [TestMethod]
        public void TestModificarJugador()
        {
            MPPJugador mpp = new MPPJugador();
            BE.BE_Jugador jugador = new BE.BE_Jugador();
            jugador.Nombre = "Antonio";
            jugador.Apellido = "Solis";
            jugador.FechaNacimiento = DateTime.Now;
            jugador.Usuario = "ASolis";
            jugador.ID = 5;
            mpp.ModificarJugador(jugador);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestEliminarJugador()
        {
            MPPJugador mpp = new MPPJugador();
            BE.BE_Jugador jugador = new BE.BE_Jugador();
            jugador.ID = 5;
            mpp.EliminarJugador(jugador);
            Assert.IsTrue(true);
        }
    }
}
