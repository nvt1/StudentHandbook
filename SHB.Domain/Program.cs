using System.Text.Json.Serialization;

namespace SHB.Domain
{
    public class Program : BaseEntity
    {
        public string? Name { get; set; }
        public int? Year { get; set; }
        public int? FieldOfStudyId { get; set; }
        [JsonIgnore]
        public FieldOfStudy? FieldOfStudy { get; set; }
        public List<Course>? Courses { get; set; }
    }
}
