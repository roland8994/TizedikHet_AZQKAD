using Microsoft.AspNetCore.Mvc;
using TizedikHet_AZQKAD.Models;

namespace TizedikHet_AZQKAD.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {
        [HttpGet]
        [Route("questions/all")]
        public IActionResult MindegyHogyHivjak()
        {
            HajosContext context = new HajosContext();
            var kérdések = from x in context.Questions select x.Question1;

            return Ok(kérdések);
        }
    }
}