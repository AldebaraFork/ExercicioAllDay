using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    internal class Timer
    {
        public void Contador()
        {
            Console.Clear();
            Console.WriteLine("Qual opçao voce deseja usar?");
            Console.WriteLine("1 - Temporizador");
            Console.WriteLine("2 - Cronometro ");
            Console.WriteLine("3 - Voltar ao menu");
            Console.WriteLine("4 - Sair do Stopwatch");
            short OpcaoSelecionada = short.Parse(Console.ReadLine());
            switch (OpcaoSelecionada)
            {
                case 1:
                    Console.WriteLine("Até quando deseja contar?");
                    int tempoEscolhido = int.Parse(Console.ReadLine());
                    int tempoTeste = 0;
                    while (tempoEscolhido > tempoTeste)
                    {
                        tempoTeste++;
                        Console.WriteLine($"Passou: {tempoTeste} segundos");
                    }
                    break;
                case 2:
                    Console.WriteLine("Desde quando deseja contar?");
                    int TempoReverso = int.Parse(Console.ReadLine());
                    int tempoTesteReverso = 0;
                    while (TempoReverso > tempoTesteReverso)
                    {
                        TempoReverso--;
                        Console.WriteLine($"ja se foi: {TempoReverso} segundos");
                    }
                    break;
                case 3:
                    Menu menu = new Menu();
                    menu.Menuzada();
                    break;
                case 4:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção invalida!");
                    break;

            }

        }
    }
}
