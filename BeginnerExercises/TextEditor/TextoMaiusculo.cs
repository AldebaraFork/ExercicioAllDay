using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditorV2
{
    internal class TextoMaiusculo
    {
        public void textoMaiusculo()
        {
            CriarArquivo criarArquivo = new CriarArquivo();
            Console.WriteLine("Digite o texto que deseja traduzir para maiusculo: (pressione ESC para sair)");
            Console.WriteLine("----------------------------------------------------------------------------");
            string TextoInserido = null;
            do
            {
                TextoInserido += Console.ReadLine().ToUpper();
                TextoInserido += Environment.NewLine;


            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine($"Texto inserido: {TextoInserido}");


            Console.WriteLine("Deseja salvar o arquivo? S/N");
            char Resposta = char.Parse(Console.ReadLine().ToLower());
            if (Resposta == 's')
            {
                SalvarTexto salvartexto = new SalvarTexto();
                salvartexto.SalvarTextos(TextoInserido);

            }
            else if (Resposta == 'n')
            {
                Console.WriteLine("Arquivo não salvo! Deseja retornar ao menu ou sair do aplicativo? MENU/SAIR");
                string saida = Console.ReadLine().ToLower();
                if (saida == "menu")
                {
                    Console.Clear();
                    Console.WriteLine("retornando ao menu");
                    Thread.Sleep(3500);
                    Menu menu = new Menu();
                    menu.Menuzada();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opção invalida ! voltando ao menu");
                Thread.Sleep(3000);
                Menu menu = new Menu();
                menu.Menuzada();

            }
        }
       
    }
}
