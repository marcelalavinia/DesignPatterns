﻿using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod fm = new FactoryMethod();

            Console.WriteLine("Liu Kang | SubZero | Scorpion");
            Console.WriteLine();
            Console.WriteLine("Escolha seu Personagem");

            string escolha = Console.ReadLine();

            Personagem personagem = fm.EscolherPersonagem(escolha);

            Console.WriteLine();
            Console.WriteLine("Você vai jogar com ");
            personagem.Escolhido();

            Console.ReadKey();

        }
    }
}
