using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleBar.ConsoleApp.Compartilhado;

namespace ControleBar.ConsoleApp.ModuloEstoque
{
    public class Estoque : EntidadeBase
    {

        public string Produto { get; set; }
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }

        public Estoque(int quantidade, string produto, double valor)
        {
            Produto = produto;
            Quantidade = quantidade;
            ValorUnitario = valor;
        }


        public override string ToString()
        {
            return "Id: " + id + Environment.NewLine +
                "Nome do produto: " + Produto + Environment.NewLine +
                "Quantidade em estoque: R$" + Quantidade + Environment.NewLine +
                "Valor unitário: R$" + ValorUnitario + Environment.NewLine;
        }








    }
}
