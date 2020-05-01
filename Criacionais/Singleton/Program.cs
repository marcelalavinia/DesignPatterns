using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton jogador_1 = Singleton.GetInstancia;
            //BolaSemSingleton jogador_1 = new BolaSemSingleton();
            jogador_1.Mensagem("Jogador 1: A bola está comigo!");

            Singleton jogador_2 = Singleton.GetInstancia;
            //BolaSemSingleton jogador_2 = new BolaSemSingleton();
            jogador_2.Mensagem("Jogador 2: recebeu  a bola do jogador 1.");

            Singleton jogador_3 = Singleton.GetInstancia;
            // BolaSemSingleton jogador_3 = new BolaSemSingleton();
            jogador_3.Mensagem("Jogador 3: recebeu  a bola do jogador 2.");

            Console.ReadKey();
        }
    }
}
