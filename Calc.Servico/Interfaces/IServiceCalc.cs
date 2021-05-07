using System.Collections.Generic;
using System.Threading.Tasks;

namespace Calc.Servico
{
    public interface IServiceCalc
    {
        List<int> CalcularDivisores(int Objeto);
        List<int> CalcularDivisoresPrimos(int Objeto);
    }
}
