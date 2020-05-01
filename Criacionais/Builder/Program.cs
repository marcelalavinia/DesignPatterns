using Builder.Builder;
using Builder.ConcrectBuilder;
using Builder.Director;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria o Fabricante 
            Fabricante fabricante = new Fabricante();

            //Permite que a classe Builder esteja pronta
            CelularBuilder celularBuilder = null;

            //Agora vamos criar um telefone 

            celularBuilder = new IPhoneBuilder();
            //celularBuilder = new AndroidBuilder();
            fabricante.Construtor(celularBuilder);

            Console.WriteLine("Celular Fabricado: {0}", celularBuilder.Celular.Nome);
            Console.WriteLine("Camera: {0}", celularBuilder.Celular.Camera);
            Console.WriteLine("Bateria: {0}", celularBuilder.Celular.Bateria);
            Console.WriteLine("Sistema Operacional: {0}", celularBuilder.Celular.Sistema);
            Console.WriteLine("Tela: {0}", celularBuilder.Celular.Tela);

            Console.ReadKey();
        }
    }
}
