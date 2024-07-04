using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditorV2
{
    internal class Caracteres
    {
        public void QuantidadeCaracteres()
        {
            Console.WriteLine("Digite o texto para saber a quantidade de caracteres: ");
            string TextoInserido = Console.ReadLine();
            int QuantidadeTexto = TextoInserido.Length;
            Console.WriteLine("A quantidade de caracteres é: " + QuantidadeTexto);
        }
    }
}
