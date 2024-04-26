using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    internal class Class
    {
        public class Teste
        {
            public void OP()
            {
                //Matriz com 7 valores
                var numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };
                //Matriz com 10 valores
                var numbers2 = new int[] { 10 };

                //percorrendo um array 
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine("Is working, i think");
                }
            }
            public void Lista()
            {
                //Lista com 10 valores
                var lista = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                //Adiciona 10 valores a lista
                lista.Add(10);
                //adiciona uma coleção
                lista.AddRange(new List<int> { 11, 12 });

                //Verifica se contem um elemento dentro da lista
                var contem = lista.Contains(2);
                if (contem == true)
                {
                    Console.WriteLine("Contem o valor 2");

                }
                else
                {
                    Console.WriteLine("Não contem o valor 2");
                }

            }
            public class Student
            {
                public string Nome;
                public string ID;
                public int Idade;
                public string Curso;

            }

        }
    }
}
