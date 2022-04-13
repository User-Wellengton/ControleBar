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

        public string produto { get; set; }
        public int quantidade { get; set; }
        public double valorUnitario { get; set; }

        public Estoque(int quantidade, string produto, double valor)
        {
            this.produto = produto;
            this.quantidade = quantidade;
            this.valorUnitario = valor;
        }


        public override string ToString()
        {
            return "Id: " + id + Environment.NewLine +
                "Nome do produto: " + produto + Environment.NewLine +
                "Quantidade em estoque: R$" + quantidade + Environment.NewLine +
                "Valor unitário: R$" + valorUnitario + Environment.NewLine;
        }








    }
}
