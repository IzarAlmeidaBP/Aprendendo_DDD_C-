using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.InterfaceServico
{
    public interface IServicoProduto
    {
        Task AdicionaProduto(Produto produto);

        Task AtualizaProduto(Produto produto);   

        
    }
}
