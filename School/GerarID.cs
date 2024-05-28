using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class GerarID
    {
        public void gerarID()
        {
            Console.Clear();

            SchoolSystem schoolSystem = new SchoolSystem();
            Console.WriteLine("Olá, aqui iremos gerar seu ID (identificação)");
            Console.WriteLine("Por-favor digite seu cargo: ");
            Console.WriteLine("1 - Aluno");
            Console.WriteLine("2 - Professor");
            Console.WriteLine("3 - Diretoria");
            Console.WriteLine("0 - retornar ao menu");
            var cargo = int.Parse(Console.ReadLine());
            switch (cargo)
            {
                case 1:
                    Console.WriteLine("Por-favor insira seu nome:");
                    var NomeAluno = Console.ReadLine();
                    Console.WriteLine($"Olá! {NomeAluno}, gerando seu ID...");
                    Thread.Sleep(2500);
                    Console.Clear();
                    var Id = Guid.NewGuid().ToString().Substring(0, 5);
                    Console.WriteLine($"{NomeAluno} ID gerado! Seu id é: {Id} ,Por-favor anote esse numero");
                    SalvarArquivo salvas = new SalvarArquivo();
                     salvas.Salvar(Id);
                    break;
                default:
                    Console.WriteLine("Opção invalida! retornando ao menu de Id...");
                    Thread.Sleep(3000);
                    gerarID();
                    break;
            }
            
           
            
        }
    }
}
