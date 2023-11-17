using SHB.Domain;

namespace SHB.Application.Models.Reponse
{
    public class FieldOfStudyDto
    {
        public string? Name { get; set; }
        public int? FacultyId { get; set; }
        public Faculty? Faculty { get; set; }
        public List<Program>? Programs { get; set; }
    }
}
