using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraV2
{
    internal class Menu
    {
        public void Menuzada()
        {
            Console.WriteLine("Olá bem vindo a calculadora V2! Por-favor digite a opção desejada: ");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Tabuada");
            Console.WriteLine("6 - MOD");
            Console.WriteLine("7 - Notas");
            Console.WriteLine("8 - MMC");
            short OpcaoSelcionada = short.Parse(Console.ReadLine());
            switch (OpcaoSelcionada)
            {
                case 1:
                    Console.Clear();
                    Soma soma = new Soma();
                    soma.CalcularSoma();
                    break;
                case 2:
                    Console.Clear();
                    Subtracao subtracao = new Subtracao();
                    subtracao.CalcularSubtracao();
                    break;
                case 3:
                    Console.Clear();
                    Multiplicar Multiplicar = new Multiplicar();
                    Multiplicar.CalcularMultiplicacao();
                    break;
                case 4:
                    Console.Clear();
                    Divisao divisao = new Divisao();
                    divisao.CalcularDivisao();
                    break;
                case 5:
                    Console.Clear();
                    Tabuada tabuada = new Tabuada();
                    tabuada.CalcularTabuada();
                    break;
                case 6:
                    Console.Clear();
                    MOD mod = new MOD();
                    mod.Calcularmod();
                    break;
                case 7:
                    Console.Clear();
                    Nota nota = new Nota();
                    nota.CalcularNota();
                    break;
                case 8:
                    Console.Clear();
                    MDC mdc = new MDC();
                    mdc.CalcularMDC();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção invalida! tente novamente");
                    Menuzada();
                    break;
            }
        }
    }
}
