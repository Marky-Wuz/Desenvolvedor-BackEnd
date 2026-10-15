using Microsoft.AspNetCore.Mvc;

namespace APIPessoas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {

        [HttpGet]
        public IActionResult Index()
        {
            string texto = "APi Funcionou";
            return Ok(texto);
        }

        [HttpGet("Home1")]
        public IActionResult Index1()
        {
            string texto = "APi Funcionou 1";
            return Ok(texto);
        }
    }
}
