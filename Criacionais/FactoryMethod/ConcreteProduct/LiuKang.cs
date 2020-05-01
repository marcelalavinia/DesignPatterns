using System;

namespace FactoryMethod.ConcreteProduct
{
    //ConcreteProduct: Implementa a interface do produto.
    public class LiuKang : Personagem
    {
        public override void Escolhido()
        {
            Console.Write("Liu Kang");
        }
    }
}
