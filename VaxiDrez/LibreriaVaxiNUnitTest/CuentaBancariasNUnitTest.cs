using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaVaxi
{
    [TestFixture]
    public class CuentaBancariasNUnitTest
    {
        private CuentaBancaria cuentaBancaria;

        [SetUp]
        public void SetUp()
        {
            cuentaBancaria = new CuentaBancaria(new LoggerFake());
        }

        [Test]
        public void Deposito_InputMonto100_returnTrue() 
        {
            #region Firma
            /* 
             * =============================================
             *  Author:          Enderson Florian Solan
             *  Author modified: null
             *  Create date:     null
             *  Tester:          null
             *  Description:
             *      Metodo que para depositar monto en cuenta
             *      dentro de la empresa, si se deposita retorna
             *      verdadero.
             * =============================================
             */
            #endregion

            //Arrage
            //Act
            var resultado = cuentaBancaria.Deposito(100);

            //Assert
            Assert.True(resultado);
            Assert.That(cuentaBancaria.GetBalance, Is.EqualTo(100));
        }
    }
}
