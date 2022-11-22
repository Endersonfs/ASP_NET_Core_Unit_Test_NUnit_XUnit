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
            Cliente cliente = new ();
            
            //act
            var result = cliente.CrearNombreCompleto (nombre, apellidos);
            
            //Assert
            Assert.That(result, Is.EqualTo("Enderson Florian"));
        }
        #endregion
    }
}
