using Microsoft.AspNetCore.Mvc;

namespace TizedikHet_AZQKAD.Controllers
{
    public class TesztController : Controller
    {
        [HttpGet]
        [Route("corvinus/szerverido")]
        public IActionResult M1()
        {
            string pontosIdő = DateTime.Now.ToShortTimeString();

            return new ContentResult
            {
                ContentType = System.Net.Mime.MediaTypeNames.Text.Plain, //"text/plain"
                Content = pontosIdő
            };
        }
    }
}
