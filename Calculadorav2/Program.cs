namespace CalculadoraV2
{
    internal class Program
    {
        static void Main(string[] args)
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
            int OpcaoSelcionada = int.Parse(Console.ReadLine());
            switch (OpcaoSelcionada)
            {
                case 1:
                    Soma soma = new Soma();
                    soma.CalcularSoma();
                    break;
                case 2:
                    Subtracao subtracao = new Subtracao();
                    subtracao.CalcularSubtracao();
                    break;
                case 3:
                    Multiplicar Multiplicar = new Multiplicar();
                    Multiplicar.CalcularMultiplicacao();
                    break;
                case 4:
                    Divisao divisao = new Divisao();
                    divisao.CalcularDivisao();
                    break;
                case 5:
                    Tabuada tabuada = new Tabuada();
                    tabuada.CalcularTabuada();
                    break;
                case 6:
                    MOD mod = new MOD();
                    mod.Calcularmod();
                    break;
                case 7:
                    Nota nota = new Nota();
                    nota.CalcularNota();
                    break;
                case 8:
                    MDC mdc = new MDC();
                    mdc.CalcularMDC();
                    break;
                default:
                    Console.WriteLine("Ooção invalida! tente novamente");
                    break;
            }

        }
    }
}