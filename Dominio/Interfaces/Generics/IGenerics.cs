using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Generics
{
    public interface IGenerics<T> where T : class
    {
        Task Add(T objeto);
        Task Atualizar(T objeto);
        Task Deletar(T objeto);
        Task<T> GetEntidadeId(int Id);
        Task<List<T>> List();

    }
}
