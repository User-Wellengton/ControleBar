using ControleBar.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;


namespace ControleBar.ConsoleApp.ModuloEstoque
{
    public class TelaCadastroEstoque : TelaBase, ITelaCadastravel
    {

        private readonly IRepositorio<Estoque> _repositorioEstoque;
        private readonly Notificador _notificador;

        public TelaCadastroEstoque(IRepositorio<Estoque> repositorioEstoque, Notificador notificador)
            : base("Cadastro de Estoque")
        {
            _repositorioEstoque = repositorioEstoque;
            _notificador = notificador;
        }


        public void Inserir()
        {
            MostrarTitulo("Cadastro de produtos");

            Estoque novoEstoque = ObterEstoque();

            _repositorioEstoque.Inserir(novoEstoque);

            _notificador.ApresentarMensagem("Estoque cadastrado com sucesso!", TipoMensagem.Sucesso);
        }



        public void Editar()
        {
            MostrarTitulo("Editando Produtos");

            bool temRegistrosCadastrados = VisualizarRegistros("Pesquisando");

            if (temRegistrosCadastrados == false)
            {
                _notificador.ApresentarMensagem("Nenhum produto cadastrado para editar.", TipoMensagem.Atencao);
                return;
            }

            int numeroGenero = ObterNumeroRegistro();

            Estoque estoqueAtualizado = ObterEstoque();

            bool conseguiuEditar = _repositorioEstoque.Editar(numeroGenero, estoqueAtualizado);

            if (!conseguiuEditar)
                _notificador.ApresentarMensagem("Não foi possível editar.", TipoMensagem.Erro);
            else
                _notificador.ApresentarMensagem("Produto editado com sucesso!", TipoMensagem.Sucesso);
        }





        public void Excluir()
        {
            MostrarTitulo("Excluindo Produtos do Estoque");

            bool temProdutosRegistrados = VisualizarRegistros("Pesquisando");

            if (temProdutosRegistrados == false)
            {
                _notificador.ApresentarMensagem("Nenhum Produto cadastrado para excluir.", TipoMensagem.Atencao);
                return;
            }

            int numeroProduto = ObterNumeroRegistro();

            bool conseguiuExcluir = _repositorioEstoque.Excluir(numeroProduto);

            if (!conseguiuExcluir)
                _notificador.ApresentarMensagem("Não foi possível excluir.", TipoMensagem.Erro);
            else
                _notificador.ApresentarMensagem("Produto excluído com sucesso!", TipoMensagem.Sucesso);
        }




        public bool VisualizarRegistros(string tipoVisualizacao)
        {
            if (tipoVisualizacao == "Tela")
                MostrarTitulo("Visualização de Produtos Cadastrados");

            List<Estoque> estoques = _repositorioEstoque.SelecionarTodos();

            if (estoques.Count == 0)
            {
                _notificador.ApresentarMensagem("Nenhum produto disponível.", TipoMensagem.Atencao);
                return false;
            }

            foreach (Estoque estoque in estoques)
                Console.WriteLine(estoque.ToString());

            Console.ReadLine();

            return true;
        }


        private Estoque ObterEstoque()
        {
            Console.Write("Digite o nome do produto: ");
            string produto =  Console.ReadLine();

            Console.Write("Digite a quantidade do produto: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor unitario do produto: ");
            double valorUnitario = double.Parse(Console.ReadLine());

            return new Estoque( quantidade, produto , valorUnitario); 
        }

        public int ObterNumeroRegistro()
        {
            int numeroRegistro;
            bool numeroRegistroEncontrado;

            do
            {
                Console.Write("Digite o ID dos produtos que deseja selecionar: ");
                numeroRegistro = Convert.ToInt32(Console.ReadLine());

                numeroRegistroEncontrado = _repositorioEstoque.ExisteRegistro(numeroRegistro);

                if (numeroRegistroEncontrado == false)
                    _notificador.ApresentarMensagem("ID dos produtos não foi encontrado, digite novamente", TipoMensagem.Atencao);

            } while (numeroRegistroEncontrado == false);

            return numeroRegistro;
        }

    }
}
