using System;

namespace Unidades
{
    class UnidadeIII
    {
        static void Main1(string[] args)
        {
            Console.Write("Digite um numero: ");
            double num = double.Parse(Console.ReadLine());
            if (num > 10)
            {
                Console.WriteLine("Numero maior que 10!");
            }
            Console.ReadKey();
        }

        static void Main2(string[] args)
        {
            Console.Write("Digite um numero inteiro: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro numero inteiro (diferente): ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Clear();
            if (num1 > num2)
            {
                Console.WriteLine(num1 + " é o maior numero.");
            }
            else
            {
                Console.WriteLine(num2 + " é o maior numero.");
            }
            Console.ReadKey();
        }

         static void Main3(string[] args)
        {
            Console.Write("Digite um numero: ");
            double num = double.Parse(Console.ReadLine());
            Console.Clear();
            if (100 < num && num < 200)
            {
                Console.WriteLine("O numero esta entre o intervalo: (100,200)");
            }
            else
            {
                Console.WriteLine("O numero NÃO esta entre o intervalo: (100,200)");
            }
            Console.ReadKey();
        }

         static void Main4(string[] args)
        {
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a primeira nota do aluno: ");
            double N1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota do aluno: ");
            double N2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a terceira nota do aluno: ");
            double N3 = double.Parse(Console.ReadLine());
            double media = (N1 + N2 + N3) / 3;
            Console.Clear();
            if (media >= 7)
            {
                Console.WriteLine(nome + ", APROVADO!!");
            }
            else
            {
                if (media <= 5)
                {
                    Console.WriteLine(nome + ", REPROVADO!!");
                }
                else
                {
                    Console.WriteLine(nome + ", RECUPERAÇÃO!!");
                }
            }
            Console.ReadKey();
        }

         static void Main5(string[] args)
        {
            int cont = 0;
            int i = 0;
            Console.WriteLine("Digite 80 numeros: ");
            for (i = 0; i < 80; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num >= 10 && num <= 150)
                {
                    cont = cont + 1;
                }
            }
            Console.Clear();
            Console.WriteLine(cont + " numeros estão estre o intervalo: [10,150].");
            Console.ReadKey();
        }

