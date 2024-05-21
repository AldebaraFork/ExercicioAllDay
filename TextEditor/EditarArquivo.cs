using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextEditorV2
{
    internal class EditarArquivo
    {
        public void Editar()
        {
            Console.Clear();
            Console.WriteLine("Por-favor insira o texto que deseja editar (ESC para sair)");
            Console.WriteLine("------------------------------------------");
            string TextoInserido = null;
            do
            {
                TextoInserido += Console.ReadLine();
                TextoInserido += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine($"Texto inserido: {TextoInserido}");
            Console.WriteLine("Deseja salvar o arquivo? S/N");
            char RespostaSalvamento = char.Parse(Console.ReadLine().ToLower());
            if (RespostaSalvamento == 's')
            {
                SalvarTexto(TextoInserido);

            }
            else if (RespostaSalvamento == 'n'){
                Console.WriteLine("Arquivo não foi salvo! retornando ao menu");
                Thread.Sleep(3500);
                Menu menu = new Menu();
                Console.Clear();
                menu.Menuzada();

            }
            else
            {
                Console.WriteLine("Opção invalida! saindo do aplicativo");
                Thread.Sleep(3000);
                System.Environment.Exit(0);
            }

        }
        public void SalvarTexto(string textoinserido)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho deseja salvar o arquivo? ");
            var path = Console.ReadLine();
            using (var arquivo = new StreamWriter(path))
            {
               //salvando arquivo o texto inserido no path
                               arquivo.WriteLine(textoinserido);

            }
            Console.Clear();
            Console.WriteLine($"Arquivo salvo com sucesso em {path}");
            Console.WriteLine("Voltando ao menu principal");
            Thread.Sleep(3500);
            Console.Clear();
            Menu menu = new Menu();
            menu.Menuzada();
        }
    }
}
