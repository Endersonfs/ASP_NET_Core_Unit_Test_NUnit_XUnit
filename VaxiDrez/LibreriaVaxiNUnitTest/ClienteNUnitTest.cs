using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaVaxi
{
    [TestFixture]
    public class ClienteNUnitTest
    {
        private Cliente cliente;

        //Configuracion global
        [SetUp]
        public void Setup()
        {
            cliente = new Cliente();
        }

        #region Clase 3
        [Test]
        [TestCase("Enderson", "Florian")]
        public void CrearNombreCompleto_InputNombreApellido_ReturnNombreCompleto(string nombre, string apellidos)
        {
            #region Firma
            /* 
             * =============================================
             *  Author:          Enderson Florian Solan
             *  Author modified: null
             *  Create date:     11/22/2022
             *  Tester:          null
             *  Description:
             *      Metodo para validar que el nombre esta 
             *      completo, colocamos los parametros y 
             *      al  final comparamos con  una variable.
             * =============================================
             */
            #endregion

            //Arrange


            //act
            cliente.CrearNombreCompleto(nombre, apellidos);

            //Assert
            Assert.AreEqual(cliente.ClienteNombre, "Enderson Florian");

            Assert.That(cliente.ClienteNombre, Is.EqualTo("Enderson Florian"));
            Assert.That(cliente.ClienteNombre, Does.Contain("Enderson"));
            Assert.That(cliente.ClienteNombre , Does.StartWith("en").IgnoreCase);
            Assert.That(cliente.ClienteNombre, Does.EndWith("n"));
          
        }
        [Test]
        public void ClienteNombre_NoValue_ReturnNull() 
        {
            Cliente cliente = new ();

            //da error porque no retorna  null
            //var result = cliente.CrearNombreCompleto("Vaxi", "Drez");

            Assert.Null(cliente.ClienteNombre);
            
           
        }
        #endregion
    }
}
