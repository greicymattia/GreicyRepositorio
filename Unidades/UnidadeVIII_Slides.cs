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
        static void Main(string[] args)
        {
            Random gerador = new Random();
            double preco = gerador.NextDouble();
            string resultado = null;
            resultado = (preco >= 0.5) ? "CARO" : "BARATO";
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
