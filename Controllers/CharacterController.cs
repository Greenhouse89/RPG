using Microsoft.AspNetCore.Mvc;
using RPG.Services.CharacterService;

namespace RPG.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //controller can be accessed by typing /api/Character
    public class CharacterController : ControllerBase
    {
        public ICharacterService CharacterService { get; }

        public CharacterController(ICharacterService characterService)
        {
            CharacterService = characterService;
        }

        [HttpGet("GetAll")] //route to get all characters
        public ActionResult<List<Character>> Get() //return a list of characters when the api is called
        {
            return Ok(CharacterService.GetAllCharacters()); //return the list of characters
        }

        [HttpGet("{id}")] //responds to get requests with an id
        public ActionResult<Character> GetSingle(int id) //return a single character when the api is called
        {
            return Ok(CharacterService.GetCharacterById(id)); //return the character with the id that matches the id in the api call. This defaults to the first one returned. 
        }

        [HttpPost] //responds to post requests. Sends the data to the service
        public ActionResult<List<Character>> AddCharacter(Character newCharacter) //add a new character to the list
        {
           return  Ok(CharacterService.AddCharacter(newCharacter)); //add the new character to the list
        }
    }
}