using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace praktikum_w14
{
    class Program
    {
        public static void prima(int input, int cek)
        {

            var list = new List<int>();
            if (cek != 2)
            {
                Console.Write("1 ");
            }
            for (int i = 2; i <= 10000; i++)
            {
                bool cekPrima = true;
                for (int j = 2; j < i; j++)
                {
                    if ((i % j) == 0)
                    {
                        cekPrima = false;
                    }
                }
                if (cekPrima == true && list.Count < input * input && cek == 2)
                {

                    string t = string.Format("{0,-8}", i);
                    Console.Write(t);
                    if (list.Count % input == 0 && i != 2)
                    {
                        Console.WriteLine();
                    }
                    list.Add(i);
                }
                if (cekPrima == false && list.Count < input * input - 1 && cek != 2)
                {
                    string y = string.Format("{0,-8}", i);
                    Console.Write(y);
                    if (list.Count % input == 0)
                    {
                        Console.WriteLine();
                    }
                    list.Add(i);
                }

                cekPrima = true;
            }

        }
        static void Main(string[] args)
        {
            Console.Write("Input : ");
            int input = Convert.ToInt32(Console.ReadLine());
            int cek = 0;
            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                {
                    cek += 1;
                }
            }
            prima(input, cek);
        }
    }
}