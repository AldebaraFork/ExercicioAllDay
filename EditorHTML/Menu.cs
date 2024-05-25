using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EditorHTML
{
    public class Menu
    {

        public void Quadrado()
        {

            Console.Write("+");

            for (var linha = 0; linha <= 80; linha++)
            {
                Console.Write("-");

            }

            Console.Write("+");

            Console.Write("\n");

            for (var coluna = 0; coluna <= 20; coluna++)
            {
                Console.Write("|");
                for (int i = 0; i <= 80; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (var linha = 0; linha <= 80; linha++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");

        }
        public void OpcoesMenu()
        {

            Console.SetCursorPosition(4, 2);
            Console.Write("Bem vindo ao editor HTML");
            Console.SetCursorPosition(4, 3);
            Console.WriteLine("===========================");
            Console.SetCursorPosition(4, 4);
            Console.WriteLine("selecione uma opção abaixo:");
            Console.SetCursorPosition(4, 5);
            Console.WriteLine("1 - Criar novo arquivo ");
            Console.SetCursorPosition(4, 6);
            Console.WriteLine("2 - Abrir um arquivo");
            Console.SetCursorPosition(4, 7);
            Console.WriteLine("==========================");
            Console.SetCursorPosition(4, 8);
            Console.WriteLine("0 - Sair!");
            Console.SetCursorPosition(4, 9);
            Console.Write("Opção selecionada: ");
            short RespostaMenu = short.Parse(Console.ReadLine());

            switch (RespostaMenu)
            {
                case 1:
                    Editor.Show();
                    break;
                case 2:
                    Editor.OpenFile();
                   
                    break;
                case 0:
                    Console.WriteLine("Saindo do aplicativo! ");
                    Thread.Sleep(2500);
                    System.Environment.Exit(0);

                    break;
                default:
                    Console.SetCursorPosition(1, 10);
                    Console.WriteLine("Opção invalida! tente novamente");
                    Thread.Sleep(2500);
                    Console.Clear();
                    Quadrado();
                    OpcoesMenu();
                    break;

            }
        }
    }

}
