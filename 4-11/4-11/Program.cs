using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseRet, altura, area;

            Console.Write("Digite a base: ");
            baseRet = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura: ");
            altura = double.Parse(Console.ReadLine());

            area = baseRet * altura;

            Console.WriteLine("Área: " + area);

            if (area > 100)
            {
                Console.WriteLine("Terreno grande");
            }

            Console.ReadKey();
        }
    }
}
