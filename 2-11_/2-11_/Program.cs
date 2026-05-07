using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_11_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.Write("Digite o primeiro valor: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("Maior valor: " + n1);
            }
            else if (n2 > n1)
            {
                Console.WriteLine("Maior valor: " + n2);
            }
            else
            {
                Console.WriteLine("Os números são iguais.");
            }

            Console.ReadKey();
        }
    }
}
