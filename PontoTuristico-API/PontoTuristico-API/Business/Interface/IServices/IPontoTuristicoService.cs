using Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface.IServices
{
    public interface IPontoTuristicoService : IDisposable
    {
        Task<int> Adicionar(PontoTuristico  objeto);
        Task Atualizar(PontoTuristico  objeto);
        Task<PontoTuristico > Remover(int  objeto);

    }
}
