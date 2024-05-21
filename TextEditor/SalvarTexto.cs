using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditorV2
{
    internal class SalvarTexto
    {
        public void SalvarTextos(string textoinserido)
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
