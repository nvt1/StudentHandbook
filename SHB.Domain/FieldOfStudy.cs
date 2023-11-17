using System.Text.Json.Serialization;

namespace SHB.Domain
{
    public class FieldOfStudy : BaseEntity
    {
        public string? Name { get; set; }
        public int? FacultyId { get; set; }
        [JsonIgnore]
        public Faculty? Faculty { get; set; }
        [JsonIgnore]
        public List<Program>? Programs { get; set; }
    }
}

