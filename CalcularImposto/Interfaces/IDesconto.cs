using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularImposto.Interfaces
{
    public interface IDesconto
    {
        public IDesconto ProxDesconto { get; set; }
        public double Desconta(Orcamento orcamento);
    }
}
