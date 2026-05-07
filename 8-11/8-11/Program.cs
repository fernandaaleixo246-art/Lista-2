using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Digite o valor A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor B: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor C: ");
            c = int.Parse(Console.ReadLine());

            if ((a * a) == (b * b) + (c * c) ||
                (b * b) == (a * a) + (c * c) ||
                (c * c) == (a * a) + (b * b))
            {
                Console.WriteLine("Forma um triângulo retângulo");
            }
            else
            {
                Console.WriteLine("Não forma um triângulo retângulo");
            }

            Console.ReadKey();
        }
    }
}
