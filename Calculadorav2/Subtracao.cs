using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraV2
{
    internal class Subtracao
    {
        public void CalcularSubtracao()
        {
            Console.WriteLine("Você selecionou a opção Subtração! Por-favor utilize virgula para numeros quebrados! ");
            Console.Write("Digite o primeiro numero para subtrair:");
            double Numer1 = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            Console.Write("Digite o segundo numero para subtrair:");
            double Numer2 = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            double Numer3 = Numer1 - Numer2;
            Console.WriteLine("A subtração de " + Numer1 + " - " + Numer2 + " é: " + Numer3.ToString(CultureInfo.InvariantCulture));

        }
    }
}
