using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPG.Models;
namespace RPG.Services.CharacterService
{
    public interface CharacterService : ICharacterService
    {
           private static List<Character> characters = new List<Character>()
        {
            new Character(),
            new Character {Id = 1, Name = "Sam"} 
        };
        public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            characters.Add(newCharacter);
            serviceResponse.Data = characters;
            return serviceResponse;
            throw new System.NotImplementedException();
        } 

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
        {
            var serviceResponse = new ServiceResponse<List<Character>>();
            return new ServiceResponse<List<Character>> 
            {
                Data = characters
            };
            throw new System.NotImplementedException();
        }

        public async Task<ServiceResponse<Character>> GetCharacterById(int id)
        {
            var serviceResponse = new ServiceResponse<Character>();
            var character = characters.FirstOrDefault(c => c.Id == id);
            serviceResponse.Data = character;
            return serviceResponse;
            throw new System.NotImplementedException();}
    }
}