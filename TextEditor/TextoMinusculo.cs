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
            string TextoInserido = Console.ReadLine();
            Console.WriteLine("Texto traduzido para minúsculo: " + TextoInserido.ToLower());
        }
    }
}
