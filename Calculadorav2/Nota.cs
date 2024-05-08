using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraV2
{
    internal class Nota
    {

        public void CalcularNota()
        {
            Console.WriteLine("Você selecionou a opção calcular nota! Favor utilizar virgula.");
            Console.WriteLine("Lembrete! os parametros para aprovação ou reprovação dependerâo da sua instituição!");
            Console.Write("Digite a primeira nota: ");
            double Nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            double Nota2 = double.Parse(Console.ReadLine());
            double ResultadoNota = (Nota1 + Nota2) / 2;
           
            if(ResultadoNota < 6)
            {
                Console.WriteLine("Infelizmente você foi reprovado com a nota: " + ResultadoNota);
            }else if (ResultadoNota >= 7)
            {
                Console.WriteLine("Você foi aprovado! com a nota: " + ResultadoNota);
            }
           
        }
       
    }
}
