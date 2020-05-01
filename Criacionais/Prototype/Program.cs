using Prototype.ConcretePrototype;
using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionarioPermanente funcionarioPermanente = new FuncionarioPermanente();
            funcionarioPermanente.Nome = "João";
            funcionarioPermanente.Idade = 30;
            funcionarioPermanente.Tipo = "Permanente";

            FuncionarioPermanente cloneFuncionarioPermanente = (FuncionarioPermanente)funcionarioPermanente.Clone();
            cloneFuncionarioPermanente.Nome = "Carlos";
            cloneFuncionarioPermanente.Idade = 40;

            Console.WriteLine("Detalhes do Funcionário Permanente");
            Console.WriteLine("Nome: {0}, Idade: {1}, Tipo: {2}", funcionarioPermanente.Nome, funcionarioPermanente.Idade, funcionarioPermanente.Tipo); ;

            Console.WriteLine("");

            Console.WriteLine("Detalhes do Funcionário Permanente CLONADO");
            Console.WriteLine("Nome: {0}, Idade: {1}, Tipo: {2}", cloneFuncionarioPermanente.Nome, cloneFuncionarioPermanente.Idade, cloneFuncionarioPermanente.Tipo); ;


            Console.ReadKey();
        }
    }
}
