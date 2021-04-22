using System;

namespace CalculadoraOrientObj.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            Operacoes operacoes = new Operacoes();

            operacoes.primeiroNumero = 4;
            operacoes.segundoNumero = 2;
            operacoes.operacaoMais();
            operacoes.operacaoMenos();
            operacoes.operacaoMultiplicacao();
            operacoes.operacaoDivisao();
            
            Console.WriteLine();

            operacoes.visualizarContas();

            Console.Clear();

            while (true)
            {
                MostrarMenu();

                opcao = Console.ReadLine();

                if (OpcaoInvalida(opcao))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Opcao Invalida! Tente novamente.");
                    Console.ResetColor();
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                do
                {
                    if (opcao == "4" && operacoes.segundoNumero == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Numero errado! Tente outro");
                        Console.ResetColor();
                        Console.ReadLine();
                    }
                } while (operacoes.segundoNumero == 0);

                switch (opcao)
                {
                    case "1":
                        operacoes.operacaoMais();
                        break;

                    case "2":
                        operacoes.operacaoMenos();
                        break;
                    case "3":
                        operacoes.operacaoMultiplicacao();
                        break;
                    case "4":
                        operacoes.operacaoDivisao();
                        break;
                    case "5":
                        operacoes.visualizarContas();
                        break;

                    default:
                        break;
                }
            }
        }
        private static void MostrarMenu()
        {
            Console.WriteLine("Calculadora Orientada a Objetos");
            Console.WriteLine("Digite 1 para somar");
            Console.WriteLine("Digite 2 para subtrair");
            Console.WriteLine("Digite 3 para multiplicar");
            Console.WriteLine("Digite 4 para dividir");
            Console.WriteLine("Digite 5 para apresentar as operacoes");
            Console.WriteLine("Digite S para sair");
        }

        private static bool OpcaoInvalida(string opcao)
        {
            return opcao != "1" && opcao != "2" && opcao != "3" &&
            opcao != "4" && opcao != "5" && opcao != "S" && opcao != "s";
        }
    }
}