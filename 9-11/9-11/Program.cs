using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, r;
            string sexo;

            Console.Write("Digite o sexo (M/F): ");
            sexo = Console.ReadLine();

            Console.Write("Digite o peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura: ");
            altura = double.Parse(Console.ReadLine());

            r = peso / (altura * altura);

            Console.WriteLine("R = " + r);

            if (sexo == "F" || sexo == "f")
            {
                if (r < 19)
                {
                    Console.WriteLine("Abaixo do peso");
                }
                else if (r < 24)
                {
                    Console.WriteLine("Peso ideal");
                }
                else
                {
                    Console.WriteLine("Acima do peso");
                }
            }
            else
            {
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
            }

            Console.ReadKey();
        }
    }
}
