using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Product
{
    //Product: 
    // - Representa o objeto complexo em construção.
    // - ConcreteBuilder constrói a representação interna do produto e define o processo pelo qual é montado.
    // - Inclui classes que definem as peças constituintes, incluindo interfaces para montagem das peças no resultado final.
    public class Celular
    {
        public Celular(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
        public string Tela { get; set; }
        public string Bateria { get; set; }
        public string Sistema { get; set; }
        public string Camera { get; set; }
    }
}
