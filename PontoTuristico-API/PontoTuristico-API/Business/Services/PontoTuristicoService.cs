using Business.Interface.IRepository;
using Business.Interface.IServices;
using Business.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class PontoTuristicoService : IPontoTuristicoService
    {
        private IPontoTuristicoRepository _repo { get; set; }

        public PontoTuristicoService(IPontoTuristicoRepository repo) => _repo = repo;

        public async Task<int> Adicionar(PontoTuristico  objeto)
        {
          var possuiMesmaDescricao = await _repo.GetAll(curso=> curso.Descricao == objeto.Descricao);

            if (possuiMesmaDescricao.Any()) return 0;
                await _repo.Add(objeto);
                await _repo.saveAsync();

            return 1;           
        }

        public async Task Atualizar(PontoTuristico  objeto)
        {
                _repo.Update(objeto);
                _repo.Save();
        }

        public void Dispose()
        {
            return;
        }

        public async Task<PontoTuristico > Remover(int  objeto)
        {
            var curso = await _repo.GetById(objeto);

            if (curso == null) return null;
                await _repo.Delete(curso);
                await _repo.saveAsync();
                return curso;
        }

    }
}
