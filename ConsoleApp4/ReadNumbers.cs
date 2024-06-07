using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoEnd
{
    internal class ReadNumbers : IReadNumbers
    {
        public double[] numbers = new double[666];
        public double[] ReadNums(int NumCount) 
        {
            for (int i = 0; i != NumCount; i++)
            {
                Console.Write($"Введите число {i+1} : ");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
               
            }
            return numbers;
        }

    }
}
