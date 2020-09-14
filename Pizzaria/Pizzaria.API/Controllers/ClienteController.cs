using Microsoft.AspNetCore.Mvc;
using Pizzaria.Business.Repositories;
using Pizzaria.Model.Models;
using System.Collections.Generic;

namespace Pizzaria.API.Controllers
{
    [Route("api/cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteRepository<Cliente> _repository;

        public ClienteController(ClienteRepository<Cliente> repository)
        {
            _repository = repository;
        }

        [Route("clientes")]
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return _repository.GetAll();
        }
    }
}
