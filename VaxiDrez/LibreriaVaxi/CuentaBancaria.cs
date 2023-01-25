using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaVaxi
{
    public class CuentaBancaria
    {
        //inyeccion DP
        private readonly ILoggerGeneral _loggerGeneral;

        //propiedad
        public int balance { get; set; }

        public CuentaBancaria(ILoggerGeneral loggerGeneral) 
        {
            _loggerGeneral = loggerGeneral;
            balance = 0;
        }
        public bool Deposito(int monto)
        {
            _loggerGeneral.Message("EL Monto a Depositar es: " + monto);
            balance += monto;
            return true;
        }
        public bool Retiro(int monto) 
        {
            if (balance >= monto) 
            {
                _loggerGeneral.Message("EL monto a retirar es: " + monto);
                balance -= monto;
                return true;
            }
            else 
            {
                _loggerGeneral.Message("No tiene dinero suficiente, su monton en menor a "+ monto);
                return false;
            }
        }
        public int GetBalance() 
        {
            return balance;
        }
    }
}
