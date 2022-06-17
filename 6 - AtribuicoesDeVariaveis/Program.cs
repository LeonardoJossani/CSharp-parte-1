using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___AtribuicoesDeVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6 - Atribuições de Variaveis");

            int idade = 24;
            int idadeLeonardo = idade;

            idade = 67;

            Console.WriteLine(idade);
            Console.WriteLine(idadeLeonardo);

            Console.ReadLine();
        }
    }
}
