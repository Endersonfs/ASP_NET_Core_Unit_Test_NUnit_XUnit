using LibreriaVaxi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaVaxiMSTest
{
    [TestClass]
    public class OperacionMSTest
    {
        [TestMethod]
        public void SumaNumeros_InputDosNumero_GetValorCorrecto()
        {
            #region Firma
            /* 
             * =============================================
             *  Author:          Enderson Florian Solan
             *  Author modified: Leilan Alcantara
             *  Create date:     12/25/1010
             *  Tester:          Wally
             *  Description:
             *      Aqui tendremos el comentario con esta
             *      estructura, Veamos que nos dice
             *      Jose Toyos. LOL
             *      Formula (A + B) = C
             * =============================================
             */
            #endregion

            //Arrange
            //inicializacion de los objetos y variables que ejecuta el test
            int numero1test = 50;
            int mumero2test = 50;
            Operaciones op = new ();

            //Act
            int resultado = op.SumaNumero(numero1test, mumero2test);

            //Assert
            Assert.AreEqual(100, resultado);
        }
    }
}
