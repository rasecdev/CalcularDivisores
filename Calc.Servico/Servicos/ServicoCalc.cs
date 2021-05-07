using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calc.Servico.Servicos
{
    public class ServicoCalc : IServiceCalc
    {
        public List<int> CalcularDivisores(int Objeto)
        {
            List<int> result = new List<int>();

            for (int i = 1; i <= Objeto; i++)
            {
                if (Objeto % i == 0)
                {
                    result.Add(i);
                }
            }
            return result;
        }

        public List<int> CalcularDivisoresPrimos(int Objeto)
        {
            List<int> primes = new List<int>();

            if (Objeto % 2 == 0)
            {
                primes.Add(2);
            }

            for (int n = 3; n <= Objeto; n += 2)
            {
                int sqrt = (int)CalcularRaizQuadrada(n);

                if (primes.TakeWhile(p => p <= sqrt).All(p => n % p != 0))
                {
                    if (Objeto % n == 0)
                    {
                        primes.Add(n);
                    }
                }
            }

            return primes;
        }

        public int CalcularRaizQuadrada(int num)
        {
            //Conta os números ímpares até zerar o num
            int raiz = 0;
            for (int i = 1; true; i += 2)
            {
                num -= i;
                if (num < i)
                {
                    if (num != 0)
                    {
                        break;
                    }
                    else
                    {
                        raiz++;
                        break;
                    }
                }
                raiz++;
            }

            return raiz;
        }
    }
}
