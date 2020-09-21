using Microsoft.AspNetCore.Mvc;
using Pizzaria.Business.Business;
using Pizzaria.Model.Models;
using System.Collections.Generic;

namespace Pizzaria.API.Controllers
{
    [Route("api/item")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly ItemBusiness _business;

        public ItemController(ItemBusiness business)
        {
            _business = business;
        }

        [Route("itens")]
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return _business.RetornaTodos();
        }

    }
}
