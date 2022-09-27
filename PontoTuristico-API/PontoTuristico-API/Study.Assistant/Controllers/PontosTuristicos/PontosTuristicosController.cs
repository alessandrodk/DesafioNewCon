using AutoMapper;
using Business;
using Business.Interface.IRepository;
using Business.Interface.IServices;
using Business.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Ajuda
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class PontoTuristicoController : ControllerBase
    {
        private IPontoTuristicoService _service { get; set; }
        private IPontoTuristicoRepository _repository { get; set; }

        private IMapper _map { get; set; }
        public PontoTuristicoController(IPontoTuristicoService service, IMapper mapper, IPontoTuristicoRepository repository)
        {
            _service = service;
            _map = mapper;
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            return Ok(await _repository.GetAll());
        }

        [HttpGet]
        [Route("BuscarPorNome")]

        public async Task<IActionResult> obterPorNome(string nome)
        {
            return Ok(await _repository.GetAll(x => x.Nome.Contains(nome) || x.Descricao.Contains(nome)));
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> obterPonto(int id)
        {
            return Ok(await _repository.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Adicionar([FromBody] PontoTuristicoDto PontoTuristicoDto)
        {
            var PontoTuristico = _map.Map<PontoTuristico>(PontoTuristicoDto);

            if (!ModelState.IsValid) return BadRequest();
            await _service.Adicionar(PontoTuristico);

            return Ok("Ponto Turístico Adicionado Com Sucesso");
        }


       
       
     


    }
}
