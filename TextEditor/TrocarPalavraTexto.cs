using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditorV2
{
    internal class TrocarPalavraTexto
    {
        public void TrocarPalavra()
        {
            Console.WriteLine("Você selecionou a opção trocar palavras!");
            Console.WriteLine("Digite o texto que deseja modificar: ");
            string TextoInserido = Console.ReadLine();
            Console.Write("Por-favor digite a palavra que deseja substituir: ");
            string PalavraSubstituida = Console.ReadLine();
            Console.Write("Por qual palavra voce deseja substiuir " + PalavraSubstituida + " por?  ");
            string PalavraSubstituta = Console.ReadLine();
            string TextoModificado = TextoInserido.Replace(PalavraSubstituida, PalavraSubstituta);
            Console.WriteLine(TextoModificado);
        }
    }
}
