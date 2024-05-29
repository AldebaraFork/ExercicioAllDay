using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class SalvarArquivo
    {
        public void Salvar(string Id)
        {
            SchoolSystem system = new SchoolSystem();
            Console.WriteLine("Deseja salvar esse arquivo? S/N");
            var resposta = char.Parse(Console.ReadLine().ToLower());
            if (resposta == 's')
            {
                Console.Clear();
                Console.WriteLine("Onde deseja salvar esse arquivo?");
                var path = Console.ReadLine();
                using (var file = new StreamWriter(path))
                {
                    file.WriteLine(Id);
                    
                }
                Console.WriteLine("Arquivo salvo com sucesso! retornando ao menu...");
                Thread.Sleep(2000);
                Console.Clear();
                system.Menu();

            }else if (resposta == 'n')
            {
                Console.WriteLine("Deseja sair do app ou voltar ao menu principal? MENU/SAIR");
                var RespostaSaida = Console.ReadLine().ToLower();
                if (RespostaSaida == "menu")
                {
                    Console.WriteLine("Retornando ao menu....");
                    Thread.Sleep(2500);
                    Console.Clear();
                    system.Menu();
                }else if (RespostaSaida == "sair")
                {
                    Console.WriteLine("Saindo do app....");
                    Thread.Sleep(2500);
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Opção invalida!");
                }
                
            }else
            {
                Console.WriteLine("Resposta invalida! tente novamente");
                Thread.Sleep(3000);
                Salvar(Id);
            }
        }

    }
}
