using CalcularImposto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularImposto.Models.TiposDesconto
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto ProxDesconto { get; set; }

        public double Desconta(Orcamento orcamento)
        {

            if(aconteceuVendaCasadaEm(orcamento))
            {
                return orcamento.Valor * 0.05;
            }
            return ProxDesconto.Desconta(orcamento);
        }
        private bool aconteceuVendaCasadaEm(Orcamento orcamento)
        {
            return Existe("Lapis", orcamento) && Existe("Caneta", orcamento);
        }

        private bool Existe(String nomeDoItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem))
                    return true;
            }
            return false;
        }
    }
}
