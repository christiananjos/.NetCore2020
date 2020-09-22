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

        [Route("create")]
        [HttpGet]
        public IEnumerable<Cliente> Create()
        {
            return _business.RetornaTodos();
        }


        [Route("update")]
        [HttpPost]
        public IEnumerable<Cliente> Update()
        {
            return _business.RetornaTodos();
        }

        [Route("delete")]
        [HttpPost]
        public IEnumerable<Cliente> Delete()
        {
            return _business.RetornaTodos();
        }

        [Route("getById")]
        [HttpPost]
        public IEnumerable<Cliente> GetById(int id)
        {
            return _business.RetornaTodos();
        }

        [Route("clientes")]
        [HttpGet]
        public IEnumerable<Cliente> GetAll()
        {
            return _business.RetornaTodos();
        }
    }
}
