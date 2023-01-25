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
        private Operaciones  op= new Operaciones();

        //Configuracion
        [SetUp]
        public void SetUp()
        {
            op = new Operaciones();
        }
        #region Clase 2
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
        #endregion

        #region Clase 3

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
            
            //action
            bool resultado = op.IsValorPar(valorPar);

            //asset
            Assert.IsFalse(resultado);
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

        #region metodos con parametros
        [Test]
        [TestCase("Enderson")]
        [TestCase("Jose")]
        //[TestCase("Jose","Paul")]
        public void IsDeveloperOfPhoenix_InputNombre_ReturnTrue(string nombreDevelper)
        {

            #region Firma
            /* 
             * =============================================
             *  Author:          Enderson Florian Solan
             *  Author modified: null
             *  Create date:     11/22/2022
             *  Tester:          null
             *  Description:
             *      Metodo que identifica si es un programador
             *      dentro de la empresa, si existe pues retorna 
             *      verdadero.
             * =============================================
             */
            #endregion

            //Arrage
            Operaciones op = new();
            //Act
            var resultado = op.IsDeveloperOfPhoenix(nombreDevelper);
            //Assert
            Assert.IsTrue(resultado);

        }
        #endregion

        #region Metodos que retonan valor - ExpectedResult
        [Test]
        [TestCase(3, ExpectedResult = false)]
        [TestCase(4, ExpectedResult = true)]
        [TestCase(7, ExpectedResult = false)]
        public bool IsValorPar_InputNumero_ReturnFalse(int numero)
        {
            #region Firma
            /* 
             * =============================================
             *  Author:          Enderson Florian Solan
             *  Author modified: null
             *  Create date:     11/22/2022
             *  Tester:          null
             *  Description:
             *      Metodo para validar si el numero es 
             *      par o  impar.
             * =============================================
             */
            #endregion
            //Arrange
            Operaciones op = new();

            //Action
            return op.IsValorPar(numero);

            //Assert
        }
        #endregion

        #region Operaciones con decimales
        [Test]
        [TestCase(2.5,2.54)]
        public void SumarDecimal_InputDosNumeros_GetValorCorrecto(double decima1, double decimal2) 
        {
            #region Firma
            /* 
             * =============================================
             *  Author:          Enderson Florian Solan
             *  Author modified: null
             *  Create date:     11/22/2022
             *  Tester:          null
             *  Description:
             *     Metodo que suma sumeros de coma 
             *     flotantes, (2.5 + 2.5 = 5)
             * =============================================
             */
            #endregion
            //Arrange
            Operaciones op = new ();

            //Action
            var result = op.SumarDecimal(decima1, decimal2);
            
            //Assert
            Assert.AreEqual(5.04, result);

        }
        #endregion

        #endregion

        #region Clase4
        [Test]
        public void GetListaNumeroImpares_InputMinimoMaxinoIntervalos_ReturnListaImpares()
        {
            //Arrange           
            List<int> numeroImparesEsperados = new() {5,7,9 };

            //Act
            List<int> result = op.GetListaNumeroImpares(5, 10);

            //Assert
            //-- Comparando lista
            Assert.That(result, Is.EquivalentTo(numeroImparesEsperados)); 
            Assert.AreEqual(numeroImparesEsperados, new List<int> {5,7,9 }); 
            Assert.AreEqual(numeroImparesEsperados, result);

            //evaluar si un  elemento esta en la collection
            Assert.That(result, Does.Contain(5));

            //evaluar su un elemento no esta en la lista
            Assert.That(result, Has.No.Member(100));
            //Assert.That(result, Has.No.Member(7));//codigo de error
            
            //evaluando si esta vacio
            Assert.That(result, Is.Not.Empty);

            //contar los elementos
            Assert.That(result.Count, Is.EqualTo(3));

            //evaluar si estan organizados
            Assert.That(result, Is.Ordered.Ascending);
            //Assert.That(result, Is.Ordered.Descending);//error 

            //var si tenemos valore duplicados
            Assert.That(result, Is.Unique);

            //rango de intervalo 

        }
        #endregion
    }
}
