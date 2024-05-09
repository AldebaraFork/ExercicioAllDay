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
            Console.WriteLine("Digite o texto que deseja traduzir para maiusculo: ");
            string TextoInserido = Console.ReadLine();
            Console.WriteLine("Texto traduzido para maiusculo: " + TextoInserido.ToUpper());
        }
    }
}
