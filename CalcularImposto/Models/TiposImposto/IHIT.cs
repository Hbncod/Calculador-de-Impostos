using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularImposto.Models.TiposImposto
{
    class IHIT : TempleteImpostos
    {
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return ExistemDoisItensDeMesmoNome(orcamento.Itens);
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.01 * orcamento.Itens.Count;
        }
        private bool ExistemDoisItensDeMesmoNome(IList<Item> itens)
        {
            return itens.GroupBy(i => i.Nome).Any(i => i.Count() > 1);
        }
    }
}
