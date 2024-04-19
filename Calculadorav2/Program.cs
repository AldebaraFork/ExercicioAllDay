namespace CalculadoraV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operacoes operacoes = new Operacoes();
            Console.WriteLine("Olá bem vindo a calculadora V2! Por-favor digite a opção desejada: ");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Tabuada");
            int OpcaoSelcionada = int.Parse(Console.ReadLine());
            switch (OpcaoSelcionada)
            {
                case 1:
                    operacoes.Soma();
                    break;
                case 2:
                    operacoes.Subtracao();
                    break;
                case 3:
                    operacoes.Multiplicacao();
                    break;
                case 4:
                    operacoes.Divisao();
                    break;
                case 5:
                    operacoes.Tabuada();
                    break;
            }

        }
    }
}