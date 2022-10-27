using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoApp.Interfaces
{
    public interface IGenericaApp<T> where T : class
    {
        Task Add(T objeto);
        Task Atualizar(T objeto);
        Task Deletar(T objeto);
        Task<T> GetEntidadeId(int Id);
        Task<List<T>> List();
    }
}