         static void Main6(string[] args)
        {
            int i = 0;
            for (i = 1; i < 76; i++)
            {
                Console.Write("Informe a idade da pessoa " + i + ": ");
                int idade = int.Parse(Console.ReadLine());
                if (idade >= 18)
                {
                    Console.WriteLine("Maior de idade!");
                }
                else
                {
                    Console.WriteLine("Menor de idade!");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void Main7(string[] args)
        {
            int i = 0;
            int M = 0;
            int H = 0;
            for (i = 1; i < 57; i++)
            {
                Console.Write("Informe o nome da pessoa " + i + ": ");
                string nome = Console.ReadLine();
                Console.Write("Informe seu sexo (F/M): ");
                string sexo = Console.ReadLine();
                if (sexo == "F" || sexo == "f")
                {
                    Console.WriteLine("Mulher!");
                    M = M + 1;
                }
                else
                {
                    Console.WriteLine("Homem!");
                    H = H + 1;
                }
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("Total de Mulheres: " + M);
            Console.WriteLine("Total de Homens: " + H);
            Console.ReadKey();
        }

         static void Main8(string[] args)
        {
            int cont1 = 0;
            int cont2 = 0;
            double total = 0;
            double tDesc = 0;
            double tPagar = 0;
            int ano = 0;
            double valor = 0;
            double desc = 0;
            string Resp = null;
            do
            {
                Console.Clear();
                Console.Write("Digite o ano do carro: ");
                ano = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor do veiculo: ");
                valor = double.Parse(Console.ReadLine());
                if (ano <= 2000)
                {
                    desc = valor * 0.12;
                    total = valor - desc;
                    cont2 = cont2 + 1;
                    cont1 = cont1 + 1;
                }
                else
                {
                    desc = valor * 0.07;
                    total = valor - desc;
                    cont1 = cont1 + 1;
                }
                tDesc = tDesc + desc;
                tPagar = tPagar + total;
                Console.WriteLine("Desconto pelo carro: R$" + desc);
                Console.WriteLine("Total a pagar pelo carro: R$" + total);
                Console.WriteLine("Deseja continuar calculando? (S/N)");
                Resp = Console.ReadLine();
            } while (Resp == "s" || Resp == "S");
            Console.Clear();
            Console.WriteLine("Total de carros até o ano 2000: " + cont2);
            Console.WriteLine("Total de carros: " + cont1);
            Console.WriteLine("Total de desconto: R$ " + tDesc);
            Console.WriteLine("Total a pagar: R$ " + tPagar);
            Console.ReadKey();
        }

         static void Main9(string[] args)
        {
            Console.WriteLine("Quantas pessoas deseja averiguar?");
            int N = int.Parse(Console.ReadLine());
            int i = 0;
            string nome = null;
            char sexo;
            int idade = 0;
            char saude;
            int A = 0;
            int n = 0;
            Console.Clear();
            for (i = 0; i < N; i++)
            {
                Console.Write("Digite o nome: ");
                nome = Console.ReadLine();
                Console.Write("Digite o sexo ");
                Console.Write("(F/M): ");
                sexo = char.Parse(Console.ReadLine());
                sexo = char.ToUpper(sexo);
                Console.Write("Digite a idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.Write("Digite o estado de saude ");
                Console.Write("(B - Bom /R - Ruim): ");
                saude = char.Parse(Console.ReadLine());
                saude = char.ToUpper(saude);
                Console.Clear();
                if (idade >= 18 && saude == 'B' && sexo == 'M')
                {
                    A = A + 1;
                    Console.WriteLine("Apto para servir ao serviço militar!");
                }
                else
                {
                    n = n + 1;
                    if (sexo == 'F')
                    {
                        Console.WriteLine("Dispensada do serviço militar, por ser MULHER!");
                    }
                    if (saude == 'R')
                    {
                        Console.WriteLine("Dispensado por sua saude ser RUIM!");
                    }
                    if (idade < 18)
                    {
                        Console.WriteLine("Dispensado pois não atingiu idade minima de 18 anos!");
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine(A + " pessoas estão aptas para cumprir o serviço militar!");
            Console.WriteLine(n + "pessoas NÃO estão aptas para cumprir o serviço militar!");
            Console.ReadKey();
        }

       static void Main10(string[] args)
        {
            double venda = 0;
            int i = 0;
            double custo = 0;
            double mCusto = 0;
            double mVenda = 0;
            for (i = 0; i < 40; i++)
            {
                Console.Write("Digite o preço de venda do produto: ");
                venda = double.Parse(Console.ReadLine());
                Console.Write("Digite o preço de custo do produto: ");
                custo = double.Parse(Console.ReadLine());
                mCusto = mCusto + custo;
                mVenda = mVenda + venda;
                if (venda == custo)
                {
                    Console.WriteLine("Empate!");
                }
                else
                {
                    if (venda > custo)
                    {
                        Console.WriteLine("Lucro!");
                    }
                    else
                    {
                        Console.WriteLine("Prejuizo!");
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }
            mCusto = mCusto / 40;
            mVenda = mVenda / 40;
            Console.WriteLine("Média de custo: " + mCusto);
            Console.WriteLine("Média de venda: " + mVenda);
            Console.ReadKey();
        }

         static void Main11(string[] args)
        {
            Console.Write("Digite um numero: ");
            double num = double.Parse(Console.ReadLine());
            if (num > 80)
            {
                Console.WriteLine("Maior que 80!");
            }
            else
            {
                if (num == 40)
                {
                    Console.WriteLine("Igual a 40!");
                }
                else
                {
                    if (num < 25)
                    {
                        Console.WriteLine("Menor que 25!");
                    }
                }
            }
            Console.ReadKey();
        }

         static void Main12(string[] args)
        {
            Console.Write("Digite quantas vezes deseja verificar: ");
            int N = int.Parse(Console.ReadLine());
            int i = 0;
            for (i = 0; i < N; i++)
            {
                Console.Write("Digite um numero: ");
                double x = double.Parse(Console.ReadLine());
                if (x > 0)
                {
                    Console.WriteLine("POSITIVO!");
                }
                else
                {
                    if (x == 0)
                    {
                        Console.WriteLine("ZERO!");
                    }
                    else
                    {
                        Console.WriteLine("NEGATIVO!!!");
                    }
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void Main13(string[] args)
        {
            Console.WriteLine("1 - Escrever em ordem crescente;");
            Console.WriteLine("2 - Escrever em ordem decrescente;");
            Console.WriteLine("3 - Escrever de forma que o maior fique no meio.");
            Console.Write("Esolha uma opção: ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Escreva um valor para 'a': ");
            double A = double.Parse(Console.ReadLine());
            Console.Write("Escreva um valor para 'b': ");
            double B = double.Parse(Console.ReadLine());
            Console.Write("Escreva um valor para 'c': ");
            double C = double.Parse(Console.ReadLine());
            Console.Clear();
            if (i == 1)
            {
                if (A > B && A > C)
                {
                    if (B > C)
                    {
                        Console.WriteLine(A + " " + B + " " + C);
                    }
                    else
                    {
                        Console.WriteLine(A + " " + C + " " + B);
                    }
                }
                else
                {
                    if (B > A && B > C)
                    {
                        if (A > C)
                        {
                            Console.WriteLine(B + " " + A + " " + C);
                        }
                        else
                        {
                            Console.WriteLine(B + " " + C + " " + B);
                        }
                    }
                    else
                    {
                        if (C > B && C > A)
                        {
                            if (B > A)
                            {
                                Console.WriteLine(C + " " + B + " " + A);
                            }
                            else
                            {
                                Console.WriteLine(C + " " + A + " " + B);
                            }
                        }
                    }
                }
            }
            else
            {
                if (i == 2)
                {
                    if (A < B && A < C)
                    {
                        if (B < C)
                        {
                            Console.WriteLine(A + " " + B + " " + C);
                        }
                        else
                        {
                            Console.WriteLine(A + " " + C + " " + B);
                        }
                    }
                    else
                    {
                        if (B < A && B < C)
                        {
                            if (A < C)
                            {
                                Console.WriteLine(B + " " + A + " " + C);
                            }
                            else
                            {
                                Console.WriteLine(B + " " + C + " " + A);
                            }
                        }
                        else
                        {
                            if (C < B && C < A)
                            {
                                if (B < A)
                                {
                                    Console.WriteLine(C + " " + B + " " + A);
                                }
                                else
                                {
                                    Console.WriteLine(C + " " + A + " " + B);
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (B > A && B > C)
                    {
                        if (A > C)
                        {
                            Console.WriteLine(B + " " + A + " " + C);
                        }
                        else
                        {
                            Console.WriteLine(B + " " + C + " " + B);
                        }
                    }
                    else
                    {
                        if (C > B && C > A)
                        {
                             Console.WriteLine(B + " " + C + " " + A);
                        }else
                            {
                               if (B>A && B>C){ 
                                   Console.WriteLine(C + " " + B + " " + A);
                               }else{
                                   Console.WriteLine(C + " " + A + " " + B);
                               }
                            }
                    }
                }
            }
            Console.ReadKey();
        }
        static void Main14(string[] args)
        {
            Console.Write("Digite um valor em R$: ");
            int valor = int.Parse(Console.ReadLine());
            int cem = valor / 100;
            valor = valor - cem*100;
            int cinq = valor / 50;
            valor = valor - cinq*50;
            int dez = valor / 10;
            valor = valor - dez*10;
            int cinc = valor / 5;
            valor = valor - cinc*5;
            int um = valor / 1;
            valor = valor - um;
            Console.WriteLine("Notas de R$ 100,00: " + cem);
            Console.WriteLine("Notas de R$ 50,00: " + cinq);
            Console.WriteLine("Notas de R$ 10,00: " + dez);
            Console.WriteLine("Notas de R$ 5,00: " + cinc);
            Console.WriteLine("Notas de R$ 1,00: " + um);
            Console.ReadKey();
        }
    }
}