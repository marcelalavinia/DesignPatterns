using Prototype.Prototype;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.ConcretePrototype
{
    public class FuncionarioPermanente : IFuncionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Tipo { get; set; }
        public IFuncionario Clone()
        {
            //MemberwiseClone: Cria uma cópia do objeto atual
            return MemberwiseClone() as IFuncionario;
        }
    }
}
