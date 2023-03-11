using Newtonsoft.Json;

namespace MiskSchool.Models
{
    public class BaseEntity
    {
        [JsonProperty(PropertyName = "id")]
        public Guid Id { get; set; }
    }
}
