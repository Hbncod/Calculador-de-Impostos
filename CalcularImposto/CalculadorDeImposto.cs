using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularImposto
{
    public class CalculadorDeImposto
    {
        public CalculadorDeImposto(Orcamento orcamento, IImposto imposto)
        {
            double valorImposto = imposto.Calcula(orcamento);
            Console.WriteLine(valorImposto);
        }
    }
}
