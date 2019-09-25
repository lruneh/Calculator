using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class SortArray
    {
        int[] array1 = new int[] { 7, 6, 2, 9, 1, 11, 12, 3, 5, 4, 8, 10 };

        public string printArray()
        {
            string myString = "";
            foreach (var item in array1)
            {
                myString += item + " ";
                
            }
            return myString;
        }

        public string sorteret(int[] myArray)
        {
            
            
            int temp = 0;
            int index = myArray.Length-1;
            int next = index - 1;

            while (next >= 0 ){
                if (myArray[index] < myArray[next])
                {
                    temp = myArray[index];
                    myArray[index] = myArray[next];
                    myArray[next] = temp;
                    if (index < myArray.Length - 1)
                    {
                        index += 1;
                        next += 1;
                    }
                }
                else
                {
                    index -= 1;
                    next -= 1;
                }
            }
            string myString = "";
            foreach (var item in myArray)
            {
                myString += item + " ";

            }
            return myString;

        }
    }
}
