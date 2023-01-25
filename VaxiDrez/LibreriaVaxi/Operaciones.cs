using System.Reflection.Metadata.Ecma335;

namespace LibreriaVaxi
{
    public class Operaciones
    {
        //variables  necesarias
        public List<int> NumeroImpares = new List<int>();

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

        public List<int> GetListaNumeroImpares(int intervaloMinimo, int intervaloMaximo) 
        {
            //limpiando lista
            NumeroImpares.Clear();

            //Almacenando numero impares
            for(int i = intervaloMinimo; i<= intervaloMaximo; i++) 
            {
                if (i % 2 != 0)
                {
                    NumeroImpares.Add(i);
                }                
            }            

            return NumeroImpares;
        }
    }
}