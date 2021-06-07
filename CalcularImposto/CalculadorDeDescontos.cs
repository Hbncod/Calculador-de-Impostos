using CalcularImposto.Models.TiposDesconto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularImposto
{
    public class CalculadorDeDescontos
    {
        
        public double Calcula(Orcamento orcamento)
        {
            DescontoMaisDe5Itens d1 = new DescontoMaisDe5Itens();
            DescontoValorDaCompraMaiorQue500Reais d2 = new DescontoValorDaCompraMaiorQue500Reais();
            DescontoPorVendaCasada d3 = new DescontoPorVendaCasada();
            SemDesconto d4 = new SemDesconto();

            d1.ProxDesconto = d2;
            d2.ProxDesconto = d3;
            d3.ProxDesconto = d4;

            return d1.Desconta(orcamento); ;
        }
    }
}
