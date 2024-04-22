using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CalculadoraV2
{
    internal class Operacoes
    {
        //SOMA
        public void Soma()
        {
            Console.WriteLine("Você selecionou a opção soma! ");
            Console.Write("Digite o primeiro numero para soma: ");
            double Numer1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero para soma:");
            double Numer2 = double.Parse(Console.ReadLine());
            double Numer3 = Numer1 + Numer2;
            Console.WriteLine("A soma de " + Numer1 + " + " + Numer2 + " é: " + Numer3);

        }
        //SUBTRAÇÃO
        public void Subtracao()
        {
            Console.WriteLine("Você selecionou a opção Subtração! Por-favor utilize virgula para numeros quebrados! ");
            Console.Write("Digite o primeiro numero para subtrair:");
            double Numer1 = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            Console.Write("Digite o segundo numero para subtrair:");
            double Numer2 = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));
            double Numer3 = Numer1 - Numer2;
            Console.WriteLine("A subtração de " + Numer1 + " - " + Numer2 + " é: " + Numer3.ToString(CultureInfo.InvariantCulture));

        }
        //MULTIPLICAÇÃO
        public void Multiplicacao()
        {
            Console.WriteLine("Você selecionou a opção multiplicação! ");
            Console.Write("Digite o primeiro numero para multiplicar: ");
            double Numer1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero para multiplicar:");
            double Numer2 = double.Parse(Console.ReadLine());
            double Numer3 = Numer1 * Numer2;
            Console.WriteLine("A multiplicação de " + Numer1 + " * " + Numer2 + " é: " + Numer3);

        }
        //TABUADA
        public void Divisao()
        {
            Console.WriteLine("Você selecionou a opção Divisão! ");
            Console.WriteLine("Cuidado 0 nâo é um numero divisivel! ");
            Console.Write("Digite o primeiro numero para dividir: ");
            double Numer1 = double.Parse(Console.ReadLine());
            if (Numer1 == 0)
            {
                Console.WriteLine("0 Não é um numero divisivel! tente novamente. ");

            }
            else
            {
                Console.Write("Digite o segundo numero para dividir: ");
                double Numer2 = double.Parse(Console.ReadLine());
                if (Numer2 == 0)
                {
                    Console.WriteLine("0 Não é um numero divisivel! tente novamente. ");

                }
                else
                {
                    double Numer3 = Numer1 / Numer2;
                    Console.WriteLine("A divisão de: " + Numer1 + " / " + Numer2 + " é: " + Numer3);
                }
            }
        }
        //TABUADA
        public void Tabuada()
        {
            Console.WriteLine("Você selecionou a opção tabuada! ");
            Console.Write("Por-favor digite o numero que gostaria de saber a tabuada: ");
            int Numer1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Até aonde gostaria de saber a tabuada? ");
            int Numer2 = int.Parse(Console.ReadLine());
            for (int i = 0; i <= Numer2; i++)
            {
                int Numer3 = Numer1 * i;
                Console.WriteLine("A tabuada de " + Numer1 + " é: " + Numer3);
            }
        }
        //RESTO DIVISÃO
        public void MOD()
        {
            Console.WriteLine("Você selecionou a opção MOD! (Resto da divisão)");
            Console.Write("Por-favor digite o primeiro numero!, lembrando que 0 não é um numero divisivel.");
            double Numer1 = double.Parse(Console.ReadLine());
            if (Numer1 == 0)
            {
                Console.WriteLine("0 não é um numero divisivel! tente novamente.");

            }
            else
            {
                Console.Write("Por-favor digite o segundo numero! ");
                double Numer2 = double.Parse(Console.ReadLine());
                if (Numer2 == 0)
                {
                    Console.WriteLine("0 não é um numero divisivel! tente novamente.");

                }
                else
                {
                    double Numer3 = Numer1 % Numer2;
                    Console.WriteLine("O resto da divisão de " + Numer1 + " e " + Numer2 + " é: " + Numer3);
                }
            }

        }
        //CALCULAR NOTA
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
        //MMC
        public int CalcularMDC()
        {
            Console.WriteLine("Você selecionou a opção calcular MMC!");
            Console.Write("Digite o primeiro numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());
            // Validação de entrada
            if (numero2 == 0)
            {
                throw new ArgumentException("O divisor não pode ser zero.");
            }

            // Casos especiais
            if (numero1 == numero2)
            {
                return numero1;
            }

            if (numero1 == 1 || numero2 == 1)
            {
                return 1;
            }

            int resto;
            int mdc = numero2;

            while (true)
            {
                resto = numero1 % mdc;
                numero1 = mdc;
                mdc = resto;

                if (resto == 0)
                {
                    break;
                }
            }
            Console.WriteLine("O MDC dos numeros escolhidos é: " + mdc);
            return mdc;
            
        }



    }
}


