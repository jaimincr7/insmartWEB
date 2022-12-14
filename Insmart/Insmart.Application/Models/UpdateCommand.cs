using System.Text.Json.Serialization;

namespace Insmart.Application.Models
{
    public class UpdateCommand
    {
        public int Id { get; set; }       

        [JsonIgnore]
        public DateTime? UpdatedAt { get; set; }
    }
}

