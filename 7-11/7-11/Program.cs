using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Digite o lado A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o lado B: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite o lado C: ");
            c = int.Parse(Console.ReadLine());

            if (a < b + c && b < a + c && c < a + b)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Triângulo Equilátero");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Triângulo Isósceles");
                }
                else
                {
                    Console.WriteLine("Triângulo Escaleno");
                }
            }
            else
            {
                Console.WriteLine("Não forma triângulo");
            }

            Console.ReadKey();
        }
    }
}
