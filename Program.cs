// treino - lógica de Programação - c#
// Estrutura sequencial - condicional - Repetição - Laço For
// Lucas Celestino Diniz
// lucascelestino.diniz@gmail.com


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; // utilizado no 5º exercício em diante

namespace ProvaLogicaDeProgramacao
{
    class Program
    {
        static void Main(string[] args)

        {
            // ****************** 1 até 8 Estrutura sequencial ********************************

            // 1 PRIMEIRO EXERCÍCIO
            /*int cod1, cod2, quant1, quant2;
            float valor1, valor2;

            Console.WriteLine("Digite o código da Peça Um");
            cod1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o código da Peça Dois");
            cod2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade da Peça Um");
            quant1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade da Peça Dois");
            quant2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Informe o valor da Peça Um");
            valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor da Peça Dois");
            valor2 = float.Parse(Console.ReadLine());

            float x = valor1 * quant1;
            float y = valor2 * quant2;
            float z = x + y;

            Console.WriteLine("O código da peça um é: " + cod1 + " e o código da peça dois é: "+ cod2);
            Console.Write("");
            Console.WriteLine("O valor total que será pago é de: " + z + " reais");
            Console.ReadKey();*/


            // 2 SEGUNDO EXERCICIO
            //FÓRMULA ÁREA = PI * RAIO²

            /*double area, pi, raio;
            pi = 3.14159;
            Console.WriteLine("********** ÁREA DE UM CÍRCULO **********");
            Console.Write("");
            Console.WriteLine("Informe o valor do Raio de seu círculo: ");
            raio = double.Parse(Console.ReadLine());
            area = pi * (raio * raio);
            Console.Write("");
            Console.Write("");
            double x = Math.Round(area, 2);
            Console.WriteLine("O valor de sua Área é de: "+ x);
            Console.ReadLine();*/


            // 3 TERCEIRO EXERCÍCIO
            /*int senha;
            i:
            Console.WriteLine("Informe a senha:");
            senha = int.Parse(Console.ReadLine());
            if(senha == 2002)
            {
                Console.WriteLine("Acesso Permitido");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Senha Inválida");
                goto i;
            }*/

            //caso queira continuar treinando dê continuidade logo abaixo
            // 4 EXERCÍCO
            /*int x, y;
            Console.WriteLine("Informe o primeiro valor");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor");
            y = int.Parse(Console.ReadLine());

            int aux = x + y;
            Console.WriteLine("O valor da soma é: " + aux);
            Console.ReadKey();*/


            // 5 QUINTO EXERCÍCIO - Programa de descobrir a área de um círculo feito de outra maneira
            /*double R, A, pi = 3.14159;

            Console.WriteLine("Informe o Raio:");
            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A = pi * (R * R);

            Console.WriteLine("Area = " + A.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadKey();*/

            // 6 SEXTO EXERCÍCIO
            /*int a, b, c, d, dif;
            i:
            Console.WriteLine("Diferença do Produto de A e B pelo produto de C e D");
            Console.WriteLine();
            Console.WriteLine("Informe um valor para A: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe um valor para B: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe um valor para C: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe um valor para D: ");
            d = int.Parse(Console.ReadLine());

            dif = (a * b) - (c * d);
            Console.WriteLine();
            Console.WriteLine("A diferença é: " + dif);
            Console.ReadKey();
            goto i;*/

            // 7 SÉTIMO EXERCÍCIO
            /*int codf;
            float htrb, sal;
            Console.WriteLine("Informe o código do funcionário:");
            codf = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe as horas trabalhadas:");
            htrb = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor a receber por hora trabalhada");
            sal = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            float conta = htrb * sal;
            Console.WriteLine();
            Console.WriteLine("Código do funcionário = " + codf);
            Console.WriteLine();
            Console.WriteLine("Salário = " + conta.ToString("F2", CultureInfo.InvariantCulture) + " R$");
            Console.ReadLine();*/

            // 8º Oitavo exercíco
            // Cálculo de Áreas

            /*double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            triangulo = A * C / 2.0;
            circulo = 3.14159 * C * C;
            trapezio = (A + B) / 2.0 * C;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadKey();*/

            // *************** 9 até 15 estrutura condicional ************************
            // dizer se um número é negativo ou positivo

            /* double num;
             Console.WriteLine("Informe umm valor: ");
             num = int.Parse(Console.ReadLine());
             if(num >= 0)
             {
                 Console.WriteLine(num + " é um número positivo");
                 Console.ReadKey();
             }
             else
             {
                 Console.WriteLine(num + " é um número negativo");
                 Console.ReadKey();
             }*/

            // 10 décimo exercíco
            // par ou ímpar?

            /*double num;
            Console.WriteLine("Informe umm valor: ");
            num = int.Parse(Console.ReadLine());
            if (num%2 == 0) // resto da vivisão
            {
                Console.WriteLine(num + " é um número par");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(num + " é um número ímpar");
                Console.ReadKey();
            }*/

            // 11 décimo primeiro
            /*double A,B;
            Console.WriteLine("Informe um valor: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe um outro valor: ");
            B = int.Parse(Console.ReadLine());
            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("São Múltiplos");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Não são múltiplos");
                Console.ReadKey();
            }*/

            // 12 Décimo segundo exercício 
            // quanto tempo durou?

            /*int hrIni, hrFim, dur;
            Console.WriteLine("Que horas começou? ");
            hrIni = int.Parse(Console.ReadLine());
            Console.WriteLine("Que horas terminou? ");
            hrFim = int.Parse(Console.ReadLine());

            if (hrIni < hrFim)
            {
                dur = hrFim - hrIni;
            }
            else
            {
                dur = 24 - hrIni + hrFim;
            }

            Console.WriteLine("O Jogo durou " + dur + " horas");
            Console.ReadKey();*/

            // 13 décimo terceiro
            /* i:
             Console.WriteLine("******* Lanches do Lucão ******");
             Console.WriteLine("CÓDIGO    CARDÁPIO     PREÇOS");
             Console.WriteLine("  1   Cachorro Quente R$ 4,00");
             Console.WriteLine("  2    X-Salada       R$ 4,50");
             Console.WriteLine("  3    X-Bacon        R$ 5,00");
             Console.WriteLine("  4    Torrada        R$ 2,00");
             Console.WriteLine("  5   Refrigereante   R$ 3.50");
             Console.WriteLine();
             Console.WriteLine("Informe o seu Pedido e a Quantidade: ");
             Console.WriteLine();
             string[] val = Console.ReadLine().Split(' '); // informa duas coisas separadas por espaço
             int cod = int.Parse(val[0]);
             int qtde = int.Parse(val[1]);

             double total;
             if(cod == 1)
             {
                 total = qtde * 4.0;
             }
             else if(cod == 2)
             {
                 total = qtde * 4.50;
             }
             else if (cod == 3)
             {
                 total = qtde * 5.0;
             }
             else if (cod == 4)
             {
                 total = qtde * 2.0;
             }
             else
             {
                 total = qtde * 3.50;
             }

             Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
             Console.ReadKey();
             Console.Clear();
             goto i;*/

            // 14 Décimo Quarto Exercício
            // pega as coordenadas de X e Y e apresenta para você onde o seu ponto está no Plano Cartesiano

            /*double x, y;
            volta:
            Console.WriteLine("Coordenadadas de um ponto em um Plano");
            Console.WriteLine("Informe as coordenadas de X e Y");
            string[] valores = Console.ReadLine().Split(' ');
             x = double.Parse(valores[0], CultureInfo.InvariantCulture);
             y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("( " + valores[0] + ", " + valores[1] + " )");
            Console.WriteLine();
            Console.ReadKey();

            if(x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }else if (x == 0){
                Console.WriteLine("Eixo Y");
            }else if (y == 0)
            {
                Console.WriteLine("Eixo X");
            }else if (x > 0 && y > 0)
            {
                Console.WriteLine("Primeiro Quadrante");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Segundo Quadrante");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Terceiro Quadrante");
            }
            else
            {
                Console.WriteLine("Quarto Quadrante");
            }

            Console.ReadKey();
            Console.Clear();
            goto volta;*/

            /*Console.WriteLine("Imposto de Renda do País - Lubvap");
            Console.WriteLine("Cidadão de Rombus, informe a sua renda:");
            double renda, ir;
            renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if (renda >= 0 && renda < 2000.01)
            {
                Console.WriteLine("Você é um felizardo, e está isento de impostos");
                Console.ReadKey();
            }else if (renda >= 2000.01 && renda < 3000.01)
            {
                ir = renda * 0.8;
                Console.WriteLine("Você que recebe " + renda + " irá pagar " + ir.ToString("F2", CultureInfo.InvariantCulture) + " reais de impostos, que corresponde a 8% da sua renda" );
                Console.ReadKey();
            }
            else if (renda >= 3000.01 && renda < 4500.01)
            {
                ir = renda * 0.18;
                Console.WriteLine("Você que recebe " + renda + " irá pagar " + ir.ToString("F2", CultureInfo.InvariantCulture) + " reais de impostos, que corresponde a 18% da sua renda");
                Console.ReadKey();
            }
            else
            {
                ir = renda * 0.28;
                Console.WriteLine("Você que recebe " + renda + " irá pagar " + ir.ToString("F2", CultureInfo.InvariantCulture) + " reais de impostos, que corresponde a 28% da sua renda");
                Console.ReadKey();
            }*/

            // Estrutura While
            // ******************************************************************************************

            /*int senha;
            Console.WriteLine("Informe a senha:");
            senha = int.Parse(Console.ReadLine());

            while(senha != 2002)
            {
                Console.Clear();
                Console.WriteLine("Senha Incorreta \nInforme a Senha novamente:");
                senha = int.Parse(Console.ReadLine());
                
            }

            Console.WriteLine("Senha Correta");
            Console.ReadKey();*/

            /*double x, y;
            Console.WriteLine("Coordenadadas de um ponto em um Plano - 2.0");
            Console.WriteLine("Informe as coordenadas de X e Y:");
            string[] valores = Console.ReadLine().Split(' ');
            x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("(X " + valores[0] + ", Y " + valores[1] + " )");
            Console.WriteLine();
            Console.ReadKey();

            while(x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
            {
                Console.WriteLine("Primeiro Quadrante");
                    Console.WriteLine();
                    Console.WriteLine("Informe as coordenadas de X e Y");
                    valores = Console.ReadLine().Split(' ');
                    x = double.Parse(valores[0], CultureInfo.InvariantCulture);
                    y = double.Parse(valores[1], CultureInfo.InvariantCulture);
                    Console.WriteLine();
                    Console.WriteLine("( " + valores[0] + ", " + valores[1] + " )");
                    Console.WriteLine();
                }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Segundo Quadrante");
                    Console.WriteLine();
                    Console.WriteLine("Informe as coordenadas de X e Y");
                    valores = Console.ReadLine().Split(' ');
                    x = double.Parse(valores[0], CultureInfo.InvariantCulture);
                    y = double.Parse(valores[1], CultureInfo.InvariantCulture);
                    Console.WriteLine();
                    Console.WriteLine("( " + valores[0] + ", " + valores[1] + " )");
                    Console.WriteLine();
                }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Terceiro Quadrante");
                    Console.WriteLine();
                    Console.WriteLine("Informe as coordenadas de X e Y");
                    valores = Console.ReadLine().Split(' ');
                    x = double.Parse(valores[0], CultureInfo.InvariantCulture);
                    y = double.Parse(valores[1], CultureInfo.InvariantCulture);
                    Console.WriteLine();
                    Console.WriteLine("( " + valores[0] + ", " + valores[1] + " )");
                    Console.WriteLine();
                }
            else
            {
                Console.WriteLine("Quarto Quadrante");
                    Console.WriteLine();
                    Console.WriteLine("Informe as coordenadas de X e Y");
                    valores = Console.ReadLine().Split(' ');
                    x = double.Parse(valores[0], CultureInfo.InvariantCulture);
                    y = double.Parse(valores[1], CultureInfo.InvariantCulture);
                    Console.WriteLine();
                    Console.WriteLine("( " + valores[0] + ", " + valores[1] + " )");
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Valor zerado informado\nPrograma será encerrado, aperte qualquer tecla");
            Console.ReadKey();*/

            /*int cod;
            int alc = 0, gas = 0, die = 0;
            Console.WriteLine("Posto de Combustível do Seu José");
            Console.WriteLine();
            Console.WriteLine("Informe o Combustível utilizado:\n1 - Álcool\n2 - Gasolina\n3 - Diesel\n4 - Encerrar programa.");
            cod = int.Parse(Console.ReadLine());

            while(cod != 4 )
            {
               
                 if (cod == 1)
                {
                    alc += 1;
                }else if(cod == 2)
                {
                    gas += 1;
                }else if(cod == 3)
                {
                    die += 1;
                }
                Console.WriteLine();
                Console.WriteLine("Posto de Combustível do Seu José");
                Console.WriteLine();
                Console.WriteLine("Informe o Combustível utilizado:\n1 - Álcool\n2 - Gasolina\n3 - Diesel\n4 - Encerrar programa.");
                cod = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Muito Obrigado");

            Console.WriteLine("Produtos selecionados:");
            Console.WriteLine("Alcool: " + alc);
            Console.WriteLine("Gasolina: " + gas);
            Console.WriteLine("Diesel: " + die);
            Console.ReadKey();*/
            //************************************************************************************************
            // Estrutura FOR
            //**************
            /*Console.WriteLine("Informe um valor");
            int x = int.Parse(Console.ReadLine());

            for(int i = 1; i <= x; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine("Valores ímpares: " + i);
                }
            }
            Console.ReadKey();*/

            /*Console.WriteLine("Informe a quantidade de consultas");
            int x = int.Parse(Console.ReadLine());

            int dentro = 0, fora = 0;

            for(int i = 0; i < x; i++)
            {
                Console.WriteLine("Informe os valores para verificar se estão dentro do Intervalo:");
                int y = int.Parse(Console.ReadLine());
                if( y >= 10 && y >= 20)
                {
                    dentro += 1;
                }
                else
                {
                    fora += 1;
                }
            }

            Console.WriteLine(dentro + " número(s) dentro do intervalo");
            Console.WriteLine(fora + " número(s) fora do intervalos");
            Console.ReadKey();*/

            /*Console.WriteLine("Informe a quantidade de consultas");
            int x = int.Parse(Console.ReadLine());

            for(int i = 0; i <= x; i++)
            {
                Console.WriteLine("Informe os valores");
                string[] val = Console.ReadLine().Split(' ');
                double a = double.Parse(val[0], CultureInfo.InvariantCulture);
                double b = double.Parse(val[1], CultureInfo.InvariantCulture);
                double c = double.Parse(val[2], CultureInfo.InvariantCulture);

                double media = (a * 2 + b * 3 + c * 5)/10;
                Console.WriteLine("Está é a sua média: " + media.ToString("F1",CultureInfo.InvariantCulture));
                Console.ReadKey();
            }*/

            /*Console.WriteLine("Informe um valor:");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Informe os números para realizar a divisão");
                string[] linha = Console.ReadLine().Split(' ');
                int x = int.Parse(linha[0], CultureInfo.InvariantCulture);
                int y = int.Parse(linha[1], CultureInfo.InvariantCulture);

                if(y == 0)
                {
                    Console.WriteLine("Divisão com denominador igual a 0 é impossível");
                    Console.ReadKey();
                }
                else
                {
                    double divisao = (double) x / y;
                    Console.WriteLine("Resultado: " + divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }*/


            //FATORIAL
            /*Console.WriteLine("Informe um número:");
            int n = int.Parse(Console.ReadLine());
            int fat = 1;
            for(int i = 1; i <= n; i++)
            {
                fat *= i;
            }
            Console.WriteLine("Fatorial de " + n + " é igual a " + fat);
            Console.ReadKey();*/

            // Ler um número N e mostrar os seus divisores
            /* Console.WriteLine("Informe um número:");
             int n = int.Parse(Console.ReadLine());
             for(int i = 1; i<= n; i++)
             {
                 if (n % i == 0) // se o resto da divisão for igual a 0, significa que estes números são divisíveis pelo número N informado mais acima

                 {
                     Console.WriteLine("Estes são os divisores " + i);   
                 }

             }
             Console.ReadKey();*/

            // ler um número N, este número N irá mostrar a quantidade de linhas, e para cada linha vai mostrar o número da linha e depois irá mostra n ao quadrado e ao cubo

            /*Console.WriteLine("Informe a quantidade de Linhas"); ;
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine($"{primeiro} {segundo} {terceiro}");
            }
            Console.ReadKey();*/
        }
    }
}
// treino - lógica de Programação - c#
// Estrutura sequencial - condicional - Repetição - Laço For
// Lucas Celestino Diniz
// lucascelestino.diniz@gmail.com