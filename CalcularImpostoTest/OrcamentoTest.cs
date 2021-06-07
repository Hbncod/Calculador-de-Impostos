using CalcularImposto;
using CalcularImposto.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CalcularImpostoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [Owner("Hbncod")]
        public void AddedItem()
        {
            Orcamento orcamento = new Orcamento();
            int numItens = orcamento.Itens.Count;

            orcamento.AdicionaItem(new Item("Shampoo", 33.90));
            bool added = orcamento.Itens.Count > numItens;

            Assert.IsTrue(added);
        }
        [TestMethod]
        [Owner("Hbncod")]
        public void UpdatedValue()
        {
            Orcamento orcamento = new Orcamento();
            double oldValue = orcamento.Valor;

            orcamento.AdicionaItem(new Item("Shampoo", 33.90));
            bool updatedValue = orcamento.Valor > oldValue;

            Assert.IsTrue(updatedValue);
        }
    }
}
