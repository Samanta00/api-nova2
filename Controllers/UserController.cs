using Microsoft.AspNetCore.Mvc;

namespace usuario.Controllers
{
    [ApiController]
    [Route("api/[controller]")]


    public class UsuarioController: ControllerBase
    {
        [HttpGet(Name = "GetUsuario")]
        public string Get()
        {
            return "Teste";
        }
        
    }
}