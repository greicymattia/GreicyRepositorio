using System;

namespace Unidades
{
     class Complementar_UnidadeIII
    {
         public static double Base = 0;
         public static double potenc = 0;
         public static double result = 0;
         public static int resultado = 0;
         public static string resp = null;
         public static int num = 0;
        // static void Main1 (string[] args)
        //{
        //    Console.Write("Digite o tempo gasto na viagem (em horas): ");
        //    double tempo = double.Parse(Console.ReadLine());
        //    Console.Write("Digite a velocidade média da viagem: ");
        //    double velMed = double.Parse(Console.ReadLine());
        //    double Dist = tempo * velMed;
        //    double LitrosUsados = Dist / 12;
        //    Console.Clear();
        //    Console.WriteLine("Velocidade Média: " + velMed+" Km/h");
        //    Console.WriteLine("Tempo gasto: " + tempo+" h.");
        //    Console.WriteLine("Distancia: " + Dist+" Km/h");
        //    Console.WriteLine("Litros de combustivel: " + LitrosUsados+" l.");
        //    Console.ReadKey();
        //}

         //--------------------------------------------------------------------------
        // static void Main2(string[] args)
        //{
           
        //   ler();
        //   double resultado = potencia(Base,potenc);
        //   Console.WriteLine(resultado);
        //   Console.ReadKey();
            
        //}
        //static void ler ()
        //{
        //     Console.Write("Digite a base: ");
        //     Base = double.Parse(Console.ReadLine());
        //     Console.Write("Digite a potencia: ");
        //     potenc = double.Parse(Console.ReadLine());
        //}
        //static double potencia(double b, double p)
        //{
        //    result = Math.Pow(b,p); // Math (de matematica)  - Pow (de potencia);
        //    return result;
        //}
     //------------------------------------------------------------------------------
         //static void Main3(string[] args)
         //{
         //    Console.Write("Digite um numero: ");
         //    double num1 = double.Parse(Console.ReadLine());
         //    Console.Write("Digite outro numero: ");
         //    double num2 = double.Parse(Console.ReadLine());
         //    double resp = media(num1,num2);
         //    Console.WriteLine("Média: "+resp);
         //    Console.ReadKey();

         //}
         //static double media(double x, double y)
         //{
         //    result = (x+y)/2;
         //    return result;
         //}
     //-----------------------------------------------------------------------------
         //static void Main4(string[] args)
         //{
         //    Console.WriteLine("Digite um numero: ");
         //    int num1 = int.Parse(Console.ReadLine());
         //    Console.WriteLine("Digite outro numero: ");
         //    int num2 = int.Parse(Console.ReadLine());
         //    multiplicacao(num1, num2);
         //    Console.WriteLine("Multiplicação: "+result);
         //    Console.ReadKey();
         //}
         //static void multiplicacao(int x, int y)
         //{
         //    result = x * y;
             
         //}
         //----------------------------------------------------------------------
         //static void Main5(string[] args)
         //{
         //    resultado = ler();
         //    resp = verificar(resultado);
         //    Console.WriteLine(resp);
         //    Console.ReadKey();
         //}
         //static int ler()
         //{
         //    Console.Write("Digite um numero: ");
         //    num = int.Parse(Console.ReadLine());
         //    return num;
         //}
         //static string verificar(int x)
         //{
         //    if (x > 0)
         //    {
         //        return "Numero Positivo!!";
         //    }else
         //    {
         //        if (x == 0)
         //        {
         //            return "Numero igual a Zero!!";
         //        }else
         //        {
         //            return "Numero Negativo!!";
         //        }
         //    }
         
         //}
         //static void Main6(string[] args)
         //{
         //    Console.Write("Digite a idade do nadador: ");
         //    int idade = int.Parse(Console.ReadLine());
         //    resp = ler(idade);
         //    Console.WriteLine(resp);
         //    Console.ReadKey();
         //}
         //static string ler(int x)
         //{
         //    if (x >= 5 && x<=7)
         //    {
         //        return "Categoria: Infantil A.";
         //    }
         //    else
         //    {
         //        if (x >= 8 && x<=10)
         //        {
         //            return "Categoria: Infantil B.";
         //        }
         //        else
         //        {
         //            if (x >= 11 && x<=13)
         //            {
         //                return "Categoria: Juvenil A.";
         //            }
         //            else
         //            {
         //                if (x >= 14 && x <= 17)
         //                {
         //                    return "Categoria: Juvenil B.";
         //                }
         //                else
         //                {
         //                    if (x >= 18 && x <= 25)
         //                    {
         //                        return "Categoria: Sênior.";
         //                    }
         //                    else
         //                    {
         //                        return "Idade fora dos padrões.";
         //                    }
         //                }
         //            }
         //        }
         //    }
             
             
         //}
         //static void Main7(string[] args)
         //{
         //    Console.WriteLine("100 - Cachorro quente ------ 1,10;");
         //    Console.WriteLine("101 - Bauru simples -------- 1,30;");
         //    Console.WriteLine("102 - Bauru c/ ovo --------- 1,50;");
         //    Console.WriteLine("103 - Hamburguer ----------- 1,10;");
         //    Console.WriteLine("104 - Cheeseburger --------- 1,30;");
         //    Console.WriteLine("105 - Refrigerante --------- 1,00.");
         //    Console.Write("Digite o código do produto: ");
         //    int cod = int.Parse(Console.ReadLine());
         //    Console.Write("Digite a quantidade do produto: ");
         //    int quant = int.Parse(Console.ReadLine());
         //    if (cod == 100 || cod == 103)
         //    {
         //        result = 1.1 * quant;
         //    }
         //    else
         //    {
         //        if (cod == 101 || cod == 104)
         //        {
         //            result = 1.3 * quant;
         //        }
         //        else
         //        {
         //            if (cod == 102)
         //            {
         //                result = 1.5 * quant;
         //            }
         //            else
         //            {
         //                if (cod == 105)
         //                {
         //                    result = 1 * quant;
         //                }
         //            }
         //        }
         //    }
         //    Console.WriteLine("Valor a pagar: " + result);
         //    Console.ReadKey();

