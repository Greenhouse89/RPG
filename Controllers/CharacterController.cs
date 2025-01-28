using Microsoft.AspNetCore.Mvc;

namespace RPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //controller can be accessed by typing /api/Character
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>()
        {
            new Character(),
            new Character {Id = 1, Name = "Sam"} 
        };
        [HttpGet] //responds to get requests
        [Route("GetAll")] //route to get all characters
        public ActionResult<List<Character>> Get() //return a list of characters when the api is called
        {
            return Ok(characters);
        }

        [HttpGet("{id}")] //responds to get requests with an id
        public ActionResult<Character> GetSingle(int id) //return a single character when the api is called
        {
            return Ok(characters.FirstOrDefault(c => c.Id == id)); //return the character with the id that matches the id in the api call. This defaults to the first one returned. 
        }
    }
}