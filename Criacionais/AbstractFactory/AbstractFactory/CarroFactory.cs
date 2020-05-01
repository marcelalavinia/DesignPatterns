using AbstractFactory.AbstractProduct;

namespace AbstractFactory.AbstractFactory
{
    //AbstractFactory: Declara uma interace para operações que criam produtos abstratos.
    public abstract class CarroFactory
    {
        public abstract Roda MontarRoda();
        public abstract Som MontarSom();
    }
}
