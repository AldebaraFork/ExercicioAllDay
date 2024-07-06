using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Stopwatch
{
    internal class TodayTime
    {
        public void WhatTimeIsNow()
        {

            Console.WriteLine("Deseja contar em minuto ou segundo?");
            Console.WriteLine("M = Minuto (EX: 1m = 1 minuto)");
            Console.WriteLine("S = Segundo (Ex: 10s = 10 segundo)");
            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplicador = 1;
            if (type == 'm')
            {
                multiplicador = 60;
                int conta = multiplicador * time;
                int testando = 0;
                while (conta > testando)
                {
                    Console.Clear();
                    conta--;
                    Console.WriteLine($"{conta} segundos");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("Contagem finalizada, retornando ao menu");
                Thread.Sleep(3500);
                Menu menuz = new Menu();
                Console.Clear();
                menuz.Menuzada();


            }
            else if (type == 's')
            {
                int conta = multiplicador * time;
                int testando = 0;
                while (conta > testando)
                {
                    Console.Clear();
                    conta--;
                    Console.WriteLine($"{conta} segundos");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("Contagem finalizada, retornando ao menu");
                Thread.Sleep(3500);
                Menu menuz = new Menu();
                Console.Clear();
                menuz.Menuzada();
                
            }

        }
    }
}
