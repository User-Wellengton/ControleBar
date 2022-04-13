using System;
using System.Collections.Generic;
using ControleBar.ConsoleApp.Compartilhado;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleBar.ConsoleApp.ModuloEstoque;

namespace ControleBar.ConsoleApp.ModuloPedido
{
    public  class Pedido : EntidadeBase
    {
        public Estoque estoque;


        public override string ToString()
        {
            return "Id: " + id + Environment.NewLine +
                "Produto: " + estoque.produto + Environment.NewLine +
                "Quantidade: " + estoque.quantidade + Environment.NewLine;
              
        }

    }
}
