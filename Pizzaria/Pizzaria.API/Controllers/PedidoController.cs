using Microsoft.AspNetCore.Mvc;
using Pizzaria.Business.Business;
using Pizzaria.Business.Repositories;
using Pizzaria.Model.Models;
using System;
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

        [Route("pedido/{id}")]
        [HttpGet]
        public Pedido GetById(string id)
        {
            return _business.RetornaPorId(Convert.ToInt32(id));
        }

        [Route("pedido")]
        [HttpPost]
        public void Create([FromBody] Pedido pedido)
        {
            _business.Cria(pedido);
        }

        [Route("pedidoAtualiza")]
        [HttpPost]
        public void Update([FromBody] Pedido pedido)
        {
            _business.Atualiza(pedido);
        }

        [Route("pedidoDelete")]
        [HttpPost]
        public void Delete([FromBody] Pedido pedido)
        {
            _business.Remove(pedido);
        }
    }
}
