using System;
using System.Collections.Generic;
using ControleBar.ConsoleApp.Compartilhado;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleBar.ConsoleApp.ModuloEstoque;
using ControleBar.ConsoleApp.ModuloMesa;

namespace ControleBar.ConsoleApp.ModuloPedido
{
    public  class Pedido : EntidadeBase
    {
        public Estoque estoque;
        public Mesa mesa;
         
        public Pedido(Estoque estoque, Mesa mesa)
        {
            this.estoque = estoque;
            this.mesa = mesa;
        }

        public override string ToString()
        {
            return "Id: " + id + Environment.NewLine +
                "Produto: " + estoque.Produto + Environment.NewLine +
                "Quantidade: " + estoque.Quantidade + Environment.NewLine;
              
        }

    }
}
