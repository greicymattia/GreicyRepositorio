using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidades
{
    class UnidadeVII_Operadores
    {
        //OPERADORES
        static void Main1(string[] args)
        {
            Console.WriteLine(1 + 1); //adição;
            Console.WriteLine(1 - 1); //subtração;
            Console.WriteLine(2 * 2); // multiplicação;
            Console.WriteLine((double)2 / (double)3); //divisão;
            Console.WriteLine((double)2 % (double)3); //módulo;
            Console.WriteLine((int)2 / (int)3); //divisão inteira;
            int x = 5;
            int y = 8;
            Console.WriteLine((double)x / y); // casting
            string A = "Ola";
            string B = "Mundo";
            string C = " ";
            string D = "!";
            Console.WriteLine(A + C + B + D); //Concatenação de Strings;
            Console.ReadKey();

        }
    }
}
