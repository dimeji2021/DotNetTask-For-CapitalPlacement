using Newtonsoft.Json;

namespace MiskSchool.Models
{
    public class BaseEntity
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
    }
}
