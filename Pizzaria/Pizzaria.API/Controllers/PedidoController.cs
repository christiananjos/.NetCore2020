using Microsoft.AspNetCore.Mvc;
using Pizzaria.Business.Repositories;
using Pizzaria.Model.Models;
using System.Collections.Generic;

namespace Pizzaria.API.Controllers
{
    [Route("api/pedido")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly PedidoRepository<Pedido> _repository;

        public PedidoController(PedidoRepository<Pedido> repository)
        {
            _repository = repository;
        }

        [Route("pedidos")]
        [HttpGet]
        public IEnumerable<Pedido> Get()
        {
            return _repository.Filter();
        }
    }
}
