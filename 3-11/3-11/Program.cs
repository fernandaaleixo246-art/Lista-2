using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Digite o primeiro valor: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            c = int.Parse(Console.ReadLine());

            int maior = a;

            if (b > maior)
            {
                maior = b;
            }

            if (c > maior)
            {
                maior = c;
            }

            Console.WriteLine("Maior valor: " + maior);

            Console.ReadKey();
        }
    }
}
