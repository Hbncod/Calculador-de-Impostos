using CalcularImposto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularImposto.Models.TiposDesconto
{
    class DescontoValorDaCompraMaiorQue500Reais : IDesconto
    {
        public IDesconto ProxDesconto { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.07;
            }
            return ProxDesconto.Desconta(orcamento);
        }
    }
}
