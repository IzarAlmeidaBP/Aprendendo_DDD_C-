using Dominio.Interfaces.InterfaceProduto;
using Dominio.Interfaces.InterfaceServico;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Servico
{
    public class ServicoProduto : IServicoProduto
    {
        private readonly IProduto _IProduto;
        public ServicoProduto(IProduto IProduto)
        {
            _IProduto = IProduto;
        }

        public async Task AdicionaProduto(Produto produto)
        {
            var validaNome = produto.ValidaPropriedadeString(produto.Nome, "Nome");

            var validaValor = produto.ValidaPropriedadeDecimal(produto.Valor, "Valor");

            if(validaNome && validaValor)
            {
                produto.Estado = true;
                await _IProduto.Add(produto);
                        
            }
        }

        public async Task AtualizaProduto(Produto produto)
        {
            var validaNome = produto.ValidaPropriedadeString(produto.Nome, "Nome");

            var validaValor = produto.ValidaPropriedadeDecimal(produto.Valor, "Valor");

            if (validaNome && validaValor)
            {
               
                await _IProduto.Atualizar(produto);

            }
        }
    }
}
