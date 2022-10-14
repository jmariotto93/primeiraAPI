using Microsoft.AspNetCore.Mvc;

namespace PrimeiraAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        

        [HttpGet(Name = "GetWeatherForecast")]
        public string Get()
        {
            return "Minha Primeira API .NET CORE no framework 5.0";
        }
    }
}