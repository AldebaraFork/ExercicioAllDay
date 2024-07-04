using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditorV2
{
    internal class TextoMinusculo
    {
        public void textoMinusculo()
        {
            Console.WriteLine("Digite o texto que deseja traduzir para minúsculo: ");
            Console.WriteLine("---------------------------------------------------");
            string TextoInserido = null;
            do
            {
                TextoInserido = Console.ReadLine().ToLower();
                TextoInserido += Environment.NewLine;

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine($"Texto inserido: {TextoInserido}");


            Console.WriteLine("Deseja salvar o arquivo? S/N");
            char resposta = char.Parse(Console.ReadLine().ToLower());
            if (resposta == 's')
            {
                SalvarTexto salvarTexto = new SalvarTexto();
                salvarTexto.SalvarTextos(TextoInserido);
            }
            else if (resposta == 'n')
            {
                Console.WriteLine("deseja retornar ao menu ou sair do aplicativo? MENU/SAIR");
                string Opcao = Console.ReadLine().ToLower();
                if (Opcao == "menu")
                {
                    Console.WriteLine("Retornando ao menu");
                    Thread.Sleep(3000);
                    Menu menu = new Menu();
                    menu.Menuzada();
                }
                else if (Opcao == "sair")
                {
                    Console.WriteLine("Obrigad por usar meu app! Saindo do aplicativo");
                    Thread.Sleep(3000);
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("opção invalida! saindo do aplicativo");
                    
                }
                       
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opção invalida! retornando ao menu principal");
                Thread.Sleep(3500);
                Menu menu = new Menu();
                menu.Menuzada();
            }
        }
    }
}
