using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Linq;
using Sistema;

namespace UnitTestProject1
{
    /// <summary>
    /// Descripción resumida de UnitTestUnidadMedida
    /// </summary>
    [TestClass]
    public class UnitTestUnidadMedida
    {
        public UnitTestUnidadMedida()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }

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

        [TestMethod]
        public void TestGuardar()
        {
            //
            // TODO: Agregar aquí la lógica de las pruebas
            //

            unidad_medida um = new unidad_medida();
            um.codigo = "PL";
            um.descripcion = "PALETA GORDO TEST";
            um.creado_el = DateTime.Today;
            um.modificado_el = null;
            um.eliminado_el = null;
            costeoEntities db = new costeoEntities();
            db.unidad_medida.Add(um);
            db.SaveChanges();

            costeoEntities dbum = new costeoEntities();

            Boolean encontrado = false;            
            foreach (var dato in dbum.unidad_medida.ToList())
            {
                if (dato.descripcion == "PALETA GORDO TEST")
                {
                    encontrado = true;
                    
                }
            }


            Assert.AreEqual(true, encontrado);


        }
    }
}
