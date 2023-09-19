using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace UnitTestSimuParcial
{
    /// <summary>
    /// Descripción resumida de Test_conexion
    /// </summary>
    [TestClass]
    public class Test_conexion
    {
        /*
        public Test_conexion()
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
        public void TestConexion()
        {

            DAL.Conexion con = new DAL.Conexion();
            
            con.Conectar();
            Assert.IsTrue(con.Conectar().State == ConnectionState.Open);
            con.Desconectar();
            //Assert.IsTrue(con.Desconectar().State == System.Data.ConnectionState.Closed);

            
        }
    }
}
