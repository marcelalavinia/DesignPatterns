using Builder.Builder;
using Builder.Product;

namespace Builder.ConcrectBuilder
{
    //ConcreteBuilder: 
    // - Constrói e monta partes do produto implementando a interface do builder
    // - Define e acompanha a representação que cria
    // - Fornece uma interface para recuperar o produto
    public class IPhoneBuilder : CelularBuilder
    {
        public IPhoneBuilder()
        {
            celular = new Celular("IPhone");
        }

        public override void BuildBateria()
        {
            celular.Bateria = "134_HM";
        }

        public override void BuildCamera()
        {
            celular.Camera = "15 MP";
        }

        public override void BuildSistema()
        {
            celular.Sistema = "iOS 11";
        }

        public override void BuildTela()
        {
            celular.Tela = "9";
        }
    }
}
