using System;

namespace lab2ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrieti un program care va afisa suma cifrelor unui numar n, n fiind citit de la tastatura.
            Console.WriteLine("Introduceti un numar: ");
            int n = int.Parse(Console.ReadLine());
            int suma=0;
            while(n!=0)
            {
                suma = suma + n % 2;
                n = n / 10;
            }
            Console.WriteLine("Suma cifrelor este: "+suma);
        }
    }
}
