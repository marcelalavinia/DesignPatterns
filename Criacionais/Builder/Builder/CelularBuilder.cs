using Builder.Product;

namespace Builder.Builder
{
    //Builder: Especifica uma interface abstrata para criar partes de um objeto produto
    public abstract class CelularBuilder
    {
        //Produto
        protected Celular celular;
        public Celular Celular
        {
            get{ return celular; }
        }

        public abstract void BuildTela();
        public abstract void BuildBateria();
        public abstract void BuildSistema();
        public abstract void BuildCamera();
    }
}
