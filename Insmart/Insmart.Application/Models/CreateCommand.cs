using System.Text.Json.Serialization;

namespace Insmart.Application.Models
{
    public class CreateCommand
    {        
        [JsonIgnore]
        public DateTime CreatedAt { get; set; }
    }
}
