using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoApp.Interfaces
{
   public interface IProdutoApp : IGenericaApp<Produto>
    {
        Task AdicionaProduto(Produto produto);

        Task AtualizaProduto(Produto produto);

    }
}
