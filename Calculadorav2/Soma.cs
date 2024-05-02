using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraV2
{
    internal class Soma
    {
        public void CalcularSoma()
        {
            Console.WriteLine("Você selecionou a opção soma! ");
            Console.Write("Digite o primeiro numero para soma: ");
            double Numer1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero para soma:");
            double Numer2 = double.Parse(Console.ReadLine());
            double Numer3 = Numer1 + Numer2;
            Console.WriteLine("A soma de " + Numer1 + " + " + Numer2 + " é: " + Numer3);
        }
    }
}
