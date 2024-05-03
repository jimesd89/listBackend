using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace listaBack.Controllers
{

    [Route("api/[Controller]")]
    [ApiController]
    public class DefaultController : Controller
    {
        // GET: HomeController
        [HttpGet]
        public string Get()
        {
            return "App funcionando";
        }


    }
}
