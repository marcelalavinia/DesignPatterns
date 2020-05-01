using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    //SINGLETON: O objetivo desse pattern é garantir que apenas uma unica instancia da classe possa ser criada em memória.

    /*Exemplo de uso: Quando você necessita de somente uma instância da classe, por exemplo, a conexão com banco de dados, 
    vamos supor que você terá que chamar diversas vezes a conexão com o banco de dados em um código na mesma execução, 
    se você instanciar toda vez a classe de banco, haverá grande perda de desempenho, assim usando o padrão singleton,
    é garantida que nesta execução será instânciada a classe somente uma vez. */

    public class Singleton
    {
        //Para não permitir que a classe seja instancia com new.
        protected Singleton()
        {
        }

        private static Singleton instancia = null;

        public static Singleton GetInstancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Singleton();
                    Console.WriteLine("Bola em jogo!");
                }

                return instancia;
            }
        }

        public void Mensagem(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
