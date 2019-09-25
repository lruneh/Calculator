using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class AddTwoNumbers
    {
        private int firstNumber;
        private int secondNumber;

        public AddTwoNumbers(int firstNumber, int secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

        public int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }
    }
}
