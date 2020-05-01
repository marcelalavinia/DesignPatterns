using AbstractFactory.Product;
using System;

namespace AbstractFactory.AbstractProduct
{
    //AbstractProduct: Declara uma interface para um tipo de objeto de produto
    public class Carro
    {
        public Roda Roda { get; set; }
        public Som Som { get; set; }
    }
}
