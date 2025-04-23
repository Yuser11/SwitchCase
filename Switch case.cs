using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        static void VelocidadeVeiculo()
        {


            Console.WriteLine("Entre qual destes números a velocidade do veículo estava? \n1-) 0-80, \n2-) 81-100, \n3-) 101-110 \n 4-) acima de 110");
            string velocidade = Console.ReadLine();
            switch (velocidade)
            {
                case "1": Console.WriteLine("ESTÁ NO LIMITE DE VELOCIDADE"); break;
                case "2": Console.WriteLine("VELOCIDADE PERMITIDA SOMENTE EM RODOVIAS"); break;
                case "3": Console.WriteLine("VELOCIDADE PERMITIDA"); break;
                case "4": Console.WriteLine("VELOCIDADE FORA DO PADRÃO  PERMITIDO"); break;
                default: Console.WriteLine("Resposta inválida"); break;

            }

        }
        static void ClassificacaoProduto()
        {
            Console.WriteLine("Digite o código do produto");
            string codigo = Console.ReadLine();
            switch (codigo)
            {
                case "1": Console.WriteLine(); break;
                case "2":
                case "3":
                case "4":
                    Console.WriteLine("Alimento perecível"); break;
                case "5":
                case "6":
                    Console.WriteLine("Vestuário"); break;
                case "7":
                    Console.WriteLine("Higiene"); break;
                case "8":
                case "9":
                case "10":
                case "11":
                case "12":
                case "13":
                case "14":
                case "15":
                    Console.WriteLine("Limpeza e Utensílios Domésticos"); break;
                default:
                    Console.WriteLine("Código inválido"); break;


            }
        }
        static void Operacao()
        {
            Console.WriteLine("Digite dois números inteiros");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual operação gostaria de executar?\n1-)Soma\n2-)Subtração\n3-)Multiplicação\n4-)Divisão");
            string opcao = Console.ReadLine();
            double resultado;
            switch (opcao)
            {
                case "1":
                    resultado = num1 + num2;
                    if (resultado % 3 == 0 && resultado % 7 == 0)
                    {
                        Console.WriteLine("O resultado é múltiplo de 3 e de 7");
                    }
                    else if (resultado % 3 == 0)
                    {
                        Console.WriteLine("O resultado é somente múltiplo de 3");
                    }
                    else if (resultado % 7 == 0)
                    {
                        Console.WriteLine("O resultado é somente múltiplo de 7");
                    }
                    else
                    {
                        Console.WriteLine("O resultado não é múltiplo de 3 e nem de 7");
                    }
                    Console.WriteLine();
                    break;

                case "2":
                    if (num1 > num2)
                    {
                        resultado = num1 - num2;
                        Console.WriteLine("O resultado da subtração de " + num1 + " - " + num2 + " é igual a " + resultado);
                    }
                    else
                    {
                        resultado = (num1 * 10) - num2;
                        Console.WriteLine("Como " + num1 + " é menor que " + num2, "o resultado da subtração de " + num1 + " vezes 10 - " + num2 + " é igual a " + resultado);
                    }
                    break;

                case "3":
                    resultado = num1 * num2;
                    if (resultado % 10 == 0)
                    {
                        Console.WriteLine("O número é múltiplo de 10");
                    }
                    else
                    {
                        Console.WriteLine("O número não é múltiplo de 10");
                    }
                    Console.WriteLine("O resultado é " + resultado);
                    break;

                case "4":
                    if (num1 > num2)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("O resultado da divisão de " + num1 + " por " + num2 + " é igual a " + resultado);
                    }
                    else
                    {
                        Console.WriteLine("O número um não é maior que o número dois");
                    }
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;

            }
        }
        static void FormaDePagamento()
        {
            double valor = 10850;
            Console.WriteLine("O valor é de R$" + valor + "\nEntretanto, existe a possibilidade de comprar à vista com 20% de desconto \nOu a prazo com um aumento de 15% no valor");
            Console.WriteLine("\nDeseja fazer o pagamento a prazo ou a vista?");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "a prazo":
                    Console.WriteLine("O valor a prazo, então, vai ficar R$" + (valor * 1.15)); break;
                case "a vista":
                    Console.WriteLine("O valor a vista, então, vai ficar R$" + (valor * 0.80)); break;
            }
        }
        static void MesDoAno()
        {
            Console.WriteLine("Digite um valor de 1 a 12");
            string mes = Console.ReadLine();
            switch (mes)
            {
                case "1": Console.WriteLine("Janeiro"); break;
                case "2": Console.WriteLine("Fevereiro"); break;
                case "3": Console.WriteLine("Março"); break;
                case "4": Console.WriteLine("Abril"); break;
                case "5": Console.WriteLine("Maio"); break;
                case "6": Console.WriteLine("Junho"); break;
                case "7": Console.WriteLine("Julho"); break;
                case "8": Console.WriteLine("Agosto"); break;
                case "9": Console.WriteLine("Setembro"); break;
                case "10": Console.WriteLine("Outubro"); break;
                case "11": Console.WriteLine("Novembro"); break;
                case "12": Console.WriteLine("Dezembro"); break;
                default: Console.WriteLine("Número digitado não é válido"); break;
            }
        }
        static void PedidoLanchonete()
        {
            Console.WriteLine("Qual o código do produto que você gostaria de comprar?");
            Console.WriteLine("100-)Cachorro quente\n101-)Bauru Simples\n102-)Bauro com ovo\n103-)Hamburguer\n104-)Cheeseburguer\n105-)Refrigerante");
            string codigo = Console.ReadLine();
            Console.WriteLine("Digite a quantidade desejada");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            double valor;
            switch (codigo)
            {
                case "100":
                    Console.WriteLine("1");
                    valor = quantidade * 1.70;
                    Console.WriteLine("O valor total a pagar, comprando +" + quantidade + " Cachorros quente, cada um custando R$1,70 é de R$" + valor);
                    break;

                case "101":
                    valor = quantidade * 2.30;
                    Console.WriteLine("O valor total a pagar, comprando +" + quantidade + " Bauru simples, cada um custando R$2,30 é de R$" + valor);
                    break;

                case "102":
                    valor = quantidade * 2.60;
                    Console.WriteLine("O valor total a pagar, comprando +" + quantidade + " Bauru com ovo, cada um custando R$2,60 é de R$" + valor);
                    break;

                case "103":
                    valor = quantidade * 2.40;
                    Console.WriteLine("O valor total a pagar, comprando +" + quantidade + " Hamburguer, cada um custando R$2,40 é de R$" + valor);
                    break;

                case "104":
                    valor = quantidade * 2.50;
                    Console.WriteLine("O valor total a pagar, comprando +" + quantidade + " Cheeseburguer, cada um custando R$2,50 é de R$" + valor);
                    break;

                case "105":
                    valor = quantidade * 1;
                    Console.WriteLine("O valor total a pagar, comprando +" + quantidade + " Refrigerantes, cada um custando R$1,00 é de R$" + valor);
                    break;

                default:
                    Console.WriteLine("Código inválido");
                    break;
            }
        }
        static void Conversao()
        {
            Console.WriteLine("Qual a conversão desejada?");
            Console.WriteLine("1-)Metros para centímetros\n2-)Quilômetros para metros\n3-)Graus Celsius para Fahrenheit\n4-)Quilogramas para gramas");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Quantos metros?");
                    double metros = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(metros + " são " + metros * 1000 + "centímetros");
                    break;

                case "2":
                    Console.WriteLine("Quantos quilômetros?");
                    double quilometros = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(quilometros + " são " + quilometros * 1000 + "metros");
                    break;

                case "3":
                    Console.WriteLine("Quantos graus celsius?");
                    double celsius = Convert.ToDouble(Console.ReadLine());
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine(celsius + " graus celsius são " + fahrenheit + " graus fahrenheit");
                    break;

                case "4":
                    Console.WriteLine("Quantos quilogramas?");
                    double quilogramas = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(quilogramas + " são " + quilogramas * 1000 + "centímetros");
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;

            }

        }
        static void FolhaDePagamento()
        {
            Console.WriteLine("Escreva o salário bruto");
            double salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual cálculo deseja fazer?\n1-)Valor do INSS\n2-)Retorna o valor do IRRF\n3-)Retorna o salário líquido");
            string opcao = Console.ReadLine();
            Double INSS;
            Double IRRF;
            switch (opcao)
            {
                case "1":
                    if (salario <= 1412)
                    {
                        INSS = salario * 0.075;
                        Console.WriteLine("O valor do INSS, 7,5% do salário, é de R$" + INSS);
                    }
                    else if (salario > 1412 && salario <= 2666.68)
                    {
                        INSS = salario * 0.09;
                        Console.WriteLine("O valor do INSS, 9% do salário, é de R$" + INSS);
                    }
                    else if (salario > 2666.68 && salario <= 4000.03)
                    {
                        INSS = salario * 0.12;
                        Console.WriteLine("O valor do INSS, 12% do salário, é de R$" + INSS);
                    }
                    else if (salario > 4000.03 && salario <= 7786.02)
                    {
                        INSS = salario * 0.14;
                        Console.WriteLine("O valor do INSS, 14% do salário, é de R$" + INSS);
                    }
                    else if (salario > 7786.02)
                    {
                        INSS = salario * 0.175;
                        Console.WriteLine("O valor do INSS, 17,5% do salário, é de R$" + INSS);
                    }
                    break;

                case "2":
                    if (salario <= 2112)
                    {
                        IRRF = 0;
                        Console.WriteLine("Salário abaixo de R$2112,00 está isento de imposto de renda");
                    }
                    else if (salario > 2112 && salario <= 2826.65)
                    {
                        IRRF = salario * 0.075;
                        Console.WriteLine("O valor do imposto de renda, 7,5% do salário, é de R$" + IRRF);
                    }
                    else if (salario > 2826.65 && salario <= 3751.05)
                    {
                        IRRF = salario * 0.15;
                        Console.WriteLine("O valor do imposto de renda, 15% do salário, é de R$" + IRRF);
                    }
                    else if (salario > 3751.05 && salario <= 4664.68)
                    {
                        IRRF = salario * 0.225;
                        Console.WriteLine("O valor do imposto de renda, 22,5% do salário, é de R$" + IRRF);
                    }
                    else if (salario > 4664.68)
                    {
                        IRRF = salario * 0.275;
                        Console.WriteLine("O valor do imposto de renda, 27,5% do salário, é de R$" + IRRF);
                    }
                    break;

                case "3":
                    CalculoSalario(salario);
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

        private static double CalculoINSS(double salario)
        {
            Double iNSS;
            if (salario <= 1412)
            {
                iNSS = salario * 0.075;
                return iNSS;
            }
            else if (salario > 1412 && salario <= 2666.68)
            {
                iNSS = salario * 0.09;
                return iNSS;
            }
            else if (salario > 2666.68 && salario <= 4000.03)
            {
                iNSS = salario * 0.12;
                return iNSS;
            }
            else if (salario > 4000.03 && salario <= 7786.02)
            {
                iNSS = salario * 0.14;
                return iNSS;
            }
            else
            {
                iNSS = salario * 0.175;
                return iNSS;
            }
        }
        private static double CalculoIRRF(double salario)
        {
            Double IRRF;
            if (salario <= 2112)
            {
                IRRF = 0;
                return IRRF;
            }
            else if (salario > 2112 && salario <= 2826.65)
            {
                IRRF = salario * 0.075;
                return IRRF;
            }
            else if (salario > 2826.65 && salario <= 3751.05)
            {
                IRRF = salario * 0.15;
                return IRRF;
            }
            else if (salario > 3751.05 && salario <= 4664.68)
            {
                IRRF = salario * 0.225;
                return IRRF;
            }
            else if (salario > 4664.68)
            {
                IRRF = salario * 0.275;
                return IRRF;
            }
            else { return 0; }
        }
        private static double CalculoSalario(double salario)
        {
            Double IRRF = CalculoIRRF(salario);
            Double INSS = CalculoINSS(salario);
            Double liquido = salario - INSS - IRRF;
            Console.WriteLine("O salário líquido, descontando INSS e imposto de renda, é de R$" + liquido);
            return liquido;

        }
        static void Operacoes2()
        {
            {
                Console.WriteLine("Digite dois números inteiros");
                Double num1 = Convert.ToDouble(Console.ReadLine());
                Double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Qual operação gostaria de executar?\n1-)Média\n2-)Diferença entre os valores\n3-)Produto dos valores\n4-)Resto da divisão");
                string opcao = Console.ReadLine();
                double resultado;
                switch (opcao)
                {
                    case "1":
                        resultado = (num1 + num2) / 2;
                        Console.WriteLine("A média dos dois números é " + resultado);
                        break;

                    case "2":
                        resultado = num1 - num2;
                        Console.WriteLine("A diferença de  " + num1 + " por " + num2 + " é igual a " + resultado);
                        break;

                    case "3":
                        resultado = num1 * num2;                        
                            Console.WriteLine("O produto dos dois valores é "+resultado);                        
                        break;

                    case "4":                        
                            resultado = num1 % num2;
                            Console.WriteLine("O resto da divisão de " + num1 + " por " + num2 + " é igual a " + resultado);
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;

                }
            }
        }
        static void VerificacaoDeLetra()
        {
            Console.WriteLine("Digite um uma letra minúscula");
                string letra = Console.ReadLine(); 
            switch (letra) 
            {  
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine("É uma vogal");
                    break;
                case "b":
                case "c":
                case "d":
                case "f":
                case "g":
                case "h":
                case "j":
                case "k":
                case "l":
                case "m":
                case "n":
                case "p":
                case "q":
                case "r":
                case "s":
                case "t":
                case "v":
                case "w":
                case "x":
                case "y":
                case "z":
                    Console.WriteLine("É uma consoante");
                    break; 
                default: Console.WriteLine("Não é uma letra"); break;

            }
        }
        static void CalculoArea()
        {
            Console.WriteLine("Deseja calcular a área de qual forma geométrica?");
            Console.WriteLine("1-)Triângulo\n2-)Retângulo\n3-)Círculo");
            string opcao = Console.ReadLine();
            double resultado;
            switch (opcao) 
            {
                case "1":
                    Console.WriteLine("Qual a base do triângulo?");
                    Double base1= Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Qual a altura do triângulo?");
                    Double altura = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("O triângulo tem" + (altura * base1)/2 + " de área");
                    break;
                case "2":
                    Console.WriteLine("Qual a base do retângulo?");
                    base1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Qual a altura do retângulo?");
                    altura = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("O retângulo tem" + (altura * base1) + " de área");
                    break;
                case "3":
                    Console.WriteLine("Qual o raio do círculo?");
                    Double raio = Convert.ToDouble(Console.ReadLine());
                    const double pi = 3.14159265359;
                    Console.WriteLine("O círculo tem" + (pi * Math.Pow(raio,2)) + " de área");
                    break;
            }
        }
        static void ConversaoGraus()
        {
            Console.WriteLine("Deseja fazer qual conversão?");
            Console.WriteLine("1-)Celsius para Fahrenheit\n2-)Fahrenheit para Celsius\n3-)Celsius para Kelvin");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Quantos graus celsius?");
                    double celsius = Convert.ToDouble(Console.ReadLine());
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine(celsius + " graus celsius são " + fahrenheit + " graus fahrenheit");
                    break;

                case "2":
                    Console.WriteLine("Quantos graus celsius?");
                    fahrenheit = Convert.ToDouble(Console.ReadLine());
                    celsius = (fahrenheit - 32) * 5/9;
                    Console.WriteLine(celsius + " graus fahrenheit são " + celsius + " graus celsius");
                    break;

                case "3":
                    Console.WriteLine("Quantos graus celsius?");
                    celsius = Convert.ToDouble(Console.ReadLine());
                    double kelvin = celsius + 273.15;
                    Console.WriteLine(celsius + " graus celsius  são " + kelvin + " graus kelvin");
                    break;
            }
        }
    }


}


