using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidades
{
    //CONTROLE DE FLUXO
    class UnidadeVIII_Slides
    {
        static void Main1(string[] args)
        {
            Random num = new Random();
            double nota = num.NextDouble();
            string resultado = null;
            resultado = (nota >= 0.7) ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
        static void Main2(string[] args)
        {
            Random gerador = new Random();
            double preco = gerador.NextDouble();
            string resultado = null;
            string caminho = null;
            resultado = (preco >= 0.5) ? "CARO" : "BARATO";
            string camisa = null;
            camisa = (preco >= 0.5) ? "VERMELHA" : "AZUL";
            caminho = (preco >= 0.5) ? "Vá para a direita" : "Vá para a esquerda";
            Console.WriteLine("Preço: {0}; \nCor:  {1};\n{2}.",resultado, camisa,caminho);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Random gerador = new Random();
            int A = gerador.Next(1, 5);
            int B = gerador.Next(1, 5);
            double divisao = A % B;
            string resultado = null;
            resultado = (divisao == 0) ? "A DIVISIVEL POR B" : "A NÃO É DIVISIVEL POR B";
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
