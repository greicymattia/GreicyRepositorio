using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidades
{
    class Complementar_UnidadeVI
    {
        public static int A = 0;
        public static int B = 0;
        public static string senha = null;
        public static int Cont = 0;
        public static int DiaAtual, MesAtual, AnoAtual = 0;
        public static string Usuario = null;
        public static DateTime PrimeiraData = new DateTime();
        static void Main1(string[] args)
        {
            Console.Write("Digita a quantidade de maças da compra: ");
            int quantidade = int.Parse(Console.ReadLine());
            double total = 0;
            if (quantidade > 12)
            {
                total = quantidade * 0.25;
            }
            else
            {
                total = quantidade * 0.30;
            }
            Console.WriteLine("\nValor total da compra: R$ {0:F2}",total);
            Console.ReadKey();
        }
        static void Main2(string[] args)
        {
            int i = 0;
            for (i=0; i<5;i++){
                Console.Clear();
                if (Cont == 0)
                {
                  //  Cadastro();
                }
                else
                {
                    DateTime DataAtual = new DateTime();
                    DataAtual = DateTime.Now;
                    // Console.WriteLine("DataAtual: {0};  PrimeiraData: {1}", DataAtual, PrimeiraData);
                    // Console.ReadKey();
                    Console.Write("Usuario: {0} \nSenha: ",Usuario);
                    string tentativa = Console.ReadLine();
                    if (tentativa == senha)
                    {
                        Console.WriteLine("\nACESSO PERMITIDO!");
                        int total = DataAtual.Day - PrimeiraData.Day;
                        if (total >= 15)
                        {
                            // Alterar();
                            PrimeiraData = DataAtual;
                        }
                    }
                    else
                    {
                          Console.WriteLine("\nACESSO NEGADO!");
                    }
                }
                Console.ReadKey();
            }
        }
        //static void Cadastro()
        //{
        //    Console.Write("Digite o nome de usuario: ");
        //    Usuario = Console.ReadLine();
        //    Console.Write("Digite o dia atual: ");
        //    DiaAtual = int.Parse(Console.ReadLine());
        //    Console.Write("Digite o mes atual: ");
        //    MesAtual = int.Parse(Console.ReadLine());
        //    Console.Write("Digite o ano atual: ");
        //    AnoAtual = int.Parse(Console.ReadLine());
        //    PrimeiraData.AddDays(DiaAtual);
        //    PrimeiraData.AddYears(AnoAtual);
        //    PrimeiraData.AddMonths(MesAtual);
        //    Console.Clear();
        //    senha = "NomeUsuário123";
        //    Console.WriteLine("Primeira senha gerada automaticamente. \nSua senha é: {0}", senha);
        //    Cont = Cont + 1;
        //}
        //static void Alterar()
        //{
        //    Console.Write("\n\n{0}...\nSua senha expirou!\n\nPor favor digite a nova senha: ",Usuario);
        //    senha = Console.ReadLine();
        //}
        static void Main3(string[] args)
        {
            char sexo = ' ';
            Console.Write("Digite a sua altura: ");
            double altura = double.Parse(Console.ReadLine());
            do
            {
                Console.Write("Sexo (1 - Feminino/ 2 - Masculino): ");
                sexo = char.Parse(Console.ReadLine());
                if (sexo != 1 && sexo != 2)
                {
                    Console.WriteLine("Digite novamente...");
                }
            }while(sexo != '1' && sexo != '2');
            double pesoIdeal = 0;
            if (sexo == '1')
            {
                pesoIdeal = (62.1 * altura) - 44.7;
            }
            else
            {
                pesoIdeal = (72.7 * altura) - 58;
            }
            Console.WriteLine("Seu peso ideal é: {0:F2}Kg", pesoIdeal);
            Console.ReadKey();
        }
        static void Main4(string[] args)
        {
            Random Gol = new Random();
            int inter = Gol.Next(0,6);
            int gremio = Gol.Next(0,6);
            if (inter == gremio)
            {
                Console.WriteLine("Empate! \nGrêmio {0} X {1} Inter", gremio, inter);
            }
            else if (inter > gremio)
            {
                Console.WriteLine("Vitória dos Colorados! \nGrêmio {0} X {1} Inter", gremio, inter);
            }
            else
            {
                Console.WriteLine("Vitória do Tricolor Gaúcho! \nGrêmio {0} X {1} Inter", gremio, inter);
            }
            Console.ReadKey();
        }
        static void Main5(string[] args)
        {
            //Coluna 1: Codigo;
            //Coluna 2: idade;
            //Coluna 3: Quantidade de caixas;
            Console.Write("Digite quantos trabalhadores foram contratados: ");
            int quantidadeTrabalhadores = int.Parse(Console.ReadLine());
            Console.Clear();
            int i = 0;
            int[,] identificacao = new int[quantidadeTrabalhadores,3];

            double[] total = new double[quantidadeTrabalhadores];
            for (i = 0; i < quantidadeTrabalhadores; i++)
            {
                identificacao[i, 0] = i + 1;
                Console.Write("Digite a idade do trabalhador {0}:",identificacao[i,0]);
                identificacao[i, 1] = int.Parse(Console.ReadLine());
                Console.Write("Digite quantas caixas de laranja o trabalhador colheu: ");
                identificacao[i, 2] = int.Parse(Console.ReadLine());
                if (identificacao[i, 2] <= 5)
                {
                    total[i] = identificacao[i, 2] * 2;
                }else if(identificacao[i,2]<=10){
                    total[i] = identificacao[i, 2] * 2.5;
                }
                else if (identificacao[i, 2] <= 20)
                {
                    total[i] = identificacao[i, 2] * 3.5;
                }
                else
                {
                    total[i] = identificacao[i, 2] * 5;
                }
                if(identificacao[i,1]>=18 && identificacao[i,1]<=45){
                    total[i] = total[i] + total[i] * 0.1;
                }
                else if (identificacao[i, 1] <= 65)
                {
                    total[i] = total[i] + total[i] * 0.2;
                }
            }
            Console.Clear();
            for (i = 0; i < quantidadeTrabalhadores; i++)
            {
                Console.WriteLine("Codigo: {0}; \t Idade: {1}; \t Caixas: {2}; \t Pagar: R${3:F2}",identificacao[i,0],identificacao[i,1],identificacao[i,2],total[i]);
            }
            Console.ReadKey();
        }
        static void Main6(string[] args)
        {
            int cont = 0;
            string nomeMaior = null;
            double alturaMaior = 0;
            double altura = 0;
            string nome = null;
            do
            {
                if (cont == 0)
                {
                    Console.Write("Digite o nome: ");
                    nome = Console.ReadLine();
                    Console.Write("Digite a altura: ");
                    altura = double.Parse(Console.ReadLine());
                    nomeMaior = nome;
                    alturaMaior = altura;
                    cont = cont + 1;
                }
                else
                {
                    Console.Write("Digite o nome (ou FIM para encerrar): ");
                    nome = Console.ReadLine();
                    if (nome == "FIM" || nome=="fim")
                    {
                        Console.Clear();
                        break;
                    }
                    Console.Write("Digite a altura: ");
                    altura = double.Parse(Console.ReadLine());
                    if (altura > alturaMaior)
                    {
                        alturaMaior = altura;
                        nomeMaior = nome;
                    }
                    cont = cont + 1;
                }
                Console.Clear();
            } while (nome != "FIM");
            Console.WriteLine("Moças inscritas: {0}\nMoça mais alta...\t Nome: {1}.\t\tAltura: {2:F2}.",cont,nomeMaior,alturaMaior);
            Console.ReadKey();
        }
        static void Main7(string[] args)
        {
            Console.WriteLine("Escolha uma opção... \n('H' para horistas ou 'M' para mensalistas): ");
            string opcao1 = Console.ReadLine();
            double salarioBruto = 0;
            opcao1 = opcao1.ToUpper();
            if (opcao1 == "H")
            {
                Console.Write("Digite seu salario por hora: R$ ");
                double salarioHora = double.Parse(Console.ReadLine());
                Console.Write("Digite a quantidade de horas trabalhadas: ");
                double horas = double.Parse(Console.ReadLine());
                salarioBruto = horas * salarioHora;
            }
            else
            {
                Console.Write("Digite seu salário por mês: R$ ");
                double salarioMes = double.Parse(Console.ReadLine());
                Console.Write("Digite a quantidade de dias faltados no mês: ");
                int faltas = int.Parse(Console.ReadLine());
                salarioBruto = salarioMes - ((salarioMes/30) * faltas);
            }
            Console.WriteLine("Salario Bruto: R$ {0:F2}", salarioBruto);
            Console.ReadKey();
        }
        static void Main8(string[] args)
        {
            Console.Write("Digite a quantidade de autores: ");
            int quantidade = int.Parse(Console.ReadLine());
          //  string[] separador = new string[quantidade];
            string[] nomes = new string[quantidade];
            int i = 0;
            string X = ", ";
            for (i = 0; i < quantidade; i++)
            {
                Console.Write("Digite o primeiro e o ultimo nome do autor {0}: ", i + 1);
                nomes[i] = Console.ReadLine();
                string[] separador = nomes[i].Split(' ');
                separador[1] = separador[1].ToUpper();
                nomes[i] = separador[1] + X + separador[0];
            }
            for (i = 0; i < quantidade; i++)
            {
                Console.WriteLine(nomes[i]);
            }
            Console.ReadKey();
        }

        //static void Main10(string[] args)
        //{
        //    int i = 0;
        //    for (i = 0; i < 5; i++)
        //    {
        //        Console.Write("Digite um par de numeros: ");
        //        A = int.Parse(Console.ReadLine());
        //        B = int.Parse(Console.ReadLine());
        //        int divisor = divisoresA();
        //        if (divisor == B)
        //        {
        //            Console.WriteLine("{0} e {1} são numeros amigos!", A, B);
        //        }
        //        else
        //        {
        //            divisor = divisoresB();
        //            if (divisor == A)
        //            {
        //                Console.WriteLine("{0} e {1} são numeros amigos!", A, B);
        //            }
        //        }
        //        Console.ReadKey();
        //        Console.Clear();
        //    }
        //}
        //static int divisoresA()
        //{
        //    int i = 0;
        //    int soma = 0;
        //    for (i = 1; i < A; i++)
        //    {
        //        if (A % i == 0 && A != i)
        //        {
        //            soma = soma + i;
        //        }
        //    }
        //    return soma;
        //}
        //static int divisoresB()
        //{
        //    int i = 0;
        //    int soma = 0;
        //    for (i = 1; i < B; i++)
        //    {
        //        if (B % i == 0 && B != i)
        //        {
        //            soma = soma + i;
        //        }
        //    }
        //    return soma;
        //}
    }
}
