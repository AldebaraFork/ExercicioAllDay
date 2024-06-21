using System.Data.SqlTypes;
using System.Security.Cryptography.X509Certificates;

namespace BankingPOO
{
    internal class Program
    {
        //CLASSE PRINCIPAL
        static void Main(string[] args)
        {




        }

    }

    //COMO USAR O GET E SET
    public class DadosPagamento()
    {
        //PIX
        public string CodigoPix { get; set; }


        //DADOS CARTAO
        public string NumeroCartao { get; set; }
        public string NomeCartao { get;  set; }
        public DateTime ValidadeCartao { get; set; }

        public string CodigoSeguranca { get; set; }


    }
    public class Pagamentos : DadosPagamento
    {
        public DateTime Vencimento { get; set; }

        public void PagarComCartao()
        {
            Console.Write("Por-favor insira os numeros no cartão: ");
            NumeroCartao = Console.ReadLine();
            Console.Write("Agora insira o nome impresso no cartão");
            NomeCartao = Console.ReadLine().ToUpper();
            Console.Write("Insira o Codigo de segurança atrás do cartão: ");


            //VALIDAÇÃO CVV
            CodigoSeguranca = Console.ReadLine();
            if (CodigoSeguranca.Length > 3)
            {
                Console.WriteLine("Valor invalido!");
                Thread.Sleep(2000);
                Console.Clear();
                PagarComCartao();

                
            }else if (CodigoSeguranca.Length <= 3)
            {
                Console.WriteLine("Obrigado por informar! ");

            }
            Console.WriteLine("Dados do cartão salvo ! ");
        }
    }
}