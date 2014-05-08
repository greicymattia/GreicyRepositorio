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

        //OPERADORES DE ATRIBUIÇÃO;
        static void Main2(string[] args)
        {
            int i = 0;
            i++;        //i=i+1;  executa dps     (pós)
            i--;        //i=i-1;  executa dps     (pós)  
            --i;        //i=i-1;  executa antes   (pré)
            ++i;        //i=i+1;  executa antes   (pré)
            i += 3;     // i=i+3;
            i -= 2;     //i=i-2;
            i *= 5;     //i=i*5;
            i /= 1;     // i=i/1;
            i %= 2;     //i=i%2;
        }
        
        //OPERADORES RELACIONAIS
        static void Main3(string[] args)
        {
            int i = 7;
            bool j = false;
            j = (i == 7);
            j = (i != 7);
            j = (i >= 5);
            j = (i <= 3);

        }

        //OPERADORES LOGICOS
        static void Main4(string[] args){
            int i = 7;
            bool j = false;
            j = (i == 6 && i != 7); // E
            j = (i <= 10 || i >= 5); // OU
            j = (i == 7 ^ i <= 10);   // XOR

        }
        //OPERADOR TERNARIO
        static void Main5(string[] args)
        {
            double nota = 0.8;
            string resultado = nota >= 0.5 ? "aprovado" : "reprovado";
            Console.WriteLine(nota >= 0.5 ? "aprovado" : "reprovado");
            
            //NEGAÇÃO
            if (!(nota == 0.8))
            {
                Console.WriteLine(!(nota == -8));
            }
            int i = 10;

            // INCREMENTO E DECREMENTO (PÓS E PRÉ)
            int j = ++i + i--;

            Console.WriteLine(j);
            Console.WriteLine(i);
            Console.ReadKey();
        }

    }
}
