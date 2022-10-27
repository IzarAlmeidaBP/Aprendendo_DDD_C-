using AplicacaoApp.Interfaces;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositorio.MetodosGenericos
{
    public class RepositorioGenerico<T> : IGenericaApp<T>, IDisposable where T : class
    {
        public Task Add(T objeto)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(T objeto)
        {
            throw new NotImplementedException();
        }

        public Task Deletar(T objeto)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetEntidadeId(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> List()
        {
            throw new NotImplementedException();
        }

        bool descartado = false;

        SafeHandle lide = new SafeFileHandle(IntPtr.Zero, true);


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
            return;
            
        }
        protected virtual void Dispose(bool descarte) { 
            if (descartado) 
                return;

            if (descarte)
            {
                Dispose();
            }
            descartado = true;    
        }


    }


}
