using Microsoft.AspNetCore.Mvc;

namespace Pizzaria.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController<T> : ControllerBase where T : class
    {

    }
}
