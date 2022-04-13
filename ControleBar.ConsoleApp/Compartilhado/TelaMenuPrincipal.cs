using ControleBar.ConsoleApp.ModuloGarcom;
using ControleBar.ConsoleApp.ModuloConta;
using ControleBar.ConsoleApp.ModuloPedido;
using ControleBar.ConsoleApp.ModuloEstoque;
using ControleBar.ConsoleApp.ModuloMesa;
using System;

namespace ControleBar.ConsoleApp.Compartilhado
{
    public class TelaMenuPrincipal
    {
        private readonly IRepositorio<Garcom> repositorioGarcom;
        private readonly TelaCadastroGarcom telaCadastroGarcom;

        private readonly IRepositorio<Conta> repositorioConta;
        private readonly TelacadastroConta telaCadastroConta;

        private readonly IRepositorio<Pedido> repositorioPedido;
        private readonly TelaCadastroPedido telaCadastroPedido;

        private readonly IRepositorio<Estoque> repositorioEstoque;
        private readonly TelaCadastroEstoque telaCadastroEstoque;

        private readonly IRepositorio<Mesa> repositorioMesa;
        private readonly TelaCadastroMesa telaCadastroMesa;


        public TelaMenuPrincipal(Notificador notificador)
        {
            repositorioGarcom = new RepositorioGarcom();
            telaCadastroGarcom = new TelaCadastroGarcom(repositorioGarcom, notificador);

            repositorioConta = new RepositorioConta();
            // telaCadastroConta = new TelaCadastroConta(repositorioConta, notificador);

            repositorioPedido = new RepositorioPedido();
            telaCadastroPedido = new TelaCadastroPedido(repositorioPedido, notificador);

            repositorioEstoque = new RepositorioEstoque();
            telaCadastroEstoque = new TelaCadastroEstoque(repositorioEstoque, notificador);

            repositorioMesa = new RepositorioMesa();
            telaCadastroMesa = new TelaCadastroMesa(repositorioMesa, notificador);


            PopularAplicacao();
        }

        public string MostrarOpcoes()
        {
            Console.Clear();

            Console.WriteLine("Controle de Mesas de Bar 1.0");

            Console.WriteLine();

            Console.WriteLine("Digite 1 para Gerenciar Garçons");
            Console.WriteLine("Digite 2 para Gerenciar Conta");
            Console.WriteLine("Digite 3 para Gerenciar Pedido");
            Console.WriteLine("Digite 4 para Gerenciar Estoque");
            Console.WriteLine("Digite 5 para Gerenciar Mesas");

            Console.WriteLine("Digite s para sair");

            string opcaoSelecionada = Console.ReadLine();

            return opcaoSelecionada;
        }

        public TelaBase ObterTela()
        {
            string opcao = MostrarOpcoes();

            TelaBase tela = null;

            if (opcao == "1")
                tela = telaCadastroGarcom;

            //else if (opcao == "2")
            // tela = telaCadastroConta;

            else if (opcao == "3")
                tela = telaCadastroPedido;

            else if (opcao == "4")
                tela = telaCadastroEstoque;

            else if (opcao == "5")
                tela = telaCadastroMesa;

            return tela;
        }

        private void PopularAplicacao()
        {
            var garcom = new Garcom("Julinho", "230.232.519-98");
            repositorioGarcom.Inserir(garcom);
        }
    }
}
