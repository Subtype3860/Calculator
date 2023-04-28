using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class PrintRezult
    {
        private Account _account;
        public PrintRezult(Account account) {

            _account = account;
        }
        public void Print()
        {
            Console.WriteLine($"Тарифный план:\t{_account.Type}");
            Console.WriteLine($"Процентная ставка:\t{_account.Interest}");
            Console.WriteLine($"Баланс:\t{_account.Balance}");
        }


    }
}
