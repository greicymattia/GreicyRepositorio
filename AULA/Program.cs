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
        static void Main(string[] args)
        {
            //quantidade de caracter que tem na string (contando os espaços);
            string s = "Nome da Pessoa";
            int quantidade = s.Length;
            Console.WriteLine(quantidade);
            
            //recuperar um caracter de acordo com a sua posição
            char c = s[0];
            Console.WriteLine(c); //ixibira a letra 'N'

            //verfica se tem aquela palavra/caracter na string

            s = "Apostila de Java";

            bool resultado1 = s.Contains("C#");
            bool resultado2 = s.Contains("Java");

            //false
            Console.WriteLine(resultado1);

            //true
            Console.WriteLine(resultado2);


            //Extrair um trecho de uma string
            string s1 = " Thiago Sartor ";
            string s2 = s1.Substring(7);    // " Sartor ";
            string s3 = s1.Substring(0, 6); // " Thiag";
            string s4 = s1.Substring(1, 1); // "T";

        
        }
    }
}
