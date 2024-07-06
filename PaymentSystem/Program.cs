namespace PaymentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public interface IPagamento
        {
            double Valor { get; set; }
            DateTime Vencimento { get; set; }

            Guid ReciboPagamento { get; set; }
        }

        public class PagamentoCartao : IPagamento
        {
            //INTERFACE 
            public double Valor { get; set; }
            public DateTime Vencimento { get; set; }
            public Guid ReciboPagamento { get; set; }

            //DADOS CARTÃO 
            protected string NumeracaoCartao { get; set; }
            protected string CVV { get; set; }
            protected string NomeCartao { get; set; }

            public void PagarCartao()
            {
                Console.WriteLine("")
            }
        }
    }
}
