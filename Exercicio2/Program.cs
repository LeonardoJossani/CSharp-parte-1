using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Exercicio 2");
            //Imprimir na tela todos os números multiplos por 3 de 1 a 100

            for (int numero = 1; numero <= 100; numero++)
            {
                if (numero % 3 == 0)
                {
                    Console.WriteLine("O número " + numero + " é multiplo de 3");
                }
            }

            Console.ReadLine();
        }
    }
}
