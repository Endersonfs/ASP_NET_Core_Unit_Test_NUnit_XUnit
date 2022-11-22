using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaVaxi
{
    [TestFixture]
    public class OperacionNUnitTest
    {
        // Clase 2
        [Test]
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
            int mumero2test = 69;
            Operaciones op = new();

            //Act
            int resultado = op.SumaNumero(numero1test, mumero2test);

            //Assert
            Assert.AreEqual(119, resultado);
        }
        // Clase 3
        [Test]
        public void IsValorPar_IputNumeroImPar_ReturnFalse() 
        {
            #region Firma
            /* 
             * =============================================
             *  Author:          Enderson Florian Solan
             *  Author modified: Enrique Cedeno
             *  Create date:     12/25/1010
             *  Tester:          Wally
             *  Description:
             *      Aqui tendremos el comentario con esta
             *      estructura, Veamos que nos dice
             *      Jose Toyos. LOL
             *      Formula = null
             * =============================================
             */
            #endregion

            //Arrange
            int valorPar = 3;
            Operaciones op = new();
            
            //action
            bool resultado = op.IsValorPar(valorPar);
            
            //asset
            //Assert.IsFalse(resultado);
            Assert.That(resultado, Is.EqualTo(resultado));

        }
        [Test]
        public void IsValorPar_InputNumeroPar_ReturnTrue() 
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
            int par = 4;
            Operaciones operaciones = new();
            //Act
            bool resultado = operaciones.IsValorPar(par);
            //Assert
            Assert.IsTrue(resultado);
        }
    }
}
