using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //De 1900.0 até 2800.0, o IR é de 7.5 % e pode deduzir na declaração o valor de R$ 142;
            //De 2800.01 até 3751.0, o IR é de 15 % e pode deduzir R$ 350;
            //De 3751.01 até 4664.00, o IR é de 22.5 % e pode deduzir R$ 636.

            Console.WriteLine("Executando Exercicio 1");

            double salario = 3300.0;

            if (1900.0 <= salario && salario <= 2800.0)
            {
                Console.WriteLine("A sua alíquota é de 7.5%");
                Console.WriteLine("Pode deduzir o valor de R$ 142");
            }
            else
            {
                if (2800.01 <= salario && salario <= 3751.0)
                {
                    Console.WriteLine("A sua alíquota é de 15%");
                    Console.WriteLine("Pode deduzir o valor de R$350");
                }
                else
                {
                    if (3751.01 <= salario && salario <= 4664.0)
                    {
                        Console.WriteLine("A sua alíquota é de 22.5%");
                        Console.WriteLine("Pode deduzir o valor de R$636");
                    }
                }
            }


            Console.ReadLine();
            
        }
    }
}
