using System;

namespace Unidades
{
    class UnidadeVI
    {
         static void Main1 (string[] args)
        {
            int[] num;
            num = new int[20];
            int[] numPos;
            numPos = new int[20];
            Console.Write("Digite 20 numeros: ");
            int posi = 0;
            int numNeg = 0;
            int i = 0;
            int j = 0;
            int nulo = 0;
            for (i = 0; i < 20; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
                if ((num[i] > 0) && (num[i] != 0))
                {
                    posi = posi + 1;
                    for (j = 0; j < 20; j++)
                    {
                        numPos[i] = num[i];
                    }
                }
                else
                {
                    if (num[i] < 0)
                    {
                        numNeg = numNeg + 1;
                    }
                    else
                    {
                        nulo = nulo + 1;
                    }
                }
            }
            Console.Clear();
            for (i = 0; i < 20; i++)
            {
                if (numPos[i] != 0)
                {
                    Console.WriteLine(numPos[i]);
                }
            }
            Console.WriteLine(" Quantidade de numeros positivos: " + posi + "\n Quantidade de numeros Negativos: " + numNeg + "\n Quantidade de numeros zeros: " + nulo);
            Console.ReadKey();
        }

         static void Main2 (string[] args)
        {
             string[] A = new string[10];
             string[] B = new string[10];
             string[] C = new string[10];
             int i = 0;
             Console.WriteLine("Digite os elementos para o vetor A...");
             for (i=0; i<10;i++){
                 A[i] = Console.ReadLine();
             }
             Console.WriteLine("Digite os elementos para o vetor B...");
             for (i = 0; i < 10; i++)
             {
                 B[i] = Console.ReadLine();
             }
             for (i = 0; i < 10; i++)
             {
                 C[i] = A[i] + B[i];
             }
             Console.Clear();
             for (i=0; i < 10;i++){
                 Console.WriteLine(C[i]);
             }
             Console.ReadKey();
        }

         static void Main3(string[] args)
         {
             int x, y, z = 0;

                 Console.Write("Digite o dia (com 2 digitos): ");
                 x = int.Parse(Console.ReadLine());
                 Console.Write("Digite o mês (com 2 digitos): ");
                 y = int.Parse(Console.ReadLine());
                 Console.Write("Digite o ano (com 4 digitos): ");
                 z = int.Parse(Console.ReadLine());
                 //data(z,y,x);
             
         }
         //static void data(int a, int b, int c)
         //{
         //    DateTime Nascimento = new DateTime(a, b, c);
         //    Console.WriteLine(Nascimento.ToLongDateString());
         //    Console.ReadKey();
         //}

