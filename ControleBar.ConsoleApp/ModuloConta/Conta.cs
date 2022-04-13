using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleBar.ConsoleApp.Compartilhado;
using ControleBar.ConsoleApp.ModuloPedido;
using ControleBar.ConsoleApp.ModuloMesa;
using ControleBar.ConsoleApp.ModuloEstoque;


namespace ControleBar.ConsoleApp.ModuloConta
{
    public class Conta : EntidadeBase
    {
        public Pedido pedido;
        public Mesa mesa;
        public Estoque estoque;


        public bool estaAberta;



        public bool EstaAberta { get => estaAberta; }

        public string Status { get => EstaAberta ? "Aberta" : "Fechada"; }


        public void Abrir()
        {
            if (!estaAberta)
            {
                estaAberta = true;             

                
            }
        }

        public void Fechar()
        {
            if (estaAberta)
                estaAberta = false;
        }




        public override string ToString()
        {
            return "Id: " + id + Environment.NewLine +
                "Pedido: " + Environment.NewLine +
                "Mesa: " + mesa.NumeroDaMesa + Environment.NewLine +
                "Produtos: " + estoque.produto + " - " + estoque.quantidade + Environment.NewLine;
        }





    }
}
