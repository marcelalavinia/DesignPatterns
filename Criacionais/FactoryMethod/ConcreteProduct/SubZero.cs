using System;

namespace FactoryMethod.ConcreteProduct
{
    //ConcreteProduct: Implementa a interface do produto.
    public class SubZero : Personagem
    {
        public override void Escolhido()
        {
            Console.Write("SubZero");
        }
    }
}
