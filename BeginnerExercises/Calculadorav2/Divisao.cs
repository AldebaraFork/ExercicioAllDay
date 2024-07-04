using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraV2
{
    internal class Divisao
    {
         public void CalcularDivisao()
        {
            Console.WriteLine("Você selecionou a opção Divisão! ");
            Console.WriteLine("Cuidado 0 nâo é um numero divisivel! ");
            Console.Write("Digite o primeiro numero para dividir: ");
            double Numer1 = double.Parse(Console.ReadLine());
            if (Numer1 == 0)
            {
                Console.WriteLine("0 Não é um numero divisivel! tente novamente. ");

            }
            else
            {
                Console.Write("Digite o segundo numero para dividir: ");
                double Numer2 = double.Parse(Console.ReadLine());
                if (Numer2 == 0)
                {
                    Console.WriteLine("0 Não é um numero divisivel! tente novamente. ");

                }
                else
                {
                    double Numer3 = Numer1 / Numer2;
                    Console.WriteLine("A divisão de: " + Numer1 + " / " + Numer2 + " é: " + Numer3);
                }
            }
        }
    }
}
