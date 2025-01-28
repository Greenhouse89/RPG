using System.Text.Json.Serialization;

namespace RPG.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))] //converts the enum to a string. Yow will see sthe string instead of the number/position of the enum
    public enum RpgClass
    {
        Knight = 1,
        Mage = 2,
        Cleric = 3 
    }
}