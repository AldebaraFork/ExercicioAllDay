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
        public void Multiplicacao()
        {
           Console.WriteLine("Você selecionou a opção multiplicação ");
            Console.Write("Digite o primeiro numero para multiplicar: ");
            double Numer1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero para multiplicar:");
            double Numer2 = double.Parse(Console.ReadLine());
            double Numer3 = Numer1 * Numer2;
            Console.WriteLine("A multiplicação de " + Numer1 + " * " + Numer2 + " é: " + Numer3);
        }
    }

}
