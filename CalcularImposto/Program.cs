using CalcularImposto.Models;
using CalcularImposto.Models.TiposImposto;
using CalcularImposto.TiposImposto;
using System;

namespace CalcularImposto
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalculadorDeDescontos calculadorDeDescontos = new CalculadorDeDescontos();
            Orcamento orcamento = new Orcamento();
            orcamento.AdicionaItem(new Item("Lapis", 2));
            orcamento.AdicionaItem(new Item("Chinelo", 20));
            orcamento.AdicionaItem(new Item("Caneta", 5));
            orcamento.AdicionaItem(new Item("Chinelo", 2));


            //double desconto = calculadorDeDescontos.Calcula(orcamento);
            //Console.WriteLine(desconto);
            new CalculadorDeImposto(orcamento, new IHIT());
            Console.ReadKey();
        }
    }
}
