﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 8 - Condicionais2");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            bool acompanhado = quantidadePessoas >= 2;

            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar");
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }

            Console.ReadLine();
        }
    }
}
