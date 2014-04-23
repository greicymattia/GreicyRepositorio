using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 19;   /// LONG RECEBE INTEIRO!!
            long valor2 = valor;
            string valor1 = "19";
            long valor4 = int.Parse(valor1); /// CONVERTER VERIAVEL!!!
            Console.WriteLine(valor4);
            valor4 = Convert.ToInt32(valor1); // CONVERTER VARIAVEL!!!
            Console.WriteLine(valor4);
            Console.ReadKey();
            //CASTING...

        }
    }
}
