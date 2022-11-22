using System.Reflection.Metadata.Ecma335;

namespace LibreriaVaxi
{
    public class Operaciones
    {
        public int SumaNumero(int numero1, int numero2) 
        {
            return numero1 + numero2;
        }
        public bool IsValorPar(int numero)
        {
            return numero % 2 == 0;
        }
        public bool IsDeveloperOfPhoenix(string nombreDevelper) 
        {
            var Lista = new List<string> { "Enrique","Leilan","Jose", "Enderson"};
            var nombreRetorno = false;

            foreach (var nombre in Lista)
            {
             if(nombre == nombreDevelper)
                    nombreRetorno = true;
            }

            return nombreRetorno;
        }

        public double SumarDecimal(double decimal1, double decimal2)
        {
            return decimal1 + decimal2;
        }
    }
}