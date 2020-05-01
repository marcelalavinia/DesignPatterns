using Builder.Builder;
using Builder.Product;

namespace Builder.ConcrectBuilder
{
    //ConcreteBuilder: 
    // - Constrói e monta partes do produto implementando a interface do builder
    // - Define e acompanha a representação que cria
    // - Fornece uma interface para recuperar o produto
    public class AndroidBuilder : CelularBuilder
    {
        public AndroidBuilder()
        {
            celular = new Celular("Android");
        }

        public override void BuildBateria()
        {
            celular.Bateria = "MAH_1500";
        }

        public override void BuildCamera()
        {
            celular.Camera = "15 MP";
        }

        public override void BuildSistema()
        {
            celular.Sistema = "Android 4.5";
        }

        public override void BuildTela()
        {
            celular.Tela = "7";
        }
    }
}
