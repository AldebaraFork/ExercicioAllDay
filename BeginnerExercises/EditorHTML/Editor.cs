using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorHTML
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao modo edição!");
            Console.WriteLine("======================================");
            StartEditor();
        }
        public static void StartEditor()
        {

            Console.WriteLine("Digite o texto: (ESC para sair)");
            var Texto = new StringBuilder();
            do
            {
                Texto.Append(Console.ReadLine());
                Texto.Append(System.Environment.NewLine);

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("======================================");
            Console.WriteLine("Texto inserido: " + Texto.ToString());

            Console.WriteLine("======================================");
            Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine("Deseja salvar esse arquivo? S/N");
            var resposta = char.Parse(Console.ReadLine().ToLower());
            if (resposta == 's')
            {
                SalvarTexto salvar = new SalvarTexto();
                salvar.SalvaHTML(Texto.ToString());
                Console.Clear();
                Menu menuzada = new Menu();
                menuzada.Quadrado();
                menuzada.OpcoesMenu();
            }
            else if (resposta == 'n')
            {
                Console.Clear();
                Console.WriteLine("Arquivo nao salvo ! Deseja retornar ao menu ou sair do app? MENU/SAIR");
                var respostan = Console.ReadLine().ToLower();
                if (respostan == "menu")
                {
                    Console.Clear();
                    Console.WriteLine("Voltando ao menu!");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Menu menuzada = new Menu();
                    menuzada.Quadrado();
                    menuzada.OpcoesMenu();
                }
                else if (respostan == "sair")
                {
                    Console.WriteLine("Saindo do aplicativo!");
                    Thread.Sleep(3000);
                    System.Environment.Exit(0);
                }

            }

        }


        public static void OpenFile()
        {
            string pasta = @"E:\TesteDevs"; // Substitua pelo caminho da sua pasta
            string[] arquivos = Directory.GetFiles(pasta);

            Console.SetCursorPosition(4, 12);
            Console.WriteLine("Arquivos disponíveis:");

            for (int i = 0; i < arquivos.Length; i++)
            {
                Console.SetCursorPosition(4, 13 + i);
                Console.WriteLine($"{i + 1}. {Path.GetFileName(arquivos[i])}");
            }

            Console.SetCursorPosition(4, 14 + arquivos.Length);
            Console.Write("Digite o número do arquivo que deseja abrir: ");
            if (int.TryParse(Console.ReadLine(), out int escolha) && escolha >= 1 && escolha <= arquivos.Length)
            {
                string arquivoEscolhido = arquivos[escolha - 1];
                string conteudo = File.ReadAllText(arquivoEscolhido);
                Console.WriteLine($"\nConteúdo do arquivo {Path.GetFileName(arquivoEscolhido)}:\n");
                Console.WriteLine(conteudo);
            }
            else
            {
                Console.WriteLine("\nOpção inválida. Certifique-se de digitar um número válido.");
            }
        }
    }
}