          static void Main4 (string[] args)
         {
             double[] temp = new double[30];
             int i = 0;
             double media = 0;
             int cont = 0;
             for (i = 0; i < 30; i++)
             {
                 int dia = i + 1;
                 Console.Write("Digite a temperatura do dia " + dia + ": ");
                 temp[i] = double.Parse(Console.ReadLine());
                 media = media + temp[i];
                 if (temp[i] > 35)
                 {
                     cont = cont + 1;
                 }
             }
             media = media / 30;
             Console.WriteLine("A média de temperatura em todos os dias foi: "+media);
             Console.WriteLine(cont + " dias tiveram sua temperatura maior que 25ºC.");
             Console.ReadKey();
         }
          // ANO BISSEXTO..... COMANDO QUE RECEBE VDD OU FALSO...
            static void Main5 (string[] args)
          {
             
              Console.Write("Digite um ano: ");
              int ano = 0;
              ano = int.Parse(Console.ReadLine());
              Console.WriteLine(DateTime.IsLeapYear(ano));
              if (DateTime.IsLeapYear(ano))
              {
                  Console.WriteLine("O ano é bissexto!");
              }
              else
              {
                  Console.WriteLine("O ano não é bissexto!");
              }
              Console.ReadKey();
          }
            static void Main6 (string[] args)
            {
                
                Console.Write("Digite o numero total de prestações: ");
                int prestacao = int.Parse(Console.ReadLine());
                Console.Write("Digite a quantidade prestações pagas: ");
                int pagas = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor da prestação: ");
                double valor = double.Parse(Console.ReadLine());
                double quitado = pagas * valor;
                double devedor = valor * (prestacao - pagas);
                Console.WriteLine("Valor total pago: R$ "+quitado);
                Console.WriteLine("Valor total devedor: R$ "+ devedor);
                Console.ReadKey();
            }
            static void Main7 (string[] args)
            {
                Console.Write("Digite o nome do vendedor: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o valor do salário minimo: ");
                double salMin = double.Parse(Console.ReadLine());
                Console.Write("Digite quantos carros o vendedor vendeu: ");
                int quant = int.Parse(Console.ReadLine());
                Console.Write("Digite o total de vendas do vendedor: ");
                double vendas = double.Parse(Console.ReadLine());
                double total = 2 * salMin + quant * 150 + vendas * 0.05;
                Console.Clear();
                Console.WriteLine("Vendedor: " + nome);
                Console.WriteLine("Salário total: " + total);
                Console.ReadKey();
            }
            static void Main8(string[] args)
            {
                string[] nome = new string[3];
                double[] vendas = new double[3];
                double[] comissao = new double[3];
                double total = 0;
                int i = 0;
                for (i = 0; i < 3; i++)
                {
                    int j = i + 1;
                    Console.Write("Digite o nome do vendedor " + j + ":");
                    nome[i] = Console.ReadLine();
                    Console.Write("Valor de suas vendas: ");
                    vendas[i] = double.Parse(Console.ReadLine());
                    if (vendas[i] > 50000)
                    {
                        comissao[i] = vendas[i] * 0.12;
                    }
                    else if (vendas[i] >= 30000)
                    {
                        comissao[i] = vendas[i] * 0.095;
                    }
                    else
                    {
                        comissao[i] = vendas[i] * 0.07;
                    }
                    total = total + vendas[i];
                }
                Console.Clear();
                for (i = 0; i < 3; i++)
                {
                    Console.WriteLine("Nome: " + nome[i]);
                    Console.WriteLine("Vendas: R$ " + vendas[i]);
                    Console.WriteLine("Comissão: R$ " + comissao[i] + "\n");
                    if (i == 2)
                    {
                        Console.WriteLine("Total de vendas: R$ " + total);
                    }
                    Console.ReadKey();
                }
            }
            static void Main9(string[] args)
            {
                Console.Write("Digite um valor para A: ");
                double A = double.Parse(Console.ReadLine());
                Console.Write("Digite um valor para B: ");
                double B = double.Parse(Console.ReadLine());
                Console.Write("Digite um valor para C: ");
                double C = double.Parse(Console.ReadLine());
                double soma = A + B;
                if (soma > C)
                {
                    Console.WriteLine("Soma de A e B maior que C!");
                }
                else if (soma == C)
                {
                    Console.WriteLine("Soma de A e B igual a C!");
                }
                else
                {
                    Console.WriteLine("Soma de A e B menor que C!");
                }
                Console.ReadKey();
            }
            static void Main10(string[] args)
            {
                string[] nome = new string[4];
                double[] preco = new double[4];
                double[] desc = new double[4];
                int i = 0;
                double total = 0;
                for (i = 0; i < 4; i++)
                {
                    int j = i + 1;
                    Console.Write("Digite o nome do artigo " + j + ": ");
                    nome[i] = Console.ReadLine();
                    Console.Write("Digite o preço do artigo " + j + ": ");
                    preco[i] = double.Parse(Console.ReadLine());
                    Console.Write("Digite o percentual de desconto do artigo " + j + ": ");
                    desc[i] = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    desc[i] = preco[i] - ((preco[i] * desc[i]) / 100);
                    total = total + desc[i];
                }
                Console.Clear();
                for (i = 0; i < 4; i++)
                {
                    Console.WriteLine("Nome: " + nome[i]);
                    Console.WriteLine("Preço: R$" + preco[i]);
                    Console.WriteLine("Valor com desconto: R$" + desc[i] + "\n");
                }
                Console.WriteLine("Total a pagar: R$" + total);
                Console.ReadKey();


            }
    }
        
}