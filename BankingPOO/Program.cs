using System.Data.SqlTypes;
using System.Security.Cryptography.X509Certificates;

namespace BankingPOO
{
    internal class Program
    {
        //CLASSE PRINCIPAL
        static void Main(string[] args)
        {
            GerenciarDinheiro dindin = new GerenciarDinheiro();

            dindin.Money = double.Parse(Console.ReadLine());
            Console.WriteLine(dindin.Money);
            

        }

    }

    //COMO USAR O GET E SET
    public class GerenciarDinheiro
    {
        public double Money { get; set; }



    }
}