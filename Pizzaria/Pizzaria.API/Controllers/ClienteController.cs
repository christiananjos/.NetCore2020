using Microsoft.AspNetCore.Mvc;
using Pizzaria.Business.Business;
using Pizzaria.Business.Repositories;
using Pizzaria.Model.Models;
using System.Collections.Generic;

namespace Pizzaria.API.Controllers
{
    [Route("api/cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteBusiness _business;

        public ClienteController(ClienteBusiness business)
        {
            _business = business;
        }

        [Route("clientes")]
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return _business.RetornaTodos();
        }
    }
}
