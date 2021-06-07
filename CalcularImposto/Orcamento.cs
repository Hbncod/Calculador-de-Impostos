using CalcularImposto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularImposto
{
    public class Orcamento
    {
        public Orcamento()
        {
            Itens = new List<Item>();
        }

        public IList<Item> Itens { get; set; }
        public double Valor { get; private set; }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
            AtualizarValor(item);
        }
        private void AtualizarValor(Item item)
        {
            this.Valor += item.Valor;
        }
    }
    
}
