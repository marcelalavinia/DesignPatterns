using System;

namespace FactoryMethod.ConcreteProduct
{
    //ConcreteProduct: Implementa a interface do produto.
    public class Scorpion : Personagem
    {
        public override void Escolhido()
        {
            Console.Write("Scorpion");
        }
    }
}
