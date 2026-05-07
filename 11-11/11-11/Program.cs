using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1, p2;

            Console.Write("Digite a nota da P1: ");
            p1 = double.Parse(Console.ReadLine());

            p2 = (15 - p1) / 2;

            Console.WriteLine("Você precisa tirar " + p2 + " na P2 para ser aprovado.");

            Console.ReadKey();
        }
    }
}
