using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class MultiplyTwoNumbers
    {
        private int firstNumber;
        private int secondNumber;

        public MultiplyTwoNumbers(int firstNumber, int secondNumber)
        {
            this.firstNumber = firstNumber;
            this.secondNumber = secondNumber;
        }

        public int Product(int a, int b)
        {
            int result = a * b;
            return result;
        }
    }
}
