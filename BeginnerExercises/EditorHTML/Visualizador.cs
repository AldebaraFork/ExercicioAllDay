using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EditorHTML
{
    public class Visualizador
    {
        public static void Show(string texto)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("Modo visualização e edição ");
            Console.WriteLine("============================");
            Replace(texto);
            Console.WriteLine("============================");
            Editor.Show();
        }
        public static void Replace(string texto)
        {

            Console.Clear();
            Console.BackgroundColor= ConsoleColor.White;
            Console.ForegroundColor= ConsoleColor.Black;
            Console.WriteLine("Colocar a palavra em negrito!");
            var strong = new Regex("");

        }
    }
}
