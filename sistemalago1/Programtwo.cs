using System;
using InSystem;

namespace IntwoSystem
{
    class Equacoes
    {
        public static void MostrarMensagem()
        {
            Console.WriteLine("!Vamos fazer equações!");

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Escolha uma operação: ");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Potenciação");
                Console.WriteLine("6 - Radiciação");
                Console.WriteLine("7 - Misturar Operações");
                Console.WriteLine("8 - Sair");

                char escolha = Console.ReadKey().KeyChar;
                Console.WriteLine();

                double resultado = 0;

                switch (escolha)
                {
                    case '1':
                        resultado = RealizarAdicao();
                        break;
                    case '2':
                        resultado = RealizarSubtracao();
                        break;
                    case '3':
                        resultado = RealizarMultiplicacao();
                        break;
                    case '4':
                        resultado = RealizarDivisao();
                        break;
                    case '5':
                        resultado = RealizarPotenciacao();
                        break;
                    case '6':
                        resultado = RealizarRadiciacao();
                        break;
                    case '7':
                        resultado = RealizarMisturaOperacoes();
                        break;
                    case '8':
                        continuar = false;
                        Console.WriteLine("Encerrando o programa.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                if (continuar)
                {
                    Console.WriteLine("Resultado: " + resultado);
                    Console.WriteLine("Deseja fazer outra equação? (S/N)");
                    char resposta = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                    if (char.ToUpper(resposta) == 'N')
                    {
                        continuar = false;
                        Console.WriteLine("Encerrando o programa.");
                    }
                }
            }
        }

        private static double RealizarAdicao()
        {
            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            return num1 + num2;
        }

        private static double RealizarSubtracao()
        {
            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            return num1 - num2;
        }

        private static double RealizarMultiplicacao()
        {
            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            return num1 * num2;
        }

        private static double RealizarDivisao()
        {
            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                Console.WriteLine("Não é possível dividir por zero.");
                return 0;
            }
        }

        private static double RealizarPotenciacao()
        {
            Console.Write("Digite a base: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o expoente: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            return Math.Pow(num1, num2);
        }

        private static double RealizarRadiciacao()
        {
            Console.Write("Digite o número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o índice do radical: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            if (num2 != 0)
            {
                return Math.Pow(num1, 1.0 / num2);
            }
            else
            {
                Console.WriteLine("O índice do radical não pode ser zero.");
                return 0;
            }
        }

        private static double RealizarMisturaOperacoes()
        {
            Console.WriteLine("Misturando operações...");
            Random random = new Random();
            char[] operacoes = { '+', '-', '*', '/' };
            char operacao = operacoes[random.Next(operacoes.Length)];

            Console.Write("Digite a quantidade de números (1-10): ");
            int quantidadeNumeros = Convert.ToInt32(Console.ReadLine());
            if (quantidadeNumeros < 1 || quantidadeNumeros > 10)
            {
                Console.WriteLine("Quantidade inválida. Escolha entre 1 e 10.");
                return 0;
            }

            double[] numeros = new double[quantidadeNumeros];
            char[] operacoesEntreNumeros = new char[quantidadeNumeros - 1];

            for (int i = 0; i < quantidadeNumeros; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                numeros[i] = Convert.ToDouble(Console.ReadLine());

                if (i < quantidadeNumeros - 1)
                {
                    Console.Write($"Digite a operação entre o número {i + 1} e o número {i + 2} (+, -, *, /): ");
                    operacoesEntreNumeros[i] = Console.ReadKey().KeyChar;
                    Console.WriteLine();
                }
            }

            return CalcularResultadoMisturado(numeros, operacoesEntreNumeros);
        }

        private static double CalcularResultadoMisturado(double[] numeros, char[] operacoes)
        {
            double resultado = numeros[0];

            for (int i = 0; i < operacoes.Length; i++)
            {
                switch (operacoes[i])
                {
                    case '+':
                        resultado += numeros[i + 1];
                        break;
                    case '-':
                        resultado -= numeros[i + 1];
                        break;
                    case '*':
                        resultado *= numeros[i + 1];
                        break;
                    case '/':
                        if (numeros[i + 1] != 0)
                        {
                            resultado /= numeros[i + 1];
                        }
                        else
                        {
                            Console.WriteLine("Não é possível dividir por zero.");
                            return 0;
                        }
                        break;
                    default:
                        Console.WriteLine("Operação inválida.");
                        return 0;
                }
            }

            return resultado;
        }
    }
}
