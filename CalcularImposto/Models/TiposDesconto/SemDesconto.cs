using CalcularImposto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularImposto.Models.TiposDesconto
{
    public class SemDesconto : IDesconto
    {
        public IDesconto ProxDesconto { get; set; }
        public double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }
}
