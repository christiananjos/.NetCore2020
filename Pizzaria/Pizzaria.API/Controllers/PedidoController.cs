using Microsoft.AspNetCore.Mvc;
using Pizzaria.Business.Business;
using Pizzaria.Business.Repositories;
using Pizzaria.Model.Models;
using System.Collections.Generic;

namespace Pizzaria.API.Controllers
{
    [Route("api/pedido")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly PedidoBusiness _business;

        public PedidoController(PedidoBusiness business)
        {
            _business = business;
        }

        [Route("pedidos")]
        [HttpGet]
        public IEnumerable<Pedido> Get()
        {
            return _business.RetornaTodos();
        }
    }
}
