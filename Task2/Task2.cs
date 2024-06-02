using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_PracticWork
{
    
    class Array : IMath
    {
        int[] arr;
        public Array(int size)
        {
            arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(0, 100);
            }
            Console.WriteLine();
        }

        public void Show()
        {
            for (int i = 0; i < arr.Max(); i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Console.WriteLine(info);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }

    internal class Task2
    {
    }
}

