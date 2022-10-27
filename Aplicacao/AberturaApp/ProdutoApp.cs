using AplicacaoApp.Interfaces;
using Dominio.Interfaces.InterfaceProduto;
using Dominio.Interfaces.InterfaceServico;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoApp.AberturaApp
{
    public class ProdutoApp : IProdutoApp
    {
        IProduto _IProduto;
        IServicoProduto _IServicoProduto;
        public ProdutoApp(IProduto IProduto, IServicoProduto IServicoProduto)
        {
            _IProduto = IProduto;
            _IServicoProduto = IServicoProduto;

        }



        public async Task AdicionaProduto(Produto produto)
        {
            await _IServicoProduto.AdicionaProduto(produto);
        }

        public async Task AtualizaProduto(Produto produto)
        {
            await _IServicoProduto.AtualizaProduto(produto);
        }
        public async Task Add(Produto objeto)
        {
            await _IProduto.Add(objeto);
        }


        public async Task Atualizar(Produto objeto)
        {
            await _IProduto.Atualizar(objeto);
        }

        public async Task Deletar(Produto objeto)
        {
            await _IProduto.Deletar(objeto);

        }

        public async Task<Produto> GetEntidadeId(int Id)
        {
            return await _IProduto.GetEntidadeId(Id);
        }

        public async Task<List<Produto>> List()
        {
            return await _IProduto.List();

        }
    }
}
