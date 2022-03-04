using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            //utilizando o var a declaração de tipos será atribuida 
            // de acordo com o conteudo da variavel

            var nome = "Maria da Silva";

            Console.WriteLine(nome);
            // nome = 10; não é possivel alterar o valor para outro tipo,
            // uma vez que a variavel foi criada com um valor "string"

            // o c# é uma linguagem fortemente tipada
            // vamos recordar alguns tipos:
            // imt        -> 215
            // float      -> 25.41
            // bool       -> true | false
            // string     -> "fundação instituto tecnologico"
            // char       -> 'F'

            int exemplo = 1942;
            string corFavorita = "cinza";
            float velocidadeF1 = 296.34f;
            double pibAmericano = 555555.555d;
            bool teveAulaSabado = true;

            Console.Write(exemplo + "\n");
            Console.WriteLine(corFavorita);
            Console.WriteLine(velocidadeF1);
            Console.WriteLine(pibAmericano);
            Console.WriteLine(teveAulaSabado);
            
            
            //testando variavel
            Console.WriteLine(exemplo is string);
            dynamic corFavorita2:"Vermelho";
            
            console.WriteLine(corFavorita2);
            // utilizando o dynamic é possivel alterar o conteudo da variavel
            // com valores de outros tipos
            
            corFavorita = 12;
            
            Console.WriteLine(corFavorita2);
            
            

        }
    }
    
}
