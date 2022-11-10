using Back_End.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Back_End.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("GetFooterData")]
        public IActionResult GetFooterData()
        {
            Footer footer = new Footer();
            footer.direccion = "M Acha 982";
            footer.horario = "9 a 17";
            footer.telefono = "3531 4093";
            return Ok(footer);

        }

    }
}
