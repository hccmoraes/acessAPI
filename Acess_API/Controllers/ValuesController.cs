using Acess_API.Model;
using Acess_API.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

// Esta classe ira receber as requisições da aplicação que API estará consumindo.

namespace Acess_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DadosRepositorio _dadosRepositorio;

        public ValuesController()
        {
            _dadosRepositorio = new DadosRepositorio();
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Dados> Get()
        {
            return _dadosRepositorio.GetDados;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Dados dados)
        {
            _dadosRepositorio.InserirDados(dados);

        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
