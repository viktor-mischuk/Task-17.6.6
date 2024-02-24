using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17._6._6
{
    public static class Calculator
    {
        // Меtic тод для расчета процентной ставки
        public static void CalculateInterest(ICalculationInterest account)
        {
            account.CalculateInterest();
        }
    }    
}
