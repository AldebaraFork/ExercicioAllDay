using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraV2
{
    internal class MDC
    {
         public int CalcularMDC()
        {
            Console.WriteLine("Você selecionou a opção calcular MMC!");
            Console.Write("Digite o primeiro numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());
            // Validação de entrada
            if (numero2 == 0)
            {
                throw new ArgumentException("O divisor não pode ser zero.");
            }

            // Casos especiais
            if (numero1 == numero2)
            {
                return numero1;
            }

            if (numero1 == 1 || numero2 == 1)
            {
                return 1;
            }

            int resto;
            int mdc = numero2;

            while (true)
            {
                resto = numero1 % mdc;
                numero1 = mdc;
                mdc = resto;

                if (resto == 0)
                {
                    break;
                }
            }
            Console.WriteLine("O MDC dos numeros escolhidos é de: " + mdc);
            return mdc;
            
        }
    }
}
