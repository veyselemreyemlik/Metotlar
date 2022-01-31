using System;

namespace DegerDöndürenMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Geriye İnteger Değer Döndüren Metot

            int[] dizi = new int[10];
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rastgele();

                Console.Write(dizi[i] + "  ");
            }
        }

        static int rastgele()
        {
            Random r = new Random();
            return r.Next(101);
        }
    }
    }

