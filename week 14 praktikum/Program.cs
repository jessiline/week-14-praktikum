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
            int angka = 0;
            int prima = 0;
            for(int k = 0; k < input; k++)
            {
                for(int q = 0; q< input; q++)
                {
                    prima = 0;
                    while (prima == 0)
                    {
                        angka++;
                        bool cekPrima = true;
                        if(angka == 1)
                        {
                            cekPrima = false;
                        }
                        for (int j = 2; j < angka; j++)
                        {
                            if ((angka % j) == 0)
                            {
                                cekPrima = false;
                            }
                        }
                        if (cekPrima == true && angka != 1 && cek ==2)
                        {
                            prima = 1;
                            Console.Write($"{angka} ".PadLeft(5));
                        }
                        if (cekPrima == false && cek !=2)
                        {
                            prima = 1;
                            Console.Write($"{angka} ".PadLeft(5));
                        }
                        cekPrima = true;
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Input : ");
            int input = Convert.ToInt32(Console.ReadLine());
            while(input < 2)
            {
                Console.Write("Input terlalu kecil ! silahkan input ulang : ");
                input = Convert.ToInt32(Console.ReadLine());
            }
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