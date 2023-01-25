using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaVaxi
{
    public interface ILoggerGeneral 
    {
        void Message(string message);
    }
    public class LoggerGeneral : ILoggerGeneral
    {
        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class LoggerFake : ILoggerGeneral
    {
        public void Message(string message)
        {
            //Eliminando mensaje
        }
    }
}
