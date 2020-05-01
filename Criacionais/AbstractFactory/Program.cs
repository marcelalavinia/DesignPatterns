using AbstractFactory.AbstractProduct;
using AbstractFactory.Client;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = ExecuteAbstractFactory.MontarCarro("luxo");
            Carro c2 = ExecuteAbstractFactory.MontarCarro("popular");


            Console.ReadKey();
        }
    }
}
