using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using MPP;
using BE;

namespace UnitTestSimuParcial
{

    [TestClass]
    public class Test_Videojuego
    {
        public Test_Videojuego()
        {

        }
        /*
        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de las pruebas que proporciona
        ///información y funcionalidad para la serie de pruebas actual.
        ///</summary>
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
        */
       
        MPPVideojuego mpp = new MPPVideojuego();
        BE_Videojuego BE_Videojuego = new BE_Videojuego();

        [TestMethod]
        public void TestInsertarJuego()
        {
            
            BE_Videojuego.ID = 1;
            BE_Videojuego.Nombre = "Pokemon";
            BE_Videojuego.Estudio = "GameeFreak";
            BE_Videojuego.Genero = "RPG";
            mpp.InsertarVideojuego(BE_Videojuego);
            Assert.IsTrue(true);

        }
        
        [TestMethod]
        public void TestModificarJuego()
        {
            BE_Videojuego.ID = 1;
            BE_Videojuego.Nombre = "Pokemon";
            BE_Videojuego.Estudio = "GameFreak";
            BE_Videojuego.Genero = "RPG";
            mpp.ModificarVideojuego(BE_Videojuego);

        }

        [TestMethod]
        public void TestELiminarJuego()
        {
            BE_Videojuego.ID = 1;
            mpp.EliminarVideojuego(BE_Videojuego);

        }

        [TestMethod]
        public void TestListarJuego()
        {
            List<BE_Videojuego> lista_video  =  new List<BE_Videojuego>();
            lista_video =  mpp.ListarVideojuegos();

            Assert.IsTrue(lista_video.Count > 0);
            
            foreach (BE_Videojuego video in lista_video)
            {
                Console.WriteLine(video.ID);
                Console.WriteLine(video.Nombre);
                Console.WriteLine(video.Estudio);
                Console.WriteLine(video.Genero);
            }

        }


    }
}
