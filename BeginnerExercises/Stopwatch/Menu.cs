using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    internal class Menu
    {
        public void Menuzada()
        {
            Console.WriteLine("Welcome to StopWatch, please select one option below: ");
            Console.WriteLine("1 - Count in Sec or Min");
            Console.WriteLine("2 - Timer");
            Console.WriteLine("3 - How much time is left to....");
            Console.WriteLine("4 - Exit");
            short SelectedOption = short.Parse(Console.ReadLine());
            switch (SelectedOption)
            {
                case 1:
                    TodayTime today = new TodayTime();
                    today.WhatTimeIsNow();
                    break;
                case 2:
                    Timer timer = new Timer();
                    timer.Contador();
                    break;
                case 4:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    Menuzada();
                    break;
            }
        }
    }
}
