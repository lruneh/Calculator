using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int firstNumber = 0;
            //    int secondNumber = 0;

            //    int WhatToDo = 0;
            //    String Exit = "";

            //    while (Exit != "q")
            //    {
            //        WhatToDo = whatToDo();

            //        while (WhatToDo != 1 && WhatToDo != 2)
            //        {

            //            WhatToDo = whatToDo();
            //        }

            //        if (WhatToDo == 1)
            //        {
            //            Console.WriteLine("Please enter first number:");
            //            firstNumber = Convert.ToInt32(Console.ReadLine());

            //            Console.WriteLine("Please enter second number:");
            //            secondNumber = Convert.ToInt32(Console.ReadLine());

            //            AddTwoNumbers add = new AddTwoNumbers(firstNumber, secondNumber);

            //            var resultat = add.Sum(firstNumber, secondNumber);

            //            Console.WriteLine(resultat);
            //            Console.WriteLine("Hit q to quit");

            //            Exit = Console.ReadLine();


            //        }
            //        if (WhatToDo == 2)
            //        {
            //            Console.WriteLine("Please enter first number:");
            //            firstNumber = Convert.ToInt32(Console.ReadLine());

            //            Console.WriteLine("Please enter second number:");
            //            secondNumber = Convert.ToInt32(Console.ReadLine());

            //MultiplyTwoNumbers multiplyTwoNumbers = new MultiplyTwoNumbers(firstNumber, secondNumber);

            //var resultat = multiplyTwoNumbers.Product(firstNumber, secondNumber);

            //            Console.WriteLine(resultat);
            //            Console.WriteLine("Hit q to quit");
            //            Exit = Console.ReadLine();


            //        }
            //    }

            SortArray sorter = new SortArray();
            SortArray sorteret = new SortArray();
            
            Console.WriteLine(sorter.printArray());
            int[] myArray = new int[] { 7, 6, 2, 9, 1, 11, 12, 3, 5, 4, 8, 10, 0 };
            Console.WriteLine(sorteret.sorteret(myArray));
            Console.ReadKey();
        }

        
        
        

        private static int whatToDo()
        {
            Console.WriteLine("Press 1 for adding, 2 for multiplication.");
            int WhatToDo = Convert.ToInt32(Console.ReadLine());
            return WhatToDo;
        }
    }
}
