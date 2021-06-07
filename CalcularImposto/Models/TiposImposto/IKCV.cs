using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularImposto.Models.TiposImposto
{
    class IKCV : TempleteImpostos
    {
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && TemItemComValorSuperiorA100(orcamento.Itens);
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
        private bool TemItemComValorSuperiorA100(IList<Item> itens)
        {
            foreach (var item in itens)
            {
                if (item.Valor > 100)
                    return true;
            }
            return false;
        }
    }
}
