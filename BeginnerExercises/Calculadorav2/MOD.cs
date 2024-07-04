using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraV2
{
    internal class MOD
    {
         public void Calcularmod()
        {
            Console.WriteLine("Você selecionou a opção MOD! (Resto da divisão)");
            Console.Write("Por-favor digite o primeiro numero!, lembrando que 0 não é um numero divisivel.");
            double Numer1 = double.Parse(Console.ReadLine());
            if (Numer1 == 0)
            {
                Console.WriteLine("0 não é um numero divisivel! tente novamente.");

            }
            else
            {
                Console.Write("Por-favor digite o segundo numero! ");
                double Numer2 = double.Parse(Console.ReadLine());
                if (Numer2 == 0)
                {
                    Console.WriteLine("0 não é um numero divisivel! tente novamente.");

                }
                else
                {
                    double Numer3 = Numer1 % Numer2;
                    Console.WriteLine("O resto da divisão de " + Numer1 + " e " + Numer2 + " é: " + Numer3);
                }
            }

        }
    }
}
