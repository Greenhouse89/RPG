using Microsoft.AspNetCore.Mvc;

namespace RPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //controller can be accessed by typing /api/Character
    public class CharacterController : ControllerBase
    {
        private static Character knight = new Character();
        public IActionResult Get()
        {
            //return the knight character when the api is called successfully with a 200 status code
            return Ok(knight);
        }
    }
}