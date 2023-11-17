using System.Text.Json.Serialization;

namespace SHB.Domain
{
    public class Faculty : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        [JsonIgnore]
        public List<FieldOfStudy>? FieldOfStudies { get; set; }
    }
}
