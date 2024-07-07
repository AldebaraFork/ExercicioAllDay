using System.Runtime.CompilerServices;

namespace PaymentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pessoaFisica = new PessoaFisica();
            PessoaJuridica pessoaJuridica = new PessoaJuridica();

            pessoaJuridica.Nome = "eduardo";
            pessoaFisica.Nome = "eduardo";

            if (pessoaJuridica.Nome.Equals(pessoaFisica.Nome))
            {
                Console.WriteLine("Os nomes sao iguais");
            }
            else
            {
                Console.WriteLine("Os nomes sao diferentes!");
                
            }
        }
        public interface IPessoa
        {

            string Nome { get; set; }
            int Id { get; set; }

        }

        public class PessoaJuridica : IPessoa
        {

            public string Nome { get; set; }
            public int Id { get; set; }
            public int CNPJ { get; set; }
        }

        public class PessoaFisica : IPessoa
        {

            public string Nome { get; set; }
            public int Id { get; set; }
            public int CPF { get; set; }

        }
    }
}
