using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOrientObj.ConsoleApp
{
    class Operacoes
    {
            public double primeiroNumero, segundoNumero;
            public string historico;

            public void operacaoMais()
            {
                double resultado = primeiroNumero + segundoNumero;
                string conta = $"{primeiroNumero} + {segundoNumero} = {resultado}";
                historico += conta + "\n";

                Console.WriteLine(conta);
            }

            public void operacaoMenos()
            {
                double resultado = primeiroNumero - segundoNumero;
                string conta = $"{primeiroNumero} - {segundoNumero} = {resultado}";
                historico += conta + "\n";

                Console.WriteLine(conta);
            }

            public void operacaoMultiplicacao()
            {
                double resultado = primeiroNumero * segundoNumero;
                string conta = $"{primeiroNumero} * {segundoNumero} = {resultado}";
                historico += conta + "\n";

                Console.WriteLine(conta);
            }

            public void operacaoDivisao()
            {
                double resultado = primeiroNumero / segundoNumero;
                string conta = $"{primeiroNumero} / {segundoNumero} = {resultado}";
                historico += conta + "\n";

                Console.WriteLine(conta);
            }

            public void visualizarContas()
            {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---------------------------");
            Console.WriteLine(historico);
            Console.WriteLine("---------------------------");
        }
    }
}
