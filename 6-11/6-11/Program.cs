using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_11
{
    internal class Program
    {
        static void Main(string[] args)
        { double peso, altura, r;

        Console.Write("Digite o peso: ");
        peso = double.Parse(Console.ReadLine());

        Console.Write("Digite a altura: ");
        altura = double.Parse(Console.ReadLine());

        r = peso / (altura * altura);

        Console.WriteLine("R = " + r);

        if (r < 20)
        {
            Console.WriteLine("Abaixo do peso");
        }
        else if (r < 25)
        {
            Console.WriteLine("Peso ideal");
        }
        else
        {
            Console.WriteLine("Acima do peso");
        }

        Console.ReadKey();
        {
        }
    }
}
