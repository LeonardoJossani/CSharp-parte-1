using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Exercicio 3");
            // Imprimir na tela os valores dos fatoriais de 1 a 10

            int fatorial = 1;
            for (int i = 1; i <= 10; i++)
            {
                fatorial *= i;
                Console.WriteLine("Fatorial de " + i + " = " + fatorial);
            }

            Console.ReadLine();
        }
    }
}



