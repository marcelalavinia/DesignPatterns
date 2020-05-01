using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractProduct;
using AbstractFactory.Product;

namespace AbstractFactory.ConcreteFactory
{
    //ConcreteFactory: Implementa as operações para criar objetos de produtos concretos
    public class CarroLuxoFactory : CarroFactory
    {
        public override Roda MontarRoda()
        {
            return new RodaLigaLeve();
        }

        public override Som MontarSom()
        {
            return new BluetoohPlayer();
        }
    }
}
