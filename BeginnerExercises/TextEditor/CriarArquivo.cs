using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextEditorV2
{
    internal class CriarArquivo
    {
        public void CriarTexto()
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
               SalvarTexto salvartexto = new SalvarTexto();
                salvartexto.SalvarTextos(TextoInserido);

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
       
    }
}
