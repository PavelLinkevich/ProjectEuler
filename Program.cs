﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTask
{
    class Program
    {
        public static int[] array = new int[20];
        static void Main(string[] args)
        {
            Fibonachi.EvenFibonachiNumbers();
        }        
    }
    class Fibonachi
    {
        public static int[] array = new int[20];
        public static void EvenFibonachiNumbers()
        {
            array[0] = 0;
            array[1] = 1;
            for (int i = 2; i < 20; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }
            Helper.Writer();
            Helper.SumWriter();
        }        
    }
    class Helper
    {
        public static void Writer()
        {                      
            for (int i = 0; i < 20; i++)
            {
                
                Console.WriteLine(Fibonachi.array[i]);
            }
        }
        public static void SumWriter()
        {
            for (int i = 0; i < 20; i++)
            {
                if (Fibonachi.array[i] % 2 != 1)
                {
                    Console.Write(Fibonachi.array[i]+ " ");
                }
               
            }
        }
    }

}
