using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class BolaSemSingleton
    {    //SEALED: Não permite que a classe seja herdada 
        public BolaSemSingleton()
        {
            Console.WriteLine("Bola em jogo!");
        }

        public void Mensagem(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
