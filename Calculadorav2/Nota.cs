using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraV2
{
    internal class Nota
    {
         public void CalcularNota()
        {
            Console.WriteLine("Você selecionou a opção calcular nota! Favor utilizar virgula.");
            Console.WriteLine("Por-favor quantas notas voce gostaria de calcular? minimo de 2 e até um maximo de 4 ");
            Console.WriteLine("Lembrete! os parametros para aprovação ou reprovação dependerâo da sua instituição!");
            int QuantidadeNotas = int.Parse(Console.ReadLine());
            switch (QuantidadeNotas)
            {
                case 2:
                    Console.Write("Digite a primeira nota: ");
                    double Nota1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite a segunda nota: ");
                    double Nota2 = double.Parse(Console.ReadLine());
                    double ResultadoNota = (Nota1 + Nota2) / 2;
                    Console.WriteLine("A media das suas notas são de: " + ResultadoNota.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 3:
                    Console.Write("Digite a primeira nota: ");
                    double Nota3 = double.Parse(Console.ReadLine());
                    Console.Write("Digite a segunda nota: ");
                    double Nota4 = double.Parse(Console.ReadLine());
                    Console.Write("Digite a terceira nota: ");
                    double Nota5 = double.Parse(Console.ReadLine());
                    double ResultadoNota2 = (Nota3 + Nota4 + Nota5) / 3;
                    Console.WriteLine("A media das suas notas são de: " + ResultadoNota2.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                case 4:
                    Console.Write("Digite a primeta nota: ");
                    double Nota6 = double.Parse(Console.ReadLine());
                    Console.Write("Digite a segunda nota:: ");
                    double Nota7 = double.Parse(Console.ReadLine());
                    Console.Write("Digite a terceira nota: ");
                    double Nota8 = double.Parse(Console.ReadLine());
                    Console.Write("Digite a quarta nota: ");
                    double Nota9 = double.Parse(Console.ReadLine());
                    double ResultadoNota3 = (Nota6 + Nota7 + Nota8 + Nota9) / 4;
                    Console.WriteLine("A media das suas notas são de: " + ResultadoNota3.ToString("F2", CultureInfo.InvariantCulture));
                    break;
                default:
                    Console.WriteLine("Opção invalida! tente novamente.");
                    break;
            }
        }
    }
}
