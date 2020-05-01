using Prototype.Prototype;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.ConcretePrototype
{
    public class FuncionarioTemporario : IFuncionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Tipo { get; set; }
        public IFuncionario Clone()
        {
            return MemberwiseClone() as IFuncionario;
        }
    }
}
