using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTask
{
    class Program
    {
        static int[] array = new int[20];
        static void Main(string[] args)
        {
            EvenFibonachiNumbers();
        }
        static void EvenFibonachiNumbers()
        {
            array[0] = 0;
            array[1] = 1;
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            for (int i = 2; i < 20; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
                Console.WriteLine(array[i]);
            }
        }
    }
}
