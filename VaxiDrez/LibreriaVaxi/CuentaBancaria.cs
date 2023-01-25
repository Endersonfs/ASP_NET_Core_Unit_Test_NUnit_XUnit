using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaVaxi
{
    public class CuentaBancaria
    {
        public int balance { get; set; }

        public CuentaBancaria() 
        {
            balance = 0;
        }
        public bool Deposito(int monto)
        {
            balance += monto;
            return true;
        }
        public bool Retiro(int monto) 
        {
            if (balance => monto) 
            {
                balance -= monto;
                return true;
            }
            else 
            {
                return false;
            }
        }
        public int GetBalance() 
        {
            return balance;
        }
    }
}
