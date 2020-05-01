using Builder.Builder;

namespace Builder.Director
{
    //Director: Constrói um objeto usando a inteface Builder
    public class Fabricante
    {
        public void Construtor(CelularBuilder celularBuilder)
        {
            celularBuilder.BuildBateria();
            celularBuilder.BuildSistema();
            celularBuilder.BuildTela();
            celularBuilder.BuildCamera();
        }
    }
}
