using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class SchoolSystem
    {
        public void Menu()
        {
            var Dia = DateTime.Today;
            Console.WriteLine($"Olá, bem vindo a escola hoje é {Dia} , O que deseja fazer?");
            Console.WriteLine("1 - gerar ID ");
            Console.WriteLine("2 - verificar aulas");
            Console.WriteLine("0 - sair");

            var EscolhaMenu = short.Parse(Console.ReadLine());
            switch (EscolhaMenu)
            {
                case 1:
                    GerarID gera = new GerarID();
                    gera.gerarID();
                    break;
                case 2:
                    VerificarAulas verificas = new VerificarAulas();
                    verificas.Aulas();
                    break;
                case 0:
                    Console.Clear();
                    Console.WriteLine("Obrigado por usar meu app! desligando...");
                    Thread.Sleep(2500);
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção invalida! retornando ao menu...");
                    Thread.Sleep(2500);
                    Menu();
                    break;

            }
        }
    }
}