         //}
         //static void Main8(string[] args)
         //{
         //    int opcao = 0;
         //    Console.Write("Digite um valor: ");
         //    Base = double.Parse(Console.ReadLine());
         //    Console.Write("Digite outro valor: ");
         //    potenc = double.Parse(Console.ReadLine());
         //    Console.WriteLine("1 - Multiplicação;");
         //    Console.WriteLine("2 - Divisão;");
         //    Console.WriteLine("3 - Subtração;");
         //    Console.WriteLine("4 - Adição.");
         //    Console.Write("Digite uma opção: ");
         //    opcao = int.Parse(Console.ReadLine());
         //    Console.Clear();            
         //    switch (opcao)
         //    {
         //        case 1:
         //            multiplicacao();
         //            break;
         //        case 2:
         //            divisao();
         //            break;
         //        case 3:
         //            subtracao();
         //            break;
         //        case 4:
         //            adicao();
         //            break;
         //        default:
         //            break;
         //    }
         //    Console.ReadKey();
         //}
         //static void multiplicacao()
         //{
         //    result = Base * potenc;
         //    Console.WriteLine("Multiplicação: "+result);
         //}
         //static void divisao()
         //{
         //    result = Base / potenc;
         //    Console.WriteLine("Divisão: " + result);
         //}
         //static void subtracao()
         //{
         //    result = Base - potenc;
         //    Console.WriteLine("Subtração: " + result);
         //}
         //static void adicao()
         //{
         //    result = Base + potenc;
         //    Console.WriteLine("Adição: " + result);
         //}
         //static void Main9(string[] args)
         //{
         //    Console.Write("Escreva o nome do funcionário: ");
         //    string nome = Console.ReadLine();
         //    Console.Write("Digite a categoria do funcionário (A-Z): ");
         //    string categoria = Console.ReadLine();
         //    Console.Write("Digite o salario do empregado: ");
         //    double salario = double.Parse(Console.ReadLine());
         //    categoria = categoria.ToUpper();
         //    if (categoria == "A" || categoria == "C" || categoria == "F" || categoria == "H")
         //    {
         //        salario = salario * 0.1 + salario;
         //    }
         //    else
         //    {
         //        if (categoria == "B" || categoria == "D" || categoria == "E" || categoria == "I" || categoria == "J" || categoria == "T")
         //        {
         //            salario = salario * 0.15 + salario;
         //        }
         //        else
         //        {
         //            if (categoria == "K" || categoria == "R")
         //            {
         //                salario = salario * 0.25 + salario;
         //            }
         //            else
         //            {
         //                if (categoria == "L" || categoria == "M" || categoria == "N" || categoria == "O" || categoria == "P" || categoria == "Q" || categoria == "S")
         //                {
         //                    salario = salario * 0.35 + salario;
         //                }
         //                else
         //                {
         //                    if (categoria == "U" || categoria == "V" || categoria == "X" || categoria == "Y" || categoria == "W" || categoria == "Z")
         //                    {
         //                        salario = salario * 0.5 + salario;
         //                    }
         //                    else
         //                    {
         //                        Console.WriteLine("Categoria inexistente!");
         //                    }
         //                }
         //            }
         //        }
         //    }
         //    Console.Clear();
         //    Console.WriteLine("Funcionário: " + nome);
         //    Console.WriteLine("Categoria: " + categoria);
         //    Console.WriteLine("Novo salário: " + salario);
         //    Console.ReadKey();
         //}
         //static void Main10(string[] args)
         //{
         //    Console.Write("Digite um lado: ");
         //    double num1 = double.Parse(Console.ReadLine());
         //    Console.Write("Digite outro lado: ");
         //    double num2 = double.Parse(Console.ReadLine());
         //    Console.Write("Digite outro lado: ");
         //    double num3 = double.Parse(Console.ReadLine());
         //    double lado1 = num1 + num2;
         //    double lado2 = num1 + num3;
         //    double lado3 = num2 + num3;
         //    if (num1 < lado1 && num1 < lado2 && num1 < lado3 && num2 < lado1 && num2 < lado2 && num2 < lado3 && num3 < lado1 && num3 < lado2 && num3 < lado3)
         //    {
         //        if (num1 == num2 && num1 == num3)
         //        {
         //            Console.WriteLine("É um triangulo Equilátero!");
         //        }
         //        else
         //        {
         //            if (num1 != num2 && num1 != num3 && num2 != num3)
         //            {
         //                Console.WriteLine("É um triangulo Escaleno!");
         //            }
         //            else
         //            {
         //                Console.WriteLine("É um triangulo Isóscele!");
         //            }
         //        }
         //    }
         //    else
         //    {
         //        Console.WriteLine("Não é um triangulo!");
         //    }
         //    Console.ReadKey();
         //}
    }
}