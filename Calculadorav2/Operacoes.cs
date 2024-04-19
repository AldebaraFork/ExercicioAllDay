using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CalculadoraV2
{
    internal class Operacoes
    {
        //SOMA
        public void Soma()
        {
            Console.WriteLine("Você selecionou a opção soma! ");
            Console.Write("Digite o primeiro numero para soma: ");
            double Numer1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero para soma:");
            double Numer2 = double.Parse(Console.ReadLine());
            double Numer3 = Numer1 + Numer2;
            Console.WriteLine("A soma de " + Numer1 + " + " + Numer2 + " é: " + Numer3);
        }
        //SUBTRAÇÃO
        public void Subtracao()
        {
            Console.WriteLine("Você selecionou a opção Subtração! Por-favor utilize virgula para numeros quebrados! ");
            Console.Write("Digite o primeiro numero para subtrair:");
            double Numer1 = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            Console.Write("Digite o segundo numero para subtrair:");
            double Numer2 = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            double Numer3 = Numer1 - Numer2;
            Console.WriteLine("A subtração de " + Numer1 + " - " + Numer2 + " é: " + Numer3.ToString(CultureInfo.InvariantCulture));
        }
        //MULTIPLICAÇÃO
        public void Multiplicacao()
        {
            Console.WriteLine("Você selecionou a opção multiplicação! ");
            Console.Write("Digite o primeiro numero para multiplicar: ");
            double Numer1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero para multiplicar:");
            double Numer2 = double.Parse(Console.ReadLine());
            double Numer3 = Numer1 * Numer2;
            Console.WriteLine("A multiplicação de " + Numer1 + " * " + Numer2 + " é: " + Numer3);
        }
        //TABUADA
        public void Divisao()
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
        //TABUADA
        public void Tabuada()
        {
            Console.WriteLine("Você selecionou a opção tabuada! ");
            Console.Write("Por-favor digite o numero que gostaria de saber a tabuada: ");
            int Numer1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Até aonde gostaria de saber a tabuada? ");
            int Numer2 = int.Parse(Console.ReadLine());
            for (int i = 0; i <= Numer2; i++)
            {
                int Numer3 = Numer1 * i;
                Console.WriteLine("A tabuada de " + Numer1 + " é: " + Numer3);
            }
        }

    }
}


