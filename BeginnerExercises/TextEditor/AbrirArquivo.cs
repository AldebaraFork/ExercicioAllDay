using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditorV2
{
    internal class AbrirArquivo
    {
       public void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");
            string path = Console.ReadLine();
            using (var file = new StreamReader(path))
            {
                //le a string até o final
                string TextoInserido = file.ReadToEnd();
                Console.WriteLine(TextoInserido);
            }
            Console.WriteLine("-------------------");
            Console.WriteLine("Retornando ao menu principal");
            Thread.Sleep(3500);
            Console.Clear();
            Menu menu = new Menu();
            menu.Menuzada();
        }
    }
}
