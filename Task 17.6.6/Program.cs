using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_17._6._6.Accounts;

namespace Task_17._6._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var usualAccount = new UsualAccount();
            var salaryAccount = new SalaryAccount();

            Calculator.CalculateInterest(usualAccount);
            Calculator.CalculateInterest(salaryAccount);
        }
    }
}
