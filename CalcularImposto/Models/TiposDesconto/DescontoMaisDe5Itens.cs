using CalcularImposto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularImposto.Models.TiposDesconto
{
    public class DescontoMaisDe5Itens : IDesconto
    {
        public IDesconto ProxDesconto { get ; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
                return orcamento.Valor * 0.10;
            return ProxDesconto.Desconta(orcamento);
        }
    }
}
