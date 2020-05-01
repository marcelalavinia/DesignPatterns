using FactoryMethod.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    //Creator: 
    // - Declara o método de fábrica, que retorna um objeto do tipo produto.
    // - O cirador também pode definir uma implementação padrão do método de fábrica que retorna um objeto ConcreteProduct padrão.
    // - Pode chamar o método de fábrica para criar um objeto produto.

    //ConcreteCreator: Substitui o método de fábrica para retornar uma instância de um ConcreteProduct
    public class FactoryMethod 
    {
        //Cria objeto Produto (FactoryMethod)
        public Personagem EscolherPersonagem(string personagem)
        {
            return personagem switch
            {
                "Liu Kang" => new LiuKang(),
                "Scorpion" => new Scorpion(),
                "SubZero" => new SubZero(),
                _ => null,
            };
        }
    }
}
