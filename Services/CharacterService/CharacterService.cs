using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace RPG.Services.CharacterService
{
    public interface CharacterService : ICharacterService
    {
           private static List<Character> characters = new List<Character>()
        {
            new Character(),
            new Character {Id = 1, Name = "Sam"} 
        };
        public List<Character> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
            throw new System.NotImplementedException();
        } 

        public List<Character> GetAllCharacters()
        {
            return characters;
            throw new System.NotImplementedException();
        }

        public Character GetCharacterById(int id)
        {
            return characters.FirstOrDefault(c => c.Id == id);
            throw new System.NotImplementedException();}
    }
}