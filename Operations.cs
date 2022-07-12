using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xUnitCalculator2
{
    public class Operations
    {
        public int Adition(int[] values)
        {
            int result = 0;
            foreach (int value in values)
            {
                result += value;
            }
            Console.WriteLine($" The result is {result} ");
            return result;
        }

        public int Adition(int value1, int value2)
        {
            Console.WriteLine($" The result is {value1 + value2} ");
            return value1 + value2;
        }

        public int Substraction(int[] values)
        {
            int result = 0;
            foreach (int value in values)
            {
                result -= value;
            }
            Console.WriteLine($" The result is {result} ");
            return result;
        }
        public int Substraction(int value1, int value2)
        {
            Console.WriteLine($" The result is {value1 - value2} ");
            return value1 - value2;
        }

        public int Multiplication(int value1, int value2)
        {
            Console.WriteLine($" The result is {value1 * value2}");
            return value1 * value2;
        }
        public int Division(int value1, int value2)
        {
            if (value2 == 0)
            {
                Console.WriteLine("you cannot devide by zero");
            }
            else
            {
                Console.WriteLine($" The result is {value1 / value2}");               
            }
            return value1 / value2;
        }
    }
}
