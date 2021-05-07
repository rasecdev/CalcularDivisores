using Calc.Servico;
using Calc.Servico.Servicos;
using System;
using System.Collections.Generic;

namespace Calc.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                System.Console.WriteLine("Digite o número para o cálculo dos divisores e divisores primos: ");

                string entrada = System.Console.ReadLine();

                int numEntrada;
                if (Int32.TryParse(entrada, out numEntrada))
                {

                    if (numEntrada < 0)
                    {
                        System.Console.WriteLine("O dado de entrada não foi um número válido!");
                    } else
                    {
                        Program(numEntrada);
                    }
                }
                else
                {
                    System.Console.WriteLine("O dado de entrada não foi um número válido!");
                }
            }
            

            static void Program(int numEntrada)
            {
                List<int> result = new List<int>();
                IServiceCalc serviceCalc = new ServicoCalc();

                result = serviceCalc.CalcularDivisores(numEntrada);

                System.Console.WriteLine("Divisores: ");

                foreach (var item in result)
                {
                    System.Console.WriteLine(item);
                }

                result = serviceCalc.CalcularDivisoresPrimos(numEntrada);

                System.Console.WriteLine("Divisores Primos: ");

                foreach (var item in result)
                {
                    System.Console.WriteLine(item);
                }
            }

        }

        
    }
}
