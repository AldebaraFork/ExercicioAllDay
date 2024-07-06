using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraV2
{
    internal class Tabuada
    {
        public void CalcularTabuada()
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
