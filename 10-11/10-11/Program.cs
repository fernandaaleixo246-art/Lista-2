using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1, p2, media;

            Console.Write("Digite a nota P1: ");
            p1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota P2: ");
            p2 = double.Parse(Console.ReadLine());

            media = (p1 + (2 * p2)) / 3;

            Console.WriteLine("Média: " + media);

            if (media >= 5)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }

            Console.ReadKey();
        }
    }
}
